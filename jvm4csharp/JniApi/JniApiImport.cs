using System;
using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    internal static class JniApiImport
    {
        public const string JavaVmDllName = "jvm.dll";

        [DllImport(JavaVmDllName, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern JniResult JNI_CreateJavaVM(out IntPtr jvm, out IntPtr env, JavaVmInitArgs* args);

        [DllImport(JavaVmDllName, CallingConvention = CallingConvention.StdCall)]
        public static extern JniResult JNI_GetCreatedJavaVMs(out IntPtr jvm, int size, out int size2);

        [DllImport(JavaVmDllName, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern JniResult JNI_GetDefaultJavaVMInitArgs(JavaVmInitArgs* args);
    }
}
