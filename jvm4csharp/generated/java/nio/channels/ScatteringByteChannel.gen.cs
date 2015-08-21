//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/ScatteringByteChannel")]
	public partial interface ScatteringByteChannel : ReadableByteChannel
	{
		[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
		long read(ObjectArray<ByteBuffer> arg0, int arg1, int arg2);
		
		[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
		long read(ObjectArray<ByteBuffer> arg0);
	}
}
