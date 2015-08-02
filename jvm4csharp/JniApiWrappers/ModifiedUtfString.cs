using System;

namespace jvm4csharp.JniApiWrappers
{
    internal class ModifiedUtfString : IDisposable
    {
        private readonly JniEnvStringsWrapper _jniEnvStringsWrapper;

        internal readonly IntPtr NativePtr;
        internal readonly java.lang.String OriginalString;

        internal ModifiedUtfString(JniEnvStringsWrapper jniEnvStringsWrapper, IntPtr nativePtr, java.lang.String originalString)
        {
            if (jniEnvStringsWrapper == null) throw new ArgumentNullException(nameof(jniEnvStringsWrapper));
            if (nativePtr == IntPtr.Zero) throw new ArgumentException(nameof(nativePtr));
            if (originalString == null) throw new ArgumentNullException(nameof(originalString));

            _jniEnvStringsWrapper = jniEnvStringsWrapper;
            NativePtr = nativePtr;
            OriginalString = originalString;
        }

        public void Dispose()
        {
            _jniEnvStringsWrapper.ReleaseModifiedUtfString(this);
        }
    }
}
