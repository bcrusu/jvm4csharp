using System;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    internal interface IJavaProxy
    {
        IntPtr NativePtr { get; set; }

        JvmContext Context { get; set; }

        Class Class { get; set; }
    }
}
