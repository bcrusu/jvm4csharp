using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace jvm4csharp
{
    public class JvmManagerOptions
    {
        private readonly ISet<string> _classPath = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
        private readonly ISet<Type> _proxyTypes = new HashSet<Type>();
        private readonly IList<string> _jvmOptions = new List<string>();

        public JvmManagerOptions()
        {
            MinThreadPoolSize = 8;
        }

        public string JavaHome { get; set; }

        public int MinThreadPoolSize { get; set; }

        public void AddClassPath(string classPath)
        {
            if (classPath == null) throw new ArgumentNullException(nameof(classPath));

            var trim = classPath.Trim();
            if (!string.IsNullOrWhiteSpace(trim))
                _classPath.Add(trim);
        }

        public void AddJvmOption(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));

            if (string.IsNullOrWhiteSpace(value))
                _jvmOptions.Add(name);
            else
                _jvmOptions.Add(name + "=" + value);
        }

        public void AddJvmOption(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));
            _jvmOptions.Add(name);
        }

        public void AddProxyType(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            _proxyTypes.Add(type);
        }

        public void Configure(JvmConfigurator configurator)
        {
            configurator.Configure(this);
        }

        internal IEnumerable<Type> GetProxyTypes()
        {
            return _proxyTypes;
        }

        internal string[] GetJvmOptions()
        {
            var result = new List<string>();

            if (_classPath.Any())
            {
                var sb = new StringBuilder();
                sb.Append("-Djava.class.path=");

                foreach (var item in _classPath)
                {
                    sb.Append(item);
                    sb.Append(Path.PathSeparator);
                }
                sb.Length--;

                result.Add(sb.ToString());
            }

            foreach (var item in _jvmOptions)
                result.Add(item);

            return result.ToArray();
        }
    }
}
