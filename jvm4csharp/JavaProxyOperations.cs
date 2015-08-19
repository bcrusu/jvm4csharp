using System;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp
{
    public static class JavaProxyOperations
    {
        public sealed class Instance
        {
            private readonly IJavaObject _javaObject;

            public Instance(IJavaObject javaObject)
            {
                if (javaObject == null) throw new ArgumentNullException(nameof(javaObject));
                _javaObject = javaObject;
            }

            public TField GetField<TField>(string name, string signature)
            {
                return JvmContext.Current.JniEnv.Classes.GetField<TField>(_javaObject, name, signature);
            }

            public void SetField<TField>(string name, string signature, TField value)
            {
                JvmContext.Current.JniEnv.Classes.SetField(_javaObject, name, signature, value);
            }

            public TResult CallMethod<TResult>(string name, string signature, params object[] args)
            {
                return JvmContext.Current.JniEnv.Classes.CallMethod<TResult>(_javaObject, name, signature, args);
            }

            public void CallMethod(string name, string signature, params object[] args)
            {
                JvmContext.Current.JniEnv.Classes.CallMethod(_javaObject, name, signature, args);
            }

            public void CallConstructor(string signature, params object[] args)
            {
                JvmContext.Current.JniEnv.Classes.NewObjectForProxy(_javaObject, signature, args);
            }
        }

        public sealed class Static
        {
            public static readonly Static Singleton = new Static();

            public TField GetField<TField>(Type proxyType, string name, string signature)
            {
                return JvmContext.Current.JniEnv.Classes.GetStaticField<TField>(proxyType, name, signature);
            }

            public void SetField<TField>(Type proxyType, string name, string signature, TField value)
            {
                JvmContext.Current.JniEnv.Classes.SetStaticField(proxyType, name, signature, value);
            }

            public TResult CallMethod<TResult>(Type proxyType, string name, string signature, params object[] args)
            {
                return JvmContext.Current.JniEnv.Classes.CallStaticMethod<TResult>(proxyType, name, signature, args);
            }

            public void CallMethod(Type proxyType, string name, string signature, params object[] args)
            {
                JvmContext.Current.JniEnv.Classes.CallStaticMethod(proxyType, name, signature, args);
            }
        }
    }
}
