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
	[JavaProxy("java/util/concurrent/atomic/AtomicIntegerFieldUpdater")]
	public abstract partial class AtomicIntegerFieldUpdater<T> : Object
		where T : IJavaObject
	{
		protected AtomicIntegerFieldUpdater(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int @get(T arg0)
		{
			return Instance.CallMethod<int>("get", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)V")]
		public void @set(T arg0, int arg1)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)V")]
		public void lazySet(T arg0, int arg1)
		{
			Instance.CallMethod("lazySet", "(Ljava/lang/Object;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;II)Z")]
		public bool compareAndSet(T arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(Ljava/lang/Object;II)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicIntegerFieldUpdater;")]
		public static AtomicIntegerFieldUpdater<U> newUpdater<U>(Class<U> arg0, String arg1)
			where U : IJavaObject
		{
			return Static.CallMethod<AtomicIntegerFieldUpdater<U>>(typeof(AtomicIntegerFieldUpdater<>), "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicIntegerFieldUpdater;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;ILjava/util/function/IntBinaryOperator;)I")]
		public int accumulateAndGet(T arg0, int arg1, IntBinaryOperator arg2)
		{
			return Instance.CallMethod<int>("accumulateAndGet", "(Ljava/lang/Object;ILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;ILjava/util/function/IntBinaryOperator;)I")]
		public int getAndAccumulate(T arg0, int arg1, IntBinaryOperator arg2)
		{
			return Instance.CallMethod<int>("getAndAccumulate", "(Ljava/lang/Object;ILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public int getAndSet(T arg0, int arg1)
		{
			return Instance.CallMethod<int>("getAndSet", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/IntUnaryOperator;)I")]
		public int getAndUpdate(T arg0, IntUnaryOperator arg1)
		{
			return Instance.CallMethod<int>("getAndUpdate", "(Ljava/lang/Object;Ljava/util/function/IntUnaryOperator;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/IntUnaryOperator;)I")]
		public int updateAndGet(T arg0, IntUnaryOperator arg1)
		{
			return Instance.CallMethod<int>("updateAndGet", "(Ljava/lang/Object;Ljava/util/function/IntUnaryOperator;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;II)Z")]
		public bool weakCompareAndSet(T arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(Ljava/lang/Object;II)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public int getAndAdd(T arg0, int arg1)
		{
			return Instance.CallMethod<int>("getAndAdd", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public int addAndGet(T arg0, int arg1)
		{
			return Instance.CallMethod<int>("addAndGet", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int decrementAndGet(T arg0)
		{
			return Instance.CallMethod<int>("decrementAndGet", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int getAndDecrement(T arg0)
		{
			return Instance.CallMethod<int>("getAndDecrement", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int getAndIncrement(T arg0)
		{
			return Instance.CallMethod<int>("getAndIncrement", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int incrementAndGet(T arg0)
		{
			return Instance.CallMethod<int>("incrementAndGet", "(Ljava/lang/Object;)I", arg0);
		}
	}
}
