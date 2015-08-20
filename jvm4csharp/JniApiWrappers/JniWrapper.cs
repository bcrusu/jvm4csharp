using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal class JniWrapper
    {
        public const JniVersion PreferredJniVersion = JniVersion.v1_6;

        public static void VerifyJniResult(JniResult result)
        {
            if (result == JniResult.Ok)
                return;

            throw new JvmException($"JNI invocation API error. Code '{result}'.");
        }

        public unsafe static JavaVmWrapper CreateJavaVm(string[] jvmOptions)
        {
            Debug.Assert(jvmOptions != null);

            var initArgs = GetJavaVmInitArgs(jvmOptions);
            try
            {
                IntPtr jvmPtr;
                IntPtr envPtr;

                var jniResult = JniApiImport.JNI_CreateJavaVM(out jvmPtr, out envPtr, &initArgs);
                VerifyJniResult(jniResult);

                var result = new JavaVmWrapper(jvmPtr);

                result.DetachCurrentThread();

                return result;
            }
            finally
            {
                ReleaseJavaVmInitArgs(initArgs);
            }
        }

        private static unsafe JavaVmInitArgs GetJavaVmInitArgs(string[] jvmOptions)
        {
            var initArgs = default(JavaVmInitArgs);
            initArgs.version = (int)PreferredJniVersion;
            initArgs.ignoreUnrecognized = JniBooleanValue.True;

            var nativeJvmOptions = new JavaVmOption[jvmOptions.Length + 3];

            //exit
            JniHooksSig.Exit exitHook = ExitHook;
            nativeJvmOptions[0].optionString = Marshal.StringToHGlobalAnsi("exit");
            nativeJvmOptions[0].extraInfo = Marshal.GetFunctionPointerForDelegate(exitHook);

            //abort
            JniHooksSig.Abort abortHook = AbortHook;
            nativeJvmOptions[1].optionString = Marshal.StringToHGlobalAnsi("abort");
            nativeJvmOptions[1].extraInfo = Marshal.GetFunctionPointerForDelegate(abortHook);

            //vfprintf
            JniHooksSig.Vfprintf vfprintfHook = VfprintfHook;
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

        private static void AbortHook()
        {
            Debug.WriteLine("Abort hook was called.");
        }

        private static void ExitHook(int code)
        {
            Debug.WriteLine("Exit hook was called.");
        }

        private static unsafe int VfprintfHook(IntPtr fp, char* format, IntPtr args)
        {
            Debug.WriteLine("Vfprintf hook was called.");
            return 0;
        }
    }
}
