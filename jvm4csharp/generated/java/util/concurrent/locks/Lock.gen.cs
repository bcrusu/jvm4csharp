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
	[JavaProxy("java/util/concurrent/locks/Lock")]
	public interface Lock : IJavaObject
	{
		[JavaSignature("()V")]
		void @lock();
		
		[JavaSignature("()V")]
		void lockInterruptibly();
		
		[JavaSignature("()Ljava/util/concurrent/locks/Condition;")]
		Condition newCondition();
		
		[JavaSignature("()Z")]
		bool tryLock();
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		bool tryLock(long arg0, TimeUnit arg1);
		
		[JavaSignature("()V")]
		void unlock();
	}
}
