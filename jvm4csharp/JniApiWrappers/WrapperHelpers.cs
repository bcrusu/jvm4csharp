using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal static class WrapperHelpers
    {
        private static readonly IDictionary<MemberInfo, string> JavaSignatureCache = new Dictionary<MemberInfo, string>();

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

        public static JavaProxyAttribute GetJavaProxyAttribute(Type type)
        {
            return (JavaProxyAttribute)type.GetCustomAttributes(typeof(JavaProxyAttribute), false).FirstOrDefault();
        }

        public static string GetJavaSignature(MemberInfo member)
        {
            string result;
            if (!JavaSignatureCache.TryGetValue(member, out result))
            {
                var javaSignatureAttribute = (JavaSignatureAttribute)member.GetCustomAttributes(typeof(JavaSignatureAttribute), false).FirstOrDefault();
                if (javaSignatureAttribute == null)
                    throw new InvalidJavaProxyException(member.DeclaringType, $"Could not find 'JavaSignatureAttribute' for member '{member}'.");

                result = javaSignatureAttribute.Signature;
                JavaSignatureCache[member] = result;
            }

            return result;
        }

        public static void VerifyJniResult(JniResult result)
        {
            if (result == JniResult.Ok)
                return;

            throw new JvmException($"JNI invocation API error. Code '{result}'.");
        }
    }
}
