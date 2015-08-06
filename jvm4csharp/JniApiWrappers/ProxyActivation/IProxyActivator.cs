using System;

namespace jvm4csharp.JniApiWrappers.ProxyActivation
{
    internal interface IProxyActivator
    {
        IJavaProxy CreateInstance(Type proxyType);
    }
}
