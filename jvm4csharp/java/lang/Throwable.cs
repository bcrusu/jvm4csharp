using System;
using System.Runtime.Serialization;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp.java.lang
{
    [JavaProxy("java/lang/Throwable")]
    public class Throwable : System.Exception, IJavaProxy, IJavaObject
    {
        // ReSharper disable once UnusedParameter.Local
        protected internal Throwable(JavaVoid jv)
        {
        }

        public Throwable()
        {
        }

        protected Throwable(SerializationInfo info, StreamingContext context)
        {
            //TODO:
        }

        #region IJavaProxy
        IntPtr IJavaProxy.NativePtr
        {
            set { NativePtr = value; }
            get { return NativePtr; }
        }

        internal IntPtr NativePtr { get; set; }

        Class IJavaProxy.Class
        {
            set { Class = value; }
            get { return Class; }
        }

        internal Class Class { get; set; }
        #endregion

        #region IJavaObject
        public Class getClass()
        {
            return Class;
        }

        public virtual int hashCode()
        {
            return CallMethod<int>("hashCode", "()I");
        }

        public virtual bool equals(Object obj)
        {
            return CallMethod<bool>("equals", "(Ljava/lang/Object;)Z", obj);
        }

        public virtual String toString()
        {
            return CallMethod<String>("toString", "()Ljava/lang/String;");
        }

        public void notify()
        {
            CallMethod("notify", "()V");
        }

        public void notifyAll()
        {
            CallMethod("notifyAll", "()V");
        }

        public void wait()
        {
            CallMethod("wait", "()V");
        }

        public void wait(long timeout)
        {
            CallMethod("wait", "(J)V", timeout);
        }

        public void wait(long timeout, int nanos)
        {
            CallMethod("wait", "(JI)V", timeout, nanos);
        }
        #endregion

        public override bool Equals(object obj)
        {
            var tmp = obj as Throwable;
            if (tmp == null)
                return false;

            return CallMethod<bool>("equals", "(Ljava/lang/Object;)Z", tmp);
        }

        public override int GetHashCode()
        {
            return hashCode();
        }

        public override string ToString()
        {
            return toString();
        }

        #region Utility Methods
        protected TField GetField<TField>(string name, string signature)
        {
            return JvmContext.Current.JniEnvWrapper.Classes.GetField<TField>(this, name, signature);
        }

        protected static TField GetStaticField<TField>(Type proxyType, string name, string signature)
        {
            return JvmContext.Current.JniEnvWrapper.Classes.GetStaticField<TField>(proxyType, name, signature);
        }

        public void SetField<TField>(string name, string signature, TField value)
        {
            JvmContext.Current.JniEnvWrapper.Classes.SetField(this, name, signature, value);
        }

        protected static void SetStaticField<TField>(Type proxyType, string name, string signature, TField value)
        {
            JvmContext.Current.JniEnvWrapper.Classes.SetStaticField(proxyType, name, signature, value);
        }

        protected TResult CallMethod<TResult>(string name, string signature, params object[] args)
        {
            return JvmContext.Current.JniEnvWrapper.Classes.CallMethod<TResult>(this, name, signature, args);
        }

        protected void CallMethod(string name, string signature, params object[] args)
        {
            JvmContext.Current.JniEnvWrapper.Classes.CallMethod<JavaVoid>(this, name, signature, args);
        }

        protected static TResult CallStaticMethod<TResult>(Type proxyType, string name, string signature, params object[] args)
        {
            return JvmContext.Current.JniEnvWrapper.Classes.CallStaticMethod<TResult>(proxyType, name, signature, args);
        }

        protected static void CallStaticMethod(Type proxyType, string name, string signature, params object[] args)
        {
            JvmContext.Current.JniEnvWrapper.Classes.CallStaticMethod<JavaVoid>(proxyType, name, signature, args);
        }

        protected void CallConstructor(string signature, params object[] args)
        {
            JvmContext.Current.JniEnvWrapper.Classes.NewObjectForProxy(this, signature, args);
        }
        #endregion
    }
}
