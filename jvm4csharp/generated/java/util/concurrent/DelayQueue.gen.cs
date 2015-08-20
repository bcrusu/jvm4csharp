//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/DelayQueue")]
	public partial class DelayQueue<E> : AbstractQueue<E>, BlockingQueue<E>
		where E : Delayed
	{
		protected DelayQueue(ProxyCtor p) : base(p) {}
		
		public DelayQueue() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public DelayQueue(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
	
		[JavaSignature("(Ljava/util/concurrent/Delayed;)Z")]
		public bool @add(E arg0)
		{
			return Instance.CallMethod<bool>("add", "(Ljava/util/concurrent/Delayed;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/Delayed;)V")]
		public void put(E arg0)
		{
			Instance.CallMethod("put", "(Ljava/util/concurrent/Delayed;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Iterator;")]
		public new Iterator<E> iterator()
		{
			return Instance.CallMethod<Iterator<E>>("iterator", "()Ljava/util/Iterator;");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Delayed;")]
		public E poll(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<E>("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Delayed;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/Delayed;")]
		public E poll()
		{
			return Instance.CallMethod<E>("poll", "()Ljava/util/concurrent/Delayed;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/Delayed;")]
		public E peek()
		{
			return Instance.CallMethod<E>("peek", "()Ljava/util/concurrent/Delayed;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/Delayed;)Z")]
		public bool offer(E arg0)
		{
			return Instance.CallMethod<bool>("offer", "(Ljava/util/concurrent/Delayed;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z")]
		public bool offer(E arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<bool>("offer", "(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/util/concurrent/Delayed;")]
		public E take()
		{
			return Instance.CallMethod<E>("take", "()Ljava/util/concurrent/Delayed;");
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
		
		[JavaSignature("()Ljava/lang/Object;")]
		public new E @remove()
		{
			return Instance.CallMethod<E>("remove", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public new E element()
		{
			return Instance.CallMethod<E>("element", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		public new Spliterator<E> spliterator()
		{
			return Instance.CallMethod<Spliterator<E>>("spliterator", "()Ljava/util/Spliterator;");
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool addAll(Collection<E> arg0)
		{
			return Instance.CallMethod<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public new Stream<E> stream()
		{
			return Instance.CallMethod<Stream<E>>("stream", "()Ljava/util/stream/Stream;");
		}
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		public bool removeIf(Predicate<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public new Stream<E> parallelStream()
		{
			return Instance.CallMethod<Stream<E>>("parallelStream", "()Ljava/util/stream/Stream;");
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		public void forEach(Consumer<IJavaObject> arg0)
		{
			Instance.CallMethod("forEach", "(Ljava/util/function/Consumer;)V", arg0);
		}
	}
}
