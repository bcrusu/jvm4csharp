using System;

namespace jvm4csharp
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
    public sealed class JavaProxyAttribute : Attribute
    {
        /// <summary>
        /// Fully-qualified class name. For example, the fully-qualified class name for the java.lang.String class is: "java/lang/String"
        /// </summary>
        public string ClassName { get; private set; }

        public Type ConcreteProxyType { get; set; }

        public JavaProxyAttribute(string className)
        {
            if (className == null) throw new ArgumentNullException(nameof(className));
            ClassName = className;
        }
    }
}
