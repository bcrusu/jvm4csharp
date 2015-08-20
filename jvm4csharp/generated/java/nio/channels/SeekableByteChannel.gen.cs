//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/SeekableByteChannel")]
	public partial interface SeekableByteChannel : ByteChannel
	{
		[JavaSignature("()J")]
		long size();
		
		[JavaSignature("(J)Ljava/nio/channels/SeekableByteChannel;")]
		SeekableByteChannel position(long arg0);
		
		[JavaSignature("()J")]
		long position();
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		new int write(ByteBuffer arg0);
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		new int read(ByteBuffer arg0);
		
		[JavaSignature("(J)Ljava/nio/channels/SeekableByteChannel;")]
		SeekableByteChannel truncate(long arg0);
	}
}
