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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/PriorityQueue")]
	public class PriorityQueue<E> : AbstractQueue<E>, Serializable
		where E : IJavaObject
	{
		protected PriorityQueue(ProxyCtor p) : base(p) {}
		
		public PriorityQueue(int arg0, Comparator<IJavaObject> arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/util/Comparator;)V", arg0, arg1);
		}
		
		public PriorityQueue(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public PriorityQueue(PriorityQueue<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/PriorityQueue;)V", arg0);
		}
		
		public PriorityQueue(SortedSet<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/SortedSet;)V", arg0);
		}
		
		public PriorityQueue() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public PriorityQueue(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public PriorityQueue(Comparator<IJavaObject> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Comparator;)V", arg0);
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
		
		[JavaSignature("()Ljava/util/Comparator;")]
		public Comparator<IJavaObject> comparator()
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("comparator", "()Ljava/util/Comparator;");
		}
	}
}
