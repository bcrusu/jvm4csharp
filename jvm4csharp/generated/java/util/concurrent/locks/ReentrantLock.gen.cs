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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent.locks
{
	[JavaProxy("java/util/concurrent/locks/ReentrantLock")]
	public partial class ReentrantLock : Object, Lock, Serializable
	{
		protected ReentrantLock(ProxyCtor p) : base(p) {}
		
		public ReentrantLock() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ReentrantLock(bool arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Z)V", arg0);
		}
	
		[JavaSignature("()V")]
		public void @lock()
		{
			Instance.CallMethod("lock", "()V");
		}
		
		[JavaSignature("()I")]
		public int getHoldCount()
		{
			return Instance.CallMethod<int>("getHoldCount", "()I");
		}
		
		[JavaSignature("()I")]
		public int getQueueLength()
		{
			return Instance.CallMethod<int>("getQueueLength", "()I");
		}
		
		[JavaSignature("(Ljava/util/concurrent/locks/Condition;)I")]
		public int getWaitQueueLength(Condition arg0)
		{
			return Instance.CallMethod<int>("getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread;)Z")]
		public bool hasQueuedThread(Thread arg0)
		{
			return Instance.CallMethod<bool>("hasQueuedThread", "(Ljava/lang/Thread;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool hasQueuedThreads()
		{
			return Instance.CallMethod<bool>("hasQueuedThreads", "()Z");
		}
		
		[JavaSignature("(Ljava/util/concurrent/locks/Condition;)Z")]
		public bool hasWaiters(Condition arg0)
		{
			return Instance.CallMethod<bool>("hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isFair()
		{
			return Instance.CallMethod<bool>("isFair", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isHeldByCurrentThread()
		{
			return Instance.CallMethod<bool>("isHeldByCurrentThread", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isLocked()
		{
			return Instance.CallMethod<bool>("isLocked", "()Z");
		}
		
		[JavaSignature("()V")]
		public void lockInterruptibly()
		{
			Instance.CallMethod("lockInterruptibly", "()V");
		}
		
		[JavaSignature("()Ljava/util/concurrent/locks/Condition;")]
		public Condition newCondition()
		{
			return Instance.CallMethod<Condition>("newCondition", "()Ljava/util/concurrent/locks/Condition;");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		public bool tryLock(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<bool>("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool tryLock()
		{
			return Instance.CallMethod<bool>("tryLock", "()Z");
		}
		
		[JavaSignature("()V")]
		public void unlock()
		{
			Instance.CallMethod("unlock", "()V");
		}
	}
}
