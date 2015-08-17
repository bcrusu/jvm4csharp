namespace jvm4csharp.java.lang
{
    public partial class Class<T> : Object
        where T : IJavaObject
    {
        internal const string JavaClassName = "java.lang.Class";
        internal const string JavaInternalClassName = "java/lang/Class";

        internal string ClassName { get; private set; }

        internal string InternalClassName { get; private set; }

        internal Class(ProxyCtor p, string className, string internalClassName) : base(p)
        {
            ClassName = className;
            InternalClassName = internalClassName;
        }
    }

    public partial class Class : Class<IJavaObject>
    {
        internal Class(ProxyCtor p, string className, string internalClassName) : base(p, className, internalClassName)
        {
        }
    }
}
