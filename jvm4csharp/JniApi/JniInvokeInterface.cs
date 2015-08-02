using System;
using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JniInvokeInterface
    {
        public IntPtr reserved0;
        public IntPtr reserved1;
        public IntPtr reserved2;
        public IntPtr DestroyJavaVM;
        public IntPtr AttachCurrentThread;
        public IntPtr DetachCurrentThread;
        public IntPtr GetEnv;
        public IntPtr AttachCurrentThreadAsDaemon;
    }
}
