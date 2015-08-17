using jvm4csharp.JniApiWrappers;

namespace jvm4csharp.java.lang
{
    [JavaProxy("java/lang/Object")]
    public class Object : IJavaProxy, IJavaObject
    {
        protected JavaProxyOperations.Instance Instance { get; }

        protected static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;

        // ReSharper disable once UnusedParameter.Local
        protected internal Object(ProxyCtor p)
        {
            Instance = new JavaProxyOperations.Instance(this);
        }

        public Object() : this(ProxyCtor.I)
        {
            Instance.CallConstructor("()V");
        }

        #region IJavaProxy
        JavaProxyState IJavaProxy.ProxyState
        {
            set { ProxyState = value; }
            get { return ProxyState; }
        }

        internal JavaProxyState ProxyState { get; set; }
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

        public virtual String toString()
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
            var tmp = obj as Object;
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
    }
}
