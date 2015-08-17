//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/DirectoryIteratorException")]
	public class DirectoryIteratorException : ConcurrentModificationException
	{
		protected DirectoryIteratorException(ProxyCtor p) : base(p) {}
		
		public DirectoryIteratorException(IOException arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/IOException;)V", arg0);
		}
	
		[JavaSignature("()Ljava/io/IOException;")]
		public new IOException getCause()
		{
			return Instance.CallMethod<IOException>("getCause", "()Ljava/io/IOException;");
		}
	}
}
