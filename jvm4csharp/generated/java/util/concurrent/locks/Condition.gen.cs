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
namespace jvm4csharp.java.util.concurrent.locks
{
	[JavaProxy("java/util/concurrent/locks/Condition")]
	public partial interface Condition : IJavaObject
	{
		[JavaSignature("(J)J")]
		long awaitNanos(long arg0);
		
		[JavaSignature("()V")]
		void signal();
		
		[JavaSignature("()V")]
		void awaitUninterruptibly();
		
		[JavaSignature("(Ljava/util/Date;)Z")]
		bool awaitUntil(Date arg0);
		
		[JavaSignature("()V")]
		void signalAll();
		
		[JavaSignature("()V")]
		void @await();
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		bool @await(long arg0, TimeUnit arg1);
	}
}
