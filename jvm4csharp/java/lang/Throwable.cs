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

        public Throwable() //TODO: constructors
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

        JvmContext IJavaProxy.Context
        {
            set { Context = value; }
            get { return Context; }
        }

        internal JvmContext Context { get; set; }

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
            return JavaObjectMembers.getClass(this);
        }

        public int hashCode()
        {
            return JavaObjectMembers.hashCode(this);
        }

        public bool equals(IJavaObject obj)
        {
            return JavaObjectMembers.equals(this, obj);
        }

        public String toString()
        {
            return JavaObjectMembers.toString(this);
        }

        public void notify()
        {
            JavaObjectMembers.notify(this);
        }

        public void notifyAll()
        {
            JavaObjectMembers.notifyAll(this);
        }

        public void wait()
        {
            JavaObjectMembers.wait(this);
        }

        public void wait(long timeout)
        {
            JavaObjectMembers.wait(this, timeout);
        }

        public void wait(long timeout, int nanos)
        {
            JavaObjectMembers.wait(this, timeout, nanos);
        }
        #endregion

        public override bool Equals(object obj)
        {
            var tmp = obj as Throwable;
            if (tmp == null)
                return false;

            return equals(tmp);
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
            return JvmContext.Current.JniEnv.Classes.GetField<TField>(this, name, signature);
        }

        protected static TField GetStaticField<TField>(Type proxyType, string name, string signature)
        {
            return JvmContext.Current.JniEnv.Classes.GetStaticField<TField>(proxyType, name, signature);
        }

        public void SetField<TField>(string name, string signature, TField value)
        {
            JvmContext.Current.JniEnv.Classes.SetField(this, name, signature, value);
        }

        protected static void SetStaticField<TField>(Type proxyType, string name, string signature, TField value)
        {
            JvmContext.Current.JniEnv.Classes.SetStaticField(proxyType, name, signature, value);
        }

        protected TResult CallMethod<TResult>(string name, string signature, params object[] args)
        {
            return JvmContext.Current.JniEnv.Classes.CallMethod<TResult>(this, name, signature, args);
        }

        protected void CallMethod(string name, string signature, params object[] args)
        {
            JvmContext.Current.JniEnv.Classes.CallMethod<JavaVoid>(this, name, signature, args);
        }

        protected static TResult CallStaticMethod<TResult>(Type proxyType, string name, string signature, params object[] args)
        {
            return JvmContext.Current.JniEnv.Classes.CallStaticMethod<TResult>(proxyType, name, signature, args);
        }

        protected static void CallStaticMethod(Type proxyType, string name, string signature, params object[] args)
        {
            JvmContext.Current.JniEnv.Classes.CallStaticMethod<JavaVoid>(proxyType, name, signature, args);
        }

        protected void CallConstructor(string signature, params object[] args)
        {
            JvmContext.Current.JniEnv.Classes.NewObjectForProxy(this, signature, args);
        }
        #endregion
    }
}
