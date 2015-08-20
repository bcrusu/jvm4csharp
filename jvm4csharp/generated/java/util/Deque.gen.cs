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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Deque")]
	public partial interface Deque<E> : Queue<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @add(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E @remove();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @remove(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool contains(IJavaObject arg0);
		
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<E> iterator();
		
		[JavaSignature("()I")]
		new int size();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E getFirst();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E pop();
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void push(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E poll();
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E peek();
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void addFirst(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void addLast(E arg0);
		
		[JavaSignature("()Ljava/util/Iterator;")]
		Iterator<E> descendingIterator();
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E element();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E getLast();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool offer(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool offerFirst(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool offerLast(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		E peekFirst();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E peekLast();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E pollFirst();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E pollLast();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E removeFirst();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool removeFirstOccurrence(IJavaObject arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		E removeLast();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool removeLastOccurrence(IJavaObject arg0);
	}
}
