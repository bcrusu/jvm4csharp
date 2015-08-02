using jvm4csharp.java.lang;

namespace jvm4csharp
{
    public interface IJavaObject
    {
        void wait();

        void wait(long timeout, int nanos);

        void wait(long timeout);

        int hashCode();

        Class getClass();

        bool equals(Object obj);

        String toString();

        void notify();

        void notifyAll();
    }
}
