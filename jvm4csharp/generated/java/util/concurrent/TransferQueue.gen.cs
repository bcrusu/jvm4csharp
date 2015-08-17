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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/TransferQueue")]
	public interface TransferQueue<E> : BlockingQueue<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)V")]
		void transfer(E arg0);
		
		[JavaSignature("()I")]
		int getWaitingConsumerCount();
		
		[JavaSignature("()Z")]
		bool hasWaitingConsumer();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool tryTransfer(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		bool tryTransfer(E arg0, long arg1, TimeUnit arg2);
	}
}
