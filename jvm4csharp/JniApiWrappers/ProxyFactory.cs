using System;
using System.Diagnostics;
using jvm4csharp.java.lang;
using jvm4csharp.JniApiWrappers.ProxyActivation;

namespace jvm4csharp.JniApiWrappers
{
    internal class ProxyFactory
    {
        private readonly JniEnvWrapper _jniEnvWrapper;

        public ProxyFactory(JniEnvWrapper jniEnvWrapper)
        {
            Debug.Assert(jniEnvWrapper != null);

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
            Debug.Assert(expectedProxyType != null);
            Debug.Assert(clazz != null);

            if (nativePtr == IntPtr.Zero)
                return null;

            if (expectedProxyType.IsGenericTypeDefinition)
                throw new ArgumentException("TODO"); //TODO

            IJavaProxy result;

            if (WrapperHelpers.IsObjectArrayClass(clazz.InternalClassName))
            {
                result = NonAbstractProxyActivator.Instance.CreateInstance(expectedProxyType);
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
            result.Context = JvmContext.Current;
            result.Class = clazz;
            return result;
        }

        private static bool TryActivateProxy(Class clazz, Type expectedProxyType, out IJavaProxy proxy)
        {
            var isGenericProxy = expectedProxyType.IsGenericTypeDefinition;

            Type proxyType;
            if (ProxyRegistry.Current.TryGetProxyType(clazz.InternalClassName, isGenericProxy, out proxyType))
            {
                proxyType = proxyType.MakeGenericType(expectedProxyType.GenericTypeArguments);
                var proxyActivator = GetProxyActivator(proxyType);

                proxy = proxyActivator.CreateInstance(proxyType);
                return true;
            }

            // fallback to erased type
            if (isGenericProxy)
                if (ProxyRegistry.Current.TryGetProxyType(clazz.InternalClassName, false, out proxyType))
                {
                    var proxyActivator = GetProxyActivator(proxyType);
                    proxy = proxyActivator.CreateInstance(proxyType);
                    return true;
                }

            proxy = null;
            return false;
        }

        private static IProxyActivator GetProxyActivator(Type proxyType)
        {
            IProxyActivator proxyActivator = NonAbstractProxyActivator.Instance;

            if (proxyType.IsAbstract || proxyType.IsInterface)
            {
                //TODO: support 3rd party libraris (e.g. Castle.Core/Unity...)
                proxyActivator = RemotingProxyActivator.Instance;
            }

            return proxyActivator;
        }
    }
}
