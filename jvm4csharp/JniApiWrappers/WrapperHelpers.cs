using System;
using System.Runtime.InteropServices;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal static class WrapperHelpers
    {
        public unsafe static JniNativeInterface GetJniNativeInterface(IntPtr jniEnvPtr)
        {
            return *((JniEnv*)jniEnvPtr.ToPointer())->functions;
        }

        public unsafe static JniInvokeInterface GetJniInvokeInterface(IntPtr javaVmPtr)
        {
            return *((JavaVm*)javaVmPtr.ToPointer())->functions;
        }
        public static TResult GetDelegateForPointer<TResult>(IntPtr ptr)
        {
            return (TResult)((object)Marshal.GetDelegateForFunctionPointer(ptr, typeof(TResult)));
        }

        public static string GetInternalClassName(string className)
        {
            return className.Replace(".", "/");
        }

        public static string GetClassName(string internalClassName)
        {
            return internalClassName.Replace("/", ".");
        }

        public static bool IsObjectArrayClass(string internalClassName)
        {
            return internalClassName.StartsWith("[L", StringComparison.InvariantCultureIgnoreCase);
        }

        public static IJavaProxy GetJavaProxy(IJavaObject javaObject)
        {
            if (javaObject == null) throw new ArgumentNullException(nameof(javaObject));
            JvmContext.Current.ValidateProxyInstance(javaObject);

            return (IJavaProxy)javaObject;
        }
    }
}
