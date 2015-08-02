using System;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    internal interface IJavaProxy
    {
        IntPtr NativePtr { get; set; }  //TODO: check for Zero

        Class Class { get; set; }
    }
}
