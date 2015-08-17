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
	[JavaProxy("java/util/concurrent/atomic/AtomicLongFieldUpdater")]
	public abstract class AtomicLongFieldUpdater<T> : Object
		where T : IJavaObject
	{
		protected AtomicLongFieldUpdater(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)J")]
		public long @get(T arg0)
		{
			return Instance.CallMethod<long>("get", "(Ljava/lang/Object;)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)V")]
		public void @set(T arg0, long arg1)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;J)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)V")]
		public void lazySet(T arg0, long arg1)
		{
			Instance.CallMethod("lazySet", "(Ljava/lang/Object;J)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;JJ)Z")]
		public bool compareAndSet(T arg0, long arg1, long arg2)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(Ljava/lang/Object;JJ)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicLongFieldUpdater;")]
		public static AtomicLongFieldUpdater<U> newUpdater<U>(Class<U> arg0, String arg1)
			where U : IJavaObject
		{
			return Static.CallMethod<AtomicLongFieldUpdater<U>>(typeof(AtomicLongFieldUpdater<>), "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicLongFieldUpdater;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/function/LongBinaryOperator;)J")]
		public long accumulateAndGet(T arg0, long arg1, LongBinaryOperator arg2)
		{
			return Instance.CallMethod<long>("accumulateAndGet", "(Ljava/lang/Object;JLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;JLjava/util/function/LongBinaryOperator;)J")]
		public long getAndAccumulate(T arg0, long arg1, LongBinaryOperator arg2)
		{
			return Instance.CallMethod<long>("getAndAccumulate", "(Ljava/lang/Object;JLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)J")]
		public long getAndSet(T arg0, long arg1)
		{
			return Instance.CallMethod<long>("getAndSet", "(Ljava/lang/Object;J)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/LongUnaryOperator;)J")]
		public long getAndUpdate(T arg0, LongUnaryOperator arg1)
		{
			return Instance.CallMethod<long>("getAndUpdate", "(Ljava/lang/Object;Ljava/util/function/LongUnaryOperator;)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/LongUnaryOperator;)J")]
		public long updateAndGet(T arg0, LongUnaryOperator arg1)
		{
			return Instance.CallMethod<long>("updateAndGet", "(Ljava/lang/Object;Ljava/util/function/LongUnaryOperator;)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;JJ)Z")]
		public bool weakCompareAndSet(T arg0, long arg1, long arg2)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(Ljava/lang/Object;JJ)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)J")]
		public long getAndAdd(T arg0, long arg1)
		{
			return Instance.CallMethod<long>("getAndAdd", "(Ljava/lang/Object;J)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)J")]
		public long addAndGet(T arg0, long arg1)
		{
			return Instance.CallMethod<long>("addAndGet", "(Ljava/lang/Object;J)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)J")]
		public long decrementAndGet(T arg0)
		{
			return Instance.CallMethod<long>("decrementAndGet", "(Ljava/lang/Object;)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)J")]
		public long getAndDecrement(T arg0)
		{
			return Instance.CallMethod<long>("getAndDecrement", "(Ljava/lang/Object;)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)J")]
		public long getAndIncrement(T arg0)
		{
			return Instance.CallMethod<long>("getAndIncrement", "(Ljava/lang/Object;)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)J")]
		public long incrementAndGet(T arg0)
		{
			return Instance.CallMethod<long>("incrementAndGet", "(Ljava/lang/Object;)J", arg0);
		}
	}
}
