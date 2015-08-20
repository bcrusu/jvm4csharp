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
	[JavaProxy("java/util/concurrent/locks/AbstractQueuedLongSynchronizer")]
	public abstract partial class AbstractQueuedLongSynchronizer : AbstractOwnableSynchronizer, Serializable
	{
		protected AbstractQueuedLongSynchronizer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(J)V")]
		public void acquireInterruptibly(long arg0)
		{
			Instance.CallMethod("acquireInterruptibly", "(J)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int getQueueLength()
		{
			return Instance.CallMethod<int>("getQueueLength", "()I");
		}
		
		[JavaSignature("()Ljava/util/Collection;")]
		public Collection<Thread> getQueuedThreads()
		{
			return Instance.CallMethod<Collection<Thread>>("getQueuedThreads", "()Ljava/util/Collection;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)I")]
		public int getWaitQueueLength(AbstractQueuedLongSynchronizer.ConditionObject arg0)
		{
			return Instance.CallMethod<int>("getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)Ljava/util/Collection;")]
		public Collection<Thread> getWaitingThreads(AbstractQueuedLongSynchronizer.ConditionObject arg0)
		{
			return Instance.CallMethod<Collection<Thread>>("getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)Ljava/util/Collection;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool hasQueuedThreads()
		{
			return Instance.CallMethod<bool>("hasQueuedThreads", "()Z");
		}
		
		[JavaSignature("(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)Z")]
		public bool hasWaiters(AbstractQueuedLongSynchronizer.ConditionObject arg0)
		{
			return Instance.CallMethod<bool>("hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread;)Z")]
		public bool isQueued(Thread arg0)
		{
			return Instance.CallMethod<bool>("isQueued", "(Ljava/lang/Thread;)Z", arg0);
		}
		
		[JavaSignature("(J)Z")]
		public bool release(long arg0)
		{
			return Instance.CallMethod<bool>("release", "(J)Z", arg0);
		}
		
		[JavaSignature("(JJ)Z")]
		public bool tryAcquireNanos(long arg0, long arg1)
		{
			return Instance.CallMethod<bool>("tryAcquireNanos", "(JJ)Z", arg0, arg1);
		}
		
		[JavaSignature("(J)V")]
		public void acquire(long arg0)
		{
			Instance.CallMethod("acquire", "(J)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void acquireShared(long arg0)
		{
			Instance.CallMethod("acquireShared", "(J)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void acquireSharedInterruptibly(long arg0)
		{
			Instance.CallMethod("acquireSharedInterruptibly", "(J)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Collection;")]
		public Collection<Thread> getExclusiveQueuedThreads()
		{
			return Instance.CallMethod<Collection<Thread>>("getExclusiveQueuedThreads", "()Ljava/util/Collection;");
		}
		
		[JavaSignature("()Ljava/lang/Thread;")]
		public Thread getFirstQueuedThread()
		{
			return Instance.CallMethod<Thread>("getFirstQueuedThread", "()Ljava/lang/Thread;");
		}
		
		[JavaSignature("()Ljava/util/Collection;")]
		public Collection<Thread> getSharedQueuedThreads()
		{
			return Instance.CallMethod<Collection<Thread>>("getSharedQueuedThreads", "()Ljava/util/Collection;");
		}
		
		[JavaSignature("()Z")]
		public bool hasContended()
		{
			return Instance.CallMethod<bool>("hasContended", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasQueuedPredecessors()
		{
			return Instance.CallMethod<bool>("hasQueuedPredecessors", "()Z");
		}
		
		[JavaSignature("(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)Z")]
		public bool owns(AbstractQueuedLongSynchronizer.ConditionObject arg0)
		{
			return Instance.CallMethod<bool>("owns", "(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject;)Z", arg0);
		}
		
		[JavaSignature("(J)Z")]
		public bool releaseShared(long arg0)
		{
			return Instance.CallMethod<bool>("releaseShared", "(J)Z", arg0);
		}
		
		[JavaSignature("(JJ)Z")]
		public bool tryAcquireSharedNanos(long arg0, long arg1)
		{
			return Instance.CallMethod<bool>("tryAcquireSharedNanos", "(JJ)Z", arg0, arg1);
		}
	
		[JavaProxy("java/util/concurrent/locks/AbstractQueuedLongSynchronizer/ConditionObject")]
		public partial class ConditionObject : Object, Condition, Serializable
		{
			protected ConditionObject(ProxyCtor p) : base(p) {}
			
			public ConditionObject(AbstractQueuedLongSynchronizer arg0) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/util/concurrent/locks/AbstractQueuedLongSynchronizer;)V", arg0);
			}
		
			[JavaSignature("(J)J")]
			public long awaitNanos(long arg0)
			{
				return Instance.CallMethod<long>("awaitNanos", "(J)J", arg0);
			}
			
			[JavaSignature("()V")]
			public void signal()
			{
				Instance.CallMethod("signal", "()V");
			}
			
			[JavaSignature("()V")]
			public void awaitUninterruptibly()
			{
				Instance.CallMethod("awaitUninterruptibly", "()V");
			}
			
			[JavaSignature("(Ljava/util/Date;)Z")]
			public bool awaitUntil(Date arg0)
			{
				return Instance.CallMethod<bool>("awaitUntil", "(Ljava/util/Date;)Z", arg0);
			}
			
			[JavaSignature("()V")]
			public void signalAll()
			{
				Instance.CallMethod("signalAll", "()V");
			}
			
			[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
			public bool @await(long arg0, TimeUnit arg1)
			{
				return Instance.CallMethod<bool>("await", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
			}
			
			[JavaSignature("()V")]
			public void @await()
			{
				Instance.CallMethod("await", "()V");
			}
		}
	}
}
