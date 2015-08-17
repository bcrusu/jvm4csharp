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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/Channel")]
	public interface Channel : Closeable
	{
		[JavaSignature("()V")]
		new void close();
		
		[JavaSignature("()Z")]
		bool isOpen();
	}
}
