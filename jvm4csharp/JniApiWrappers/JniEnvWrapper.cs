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
        private JniNativeInterfaceSig.Activation.EnsureLocalCapacity _ensureLocalCapacity;
        private JniNativeInterfaceSig.MonitorEnter _monitorEnter;
        private JniNativeInterfaceSig.MonitorExit _monitorExit;

        internal JniEnvWrapper(JavaVmWrapper javaVm, IntPtr jniEnvPtr)
        {
            Debug.Assert(javaVm != null);
            Debug.Assert(jniEnvPtr != IntPtr.Zero);

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
            if (minCapacity <= 0) throw new ArgumentException(nameof(minCapacity));

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
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            JvmContext.Current.ValidateProxyInstane(proxy);

            var ptr = _popLocalFrame(JniEnvPtr, proxy.NativePtr);
            return (T)ProxyFactory.CreateProxy(proxy.GetType(), ptr);
        }

        public void EnsureLocalCapacity(int minCapacity)
        {
            if (minCapacity <= 0) throw new ArgumentException(nameof(minCapacity));

            var result = _ensureLocalCapacity(JniEnvPtr, minCapacity);
            if (result != 0)
                Exceptions.CheckLastException();
        }

        public void DeleteLocalReference(IJavaProxy proxy)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            JvmContext.Current.ValidateProxyInstane(proxy);

            _deleteLocalRef(JniEnvPtr, proxy.NativePtr);
            proxy.NativePtr = IntPtr.Zero;
            proxy.Context = null;
        }

        public IntPtr NewGlobalReference(IntPtr refPtr)
        {
            Debug.Assert(refPtr != IntPtr.Zero);

            var ptr = _newGlobalRef(JniEnvPtr, refPtr);
            if (ptr == IntPtr.Zero)
                throw new JvmException("Could not create global reference.");

            return ptr;
        }

        public IJavaProxy NewGlobalReference(IJavaProxy proxy)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            JvmContext.Current.ValidateProxyInstane(proxy);

            var globalPtr = NewGlobalReference(proxy.NativePtr);
            return ProxyFactory.CreateProxy(proxy.GetType(), globalPtr);
        }

        public void DeleteGlobalReference(IJavaProxy proxy)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            JvmContext.Current.ValidateProxyInstane(proxy);

            JavaVm.GlobalReferences.ValidateDeleteReference(proxy);

            _deleteGlobalRef(JniEnvPtr, proxy.NativePtr);
            proxy.NativePtr = IntPtr.Zero;
            proxy.Context = null;
        }

        public void MonitorEnter(IJavaProxy proxy)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            JvmContext.Current.ValidateProxyInstane(proxy);

            var result = _monitorEnter(JniEnvPtr, proxy.NativePtr);
            if (result < 0)
                throw new JvmException($"Could not enter monitor. Error code '{result}'.");
        }

        public void MonitorExit(IJavaProxy proxy)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            JvmContext.Current.ValidateProxyInstane(proxy);

            var result = _monitorExit(JniEnvPtr, proxy.NativePtr);
            if (result < 0)
            {
                Exceptions.CheckLastException();
                throw new JvmException("Could not exit monitor. Error code '{result}'.");
            }
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
            _ensureLocalCapacity = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Activation.EnsureLocalCapacity>(jni.EnsureLocalCapacity);
            _monitorEnter = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.MonitorEnter>(jni.MonitorEnter);
            _monitorExit = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.MonitorExit>(jni.MonitorExit);
        }
    }
}
