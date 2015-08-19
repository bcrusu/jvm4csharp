using System;
using System.Diagnostics;
using jvm4csharp.java.lang;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    //TODO: ExceptionClear & handle fatal error
    internal class JniEnvExceptionsWrapper
    {
        private readonly JniEnvWrapper _jniEnvWrapper;

        private JniNativeInterfaceSig.Exceptions.ExceptionDescribe _exceptionDescribe;
        private JniNativeInterfaceSig.Exceptions.ExceptionClear _exceptionClear;
        private JniNativeInterfaceSig.Exceptions.ExceptionCheck _exceptionCheck;
        private JniNativeInterfaceSig.Exceptions.ExceptionOccurred _exceptionOccurred;

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
    }
}