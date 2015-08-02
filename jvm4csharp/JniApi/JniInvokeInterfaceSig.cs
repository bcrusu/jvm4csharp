using System;
using System.Runtime.InteropServices;
using System.Security;

namespace jvm4csharp.JniApi
{
    // ReSharper disable InconsistentNaming
    internal static class JniInvokeInterfaceSig
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal unsafe delegate JniResult AttachCurrentThread(IntPtr jvm, out IntPtr env, JavaVmAttachArgs* args);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal delegate JniResult DestroyJavaVM(IntPtr jvm);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal delegate JniResult DetachCurrentThread(IntPtr jvm);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal delegate JniResult GetEnv(IntPtr jvm, out IntPtr env, int version);
    }
}
