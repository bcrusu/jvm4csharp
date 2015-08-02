namespace jvm4csharp.java.lang
{
    [JavaProxy("java/lang/Exception")]
    public class Exception : Throwable
    {
        internal Exception(JavaVoid jv) : base(jv)
        {
        }

        public Exception()
        {
            CallConstructor("()V");
        }

        public Exception(String message)
        {
            CallConstructor("(Ljava/lang/String;)V", message);
        }

        public Exception(String message, Throwable cause)
        {
            CallConstructor("(Ljava/lang/String;Ljava/lang/Throwable;)V", message, cause);
        }

        public Exception(Throwable cause)
        {
            CallConstructor("(Ljava/lang/Throwable;)V", cause);
        }
    }
}
