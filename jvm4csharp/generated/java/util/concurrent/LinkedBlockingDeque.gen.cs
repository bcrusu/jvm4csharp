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
	[JavaProxy("java/util/concurrent/LinkedBlockingDeque")]
	public partial class LinkedBlockingDeque<E> : AbstractQueue<E>, BlockingDeque<E>, Serializable
		where E : IJavaObject
	{
		protected LinkedBlockingDeque(ProxyCtor p) : base(p) {}
		
		public LinkedBlockingDeque(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public LinkedBlockingDeque(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public LinkedBlockingDeque() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void put(E arg0)
		{
			Instance.CallMethod("put", "(Ljava/lang/Object;)V", arg0);
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
		public E getLast()
		{
			return Instance.CallMethod<E>("getLast", "()Ljava/lang/Object;");
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
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		public bool offerFirst(E arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<bool>("offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1, arg2);
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
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		public bool offerLast(E arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<bool>("offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1, arg2);
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
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		public E pollFirst(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<E>("pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E pollLast()
		{
			return Instance.CallMethod<E>("pollLast", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		public E pollLast(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<E>("pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1);
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
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E take()
		{
			return Instance.CallMethod<E>("take", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/util/Collection;I)I")]
		public int drainTo(Collection<IJavaObject> arg0, int arg1)
		{
			return Instance.CallMethod<int>("drainTo", "(Ljava/util/Collection;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Collection;)I")]
		public int drainTo(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<int>("drainTo", "(Ljava/util/Collection;)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int remainingCapacity()
		{
			return Instance.CallMethod<int>("remainingCapacity", "()I");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void putFirst(E arg0)
		{
			Instance.CallMethod("putFirst", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void putLast(E arg0)
		{
			Instance.CallMethod("putLast", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E takeFirst()
		{
			return Instance.CallMethod<E>("takeFirst", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E takeLast()
		{
			return Instance.CallMethod<E>("takeLast", "()Ljava/lang/Object;");
		}
	}
}
