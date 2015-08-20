using System;
using System.Runtime.InteropServices;
using System.Security;

namespace jvm4csharp.JniApi
{
    internal static class JniHooksSig
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        public delegate void Abort();

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        public delegate void Exit(int code);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        public unsafe delegate int Vfprintf(IntPtr fp, char* format, IntPtr args);
    }
}
