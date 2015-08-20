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
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/WatchService")]
	public partial interface WatchService : Closeable
	{
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/nio/file/WatchKey;")]
		WatchKey poll(long arg0, TimeUnit arg1);
		
		[JavaSignature("()Ljava/nio/file/WatchKey;")]
		WatchKey poll();
		
		[JavaSignature("()V")]
		new void close();
		
		[JavaSignature("()Ljava/nio/file/WatchKey;")]
		WatchKey take();
	}
}
