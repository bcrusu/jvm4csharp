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
            initArgs.ignoreUnrecognized = JniBooleanValue.False;

            var nativeJvmOptions = new JavaVmOption[jvmOptions.Length + 3];

            //exit
            JniHooksSig.Exit exitHook = jvmHooks.GetExitHook() ?? DefaultExitHook;
            nativeJvmOptions[0].optionString = Marshal.StringToHGlobalAnsi("exit");
            nativeJvmOptions[0].extraInfo = Marshal.GetFunctionPointerForDelegate(exitHook);

            //abort
            JniHooksSig.Abort abortHook = jvmHooks.GetAbortHook() ?? DefaultAbortHook;
            nativeJvmOptions[1].optionString = Marshal.StringToHGlobalAnsi("abort");
            nativeJvmOptions[1].extraInfo = Marshal.GetFunctionPointerForDelegate(abortHook);

            //vfprintf
            JniHooksSig.Vfprintf vfprintfHook = DefaultVfprintfHook;
            nativeJvmOptions[2].optionString = Marshal.StringToHGlobalAnsi("vfprintf");
            nativeJvmOptions[2].extraInfo = Marshal.GetFunctionPointerForDelegate(vfprintfHook);

            if (jvmOptions.Length > 0)
            {
                for (var i = 0; i < jvmOptions.Length; i++)
                    nativeJvmOptions[i + 3].optionString = Marshal.StringToHGlobalAnsi(jvmOptions[i]);

                fixed (JavaVmOption* ptr = &nativeJvmOptions[0])
                {
                    initArgs.options = ptr;
                    initArgs.nOptions = jvmOptions.Length;
                }
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
