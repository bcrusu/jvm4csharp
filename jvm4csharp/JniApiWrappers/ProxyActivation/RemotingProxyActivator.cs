using System;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace jvm4csharp.JniApiWrappers.ProxyActivation
{
    internal class RemotingProxyActivator : IProxyActivator
    {
        public static readonly RemotingProxyActivator Instance = new RemotingProxyActivator();

        private RemotingProxyActivator()
        {

        }

        public IJavaProxy CreateInstance(Type proxyType)
        {
            if (proxyType == null) throw new ArgumentNullException(nameof(proxyType));
            if (proxyType.IsGenericTypeDefinition || !proxyType.IsAbstract)
                throw new ArgumentException(nameof(proxyType));

            var realProxy = new JvmRealProxy(proxyType);
            var instance = (IJavaProxy)realProxy.GetTransparentProxy();
            return instance;
        }

        private class JvmRealProxy : RealProxy, IRemotingTypeInfo
        {
            private static readonly MethodBase ObjectGetType = typeof(object).GetMethod("GetType");
            private static readonly MethodBase ObjectEquals = typeof(object).GetMethod("Equals", new[] { typeof(object) });
            private static readonly MethodBase ObjectGetHashCode = typeof(object).GetMethod("GetHashCode");
            private static readonly MethodBase ObjectToString = typeof(object).GetMethod("ToString");
            private static readonly MethodBase JavaObjectEquals = typeof(IJavaObject).GetMethod("equals", new[] { typeof(IJavaObject) });
            private static readonly MethodBase JavaObjectGetClass = typeof(IJavaObject).GetMethod("getClass");
            private static readonly MethodBase JavaObjectHashCode = typeof(IJavaObject).GetMethod("hashCode");
            private static readonly MethodBase JavaObjectToString = typeof(IJavaObject).GetMethod("toString");
            private static readonly MethodBase JavaObjectNotify = typeof(IJavaObject).GetMethod("notify");
            private static readonly MethodBase JavaObjectNotifyAll = typeof(IJavaObject).GetMethod("notifyAll");
            private static readonly MethodBase JavaObjectWait = typeof(IJavaObject).GetMethod("wait", new Type[0]);
            private static readonly MethodBase JavaObjectWaitLong = typeof(IJavaObject).GetMethod("wait", new[] { typeof(long) });
            private static readonly MethodBase JavaObjectWaitLongInt = typeof(IJavaObject).GetMethod("wait", new[] { typeof(long), typeof(int) });
            private static readonly MethodBase JavaProxyGetProxyState = typeof(IJavaProxy).GetProperty("ProxyState").GetMethod;
            private static readonly MethodBase JavaProxySetProxyState = typeof(IJavaProxy).GetProperty("ProxyState").SetMethod;

            private readonly Type _proxyType;
            private readonly java.lang.Object _proxy;

            public JvmRealProxy(Type proxyType) : base(proxyType)
            {
                _proxyType = proxyType;
                _proxy = new java.lang.Object(ProxyCtor.I);
            }

            public override IMessage Invoke(IMessage msg)
            {
                var mcm = (IMethodCallMessage)msg;
                var method = mcm.MethodBase;

                try
                {
                    var result = HandleJavaProxyMembers(mcm, method);
                    if (result != null)
                        return result;

                    result = HandleJavaObjectMembers(mcm, method);
                    if (result != null)
                        return result;

                    result = HandleClrObjectMembers(mcm, method);
                    if (result != null)
                        return result;

                    return HandleProxyMembers(mcm, method);
                }
                catch (Exception e)
                {
                    return CreateErrorReturnMessage(e, mcm);
                }
            }

            public bool CanCastTo(Type toType, object o)
            {
                return toType == typeof(IJavaProxy) ||
                    toType == typeof(IJavaObject) ||
                    toType.IsAssignableFrom(_proxyType);
            }

            public string TypeName
            {
                get { return _proxyType.Name; }
                set { }
            }

            private static IMethodReturnMessage CreateEmptyReturnMessage(IMethodCallMessage mcm)
            {
                return new ReturnMessage(null, mcm);
            }

            private static IMethodReturnMessage CreateReturnMessage(object result, IMethodCallMessage mcm)
            {
                return new ReturnMessage(result, new object[0], 0, mcm.LogicalCallContext, mcm);
            }

            private static IMethodReturnMessage CreateErrorReturnMessage(Exception e, IMethodCallMessage mcm)
            {
                return new ReturnMessage(e, mcm);
            }

            private IMethodReturnMessage HandleClrObjectMembers(IMethodCallMessage mcm, MethodBase method)
            {
                if (method == ObjectGetType)
                    return CreateReturnMessage(_proxyType, mcm);
                if (method == ObjectToString)
                    return CreateReturnMessage(_proxy.ToString(), mcm);
                if (method == ObjectGetHashCode)
                    return CreateReturnMessage(_proxy.GetHashCode(), mcm);
                if (method == ObjectEquals)
                    return CreateReturnMessage(_proxy.Equals(mcm.Args[0]), mcm);

                return null;
            }

            private IMethodReturnMessage HandleJavaObjectMembers(IMethodCallMessage mcm, MethodBase method)
            {
                if (method == JavaObjectEquals)
                    return CreateReturnMessage(_proxy.equals((IJavaObject)mcm.Args[0]), mcm);
                if (method == JavaObjectGetClass)
                    return CreateReturnMessage(_proxy.getClass(), mcm);
                if (method == JavaObjectHashCode)
                    return CreateReturnMessage(_proxy.hashCode(), mcm);
                if (method == JavaObjectToString)
                    return CreateReturnMessage(_proxy.toString(), mcm);
                if (method == JavaObjectNotify)
                {
                    _proxy.notify();
                    return CreateEmptyReturnMessage(mcm);
                }
                if (method == JavaObjectNotifyAll)
                {
                    _proxy.notifyAll();
                    return CreateEmptyReturnMessage(mcm);
                }
                if (method == JavaObjectWait)
                {
                    _proxy.wait();
                    return CreateEmptyReturnMessage(mcm);
                }
                if (method == JavaObjectWaitLong)
                {
                    _proxy.wait((long)mcm.Args[0]);
                    return CreateEmptyReturnMessage(mcm);
                }
                if (method == JavaObjectWaitLongInt)
                {
                    _proxy.wait((long)mcm.Args[0], (int)mcm.Args[1]);
                    return CreateEmptyReturnMessage(mcm);
                }

                return null;
            }

            private IMethodReturnMessage HandleJavaProxyMembers(IMethodCallMessage mcm, MethodBase method)
            {
                if (method == JavaProxyGetProxyState)
                    return CreateReturnMessage(_proxy.ProxyState, mcm);

                if (method == JavaProxySetProxyState)
                {
                    _proxy.ProxyState = (JavaProxyState)mcm.Args[0];
                    return CreateEmptyReturnMessage(mcm);
                }

                return null;
            }

            private IMessage HandleProxyMembers(IMethodCallMessage mcm, MethodBase method)
            {
                //TODO:
                throw new NotImplementedException();
            }
        }
    }
}
