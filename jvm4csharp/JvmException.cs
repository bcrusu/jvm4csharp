using System;
using System.Runtime.Serialization;

namespace jvm4csharp
{
    public class JvmException : Exception
    {
        public JvmException()
        {
        }

        public JvmException(string message) : base(message)
        {
        }

        public JvmException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JvmException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
