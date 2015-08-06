namespace jvm4csharp.java.lang
{
    [JavaProxy("java/lang/Error")]
    public class Error : Throwable
    {
        internal Error(JavaVoid jv) : base(jv)
        {
        }

        public Error() : base(JavaVoid.Void)
        {
            CallConstructor("()V");
        }

        public Error(String message) : base(JavaVoid.Void)
        {
            CallConstructor("(Ljava/lang/String;)V", message);
        }

        public Error(String message, Throwable cause) : base(JavaVoid.Void)
        {
            CallConstructor("(Ljava/lang/String;Ljava/lang/Throwable;)V", message, cause);
        }

        public Error(Throwable cause) : base(JavaVoid.Void)
        {
            CallConstructor("(Ljava/lang/Throwable;)V", cause);
        }
    }
}
