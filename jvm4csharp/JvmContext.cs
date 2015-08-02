using System;
using System.Diagnostics;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp
{
    //TODO: public API
    //Evict proxy/DeleteLocalRef
    //New/Delete GlobalRef
    //MonitorEnter/Exit

    public sealed class JvmContext
    {
        [ThreadStatic]
        private static JvmContext _current;

        internal readonly JniEnvWrapper JniEnvWrapper;
        
        internal JvmContext(JniEnvWrapper jniEnvWrapper)
        {
            Debug.Assert(jniEnvWrapper != null);
            JniEnvWrapper = jniEnvWrapper;
        }

        public static JvmContext Current
        {
            get { return GetCurrentContext(true); }
        }

        public JvmLocalFrame PushLocalFrame(int minCapacity = 16)
        {
            return JniEnvWrapper.PushLocalFrame(minCapacity);
        }

        internal static JvmContext GetCurrentContext(bool throwIfNotFound)
        {
            if (_current == null && throwIfNotFound)
                throw new JvmException("Invalid operation attempted. JvmContext not present.");
            return _current;
        }

        internal static void SetCurrentContext(JvmContext context)
        {
            _current = context;
        }
    }
}
