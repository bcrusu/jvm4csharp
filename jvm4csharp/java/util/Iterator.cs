using jvm4csharp._java.util;

namespace jvm4csharp.java.util
{
    [JavaProxy("java/util/Iterator", ConcreteProxyType = typeof(_Iterator<>))]
    public interface Iterator<E> : IJavaObject
        where E : IJavaObject
    {
        bool hasNext();

        E next();

        void remove();

        //TODO:
        //public void forEachRemaining(Consumer<? super E> paramConsumer);
    }
}
