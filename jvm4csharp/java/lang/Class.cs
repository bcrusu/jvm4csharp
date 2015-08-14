namespace jvm4csharp.java.lang
{
    public partial class Class<T> : Object
        where T : IJavaObject
    {
        internal const string JavaClassName = "java.lang.Class";
        internal const string JavaInternalClassName = "java/lang/Class";

        internal string ClassName { get; private set; }

        internal string InternalClassName { get; private set; }

        internal Class(JavaVoid jv, string className, string internalClassName) : base(jv)
        {
            ClassName = className;
            InternalClassName = internalClassName;
        }
    }

    public partial class Class : Class<IJavaObject>
    {
        internal Class(JavaVoid jv, string className, string internalClassName) : base(jv, className, internalClassName)
        {
        }
    }
}
