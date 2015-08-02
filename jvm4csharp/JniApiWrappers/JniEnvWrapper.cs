using System;
using System.Diagnostics;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    //TODO: track local frames and invalidate all proxies on LocalFrame.Pop()
    internal class JniEnvWrapper
    {
        internal readonly IntPtr JniEnvPtr;
        internal readonly JavaVmWrapper JavaVm;
        internal readonly ProxyFactory ProxyFactory;

        private JniNativeInterfaceSig.GetVersion _getVersion;
        private JniNativeInterfaceSig.Activation.PushLocalFrame _pushLocalFrame;
        private JniNativeInterfaceSig.Activation.PopLocalFrame _popLocalFrame;
        private JniNativeInterfaceSig.Activation.DeleteLocalRef _deleteLocalRef;
        private JniNativeInterfaceSig.Activation.NewGlobalRef _newGlobalRef;
        private JniNativeInterfaceSig.Activation.DeleteGlobalRef _deleteGlobalRef;
        private JniNativeInterfaceSig.Activation.NewLocalRef _newLocalRef;
        private JniNativeInterfaceSig.Activation.EnsureLocalCapacity _ensureLocalCapacity;

        internal JniEnvWrapper(JavaVmWrapper javaVm, IntPtr jniEnvPtr)
        {
            if (javaVm == null) throw new ArgumentNullException(nameof(javaVm));
            if (jniEnvPtr == IntPtr.Zero) throw new ArgumentException(nameof(jniEnvPtr));

            JavaVm = javaVm;
            JniEnvPtr = jniEnvPtr;
            InitFunctions();

            Strings = new JniEnvStringsWrapper(this);
            Exceptions = new JniEnvExceptionsWrapper(this);
            Classes = new JniEnvClassesWrapper(this);
            Arrays = new JniEnvArraysWrapper(this);
            ProxyFactory = new ProxyFactory(this);
        }

        public JniEnvStringsWrapper Strings { get; private set; }
        public JniEnvExceptionsWrapper Exceptions { get; }
        public JniEnvClassesWrapper Classes { get; private set; }
        public JniEnvArraysWrapper Arrays { get; private set; }

        public JniVersion GetVersion()
        {
            var version = _getVersion(JniEnvPtr);
            return (JniVersion)version;
        }

        public JvmLocalFrame PushLocalFrame(int minCapacity = 16)
        {
            var result = _pushLocalFrame(JniEnvPtr, minCapacity);
            if (result != 0)
                Exceptions.CheckLastException();

            return new JvmLocalFrame(this, minCapacity);
        }

        public void PopLocalFrame()
        {
            _popLocalFrame(JniEnvPtr, IntPtr.Zero);
        }

        public T PopLocalFrame<T>(IJavaProxy proxy)

        {
            Debug.Assert(proxy != null);
            var ptr = _popLocalFrame(JniEnvPtr, proxy.NativePtr);
            return (T)ProxyFactory.CreateProxy(proxy.GetType(), ptr);
        }

        public void EnsureLocalCapacity(int minCapacity)
        {
            var result = _ensureLocalCapacity(JniEnvPtr, minCapacity);
            if (result != 0)
                Exceptions.CheckLastException();
        }

        public void DeleteLocalReference(IJavaProxy proxy)
        {
            Debug.Assert(proxy != null);
            _deleteLocalRef(JniEnvPtr, proxy.NativePtr);
            proxy.NativePtr = IntPtr.Zero;
        }

        public IntPtr NewGlobalReference(IntPtr refPtr)
        {
            var ptr = _newGlobalRef(JniEnvPtr, refPtr);
            if (ptr == IntPtr.Zero)
                throw new JvmException("Could not create global reference.");

            return ptr;
        }

        public T NewGlobalReference<T>(T proxy)
            where T : IJavaProxy
        {
            Debug.Assert(proxy != null);

            var globalPtr = NewGlobalReference(proxy.NativePtr);

            return (T)ProxyFactory.CreateProxy(proxy.GetType(), globalPtr);
        }

        public void DeleteGlobalReference(IJavaProxy proxy)
        {
            Debug.Assert(proxy != null);
            JavaVm.GlobalReferences.ValidateDeleteReference(proxy);

            _deleteGlobalRef(JniEnvPtr, proxy.NativePtr);
            proxy.NativePtr = IntPtr.Zero;
        }

        private void InitFunctions()
        {
            var jni = WrapperHelpers.GetJniNativeInterface(JniEnvPtr);

            _getVersion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.GetVersion>(jni.GetVersion);
            _pushLocalFrame = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.PushLocalFrame>(jni.PushLocalFrame);
            _popLocalFrame = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.PopLocalFrame>(jni.PopLocalFrame);
            _deleteLocalRef = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.DeleteLocalRef>(jni.DeleteLocalRef);
            _newGlobalRef = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.NewGlobalRef>(jni.NewGlobalRef);
            _deleteGlobalRef = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.DeleteGlobalRef>(jni.DeleteGlobalRef);
            _newLocalRef = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.NewLocalRef>(jni.NewLocalRef);
            _ensureLocalCapacity = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.EnsureLocalCapacity>(jni.EnsureLocalCapacity);
        }
    }
}
