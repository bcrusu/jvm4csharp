using System;
using System.Diagnostics;
using jvm4csharp.java.lang;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    //TODO: cache fieldId & memeberId
    internal class JniEnvClassesWrapper
    {
        private const string JavaLangClassName = "java.lang.Class";
        private const string JavaLangClassInternalName = "java/lang/Class";

        private readonly JniEnvWrapper _jniEnvWrapper;
        private Class _javaLangClass;

        private JniNativeInterfaceSig.Methods.NewObjectA _newObject;
        private JniNativeInterfaceSig.Fields.GetFieldID _getFieldId;
        private JniNativeInterfaceSig.Fields.GetInstance.GetBooleanField _getBooleanField;
        private JniNativeInterfaceSig.Fields.GetInstance.GetIntField _getIntField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticIntField _getStaticIntField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticBooleanField _getStaticBooleanField;
        private JniNativeInterfaceSig.Fields.GetStaticFieldID _getStaticFieldId;
        private JniNativeInterfaceSig.Methods.GetMethodID _getMethodId;
        private JniNativeInterfaceSig.Methods.GetStaticMethodID _getStaticMethodId;
        private JniNativeInterfaceSig.Methods.CallInstance.CallIntMethodA _callIntMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallBooleanMethodA _callBooleanMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallObjectMethodA _callObjectMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticIntMethodA _callStaticIntMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticBooleanMethodA _callStaticBooleanMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticObjectMethodA _callStaticObjectMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticByteMethodA _callStaticByteMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticFloatMethodA _callStaticFloatMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticDoubleMethodA _callStaticDoubleMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticLongMethodA _callStaticLongMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticCharMethodA _callStaticCharMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticVoidMethodA _callStaticVoidMethod;
        private JniNativeInterfaceSig.Methods.CallStatic.CallStaticShortMethodA _callStaticShortMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallByteMethodA _callByteMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallFloatMethodA _callFloatMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallDoubleMethodA _callDoubleMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallVoidMethodA _callVoidMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallShortMethodA _callShortMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallCharMethodA _callCharMethod;
        private JniNativeInterfaceSig.Methods.CallInstance.CallLongMethodA _callLongMethod;
        private JniNativeInterfaceSig.Fields.GetInstance.GetLongField _getLongField;
        private JniNativeInterfaceSig.Fields.GetInstance.GetShortField _getShortField;
        private JniNativeInterfaceSig.Fields.GetInstance.GetFloatField _getFloatField;
        private JniNativeInterfaceSig.Fields.GetInstance.GetObjectField _getObjectField;
        private JniNativeInterfaceSig.Fields.GetInstance.GetByteField _getByteField;
        private JniNativeInterfaceSig.Fields.GetInstance.GetDoubleField _getDoubleField;
        private JniNativeInterfaceSig.Fields.GetInstance.GetCharField _getCharField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticLongField _getStaticLongField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticShortField _getStaticShortField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticFloatField _getStaticFloatField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticDoubleField _getStaticDoubleField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticObjectField _getStaticObjectField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticCharField _getStaticCharField;
        private JniNativeInterfaceSig.Fields.GetStatic.GetStaticByteField _getStaticByteField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetBooleanField _setBooleanField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetIntField _setIntField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetShortField _setShortField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetLongField _setLongField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetObjectField _setObjectField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetFloatField _setFloatField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetDoubleField _setDoubleField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetCharField _setCharField;
        private JniNativeInterfaceSig.Fields.SetInstance.SetByteField _setByteField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticBooleanField _setStaticBooleanField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticDoubleField _setStaticDoubleField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticCharField _setStaticCharField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticIntField _setStaticIntField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticLongField _setStaticLongField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticShortField _setStaticShortField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticFloatField _setStaticFloatField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticByteField _setStaticByteField;
        private JniNativeInterfaceSig.Fields.SetStatic.SetStaticObjectField _setStaticObjectField;
        private JniNativeInterfaceSig.Reflection.GetObjectClass _getObjectClass;
        private JniNativeInterfaceSig.Reflection.FindClass _findClass;

        internal JniEnvClassesWrapper(JniEnvWrapper jniEnvWrapper)
        {
            Debug.Assert(jniEnvWrapper != null);
            _jniEnvWrapper = jniEnvWrapper;
            InitFunctions();
        }

        private void InitFunctions()
        {
            var jni = WrapperHelpers.GetJniNativeInterface(_jniEnvWrapper.JniEnvPtr);

            _newObject = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.NewObjectA>(jni.NewObjectA);

            _getFieldId = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetFieldID>(jni.GetFieldID);
            _getBooleanField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetBooleanField>(jni.GetBooleanField);
            _getIntField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetIntField>(jni.GetIntField);
            _getLongField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetLongField>(jni.GetLongField);
            _getShortField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetShortField>(jni.GetShortField);
            _getFloatField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetFloatField>(jni.GetFloatField);
            _getDoubleField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetDoubleField>(jni.GetDoubleField);
            _getCharField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetCharField>(jni.GetCharField);
            _getByteField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetByteField>(jni.GetByteField);
            _getObjectField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetInstance.GetObjectField>(jni.GetObjectField);
            _setBooleanField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetBooleanField>(jni.SetBooleanField);
            _setIntField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetIntField>(jni.SetIntField);
            _setLongField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetLongField>(jni.SetLongField);
            _setShortField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetShortField>(jni.SetShortField);
            _setFloatField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetFloatField>(jni.SetFloatField);
            _setDoubleField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetDoubleField>(jni.SetDoubleField);
            _setCharField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetCharField>(jni.SetCharField);
            _setByteField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetByteField>(jni.SetByteField);
            _setObjectField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetInstance.SetObjectField>(jni.SetObjectField);

            _getStaticFieldId = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStaticFieldID>(jni.GetStaticFieldID);
            _getStaticBooleanField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticBooleanField>(jni.GetStaticBooleanField);
            _getStaticIntField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticIntField>(jni.GetStaticIntField);
            _getStaticLongField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticLongField>(jni.GetStaticLongField);
            _getStaticShortField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticShortField>(jni.GetStaticShortField);
            _getStaticFloatField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticFloatField>(jni.GetStaticFloatField);
            _getStaticDoubleField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticDoubleField>(jni.GetStaticDoubleField);
            _getStaticCharField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticCharField>(jni.GetStaticCharField);
            _getStaticByteField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticByteField>(jni.GetStaticByteField);
            _getStaticObjectField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.GetStatic.GetStaticObjectField>(jni.GetStaticObjectField);
            _setStaticBooleanField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticBooleanField>(jni.SetStaticBooleanField);
            _setStaticIntField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticIntField>(jni.SetStaticIntField);
            _setStaticLongField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticLongField>(jni.SetStaticLongField);
            _setStaticShortField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticShortField>(jni.SetStaticShortField);
            _setStaticFloatField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticFloatField>(jni.SetStaticFloatField);
            _setStaticDoubleField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticDoubleField>(jni.SetStaticDoubleField);
            _setStaticCharField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticCharField>(jni.SetStaticCharField);
            _setStaticByteField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticByteField>(jni.SetStaticByteField);
            _setStaticObjectField = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Fields.SetStatic.SetStaticObjectField>(jni.SetStaticObjectField);

            _getMethodId = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.GetMethodID>(jni.GetMethodID);
            _callIntMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallIntMethodA>(jni.CallIntMethodA);
            _callBooleanMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallBooleanMethodA>(jni.CallBooleanMethodA);
            _callObjectMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallObjectMethodA>(jni.CallObjectMethodA);
            _callByteMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallByteMethodA>(jni.CallByteMethodA);
            _callFloatMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallFloatMethodA>(jni.CallFloatMethodA);
            _callDoubleMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallDoubleMethodA>(jni.CallDoubleMethodA);
            _callLongMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallLongMethodA>(jni.CallLongMethodA);
            _callCharMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallCharMethodA>(jni.CallCharMethodA);
            _callShortMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallShortMethodA>(jni.CallShortMethodA);
            _callVoidMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallInstance.CallVoidMethodA>(jni.CallVoidMethodA);

            _getStaticMethodId = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.GetStaticMethodID>(jni.GetStaticMethodID);
            _callStaticIntMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticIntMethodA>(jni.CallStaticIntMethodA);
            _callStaticBooleanMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticBooleanMethodA>(jni.CallStaticBooleanMethodA);
            _callStaticObjectMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticObjectMethodA>(jni.CallStaticObjectMethodA);
            _callStaticByteMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticByteMethodA>(jni.CallStaticByteMethodA);
            _callStaticFloatMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticFloatMethodA>(jni.CallStaticFloatMethodA);
            _callStaticDoubleMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticDoubleMethodA>(jni.CallStaticDoubleMethodA);
            _callStaticLongMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticLongMethodA>(jni.CallStaticLongMethodA);
            _callStaticCharMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticCharMethodA>(jni.CallStaticCharMethodA);
            _callStaticShortMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticShortMethodA>(jni.CallStaticShortMethodA);
            _callStaticVoidMethod = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Methods.CallStatic.CallStaticVoidMethodA>(jni.CallStaticVoidMethodA);

            _findClass = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Reflection.FindClass>(jni.FindClass);
            _getObjectClass = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Reflection.GetObjectClass>(jni.GetObjectClass);
        }

        public Class FindClass(string className)
        {
            Debug.Assert(className != null);

            Class result;
            if (!_jniEnvWrapper.JavaVm.GlobalReferences.TryGetClass(className, out result))
            {
                using (_jniEnvWrapper.PushLocalFrame())
                {
                    var strPtr = _jniEnvWrapper.Strings.NewStringPtr(className);

                    using (var modifiedStr = _jniEnvWrapper.Strings.GetModifiedUtfString(strPtr))
                    {
                        var classPtr = _findClass(_jniEnvWrapper.JniEnvPtr, modifiedStr.NativePtr);
                        _jniEnvWrapper.Exceptions.CheckLastException();

                        var globalClassPtr = _jniEnvWrapper.NewGlobalReference(classPtr);

                        result = CreateClassInstance(globalClassPtr, className);

                        _jniEnvWrapper.JavaVm.GlobalReferences.SetClass(className, result);
                    }
                }
            }

            return result;
        }

        public Class FindClass(Type javaProxyType)
        {
            Debug.Assert(javaProxyType != null);

            var className = ProxyRegistry.Current.GetClassName(javaProxyType);
            return FindClass(className);
        }

        public Class GetObjectClass(IntPtr objPtr)
        {
            Debug.Assert(objPtr != IntPtr.Zero);

            using (_jniEnvWrapper.PushLocalFrame())
            {
                var classPtr = _getObjectClass(_jniEnvWrapper.JniEnvPtr, objPtr);
                _jniEnvWrapper.Exceptions.CheckLastException();

                var className = GetClassName(classPtr);

                Class globalClass;
                if (!_jniEnvWrapper.JavaVm.GlobalReferences.TryGetClass(className, out globalClass))
                {
                    var globalClassPtr = _jniEnvWrapper.NewGlobalReference(classPtr);

                    globalClass = CreateClassInstance(globalClassPtr, className);

                    _jniEnvWrapper.JavaVm.GlobalReferences.SetClass(className, globalClass);
                }

                return globalClass;
            }
        }

        public Class CreateClassInstance(IntPtr classPtr, string internalClassName)
        {
            Debug.Assert(classPtr != IntPtr.Zero);
            Debug.Assert(internalClassName != null);

            var className = WrapperHelpers.GetClassName(internalClassName);

            var result = new Class(ProxyCtor.I, className, internalClassName);

            Class clazz;
            if (string.Equals(className, JavaLangClassName, StringComparison.CurrentCultureIgnoreCase))
                clazz = result;
            else
                clazz = GetJavaLangClass();

            result.ProxyState = new JavaProxyState(classPtr, clazz);
            return result;
        }

        public T NewObject<T>(string ctorSignature, params object[] args)
        {
            if (ctorSignature == null) throw new ArgumentNullException(nameof(ctorSignature));

            var clazz = FindClass(typeof(T));
            var methodId = GetMethodId(clazz, "<init>", false, ctorSignature);
            var argValues = GetJniValues(args);

            var ptr = _newObject(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
            _jniEnvWrapper.Exceptions.CheckLastException();

            return (T)_jniEnvWrapper.ProxyFactory.CreateProxy(typeof(T), clazz, ptr);
        }

        public void NewObjectForProxy(IJavaProxy proxy, string ctorSignature, params object[] args)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            if (ctorSignature == null) throw new ArgumentNullException(nameof(ctorSignature));
            if (proxy.ProxyState != null) throw new ArgumentException("Proxy object already initialized.");

            var clazz = FindClass(proxy.GetType());
            var methodId = GetMethodId(clazz, "<init>", false, ctorSignature);
            var argValues = GetJniValues(args);

            var ptr = _newObject(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
            _jniEnvWrapper.Exceptions.CheckLastException();

            proxy.ProxyState = new JavaProxyState(ptr, clazz);
        }

        public TField GetField<TField>(IJavaProxy proxy, string name, string signature)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (signature == null) throw new ArgumentNullException(nameof(signature));
            JvmContext.Current.ValidateProxyInstane(proxy);

            var clazz = proxy.ProxyState.Class;
            var fieldType = typeof(TField);
            var fieldId = GetFieldId(clazz, name, false, signature);

            object result;

            if (typeof(IJavaProxy).IsAssignableFrom(fieldType))
            {
                var objPtr = _getObjectField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                _jniEnvWrapper.Exceptions.CheckLastException();

                result = _jniEnvWrapper.ProxyFactory.CreateProxy(fieldType, objPtr);
            }
            else
            {
                if (fieldType == typeof(int))
                    result = _getIntField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(bool))
                    result = _getBooleanField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId) == JniBooleanValue.True;
                else if (fieldType == typeof(byte))
                    result = _getByteField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(double))
                    result = _getDoubleField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(char))
                    result = _getCharField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(long))
                    result = _getLongField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(float))
                    result = _getFloatField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(short))
                    result = _getShortField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId);
                else
                    throw new ArgumentException($"Unsupported CLR type '{fieldType}'.");

                _jniEnvWrapper.Exceptions.CheckLastException();
            }

            return (TField)result;
        }

        public TField GetStaticField<TField>(Type javaProxyType, string name, string signature)
        {
            if (javaProxyType == null) throw new ArgumentNullException(nameof(javaProxyType));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            var clazz = FindClass(javaProxyType);
            var fieldType = typeof(TField);
            var fieldId = GetFieldId(clazz, name, false, signature);

            object result;

            if (typeof(IJavaProxy).IsAssignableFrom(fieldType))
            {
                var objPtr = _getStaticObjectField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                _jniEnvWrapper.Exceptions.CheckLastException();

                result = _jniEnvWrapper.ProxyFactory.CreateProxy(fieldType, objPtr);
            }
            else
            {
                if (fieldType == typeof(int))
                    result = _getStaticIntField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(bool))
                    result = _getStaticBooleanField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId) == JniBooleanValue.True;
                else if (fieldType == typeof(byte))
                    result = _getStaticByteField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(double))
                    result = _getStaticDoubleField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(char))
                    result = _getStaticCharField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(long))
                    result = _getStaticLongField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(float))
                    result = _getStaticFloatField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                else if (fieldType == typeof(short))
                    result = _getStaticShortField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId);
                else
                    throw new ArgumentException($"Unsupported CLR type '{fieldType}'.");

                _jniEnvWrapper.Exceptions.CheckLastException();
            }

            return (TField)result;
        }

        public void SetField<TField>(IJavaProxy proxy, string name, string signature, TField value)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (signature == null) throw new ArgumentNullException(nameof(signature));
            JvmContext.Current.ValidateProxyInstane(proxy);

            var clazz = proxy.ProxyState.Class;
            var fieldType = typeof(TField);
            var fieldId = GetFieldId(clazz, name, false, signature);

            if (typeof(IJavaProxy).IsAssignableFrom(fieldType))
            {
                var valuePtr = IntPtr.Zero;
                if (value != null)
                    valuePtr = ((IJavaProxy)value).ProxyState.NativePtr;

                _setObjectField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, valuePtr);
            }
            else if (fieldType == typeof(int))
                _setIntField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, Convert.ToInt32(value));
            else if (fieldType == typeof(bool))
                _setBooleanField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, JniBooleanValue.ToNativeBool(Convert.ToBoolean(value)));
            else if (fieldType == typeof(byte))
                _setByteField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, Convert.ToByte(value));
            else if (fieldType == typeof(double))
                _setDoubleField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, Convert.ToDouble(value));
            else if (fieldType == typeof(char))
                _setCharField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, Convert.ToChar(value));
            else if (fieldType == typeof(long))
                _setLongField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, Convert.ToInt64(value));
            else if (fieldType == typeof(float))
                _setFloatField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, Convert.ToSingle(value));
            else if (fieldType == typeof(short))
                _setShortField(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, fieldId, Convert.ToInt16(value));
            else
                throw new ArgumentException($"Unsupported CLR type '{fieldType}'.");

            _jniEnvWrapper.Exceptions.CheckLastException();
        }

        public void SetStaticField<TField>(Type javaProxyType, string name, string signature, TField value)
        {
            if (javaProxyType == null) throw new ArgumentNullException(nameof(javaProxyType));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            var clazz = FindClass(javaProxyType);
            var fieldType = typeof(TField);
            var fieldId = GetFieldId(clazz, name, false, signature);

            if (typeof(IJavaProxy).IsAssignableFrom(fieldType))
            {
                var valuePtr = IntPtr.Zero;
                if (value != null)
                    valuePtr = ((IJavaProxy)value).ProxyState.NativePtr;

                _setStaticObjectField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, valuePtr);
            }
            else if (fieldType == typeof(int))
                _setStaticIntField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, Convert.ToInt32(value));
            else if (fieldType == typeof(bool))
                _setStaticBooleanField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, JniBooleanValue.ToNativeBool(Convert.ToBoolean(value)));
            else if (fieldType == typeof(byte))
                _setStaticByteField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, Convert.ToByte(value));
            else if (fieldType == typeof(double))
                _setStaticDoubleField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, Convert.ToDouble(value));
            else if (fieldType == typeof(char))
                _setStaticCharField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, Convert.ToChar(value));
            else if (fieldType == typeof(long))
                _setStaticLongField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, Convert.ToInt64(value));
            else if (fieldType == typeof(float))
                _setStaticFloatField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, Convert.ToSingle(value));
            else if (fieldType == typeof(short))
                _setStaticShortField(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, fieldId, Convert.ToInt16(value));
            else
                throw new ArgumentException($"Unsupported CLR type '{fieldType}'.");

            _jniEnvWrapper.Exceptions.CheckLastException();
        }

        public TResult CallMethod<TResult>(IJavaProxy proxy, string name, string signature, params object[] args)
        {
            if (proxy == null) throw new ArgumentNullException(nameof(proxy));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (signature == null) throw new ArgumentNullException(nameof(signature));
            JvmContext.Current.ValidateProxyInstane(proxy);

            var clazz = proxy.ProxyState.Class;

            var methodId = GetMethodId(clazz, name, false, signature);
            var argValues = GetJniValues(args);

            object result;
            var resultType = typeof(TResult);

            if (typeof(IJavaObject).IsAssignableFrom(resultType))
            {
                var objPtr = _callObjectMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                _jniEnvWrapper.Exceptions.CheckLastException();

                result = _jniEnvWrapper.ProxyFactory.CreateProxy(resultType, objPtr);
            }
            else
            {
                if (resultType == typeof(int))
                    result = _callIntMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(bool))
                    result = _callBooleanMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues) == JniBooleanValue.True;
                else if (resultType == typeof(java.lang.Void))
                {
                    _callVoidMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                    result = null;
                }
                else if (resultType == typeof(byte))
                    result = _callByteMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(double))
                    result = _callDoubleMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(char))
                    result = _callCharMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(long))
                    result = _callLongMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(float))
                    result = _callFloatMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(short))
                    result = _callShortMethod(_jniEnvWrapper.JniEnvPtr, proxy.ProxyState.NativePtr, methodId, argValues);
                else
                    throw new ArgumentException($"Unsupported CLR type '{resultType}'.");

                _jniEnvWrapper.Exceptions.CheckLastException();
            }

            return (TResult)result;
        }

        public TResult CallStaticMethod<TResult>(Type javaProxyType, string name, string signature, params object[] args)
        {
            if (javaProxyType == null) throw new ArgumentNullException(nameof(javaProxyType));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            var clazz = FindClass(javaProxyType);
            var methodId = GetMethodId(clazz, name, false, signature);
            var argValues = GetJniValues(args);

            object result;
            var resultType = typeof(TResult);

            if (typeof(IJavaProxy).IsAssignableFrom(resultType))
            {
                var objPtr = _callStaticObjectMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                _jniEnvWrapper.Exceptions.CheckLastException();

                result = _jniEnvWrapper.ProxyFactory.CreateProxy(resultType, objPtr);
            }
            else
            {
                if (resultType == typeof(int))
                    result = _callStaticIntMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(bool))
                    result = _callStaticBooleanMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues) == JniBooleanValue.True;
                else if (resultType == typeof(java.lang.Void))
                {
                    _callStaticVoidMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                    result = null;
                }
                else if (resultType == typeof(byte))
                    result = _callStaticByteMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(double))
                    result = _callStaticDoubleMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(char))
                    result = _callStaticCharMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(long))
                    result = _callStaticLongMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(float))
                    result = _callStaticFloatMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                else if (resultType == typeof(short))
                    result = _callStaticShortMethod(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, methodId, argValues);
                else
                    throw new ArgumentException($"Unsupported CLR type '{resultType}'.");

                _jniEnvWrapper.Exceptions.CheckLastException();
            }

            return (TResult)result;
        }

        public string GetClassName(IntPtr classPtr)
        {
            Debug.Assert(classPtr != IntPtr.Zero);

            using (_jniEnvWrapper.PushLocalFrame())
            {
                var methodId = GetMethodId(GetJavaLangClass(), "getName", false, "()Ljava/lang/String;");

                var classNamePtr = _callObjectMethod(_jniEnvWrapper.JniEnvPtr, classPtr, methodId);
                _jniEnvWrapper.Exceptions.CheckLastException();

                var className = _jniEnvWrapper.Strings.ToClrString(classNamePtr);
                return WrapperHelpers.GetInternalClassName(className);
            }
        }

        //TODO: better logging 4 debug mode
        //public string CallToString(IntPtr objPtr)
        //{
        //    Debug.Assert(objPtr != IntPtr.Zero);

        //    var classPtr = _getObjectClass(_jniEnvWrapper.JniEnvPtr, objPtr);
        //    _jniEnvWrapper.Exceptions.CheckLastException();

        //    var methodId = GetMethodId(classPtr, "toString", false, "()Ljava/lang/String;");

        //    var strPtr = _callObjectMethod(_jniEnvWrapper.JniEnvPtr, objPtr, methodId);
        //    _jniEnvWrapper.Exceptions.CheckLastException();

        //    var clrStr = _jniEnvWrapper.Strings.ToClrString(strPtr);
        //    return clrStr;
        //}

        private IntPtr GetFieldId(Class clazz, string name, bool isStatic, string signature)
        {
            Debug.Assert(clazz != null);
            Debug.Assert(name != null);
            Debug.Assert(signature != null);

            using (_jniEnvWrapper.PushLocalFrame())
            {
                var nameStringPtr = _jniEnvWrapper.Strings.NewStringPtr(name);
                var signatureStringPtr = _jniEnvWrapper.Strings.NewStringPtr(signature);

                using (var nameModifiedString = _jniEnvWrapper.Strings.GetModifiedUtfString(nameStringPtr))
                using (var signatureModifiedString = _jniEnvWrapper.Strings.GetModifiedUtfString(signatureStringPtr))
                {
                    IntPtr ptr;
                    if (isStatic)
                        ptr = _getStaticFieldId(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, nameModifiedString.NativePtr, signatureModifiedString.NativePtr);
                    else
                        ptr = _getFieldId(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, nameModifiedString.NativePtr, signatureModifiedString.NativePtr);

                    _jniEnvWrapper.Exceptions.CheckLastException();
                    if (ptr == IntPtr.Zero)
                        throw new JvmException($"Could not get field id. Class: '{clazz.ClassName}', name: '{name}', isStatic: '{isStatic}', signature: '{signature}'");

                    return ptr;
                }
            }
        }

        private IntPtr GetMethodId(Class clazz, string name, bool isStatic, string signature)
        {
            Debug.Assert(clazz != null);
            Debug.Assert(name != null);
            Debug.Assert(signature != null);

            using (_jniEnvWrapper.PushLocalFrame())
            {
                var nameStringPtr = _jniEnvWrapper.Strings.NewStringPtr(name);
                var signatureStringPtr = _jniEnvWrapper.Strings.NewStringPtr(signature);

                using (var nameModifiedString = _jniEnvWrapper.Strings.GetModifiedUtfString(nameStringPtr))
                using (var signatureModifiedString = _jniEnvWrapper.Strings.GetModifiedUtfString(signatureStringPtr))
                {
                    IntPtr ptr;
                    if (isStatic)
                        ptr = _getStaticMethodId(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, nameModifiedString.NativePtr, signatureModifiedString.NativePtr);
                    else
                        ptr = _getMethodId(_jniEnvWrapper.JniEnvPtr, clazz.ProxyState.NativePtr, nameModifiedString.NativePtr, signatureModifiedString.NativePtr);

                    _jniEnvWrapper.Exceptions.CheckLastException();
                    if (ptr == IntPtr.Zero)
                        throw new JvmException($"Could not get method id. Class: '{clazz.ClassName}', name: '{name}', isStatic: '{isStatic}', signature: '{signature}'");

                    return ptr;
                }
            }
        }

        private static JniValue GetJniValue(object val)
        {
            var result = default(JniValue);

            if (val == null)
                return result;

            var argType = val.GetType();

            if (argType == typeof(int))
                result.Int = (int)val;
            else if (argType == typeof(bool))
                result.Bool = JniBooleanValue.ToNativeBool((bool)val);
            else if (typeof(IJavaProxy).IsAssignableFrom(argType))
            {
                var proxy = (IJavaProxy)val;
                JvmContext.Current.ValidateProxyInstane(proxy);
                result.Object = proxy.ProxyState.NativePtr;
            }
            else if (argType == typeof(byte))
                result.Byte = (byte)val;
            else if (argType == typeof(double))
                result.Double = (double)val;
            else if (argType == typeof(char))
                result.Char = (char)val;
            else if (argType == typeof(long))
                result.Long = (long)val;
            else if (argType == typeof(float))
                result.Float = (float)val;
            else if (argType == typeof(short))
                result.Short = (short)val;
            else
                throw new ArgumentException($"Unsupported CLR type '{argType}'.");

            return result;
        }

        private static JniValue[] GetJniValues(params object[] args)
        {
            var result = new JniValue[args.Length];

            for (var i = 0; i < args.Length; i++)
                result[i] = GetJniValue(args[i]);

            return result;
        }

        private Class GetJavaLangClass()
        {
            if (_javaLangClass == null)
                _javaLangClass = FindClass(JavaLangClassInternalName);
            return _javaLangClass;
        }
    }
}