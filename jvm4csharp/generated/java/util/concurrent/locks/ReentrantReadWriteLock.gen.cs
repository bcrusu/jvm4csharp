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
	[JavaProxy("java/util/concurrent/locks/ReentrantReadWriteLock")]
	public partial class ReentrantReadWriteLock : Object, ReadWriteLock, Serializable
	{
		protected ReentrantReadWriteLock(ProxyCtor p) : base(p) {}
		
		public ReentrantReadWriteLock() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ReentrantReadWriteLock(bool arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Z)V", arg0);
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
		
		[JavaSignature("()Ljava/util/concurrent/locks/ReentrantReadWriteLock/ReadLock;")]
		public ReentrantReadWriteLock.ReadLock readLock()
		{
			return Instance.CallMethod<ReentrantReadWriteLock.ReadLock>("readLock", "()Ljava/util/concurrent/locks/ReentrantReadWriteLock/ReadLock;");
		}
		
		[JavaSignature("()Z")]
		public bool isWriteLockedByCurrentThread()
		{
			return Instance.CallMethod<bool>("isWriteLockedByCurrentThread", "()Z");
		}
		
		[JavaSignature("()I")]
		public int getReadHoldCount()
		{
			return Instance.CallMethod<int>("getReadHoldCount", "()I");
		}
		
		[JavaSignature("()I")]
		public int getReadLockCount()
		{
			return Instance.CallMethod<int>("getReadLockCount", "()I");
		}
		
		[JavaSignature("()I")]
		public int getWriteHoldCount()
		{
			return Instance.CallMethod<int>("getWriteHoldCount", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isWriteLocked()
		{
			return Instance.CallMethod<bool>("isWriteLocked", "()Z");
		}
		
		[JavaSignature("()Ljava/util/concurrent/locks/ReentrantReadWriteLock/WriteLock;")]
		public ReentrantReadWriteLock.WriteLock writeLock()
		{
			return Instance.CallMethod<ReentrantReadWriteLock.WriteLock>("writeLock", "()Ljava/util/concurrent/locks/ReentrantReadWriteLock/WriteLock;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/locks/Lock;")]
		Lock ReadWriteLock.readLock()
		{
			return Instance.CallMethod<Lock>("readLock", "()Ljava/util/concurrent/locks/Lock;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/locks/Lock;")]
		Lock ReadWriteLock.writeLock()
		{
			return Instance.CallMethod<Lock>("writeLock", "()Ljava/util/concurrent/locks/Lock;");
		}
	
		[JavaProxy("java/util/concurrent/locks/ReentrantReadWriteLock/ReadLock")]
		public partial class ReadLock : Object, Lock, Serializable
		{
			protected ReadLock(ProxyCtor p) : base(p) {}
		
			[JavaSignature("()V")]
			public void @lock()
			{
				Instance.CallMethod("lock", "()V");
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
		
		[JavaProxy("java/util/concurrent/locks/ReentrantReadWriteLock/WriteLock")]
		public partial class WriteLock : Object, Lock, Serializable
		{
			protected WriteLock(ProxyCtor p) : base(p) {}
		
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
			
			[JavaSignature("()Z")]
			public bool isHeldByCurrentThread()
			{
				return Instance.CallMethod<bool>("isHeldByCurrentThread", "()Z");
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
}
