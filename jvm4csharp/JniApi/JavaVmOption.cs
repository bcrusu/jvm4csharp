using System;
using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JavaVmOption
    {
        // char*
        public IntPtr optionString;

        // void*
        public IntPtr extraInfo;
    }
}