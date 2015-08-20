using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using jvm4csharp.JniApi;
using jvm4csharp.JniApiWrappers;
using jvm4csharp.Session;

namespace jvm4csharp
{
    public class JvmManager : IDisposable
    {
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

        internal ProxyRegistry ProxyRegistry { get; private set; }

        private JavaVmWrapper _javaVm;
        private readonly SemaphoreSlim _javaVmSemaphore;
        private readonly IJvmThreadProvider _currentThreadProvider;
        private readonly IJvmThreadProvider _pooledThreadProvider;
        private readonly JvmManagerOptions _options;
        private int _disposed;

        private JvmManager(JvmManagerOptions options)
        {
            Debug.Assert(options != null);

            _options = options;
            _javaVmSemaphore = new SemaphoreSlim(1);
            _currentThreadProvider = new CurrentThreadProvider();
            _pooledThreadProvider = new PooledThreadProvider(options.MinThreadPoolSize);

            ProxyRegistry = new ProxyRegistry(options.GetProxyTypes());
        }

        ~JvmManager()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public static JvmManager Create(JvmManagerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            var result = new JvmManager(options);

            // start the JVM
            result.GetJavaVm();

            return result;
        }

        public JvmSession OpenSession(bool attachCurrentThread)
        {
            CheckDisposed();

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

            CheckDisposed();
            session.Close();
        }

        private JavaVmWrapper GetJavaVm()
        {
            try
            {
                _javaVmSemaphore.Wait();

                if (_javaVm == null)
                {
                    var jvmDllDirectory = GetJvmDllDirectory();
                    AddToEnvironmentPath(jvmDllDirectory);

                    var jvmPtr = JniWrapper.CreateJavaVm(_options.GetJvmOptions());
                    _javaVm = new JavaVmWrapper(this, jvmPtr);

                    //detach the current thread (is automatically attached during JVM startup)
                    _javaVm.DetachCurrentThread();
                }

                return _javaVm;
            }
            finally
            {
                _javaVmSemaphore.Release();
            }
        }

        private string GetJvmDllDirectory()
        {
            var javaHome = _options.JavaHome;

            if (string.IsNullOrWhiteSpace(javaHome))
            {
                var envVariableValue = Environment.GetEnvironmentVariable(JavaHomeEnvVariableName);

                if (!string.IsNullOrWhiteSpace(envVariableValue))
                    try
                    {
                        javaHome = Path.GetFullPath(envVariableValue.Replace("\"", ""));
                    }
                    catch (Exception e)
                    {
                        throw new JvmException(
                            $"Error resolving the {JavaHomeEnvVariableName} environment variable. The current value '{envVariableValue}' is incorrect.", e);
                    }
            }

            if (string.IsNullOrWhiteSpace(javaHome))
                throw new JvmException($"Error resolving the {JavaHomeEnvVariableName} environment variable.");

            foreach (var searchLocation in JvmDllSearchLocations)
            {
                var jvmDllDirectory = Path.Combine(javaHome, searchLocation);
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

        private void Dispose(bool disposing)
        {
            var disposed = Interlocked.CompareExchange(ref _disposed, 1, 0);
            if (disposed == 1)
                return;

            _pooledThreadProvider.Dispose();
            _javaVm.DestroyJavaVm();

            if (disposing)
                GC.SuppressFinalize(this);
        }

        private void CheckDisposed()
        {
            if (_disposed == 1)
                throw new ObjectDisposedException("The JVM manager was disposed.");
        }
    }
}
