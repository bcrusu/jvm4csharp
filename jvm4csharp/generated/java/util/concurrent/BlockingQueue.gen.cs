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
	[JavaProxy("java/util/concurrent/BlockingQueue")]
	public interface BlockingQueue<E> : Queue<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @add(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @remove(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void put(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool contains(IJavaObject arg0);
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		E poll(long arg0, TimeUnit arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool offer(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z")]
		bool offer(E arg0, long arg1, TimeUnit arg2);
		
		[JavaSignature("()Ljava/lang/Object;")]
		E take();
		
		[JavaSignature("(Ljava/util/Collection;)I")]
		int drainTo(Collection<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Collection;I)I")]
		int drainTo(Collection<IJavaObject> arg0, int arg1);
		
		[JavaSignature("()I")]
		int remainingCapacity();
	}
}
