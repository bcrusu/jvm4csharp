using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using jvm4csharp.JniApi;
using jvm4csharp.JniApiWrappers;
using jvm4csharp.Session;

namespace jvm4csharp
{
    //TODO: unload JVM functionality
    public class JvmManager
    {
        public static JvmManager Current { get; private set; }

        private const string JavaHomeEnvVariableName = "JAVA_HOME";
        private const string PathEnvVariableName = "PATH";

        private static readonly IList<string> JvmDllSearchLocations = new List<string>
        {
            @"bin\server\",
            @"bin\client\",
            @"bin\classic\",
            @"jre\bin\server\",
            @"jre\bin\client\",
            @"jre\bin\classic\"
        };

        private JavaVmWrapper _javaVm;
        private readonly SemaphoreSlim _javaVmSemaphore;
        private string _javaHome;
        private readonly string[] _jvmOptions;
        private readonly IJvmThreadProvider _currentThreadProvider;
        private readonly IJvmThreadProvider _pooledThreadProvider;

        private JvmManager(string javaHome, IEnumerable<string> jvmOptions, int minThreadPoolSize)
        {
            _javaVmSemaphore = new SemaphoreSlim(1);
            _javaHome = javaHome;
            _jvmOptions = (jvmOptions ?? Enumerable.Empty<string>()).ToArray();

            _currentThreadProvider = new CurrentThreadProvider();
            _pooledThreadProvider = new PooledThreadProvider(minThreadPoolSize);
        }

        public static void Configure(JvmManagerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (Current != null)
                throw new InvalidOperationException("Configure was already called.");

            ProxyRegistry.Configure(options.GetProxyTypes());

            Current = new JvmManager(options.JavaHome, options.GetJvmOptions(), options.MinThreadPoolSize);

            if (options.CreateJvmAtStartup)
                Current.GetJavaVm();
        }

        public JvmSession OpenSession(bool attachCurrentThread)
        {
            var threadProvider = _pooledThreadProvider;
            if (attachCurrentThread)
                threadProvider = _currentThreadProvider;

            var javaVm = GetJavaVm();
            var jvmThread = threadProvider.GetThread();

            var jvmSession = jvmThread.Attach(javaVm).Result;
            return jvmSession;
        }

        public void CloseSession(JvmSession session)
        {
            if (session == null) throw new ArgumentNullException(nameof(session));
            session.Close();
        }

        internal JavaVmWrapper GetJavaVm()
        {
            try
            {
                _javaVmSemaphore.Wait();

                if (_javaVm == null)
                {
                    var jvmDllDirectory = GetJvmDllDirectory();
                    AddToEnvironmentPath(jvmDllDirectory);

                    _javaVm = JniWrapper.CreateJavaVm(_jvmOptions);
                }

                return _javaVm;
            }
            finally
            {
                _javaVmSemaphore.Release();
            }
        }

        internal void DestroyJavaVm()
        {
            //TODO
            try
            {
                _javaVmSemaphore.Wait();

                _javaVm.DestroyJavaVm();
            }
            finally
            {
                _javaVmSemaphore.Release();
            }
        }

        private string GetJvmDllDirectory()
        {
            if (string.IsNullOrWhiteSpace(_javaHome))
            {
                var envVariableValue = Environment.GetEnvironmentVariable(JavaHomeEnvVariableName);

                if (!string.IsNullOrWhiteSpace(envVariableValue))
                    try
                    {
                        _javaHome = Path.GetFullPath(envVariableValue.Replace("\"", ""));
                    }
                    catch (Exception e)
                    {
                        throw new JvmException(
                            $"Error resolving the {JavaHomeEnvVariableName} environment variable. The current value '{envVariableValue}' is incorrect.", e);
                    }
            }

            if (string.IsNullOrWhiteSpace(_javaHome))
                throw new JvmException($"Error resolving the {JavaHomeEnvVariableName} environment variable.");

            foreach (var searchLocation in JvmDllSearchLocations)
            {
                var jvmDllDirectory = Path.Combine(_javaHome, searchLocation);
                if (!Directory.Exists(jvmDllDirectory))
                    continue;

                var jvmDllFile = Path.Combine(jvmDllDirectory, JniApiImport.JavaVmDllName);
                if (File.Exists(jvmDllFile))
                    return jvmDllDirectory;
            }

            throw new JvmException($"Could not locate '{JniApiImport.JavaVmDllName}'. Please verify that {JavaHomeEnvVariableName} is setup correctly.");
        }

        private static void AddToEnvironmentPath(string path)
        {
            var value = Environment.GetEnvironmentVariable(PathEnvVariableName) ?? string.Empty;
            if (!value.StartsWith(path))
            {
                value = path + Path.PathSeparator + value;
                Environment.SetEnvironmentVariable(PathEnvVariableName, value);
            }
        }
    }
}
