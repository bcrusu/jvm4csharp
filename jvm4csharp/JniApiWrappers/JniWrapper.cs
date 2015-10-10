using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal class JniWrapper
    {
        public const JniVersion PreferredJniVersion = JniVersion.v1_6;

        private static readonly JniHooksSig.Exit DefaultExitHookDelegate = DefaultExitHook;
        private static readonly JniHooksSig.Abort DefaultAbortHookDelegate = DefaultAbortHook;
        private unsafe static readonly JniHooksSig.Vfprintf DefaultVfprintfHookDelegate = DefaultVfprintfHook;

        private static readonly IntPtr DefaultExitHookPtr = Marshal.GetFunctionPointerForDelegate(DefaultExitHookDelegate);
        private static readonly IntPtr DefaultAbortHookPtr = Marshal.GetFunctionPointerForDelegate(DefaultAbortHookDelegate);
        private unsafe static readonly IntPtr DefaultVfprintfHookPtr = Marshal.GetFunctionPointerForDelegate(DefaultVfprintfHookDelegate);

        public unsafe static IntPtr CreateJavaVm(IEnumerable<string> jvmOptions, JvmHooks jvmHooks)
        {
            Debug.Assert(jvmOptions != null);
            Debug.Assert(jvmHooks != null);

            var initArgs = GetJavaVmInitArgs(jvmOptions.EmptyIfNull().ToArray(), jvmHooks);
            try
            {
                IntPtr jvmPtr;
                IntPtr envPtr;

                var result = JniApiImport.JNI_CreateJavaVM(out jvmPtr, out envPtr, &initArgs);
                WrapperHelpers.VerifyJniResult(result);

                return jvmPtr;
            }
            finally
            {
                ReleaseJavaVmInitArgs(initArgs);
            }
        }

        private static unsafe JavaVmInitArgs GetJavaVmInitArgs(string[] jvmOptions, JvmHooks jvmHooks)
        {
            var initArgs = default(JavaVmInitArgs);
            initArgs.version = (int)PreferredJniVersion;
            initArgs.ignoreUnrecognized = JniBooleanValue.True;

            var nativeJvmOptions = new JavaVmOption[jvmOptions.Length + 3];

            //exit
            nativeJvmOptions[0].optionString = Marshal.StringToHGlobalAnsi("exit");
            JniHooksSig.Exit exitHook = jvmHooks.GetExitHook();
            if (exitHook != null)
                nativeJvmOptions[0].extraInfo = Marshal.GetFunctionPointerForDelegate(exitHook);
            else
                nativeJvmOptions[0].extraInfo = DefaultExitHookPtr;

            //abort
            nativeJvmOptions[1].optionString = Marshal.StringToHGlobalAnsi("abort");
            JniHooksSig.Abort abortHook = jvmHooks.GetAbortHook();
            if (abortHook != null)
                nativeJvmOptions[1].extraInfo = Marshal.GetFunctionPointerForDelegate(abortHook);
            else
                nativeJvmOptions[1].extraInfo = DefaultAbortHookPtr;

            //vfprintf
            nativeJvmOptions[2].optionString = Marshal.StringToHGlobalAnsi("vfprintf");
            nativeJvmOptions[2].extraInfo = DefaultVfprintfHookPtr;
            
            for (var i = 0; i < jvmOptions.Length; i++)
                nativeJvmOptions[i + 3].optionString = Marshal.StringToHGlobalAnsi(jvmOptions[i]);

            //TODO: review fixed statement
            fixed (JavaVmOption* ptr = &nativeJvmOptions[0])
            {
                initArgs.options = ptr;
                initArgs.nOptions = nativeJvmOptions.Length;
            }

            return initArgs;
        }

        private unsafe static void ReleaseJavaVmInitArgs(JavaVmInitArgs initArgs)
        {
            if (initArgs.nOptions <= 0)
                return;

            for (var i = 0; i < initArgs.nOptions; i++)
            {
                var option = initArgs.options[i];
                Marshal.FreeHGlobal(option.optionString);
            }
        }

        private static void DefaultAbortHook()
        {
            Debug.WriteLine("Abort hook was called.");
        }

        private static void DefaultExitHook(int code)
        {
            Debug.WriteLine("Exit hook was called.");
        }

        private static unsafe int DefaultVfprintfHook(IntPtr fp, char* format, IntPtr args)
        {
            Debug.WriteLine("Vfprintf hook was called.");
            return 0;
        }
    }
}
