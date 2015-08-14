using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp
{
    public interface IJavaObject
    {
        [JavaSignature("()V")]
        void wait();

        [JavaSignature("(JI)V")]
        void wait(long timeout, int nanos);

        [JavaSignature("(J)V")]
        void wait(long timeout);

        [JavaSignature("()I")]
        int hashCode();

        [JavaSignature("()Ljava/lang/Class;")]
        Class getClass();

        [JavaSignature("(Ljava/lang/Object;)Z")]
        bool equals(IJavaObject obj);

        [JavaSignature("()Ljava/lang/String;")]
        String toString();

        [JavaSignature("()V")]
        void notify();

        [JavaSignature("()V")]
        void notifyAll();
    }
}
