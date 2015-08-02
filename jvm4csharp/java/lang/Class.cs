namespace jvm4csharp.java.lang
{
    [JavaProxy(JavaLangInternalClassName)]
    public sealed class Class : Object
    {
        internal const string JavaLangClassName = "java.lang.Class";
        internal const string JavaLangInternalClassName = "java/lang/Class";

        internal string ClassName { get; private set; }

        internal string InternalClassName { get; private set; }

        private String _name;

        internal Class(JavaVoid jv, string className, string internalClassName) : base(jv)
        {
            ClassName = className;
            InternalClassName = internalClassName;
        }

        public String getName()
        {
            if (_name == null)
                _name = CallMethod<String>("getName", "()Ljava/lang/String;");
            return _name;
        }
    }
}
