using System;
using System.Diagnostics;

namespace jvm4csharp.JniApiWrappers
{
    internal class ModifiedUtfString : IDisposable
    {
        private readonly JniEnvStringsWrapper _jniEnvStringsWrapper;

        internal readonly IntPtr NativePtr;
        internal readonly java.lang.String OriginalString;

        internal ModifiedUtfString(JniEnvStringsWrapper jniEnvStringsWrapper, IntPtr nativePtr, java.lang.String originalString)
        {
            Debug.Assert(jniEnvStringsWrapper != null);
            Debug.Assert(originalString != null);
            Debug.Assert(nativePtr != IntPtr.Zero);

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
