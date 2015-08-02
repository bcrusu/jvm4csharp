using System;
using System.Runtime.InteropServices;
using System.Security;

namespace jvm4csharp.JniApi
{
    // ReSharper disable InconsistentNaming
    internal static class JniNativeInterfaceSig
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        public delegate int GetVersion(IntPtr env);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        public delegate int GetJavaVM(IntPtr env, out JavaVm jvm);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        public delegate int MonitorEnter(IntPtr env, IntPtr /*jobject*/ obj);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        public delegate int MonitorExit(IntPtr env, IntPtr /*jobject*/ obj);

        public static class Reflection
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jclass*/ FindClass(IntPtr env, IntPtr /*char**/ name);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jmethodId*/ FromReflectedMethod(IntPtr env, IntPtr /*jobject*/ method);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jfieldId*/ FromReflectedField(IntPtr env, IntPtr /*jobject*/ field);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ ToReflectedMethod(IntPtr env, IntPtr /*jclass*/ cls, IntPtr /*jmethodId*/ methodId, byte /*jboolean*/ isStatic);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jclass*/ GetSuperclass(IntPtr env, IntPtr /*jclass*/ sub);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate byte /*jboolean*/ IsAssignableFrom(IntPtr env, IntPtr /*jclass*/ sub, IntPtr /*jclass*/ sup);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ ToReflectedField(IntPtr env, IntPtr /*jclass*/ cls, IntPtr /*jfieldId*/ fieldId, byte /*jboolean*/ isStatic);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate byte /*jboolean*/ IsSameObject(IntPtr env, IntPtr /*jobject*/ obj1, IntPtr /*jobject*/ obj2);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jclass*/ GetObjectClass(IntPtr env, IntPtr /*jobject*/ obj);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate byte /*jboolean*/ IsInstanceOf(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate IntPtr /*jclass*/ DefineClass(IntPtr env, IntPtr /*char**/ name, IntPtr /*jobject*/ loader, byte* buf, int /*jsize*/ len);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate int RegisterNatives(IntPtr env, IntPtr /*jclass*/ clazz, JniNativeMethod* methods, int nMethods);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int UnregisterNatives(IntPtr env, IntPtr /*jclass*/ clazz);
        }

        public static class Exceptions
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int Throw(IntPtr env, IntPtr /*jthrowable*/ obj);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int ThrowNew(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*char**/ msg);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jthrowable*/ ExceptionOccurred(IntPtr env);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void ExceptionDescribe(IntPtr env);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void ExceptionClear(IntPtr env);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void FatalError(IntPtr env, IntPtr /*char**/ msg);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate byte /*jboolean*/ ExceptionCheck(IntPtr env);
        }

        public static class Activation
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int PushLocalFrame(IntPtr env, int capacity);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ PopLocalFrame(IntPtr env, IntPtr /*jobject*/ result);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ NewGlobalRef(IntPtr env, IntPtr /*jobject*/ lobj);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void DeleteGlobalRef(IntPtr env, IntPtr /*jobject*/ gref);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void DeleteLocalRef(IntPtr env, IntPtr /*jobject*/ obj);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ NewLocalRef(IntPtr env, IntPtr /*jobject*/ ref1);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int EnsureLocalCapacity(IntPtr env, int capacity);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ AllocObject(IntPtr env, IntPtr /*jclass*/ clazz);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jweak*/ NewWeakGlobalRef(IntPtr env, IntPtr /*jobject*/ obj);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void DeleteWeakGlobalRef(IntPtr env, IntPtr /*jweak*/ ref1);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate JniObjectRefType GetObjectRefType(IntPtr env, IntPtr /*jobject*/ obj);
        }
        
        public static class Methods
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jmethodId*/ GetMethodID(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*char**/ name, IntPtr /*char**/ sig);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jmethodId*/ GetStaticMethodID(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*char**/ name, IntPtr /*char**/ sig);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ NewObjectA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

            public static class CallInstance
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jobject*/ CallObjectMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte /*jboolean*/ CallBooleanMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte CallByteMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate ushort /*jchar*/ CallCharMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate short CallShortMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate int CallIntMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate long CallLongMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate float CallFloatMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate double CallDoubleMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void CallVoidMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jobject*/ CallNonvirtualObjectMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte /*jboolean*/ CallNonvirtualBooleanMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte CallNonvirtualByteMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate ushort /*jchar*/ CallNonvirtualCharMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate short CallNonvirtualShortMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate int CallNonvirtualIntMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate long CallNonvirtualLongMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate float CallNonvirtualFloatMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate double CallNonvirtualDoubleMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void CallNonvirtualVoidMethodA(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);
            }

            public static class CallStatic
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jobject*/ CallStaticObjectMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte /*jboolean*/ CallStaticBooleanMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte CallStaticByteMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate ushort /*jchar*/ CallStaticCharMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate short CallStaticShortMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate int CallStaticIntMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate long CallStaticLongMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate float CallStaticFloatMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate double CallStaticDoubleMethodA(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jmethodId*/ methodId, params JniValue[] args);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void CallStaticVoidMethodA(IntPtr env, IntPtr /*jclass*/ cls, IntPtr /*jmethodId*/ methodId, params JniValue[] args);
            }
        }

        public static class Fields
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jfieldId*/ GetFieldID(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*char**/ name, IntPtr /*char**/ sig);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jfieldId*/ GetStaticFieldID(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*char**/ name, IntPtr /*char**/ sig);
            
            public static class GetInstance
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jobject*/ GetObjectField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte /*jboolean*/ GetBooleanField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte GetByteField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate ushort /*jchar*/ GetCharField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate short GetShortField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate int GetIntField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate long GetLongField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate float GetFloatField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate double GetDoubleField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId);
            }

            public static class SetInstance
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetObjectField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, IntPtr /*jobject*/ val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetBooleanField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, byte /*jboolean*/ val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetByteField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, byte val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetCharField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, ushort /*jchar*/ val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetShortField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, short val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetIntField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, int val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetLongField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, long val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetFloatField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, float val);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetDoubleField(IntPtr env, IntPtr /*jobject*/ obj, IntPtr /*jfieldId*/ fieldId, double val);
            }

            public static class GetStatic
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jobject*/ GetStaticObjectField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte /*jboolean*/ GetStaticBooleanField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate byte GetStaticByteField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate ushort /*jchar*/ GetStaticCharField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate short GetStaticShortField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate int GetStaticIntField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate long GetStaticLongField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate float GetStaticFloatField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate double GetStaticDoubleField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId);
            }

            public static class SetStatic
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticObjectField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, IntPtr /*jobject*/ value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticBooleanField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, byte /*jboolean*/ value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticByteField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, byte value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticCharField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, ushort /*jchar*/ value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticShortField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, short value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticIntField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, int value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticLongField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, long value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticFloatField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, float value);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetStaticDoubleField(IntPtr env, IntPtr /*jclass*/ clazz, IntPtr /*jfieldId*/ fieldId, double value);
            }
        }
        
        public static class Arrays
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int /*jsize*/ GetArrayLength(IntPtr env, IntPtr /*jarray*/ array);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate IntPtr /*void**/ GetPrimitiveArrayCritical(IntPtr env, IntPtr /*jarray*/ array, byte* /*jboolean*/ isCopy);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void ReleasePrimitiveArrayCritical(IntPtr env, IntPtr /*jarray*/ array, IntPtr /*void**/ carray, int mode);

            public static class ObjectArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jobjectArray*/ NewObjectArray(IntPtr env, int /*jsize*/ len, IntPtr /*jclass*/ clazz, IntPtr /*jobject*/ init);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jobject*/ GetObjectArrayElement(IntPtr env, IntPtr /*jobjectArray*/ array, int /*jsize*/ index);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate void SetObjectArrayElement(IntPtr env, IntPtr /*jobjectArray*/ array, int /*jsize*/ index, IntPtr /*jobject*/ val);
            }

            public static class BooleanArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jbooleanArray*/ NewBooleanArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate byte* /*jboolean*/ GetBooleanArrayElements(IntPtr env, IntPtr /*jbooleanArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseBooleanArrayElements(IntPtr env, IntPtr /*jbooleanArray*/ array, byte* /*jboolean*/ elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetBooleanArrayRegion(IntPtr env, IntPtr /*jbooleanArray*/ array, int /*jsize*/ start, int len, byte* buffer);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetBooleanArrayRegion(IntPtr env, IntPtr /*jbooleanArray*/ array, int /*jsize*/ start, int len, byte* buffer);
            }

            public static class ByteArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jbyteArray*/ NewByteArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate byte* GetByteArrayElements(IntPtr env, IntPtr /*jbyteArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseByteArrayElements(IntPtr env, IntPtr /*jbyteArray*/ array, byte* elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetByteArrayRegion(IntPtr env, IntPtr /*jbyteArray*/ array, int /*jsize*/ start, int len, byte* buffer);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetByteArrayRegion(IntPtr env, IntPtr /*jbyteArray*/ array, int /*jsize*/ start, int len, byte* buffer);
            }

            public static class CharArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jcharArray*/ NewCharArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate ushort* /*jchar*/ GetCharArrayElements(IntPtr env, IntPtr /*jcharArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseCharArrayElements(IntPtr env, IntPtr /*jcharArray*/ array, ushort* /*jchar*/ elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetCharArrayRegion(IntPtr env, IntPtr /*jcharArray*/ array, int /*jsize*/ start, int len, char* buffer);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetCharArrayRegion(IntPtr env, IntPtr /*jcharArray*/ array, int /*jsize*/ start, int len, char* buffer);
            }

            public static class ShortArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jshortArray*/ NewShortArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate short* GetShortArrayElements(IntPtr env, IntPtr /*jshortArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseShortArrayElements(IntPtr env, IntPtr /*jshortArray*/ array, short* elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetShortArrayRegion(IntPtr env, IntPtr /*jshortArray*/ array, int /*jsize*/ start, int len, short* buffer);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetShortArrayRegion(IntPtr env, IntPtr /*jshortArray*/ array, int /*jsize*/ start, int len, short* buffer);
            }

            public static class IntArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jintArray*/ NewIntArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate int* GetIntArrayElements(IntPtr env, IntPtr /*jintArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseIntArrayElements(IntPtr env, IntPtr /*jintArray*/ array, int* elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetIntArrayRegion(IntPtr env, IntPtr /*jintArray*/ array, int /*jsize*/ start, int len, int* buffer);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetIntArrayRegion(IntPtr env, IntPtr /*jintArray*/ array, int /*jsize*/ start, int len, int* buffer);
            }

            public static class LongArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jlongArray*/ NewLongArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate long* GetLongArrayElements(IntPtr env, IntPtr /*jlongArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseLongArrayElements(IntPtr env, IntPtr /*jlongArray*/ array, long* elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetLongArrayRegion(IntPtr env, IntPtr /*jlongArray*/ array, int /*jsize*/ start, int len, long* buffer);
                
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetLongArrayRegion(IntPtr env, IntPtr /*jlongArray*/ array, int /*jsize*/ start, int len, long* buffer);
            }

            public static class FloatArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jfloatArray*/ NewFloatArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate float* GetFloatArrayElements(IntPtr env, IntPtr /*jfloatArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseFloatArrayElements(IntPtr env, IntPtr /*jfloatArray*/ array, float* elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetFloatArrayRegion(IntPtr env, IntPtr /*jfloatArray*/ array, int /*jsize*/ start, int len, float* buffer);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetFloatArrayRegion(IntPtr env, IntPtr /*jfloatArray*/ array, int /*jsize*/ start, int len, float* buffer);
            }

            public static class DoubleArray
            {
                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public delegate IntPtr /*jdoubleArray*/ NewDoubleArray(IntPtr env, int /*jsize*/ len);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate double* GetDoubleArrayElements(IntPtr env, IntPtr /*jdoubleArray*/ array, byte* /*jboolean*/ isCopy);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void ReleaseDoubleArrayElements(IntPtr env, IntPtr /*jdoubleArray*/ array, double* elems, int mode);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void GetDoubleArrayRegion(IntPtr env, IntPtr /*jdoubleArray*/ array, int /*jsize*/ start, int len, double* buffer);

                [UnmanagedFunctionPointer(CallingConvention.StdCall)]
                [SuppressUnmanagedCodeSecurity]
                public unsafe delegate void SetDoubleArrayRegion(IntPtr env, IntPtr /*jdoubleArray*/ array, int /*jsize*/ start, int len, double* buffer);
            }
        }

        public static class Strings
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jstring*/ NewString(IntPtr env, IntPtr /*jchar*/ unicode, int /*jsize*/ len);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int /*jsize*/ GetStringLength(IntPtr env, IntPtr /*jstring*/ str);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate IntPtr /*jchar*/ GetStringChars(IntPtr env, IntPtr /*jstring*/ str, byte* /*jboolean*/ isCopy);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void ReleaseStringChars(IntPtr env, IntPtr /*jstring*/ str, IntPtr /*jchar*/ chars);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jstring*/ NewStringUTF(IntPtr env, IntPtr /*char**/ utf);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate int /*jsize*/ GetStringUTFLength(IntPtr env, IntPtr /*jstring*/ str);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*char**/ GetStringUTFChars(IntPtr env, IntPtr /*jstring*/ str, out byte /*jboolean*/ isCopy);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate void ReleaseStringUTFChars(IntPtr env, IntPtr /*jstring*/ str, IntPtr /*char**/ chars);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate void GetStringRegion(IntPtr env, IntPtr /*jstring*/ str, int /*jsize*/ start, int /*jsize*/ len, ushort* /*jchar*/ buf);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate void GetStringUTFRegion(IntPtr env, IntPtr /*jstring*/ str, int /*jsize*/ start, int /*jsize*/ len, char* buf);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate ushort* /*jchar*/ GetStringCritical(IntPtr env, IntPtr /*jstring*/ str, byte* /*jboolean*/ isCopy);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public unsafe delegate void ReleaseStringCritical(IntPtr env, IntPtr /*jstring*/ str, ushort* /*jchar*/ cstring);
        }

        public static class Nio
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*jobject*/ NewDirectByteBuffer(IntPtr env, IntPtr /*void**/ address, long capacity);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate IntPtr /*void**/ GetDirectBufferAddress(IntPtr env, IntPtr /*jobject*/ buf);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [SuppressUnmanagedCodeSecurity]
            public delegate long GetDirectBufferCapacity(IntPtr env, IntPtr /*jobject*/ buf);
        }
    }
}
