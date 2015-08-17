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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/BlockingDeque")]
	public interface BlockingDeque<E> : BlockingQueue<E>, Deque<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @add(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E @remove();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @remove(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		new void put(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool contains(IJavaObject arg0);
		
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<E> iterator();
		
		[JavaSignature("()I")]
		new int size();
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		new void push(E arg0);
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		new E poll(long arg0, TimeUnit arg1);
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E poll();
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E peek();
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		new void addFirst(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		new void addLast(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E element();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool offer(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		new bool offer(E arg0, long arg1, TimeUnit arg2);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool offerFirst(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		bool offerFirst(E arg0, long arg1, TimeUnit arg2);
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		bool offerLast(E arg0, long arg1, TimeUnit arg2);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool offerLast(E arg0);
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		E pollFirst(long arg0, TimeUnit arg1);
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		E pollLast(long arg0, TimeUnit arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool removeFirstOccurrence(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool removeLastOccurrence(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void putFirst(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void putLast(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		E takeFirst();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E takeLast();
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E take();
	}
}
