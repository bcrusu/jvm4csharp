﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal class JavaVmWrapper
    {
        private readonly IntPtr _javaVmPtr;
        internal GlobalReferencesManager GlobalReferences { get; private set; }
        internal JvmManager JvmManager { get; private set; }

        private JniInvokeInterfaceSig.AttachCurrentThread _attachCurrentThread;
        private JniInvokeInterfaceSig.AttachCurrentThread _attachCurrentThreadAsDaemon;
        private JniInvokeInterfaceSig.DestroyJavaVM _destroyJavaVm;
        private JniInvokeInterfaceSig.DetachCurrentThread _detachCurrentThread;
        private JniInvokeInterfaceSig.GetEnv _getEnv;

        internal JavaVmWrapper(JvmManager jvmManager, IntPtr javaVmPtr)
        {
            Debug.Assert(javaVmPtr != IntPtr.Zero);
            Debug.Assert(jvmManager != null);

            _javaVmPtr = javaVmPtr;
            JvmManager = jvmManager;
            InitFunctions();

            GlobalReferences = new GlobalReferencesManager();
        }

        private unsafe void InitFunctions()
        {
            var jvm = WrapperHelpers.GetJniInvokeInterface(_javaVmPtr);

            _destroyJavaVm = WrapperHelpers.GetDelegateForPointer<JniInvokeInterfaceSig.DestroyJavaVM>(jvm.DestroyJavaVM);
            _attachCurrentThread = WrapperHelpers.GetDelegateForPointer<JniInvokeInterfaceSig.AttachCurrentThread>(jvm.AttachCurrentThread);
            _attachCurrentThreadAsDaemon = WrapperHelpers.GetDelegateForPointer<JniInvokeInterfaceSig.AttachCurrentThread>(jvm.AttachCurrentThreadAsDaemon);
            _detachCurrentThread = WrapperHelpers.GetDelegateForPointer<JniInvokeInterfaceSig.DetachCurrentThread>(jvm.DetachCurrentThread);
            _getEnv = WrapperHelpers.GetDelegateForPointer<JniInvokeInterfaceSig.GetEnv>(jvm.GetEnv);
        }

        public void DestroyJavaVm()
        {
            var result = _destroyJavaVm(_javaVmPtr);
            WrapperHelpers.VerifyJniResult(result);
        }

        public unsafe JniEnvWrapper AttachCurrentThread()
        {
            return AttachCurrentThreadInternal(_attachCurrentThread);
        }

        public unsafe JniEnvWrapper AttachCurrentThreadAsDaemon()
        {
            return AttachCurrentThreadInternal(_attachCurrentThreadAsDaemon);
        }

        public void DetachCurrentThread()
        {
            var result = _detachCurrentThread(_javaVmPtr);
            WrapperHelpers.VerifyJniResult(result);
        }

        public JniEnvWrapper GetCurrentEnv()
        {
            IntPtr envPtr;
            var jniResult = _getEnv(_javaVmPtr, out envPtr, (int)JniWrapper.PreferredJniVersion);
            if (jniResult == JniResult.ErrDetached)
                return null;

            WrapperHelpers.VerifyJniResult(jniResult);

            return new JniEnvWrapper(this, envPtr);
        }

        private unsafe JniEnvWrapper AttachCurrentThreadInternal(JniInvokeInterfaceSig.AttachCurrentThread attachFunction)
        {
            var threadNamePtr = IntPtr.Zero;

            try
            {
                JavaVmAttachArgs attachArgs;
                attachArgs.version = (int)JniWrapper.PreferredJniVersion;

                if (!string.IsNullOrWhiteSpace(Thread.CurrentThread.Name))
                {
                    threadNamePtr = Marshal.StringToHGlobalAnsi(Thread.CurrentThread.Name);
                    attachArgs.threadName = threadNamePtr;
                }

                IntPtr envPtr;
                var jniResult = attachFunction(_javaVmPtr, out envPtr, &attachArgs);
                WrapperHelpers.VerifyJniResult(jniResult);

                return new JniEnvWrapper(this, envPtr);
            }
            finally
            {
                if (threadNamePtr != IntPtr.Zero)
                    Marshal.FreeHGlobal(threadNamePtr);
            }
        }
    }
}
