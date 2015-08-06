using System;
using System.Diagnostics;

namespace jvm4csharp.JniApiWrappers
{
    internal class ModifiedUtfString : IDisposable
    {
        private readonly JniEnvStringsWrapper _jniEnvStringsWrapper;

        internal readonly IntPtr NativePtr;
        internal readonly IntPtr OriginalStringPtr;

        internal ModifiedUtfString(JniEnvStringsWrapper jniEnvStringsWrapper, IntPtr nativePtr, IntPtr originalStringPtr)
        {
            Debug.Assert(jniEnvStringsWrapper != null);
            Debug.Assert(originalStringPtr != null);
            Debug.Assert(nativePtr != IntPtr.Zero);

            _jniEnvStringsWrapper = jniEnvStringsWrapper;
            NativePtr = nativePtr;
            OriginalStringPtr = originalStringPtr;
        }

        public void Dispose()
        {
            _jniEnvStringsWrapper.ReleaseModifiedUtfString(this);
        }
    }
}
