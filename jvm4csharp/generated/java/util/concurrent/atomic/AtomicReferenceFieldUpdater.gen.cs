//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent.atomic
{
	[JavaProxy("java/util/concurrent/atomic/AtomicReferenceFieldUpdater")]
	public abstract class AtomicReferenceFieldUpdater<T, V> : Object
		where T : IJavaObject
		where V : IJavaObject
	{
		protected AtomicReferenceFieldUpdater(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public V @get(T arg0)
		{
			return Instance.CallMethod<V>("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)V")]
		public void @set(T arg0, V arg1)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)V")]
		public void lazySet(T arg0, V arg1)
		{
			Instance.CallMethod("lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool compareAndSet(T arg0, V arg1, V arg2)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;")]
		public static AtomicReferenceFieldUpdater<U, W> newUpdater<U, W>(Class<U> arg0, Class<W> arg1, String arg2)
			where U : IJavaObject
			where W : IJavaObject
		{
			return Static.CallMethod<AtomicReferenceFieldUpdater<U, W>>(typeof(AtomicReferenceFieldUpdater<,>), "newUpdater", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		public V accumulateAndGet(T arg0, V arg1, BinaryOperator<V> arg2)
		{
			return Instance.CallMethod<V>("accumulateAndGet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		public V getAndAccumulate(T arg0, V arg1, BinaryOperator<V> arg2)
		{
			return Instance.CallMethod<V>("getAndAccumulate", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public V getAndSet(T arg0, V arg1)
		{
			return Instance.CallMethod<V>("getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;")]
		public V getAndUpdate(T arg0, UnaryOperator<V> arg1)
		{
			return Instance.CallMethod<V>("getAndUpdate", "(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;")]
		public V updateAndGet(T arg0, UnaryOperator<V> arg1)
		{
			return Instance.CallMethod<V>("updateAndGet", "(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool weakCompareAndSet(T arg0, V arg1, V arg2)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
		}
	}
}
