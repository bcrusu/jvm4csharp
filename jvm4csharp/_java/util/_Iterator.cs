using jvm4csharp.java.lang;
using jvm4csharp.java.util;

namespace jvm4csharp._java.util
{
    public class _Iterator<E> : Object, Iterator<E>
        where E : IJavaObject
    {
        internal _Iterator() : base(JavaVoid.Void)
        {
        }

        public bool hasNext()
        {
            return CallMethod<bool>("hasNext", "()Z");
        }

        public E next()
        {
            return CallMethod<E>("next", "()Ljava/lang/Object;");
        }

        public void remove()
        {
            CallMethod("remove", "()V");
        }
    }
}
