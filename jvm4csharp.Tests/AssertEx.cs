using System;
using jvm4csharp.JniApiWrappers;
using NUnit.Framework;

namespace jvm4csharp.Tests
{
    internal static class AssertEx
    {
        public static void IsValidJavaProxy(IJavaProxy proxy)
        {
            Assert.IsNotNull(proxy);
            Assert.True(proxy.NativePtr != IntPtr.Zero);
            Assert.IsNotNull(proxy.Class);
            Assert.IsNotNull(proxy.Context);
        }
    }
}
