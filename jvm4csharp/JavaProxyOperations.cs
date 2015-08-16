using System;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp
{
    public static class JavaProxyOperations
    {
        public sealed class Instance
        {
            private readonly IJavaProxy _javaProxy;

            public Instance(IJavaObject javaObject)
            {
                if (javaObject == null) throw new ArgumentNullException(nameof(javaObject));
                if (!(javaObject is IJavaProxy)) throw new ArgumentException("Invalid Java proxy instance.");
                _javaProxy = (IJavaProxy)javaObject;
            }

            public TField GetField<TField>(string name, string signature)
            {
                return JvmContext.Current.JniEnv.Classes.GetField<TField>(_javaProxy, name, signature);
            }

            public void SetField<TField>(string name, string signature, TField value)
            {
                JvmContext.Current.JniEnv.Classes.SetField(_javaProxy, name, signature, value);
            }

            public TResult CallMethod<TResult>(string name, string signature, params object[] args)
            {
                return JvmContext.Current.JniEnv.Classes.CallMethod<TResult>(_javaProxy, name, signature, args);
            }

            public void CallMethod(string name, string signature, params object[] args)
            {
                JvmContext.Current.JniEnv.Classes.CallMethod<JavaVoid>(_javaProxy, name, signature, args);
            }

            public void CallConstructor(string signature, params object[] args)
            {
                JvmContext.Current.JniEnv.Classes.NewObjectForProxy(_javaProxy, signature, args);
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
                JvmContext.Current.JniEnv.Classes.CallStaticMethod<JavaVoid>(proxyType, name, signature, args);
            }
        }
    }
}
