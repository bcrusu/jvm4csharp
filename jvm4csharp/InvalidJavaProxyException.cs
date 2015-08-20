using System;
using System.Runtime.Serialization;

namespace jvm4csharp
{
    public class InvalidJavaProxyException : JvmException
    {
        public InvalidJavaProxyException(Type proxyType) : base($"Invalid proxy definition '{proxyType}'.")
        {
        }

        public InvalidJavaProxyException(Type proxyType, string errorMessage) : base($"Invalid proxy definition '{proxyType}'. {errorMessage}")
        {
        }

        protected InvalidJavaProxyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
