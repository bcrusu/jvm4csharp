//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/AsynchronousByteChannel")]
	public partial interface AsynchronousByteChannel : AsynchronousChannel
	{
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;")]
		Future<Integer> write(ByteBuffer arg0);
		
		[JavaSignature("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		void write<A>(ByteBuffer arg0, A arg1, CompletionHandler<Integer, IJavaObject> arg2)
			where A : IJavaObject;
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;")]
		Future<Integer> read(ByteBuffer arg0);
		
		[JavaSignature("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		void read<A>(ByteBuffer arg0, A arg1, CompletionHandler<Integer, IJavaObject> arg2)
			where A : IJavaObject;
	}
}
