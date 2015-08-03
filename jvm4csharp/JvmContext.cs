using System;
using System.Diagnostics;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp
{
    //TODO: expose Global context 
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

        public static JvmContext Current
        {
            get { return GetCurrentContext(true); }
        }

        public JvmLocalFrame PushLocalFrame(int minCapacity = 16)
        {
            return JniEnv.PushLocalFrame(minCapacity);
        }

        public void DeleteLocalReference(IJavaObject obj)
        {
            JniEnv.DeleteLocalReference((IJavaProxy)obj);
        }

        public T NewGlobalReference<T>(T obj)
            where T : IJavaObject
        {
            return (T)JniEnv.NewGlobalReference((IJavaProxy)obj);
        }

        public void DeleteGlobalReference(IJavaObject obj)
        {
            JniEnv.DeleteGlobalReference((IJavaProxy)obj);
        }

        public void MonitorEnter(IJavaObject obj)
        {
            JniEnv.MonitorEnter((IJavaProxy)obj);
        }

        public void MonitorExit(IJavaObject obj)
        {
            JniEnv.MonitorExit((IJavaProxy)obj);
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

        internal void ValidateProxyInstane(IJavaProxy proxy)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));

            if (proxy.Context == null || proxy.NativePtr == IntPtr.Zero)
                throw new ArgumentException("Invalid proxy instance. Does not belong to the current JVM Context.");

            if (proxy.Context != this)
                throw new ArgumentException("Invalid proxy instance. Belongs to a different JVM Context.");
        }
    }
}
