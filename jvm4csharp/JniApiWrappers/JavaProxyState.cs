using System;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    internal class JavaProxyState
    {
        public JavaProxyState(IntPtr nativePtr, Class clazz)
        {
            if (nativePtr == IntPtr.Zero) throw new ArgumentException(nameof(nativePtr));
            if (clazz == null) throw new ArgumentNullException(nameof(clazz));

            NativePtr = nativePtr;
            Class = clazz;
            Context = JvmContext.Current;
        }

        public IntPtr NativePtr { get; private set; }

        public JvmContext Context { get; private set; }

        public Class Class { get; private set; }
    }
}
