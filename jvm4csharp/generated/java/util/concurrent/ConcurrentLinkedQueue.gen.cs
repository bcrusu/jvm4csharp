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
	[JavaProxy("java/util/concurrent/ConcurrentLinkedQueue")]
	public class ConcurrentLinkedQueue<E> : AbstractQueue<E>, Queue<E>, Serializable
		where E : IJavaObject
	{
		protected ConcurrentLinkedQueue(ProxyCtor p) : base(p) {}
		
		public ConcurrentLinkedQueue() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ConcurrentLinkedQueue(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public E poll()
		{
			return Instance.CallMethod<E>("poll", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E peek()
		{
			return Instance.CallMethod<E>("peek", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool offer(E arg0)
		{
			return Instance.CallMethod<bool>("offer", "(Ljava/lang/Object;)Z", arg0);
		}
	}
}
