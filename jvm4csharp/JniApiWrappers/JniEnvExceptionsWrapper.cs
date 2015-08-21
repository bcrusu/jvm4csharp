using System;
using System.Diagnostics;
using jvm4csharp.java.lang;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal class JniEnvExceptionsWrapper
    {
        private readonly JniEnvWrapper _jniEnvWrapper;

        private JniNativeInterfaceSig.Exceptions.ExceptionDescribe _exceptionDescribe;
        private JniNativeInterfaceSig.Exceptions.ExceptionClear _exceptionClear;
        private JniNativeInterfaceSig.Exceptions.ExceptionCheck _exceptionCheck;
        private JniNativeInterfaceSig.Exceptions.ExceptionOccurred _exceptionOccurred;
        private JniNativeInterfaceSig.Exceptions.Throw _throw;
        private JniNativeInterfaceSig.Exceptions.ThrowNew _throwNew;
        private JniNativeInterfaceSig.Exceptions.FatalError _fatalError;

        internal JniEnvExceptionsWrapper(JniEnvWrapper jniEnvWrapper)
        {
            Debug.Assert(jniEnvWrapper != null);
            _jniEnvWrapper = jniEnvWrapper;
            InitFunctions();
        }

        private void InitFunctions()
        {
            var jni = WrapperHelpers.GetJniNativeInterface(_jniEnvWrapper.JniEnvPtr);

            _exceptionDescribe = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Exceptions.ExceptionDescribe>(jni.ExceptionDescribe);
            _exceptionClear = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Exceptions.ExceptionClear>(jni.ExceptionClear);
            _exceptionCheck = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Exceptions.ExceptionCheck>(jni.ExceptionCheck);
            _exceptionOccurred = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Exceptions.ExceptionOccurred>(jni.ExceptionOccurred);
            _throw = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Exceptions.Throw>(jni.Throw);
            _throwNew = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Exceptions.ThrowNew>(jni.ThrowNew);
            _fatalError = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Exceptions.FatalError>(jni.FatalError);
        }

        public void ExceptionDescribe()
        {
            _exceptionDescribe(_jniEnvWrapper.JniEnvPtr);
        }

        public void ExceptionClear()
        {
            _exceptionClear(_jniEnvWrapper.JniEnvPtr);
        }

        public bool ExceptionCheck()
        {
            var result = _exceptionCheck(_jniEnvWrapper.JniEnvPtr);
            return JniBooleanValue.ToClrBool(result);
        }

        public IntPtr ExceptionOccurred()
        {
            return _exceptionOccurred(_jniEnvWrapper.JniEnvPtr);
        }

        public void CheckLastException()
        {
            var pendingException = ExceptionCheck();
            if (!pendingException)
                return;

            var exceptionPtr = ExceptionOccurred();
            ExceptionClear();
            if (exceptionPtr != IntPtr.Zero)
            {
                var proxy = _jniEnvWrapper.ProxyFactory.CreateProxy(typeof(Throwable), exceptionPtr);
                throw (Throwable)proxy;
            }

            throw new JvmException("Unknown JVM error occurred.");
        }

        public void FatalError(string message)
        {
            var messagePtr = _jniEnvWrapper.Strings.NewStringPtr(message);
            var modifiedUtfString = _jniEnvWrapper.Strings.GetModifiedUtfString(messagePtr);
            _fatalError(_jniEnvWrapper.JniEnvPtr, modifiedUtfString.NativePtr);
        }

        public void ThrowNew(Class excptionClass, string message)
        {
            Debug.Assert(excptionClass != null);
            Debug.Assert(message != null);

            using (_jniEnvWrapper.PushLocalFrame())
            {
                var messagePtr = _jniEnvWrapper.Strings.NewStringPtr(message);
                using (var messageModifiedString = _jniEnvWrapper.Strings.GetModifiedUtfString(messagePtr))
                {
                    var result = _throwNew(_jniEnvWrapper.JniEnvPtr, excptionClass.ProxyState.NativePtr, messageModifiedString.NativePtr);
                    if (result != 0)
                        throw new JvmException($"Unexpected error while throwing new exception. Error code: '{result}'.");
                }
            }
        }

        public void Throw(Throwable throwable)
        {
            Debug.Assert(throwable != null);

            var result = _throw(_jniEnvWrapper.JniEnvPtr, throwable.ProxyState.NativePtr);
            if (result != 0)
                throw new JvmException($"Unexpected error while throwing exception. Error code: '{result}'.");
        }
    }
}