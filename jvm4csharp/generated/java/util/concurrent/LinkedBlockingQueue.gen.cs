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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/LinkedBlockingQueue")]
	public class LinkedBlockingQueue<E> : AbstractQueue<E>, BlockingQueue<E>, Serializable
		where E : IJavaObject
	{
		protected LinkedBlockingQueue(ProxyCtor p) : base(p) {}
		
		public LinkedBlockingQueue(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public LinkedBlockingQueue() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public LinkedBlockingQueue(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void put(E arg0)
		{
			Instance.CallMethod("put", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E poll()
		{
			return Instance.CallMethod<E>("poll", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		public E poll(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<E>("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E peek()
		{
			return Instance.CallMethod<E>("peek", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		public bool offer(E arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<bool>("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool offer(E arg0)
		{
			return Instance.CallMethod<bool>("offer", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E take()
		{
			return Instance.CallMethod<E>("take", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/util/Collection;)I")]
		public int drainTo(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<int>("drainTo", "(Ljava/util/Collection;)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;I)I")]
		public int drainTo(Collection<IJavaObject> arg0, int arg1)
		{
			return Instance.CallMethod<int>("drainTo", "(Ljava/util/Collection;I)I", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int remainingCapacity()
		{
			return Instance.CallMethod<int>("remainingCapacity", "()I");
		}
	}
}
