using System;
using System.Diagnostics;
using jvm4csharp.java.lang;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp
{
    public sealed class JvmContext
    {
        [ThreadStatic]
        private static JvmContext _current;

        internal readonly JniEnvWrapper JniEnv;

        internal JvmContext(JniEnvWrapper jniEnv)
        {
            Debug.Assert(jniEnv != null);
            JniEnv = jniEnv;
        }

        public static JvmContext Current => GetCurrentContext(true);

        public JvmLocalFrame PushLocalFrame(int minCapacity = 16)
        {
            return JniEnv.PushLocalFrame(minCapacity);
        }

        public void DeleteLocalReference(IJavaObject obj)
        {
            JniEnv.DeleteLocalReference(obj);
        }

        public T NewGlobalReference<T>(T obj)
            where T : IJavaObject
        {
            return (T)JniEnv.NewGlobalReference(obj);
        }

        public void DeleteGlobalReference(IJavaObject obj)
        {
            JniEnv.DeleteGlobalReference(obj);
        }

        public void MonitorEnter(IJavaObject obj)
        {
            JniEnv.MonitorEnter(obj);
        }

        public void MonitorExit(IJavaObject obj)
        {
            JniEnv.MonitorExit(obj);
        }

        public void Throw(Throwable throwable)
        {
            if (throwable == null) throw new ArgumentNullException(nameof(throwable));
            JniEnv.Exceptions.Throw(throwable);
        }

        public void ThrowNew(Class exceptionClass, string message)
        {
            if (exceptionClass == null) throw new ArgumentNullException(nameof(exceptionClass));
            if (message == null) throw new ArgumentNullException(nameof(message));
            JniEnv.Exceptions.ThrowNew(exceptionClass, message);
        }

        public void FatalError(string message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));
            JniEnv.Exceptions.FatalError(message);
        }

        public java.lang.String NewString(string str)
        {
            return JniEnv.Strings.NewString(str);
        }

        internal static JvmContext GetCurrentContext(bool throwIfNotFound)
        {
            if (_current == null && throwIfNotFound)
                throw new InvalidOperationException("Invalid operation attempted. JvmContext not present.");
            return _current;
        }

        internal static void SetCurrentContext(JvmContext context)
        {
            _current = context;
        }

        internal void ValidateProxyInstance(IJavaObject javaObject)
        {
            var proxy = javaObject as IJavaProxy;
            if (proxy == null)
                throw new ArgumentException("Invalid proxy instance.");

            if (proxy.ProxyState == null)
                throw new ArgumentException("Invalid proxy instance. Does not belong to the current JVM Context.");

            if (proxy.ProxyState.Context != this)
                throw new ArgumentException("Invalid proxy instance. Belongs to a different JVM Context.");
        }
    }
}
