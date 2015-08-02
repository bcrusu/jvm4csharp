using System;
using System.Runtime.Serialization;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    internal class ProxyFactory
    {
        private readonly JniEnvWrapper _jniEnvWrapper;

        public ProxyFactory(JniEnvWrapper jniEnvWrapper)
        {
            if (jniEnvWrapper == null) throw new ArgumentNullException(nameof(jniEnvWrapper));
            _jniEnvWrapper = jniEnvWrapper;
        }

        public IJavaProxy CreateProxy(Type expectedProxyType, IntPtr nativePtr)
        {
            if (nativePtr == IntPtr.Zero)
                return null;

            var clazz = _jniEnvWrapper.Classes.GetObjectClass(nativePtr);
            return CreateProxy(expectedProxyType, clazz, nativePtr);
        }

        public IJavaProxy CreateProxy(Type expectedProxyType, Class clazz, IntPtr nativePtr)
        {
            if (expectedProxyType == null) throw new ArgumentNullException(nameof(expectedProxyType));
            if (clazz == null) throw new ArgumentNullException(nameof(clazz));
            if (nativePtr == IntPtr.Zero)
                return null;

            if (expectedProxyType.IsGenericTypeDefinition)
                throw new ArgumentException("TODO"); //TODO

            IJavaProxy result;

            if (WrapperHelpers.IsObjectArrayClass(clazz.InternalClassName))
            {
                result = (IJavaProxy)FormatterServices.GetUninitializedObject(expectedProxyType);
            }
            else
            {
                if (!TryActivateProxy(clazz, expectedProxyType, out result))
                {
                    var expectedClazz = _jniEnvWrapper.Classes.FindClass(expectedProxyType);
                    if (!TryActivateProxy(expectedClazz, expectedProxyType, out result))
                        throw new ArgumentException("TODO"); //TODO
                }
            }

            result.NativePtr = nativePtr;
            result.Class = clazz;
            return result;
        }

        private static bool TryActivateProxy(Class clazz, Type expectedProxyType, out IJavaProxy proxy)
        {
            var proxyType = ProxyRegistry.Current.GetProxyType(clazz.InternalClassName);
            if (proxyType != null)
            {
                if (proxyType.IsGenericTypeDefinition)
                    proxyType = proxyType.MakeGenericType(expectedProxyType.GenericTypeArguments);

                var instance = FormatterServices.GetUninitializedObject(proxyType);
                proxy = (IJavaProxy)instance;
                return true;
            }

            proxy = null;
            return false;
        }
    }
}
