using System;
using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JniNativeMethod
    {
        // char*
        public IntPtr name;

        // char*
        public IntPtr signature;

        // void*
        public IntPtr fnPtr;
    }
}
