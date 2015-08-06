using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace jvm4csharp.JniApiWrappers.ProxyActivation
{
    internal class NonAbstractProxyActivator : IProxyActivator
    {
        public static readonly NonAbstractProxyActivator Instance = new NonAbstractProxyActivator();

        private NonAbstractProxyActivator()
        {

        }

        public IJavaProxy CreateInstance(Type proxyType)
        {
            if (proxyType == null) throw new ArgumentNullException(nameof(proxyType));
            if (proxyType.IsAbstract || proxyType.IsGenericTypeDefinition)
                throw new ArgumentException(nameof(proxyType));

            var instance = FormatterServices.GetUninitializedObject(proxyType);
            return (IJavaProxy)instance;
        }
    }
}
