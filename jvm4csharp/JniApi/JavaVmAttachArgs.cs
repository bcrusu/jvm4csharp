using System;
using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JavaVmAttachArgs
    {
        public int version;

        public IntPtr threadName;

        public IntPtr threadGroup;   //java.lang.ThreadGroup
    }
}
