using System;

namespace jvm4csharp
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
    public sealed class JavaSignatureAttribute : Attribute
    {
        public string Signature { get; private set; }

        public JavaSignatureAttribute(string signature)
        {
            Signature = signature;
        }
    }
}
