using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal class JniEnvStringsWrapper
    {
        private readonly JniEnvWrapper _jniEnvWrapper;

        private JniNativeInterfaceSig.Strings.NewString _newString;
        private JniNativeInterfaceSig.Strings.GetStringUTFChars _getStringUtfChars;
        private JniNativeInterfaceSig.Strings.ReleaseStringUTFChars _releaseStringUtfChars;
        private JniNativeInterfaceSig.Strings.GetStringChars _getStringChars;
        private JniNativeInterfaceSig.Strings.ReleaseStringChars _releaseStringChars;

        internal JniEnvStringsWrapper(JniEnvWrapper jniEnvWrapper)
        {
            if (jniEnvWrapper == null) throw new ArgumentNullException(nameof(jniEnvWrapper));
            _jniEnvWrapper = jniEnvWrapper;

            InitFunctions();
        }

        private unsafe void InitFunctions()
        {
            var jni = WrapperHelpers.GetJniNativeInterface(_jniEnvWrapper.JniEnvPtr);

            _newString = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Strings.NewString>(jni.NewString);
            _getStringUtfChars = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Strings.GetStringUTFChars>(jni.GetStringUTFChars);
            _releaseStringUtfChars = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Strings.ReleaseStringUTFChars>(jni.ReleaseStringUTFChars);
            _getStringChars = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Strings.GetStringChars>(jni.GetStringChars);
            _releaseStringChars = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Strings.ReleaseStringChars>(jni.ReleaseStringChars);
        }

        public java.lang.String NewString(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var intPtr = IntPtr.Zero;
            try
            {
                intPtr = Marshal.StringToHGlobalUni(str);

                var ptr = _newString(_jniEnvWrapper.JniEnvPtr, intPtr, str.Length);
                _jniEnvWrapper.Exceptions.CheckLastException();

                var result = new java.lang.String(JavaVoid.Void);
                result.NativePtr = ptr;

                return result;
            }
            finally
            {
                if (intPtr != IntPtr.Zero)
                    Marshal.FreeHGlobal(intPtr);
            }
        }

        public ModifiedUtfString GetModifiedUtfString(java.lang.String str)
        {
            Debug.Assert(str != null);

            byte isCopy;
            var ptr = _getStringUtfChars(_jniEnvWrapper.JniEnvPtr, str.NativePtr, out isCopy);
            _jniEnvWrapper.Exceptions.CheckLastException();

            return new ModifiedUtfString(this, ptr, str);
        }

        public void ReleaseModifiedUtfString(ModifiedUtfString str)
        {
            Debug.Assert(str != null);

            _releaseStringUtfChars(_jniEnvWrapper.JniEnvPtr, str.OriginalString.NativePtr, str.NativePtr);
            _jniEnvWrapper.Exceptions.CheckLastException();
        }

        public unsafe string ToClrString(IntPtr strPtr)
        {
            Debug.Assert(strPtr != IntPtr.Zero);

            var intPtr = IntPtr.Zero;
            try
            {
                byte isCopy;
                intPtr = _getStringChars(_jniEnvWrapper.JniEnvPtr, strPtr, &isCopy);

                return Marshal.PtrToStringUni(intPtr);
            }
            finally
            {
                if (intPtr != IntPtr.Zero)
                    _releaseStringChars(_jniEnvWrapper.JniEnvPtr, strPtr, intPtr);
            }
        }

        public string ToClrString(java.lang.String str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            JvmContext.Current.ValidateProxyInstane(str);

            return ToClrString(str.NativePtr);
        }
    }
}