using System;
using jvm4csharp.JniApiWrappers;
using NUnit.Framework;

namespace jvm4csharp.Tests
{
    internal static class AssertEx
    {
        public static void IsValidJavaObject(IJavaObject javaObject)
        {
            IsValidJavaProxy((IJavaProxy)javaObject);
        }

        private static void IsValidJavaProxy(IJavaProxy proxy)
        {
            Assert.IsNotNull(proxy);
            Assert.IsNotNull(proxy.ProxyState);
            Assert.True(proxy.ProxyState.NativePtr != IntPtr.Zero);
            Assert.IsNotNull(proxy.ProxyState.Class);
            Assert.IsNotNull(proxy.ProxyState.Context);
        }
    }
}
