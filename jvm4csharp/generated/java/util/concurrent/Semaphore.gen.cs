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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/Semaphore")]
	public partial class Semaphore : Object, Serializable
	{
		protected Semaphore(ProxyCtor p) : base(p) {}
		
		public Semaphore(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public Semaphore(int arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IZ)V", arg0, arg1);
		}
	
		[JavaSignature("()I")]
		public int getQueueLength()
		{
			return Instance.CallMethod<int>("getQueueLength", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool hasQueuedThreads()
		{
			return Instance.CallMethod<bool>("hasQueuedThreads", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isFair()
		{
			return Instance.CallMethod<bool>("isFair", "()Z");
		}
		
		[JavaSignature("()V")]
		public void release()
		{
			Instance.CallMethod("release", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void release(int arg0)
		{
			Instance.CallMethod("release", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void acquireUninterruptibly()
		{
			Instance.CallMethod("acquireUninterruptibly", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void acquireUninterruptibly(int arg0)
		{
			Instance.CallMethod("acquireUninterruptibly", "(I)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int availablePermits()
		{
			return Instance.CallMethod<int>("availablePermits", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void acquire(int arg0)
		{
			Instance.CallMethod("acquire", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void acquire()
		{
			Instance.CallMethod("acquire", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool tryAcquire()
		{
			return Instance.CallMethod<bool>("tryAcquire", "()Z");
		}
		
		[JavaSignature("(IJLjava/util/concurrent/TimeUnit;)Z")]
		public bool tryAcquire(int arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<bool>("tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(I)Z")]
		public bool tryAcquire(int arg0)
		{
			return Instance.CallMethod<bool>("tryAcquire", "(I)Z", arg0);
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		public bool tryAcquire(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<bool>("tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int drainPermits()
		{
			return Instance.CallMethod<int>("drainPermits", "()I");
		}
	}
}
