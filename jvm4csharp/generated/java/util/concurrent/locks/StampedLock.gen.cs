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
	[JavaProxy("java/util/concurrent/locks/StampedLock")]
	public partial class StampedLock : Object, Serializable
	{
		protected StampedLock(ProxyCtor p) : base(p) {}
		
		public StampedLock() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(J)V")]
		public void unlock(long arg0)
		{
			Instance.CallMethod("unlock", "(J)V", arg0);
		}
		
		[JavaSignature("(J)Z")]
		public bool validate(long arg0)
		{
			return Instance.CallMethod<bool>("validate", "(J)Z", arg0);
		}
		
		[JavaSignature("()J")]
		public long readLock()
		{
			return Instance.CallMethod<long>("readLock", "()J");
		}
		
		[JavaSignature("()J")]
		public long readLockInterruptibly()
		{
			return Instance.CallMethod<long>("readLockInterruptibly", "()J");
		}
		
		[JavaSignature("()J")]
		public long tryReadLock()
		{
			return Instance.CallMethod<long>("tryReadLock", "()J");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)J")]
		public long tryReadLock(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<long>("tryReadLock", "(JLjava/util/concurrent/TimeUnit;)J", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/locks/ReadWriteLock;")]
		public ReadWriteLock asReadWriteLock()
		{
			return Instance.CallMethod<ReadWriteLock>("asReadWriteLock", "()Ljava/util/concurrent/locks/ReadWriteLock;");
		}
		
		[JavaSignature("()Z")]
		public bool isReadLocked()
		{
			return Instance.CallMethod<bool>("isReadLocked", "()Z");
		}
		
		[JavaSignature("(J)J")]
		public long tryConvertToOptimisticRead(long arg0)
		{
			return Instance.CallMethod<long>("tryConvertToOptimisticRead", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long tryConvertToReadLock(long arg0)
		{
			return Instance.CallMethod<long>("tryConvertToReadLock", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long tryConvertToWriteLock(long arg0)
		{
			return Instance.CallMethod<long>("tryConvertToWriteLock", "(J)J", arg0);
		}
		
		[JavaSignature("()J")]
		public long tryOptimisticRead()
		{
			return Instance.CallMethod<long>("tryOptimisticRead", "()J");
		}
		
		[JavaSignature("()Z")]
		public bool tryUnlockRead()
		{
			return Instance.CallMethod<bool>("tryUnlockRead", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool tryUnlockWrite()
		{
			return Instance.CallMethod<bool>("tryUnlockWrite", "()Z");
		}
		
		[JavaSignature("(J)V")]
		public void unlockRead(long arg0)
		{
			Instance.CallMethod("unlockRead", "(J)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void unlockWrite(long arg0)
		{
			Instance.CallMethod("unlockWrite", "(J)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/locks/Lock;")]
		public Lock asReadLock()
		{
			return Instance.CallMethod<Lock>("asReadLock", "()Ljava/util/concurrent/locks/Lock;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/locks/Lock;")]
		public Lock asWriteLock()
		{
			return Instance.CallMethod<Lock>("asWriteLock", "()Ljava/util/concurrent/locks/Lock;");
		}
		
		[JavaSignature("()J")]
		public long writeLock()
		{
			return Instance.CallMethod<long>("writeLock", "()J");
		}
		
		[JavaSignature("()I")]
		public int getReadLockCount()
		{
			return Instance.CallMethod<int>("getReadLockCount", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isWriteLocked()
		{
			return Instance.CallMethod<bool>("isWriteLocked", "()Z");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)J")]
		public long tryWriteLock(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<long>("tryWriteLock", "(JLjava/util/concurrent/TimeUnit;)J", arg0, arg1);
		}
		
		[JavaSignature("()J")]
		public long tryWriteLock()
		{
			return Instance.CallMethod<long>("tryWriteLock", "()J");
		}
		
		[JavaSignature("()J")]
		public long writeLockInterruptibly()
		{
			return Instance.CallMethod<long>("writeLockInterruptibly", "()J");
		}
	}
}
