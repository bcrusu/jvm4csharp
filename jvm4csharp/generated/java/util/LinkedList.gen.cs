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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/LinkedList")]
	public partial class LinkedList<E> : AbstractSequentialList<E>, List<E>, Deque<E>, Cloneable, Serializable
		where E : IJavaObject
	{
		protected LinkedList(ProxyCtor p) : base(p) {}
		
		public LinkedList() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public LinkedList(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public E @remove()
		{
			return Instance.CallMethod<E>("remove", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject clone()
		{
			return Instance.CallMethod<IJavaObject>("clone", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E getFirst()
		{
			return Instance.CallMethod<E>("getFirst", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E pop()
		{
			return Instance.CallMethod<E>("pop", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void push(E arg0)
		{
			Instance.CallMethod("push", "(Ljava/lang/Object;)V", arg0);
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
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void addFirst(E arg0)
		{
			Instance.CallMethod("addFirst", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void addLast(E arg0)
		{
			Instance.CallMethod("addLast", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Iterator;")]
		public Iterator<E> descendingIterator()
		{
			return Instance.CallMethod<Iterator<E>>("descendingIterator", "()Ljava/util/Iterator;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E element()
		{
			return Instance.CallMethod<E>("element", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E getLast()
		{
			return Instance.CallMethod<E>("getLast", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool offer(E arg0)
		{
			return Instance.CallMethod<bool>("offer", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool offerFirst(E arg0)
		{
			return Instance.CallMethod<bool>("offerFirst", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool offerLast(E arg0)
		{
			return Instance.CallMethod<bool>("offerLast", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E peekFirst()
		{
			return Instance.CallMethod<E>("peekFirst", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E peekLast()
		{
			return Instance.CallMethod<E>("peekLast", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E pollFirst()
		{
			return Instance.CallMethod<E>("pollFirst", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E pollLast()
		{
			return Instance.CallMethod<E>("pollLast", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E removeFirst()
		{
			return Instance.CallMethod<E>("removeFirst", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool removeFirstOccurrence(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("removeFirstOccurrence", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E removeLast()
		{
			return Instance.CallMethod<E>("removeLast", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool removeLastOccurrence(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("removeLastOccurrence", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)V")]
		public void replaceAll(UnaryOperator<E> arg0)
		{
			Instance.CallMethod("replaceAll", "(Ljava/util/function/UnaryOperator;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)V")]
		public void sort(Comparator<IJavaObject> arg0)
		{
			Instance.CallMethod("sort", "(Ljava/util/Comparator;)V", arg0);
		}
	}
}
