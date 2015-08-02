using System;
using System.Collections.Generic;
using System.Linq;

namespace jvm4csharp
{
    public abstract class JvmConfigurator
    {
        internal void Configure(JvmManagerOptions options)
        {
            var classPath = GetClassPath();
            if (classPath != null)
                foreach (var item in classPath)
                    options.AddClassPath(item);

            var proxyTypes = GetProxyTypes();
            if (proxyTypes != null)
                foreach (var item in proxyTypes)
                    options.AddProxyType(item);
        }

        protected virtual IEnumerable<Type> GetProxyTypes()
        {
            return Enumerable.Empty<Type>();
        }

        protected virtual IEnumerable<string> GetClassPath()
        {
            return Enumerable.Empty<string>();
        }
    }
}
