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
namespace jvm4csharp.java.util.concurrent.atomic
{
	[JavaProxy("java/util/concurrent/atomic/AtomicLong")]
	public class AtomicLong : Number, Serializable
	{
		protected AtomicLong(ProxyCtor p) : base(p) {}
		
		public AtomicLong() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public AtomicLong(long arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(J)V", arg0);
		}
	
		[JavaSignature("()J")]
		public long @get()
		{
			return Instance.CallMethod<long>("get", "()J");
		}
		
		[JavaSignature("(J)V")]
		public void @set(long arg0)
		{
			Instance.CallMethod("set", "(J)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void lazySet(long arg0)
		{
			Instance.CallMethod("lazySet", "(J)V", arg0);
		}
		
		[JavaSignature("(JJ)Z")]
		public bool compareAndSet(long arg0, long arg1)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(JJ)Z", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/LongBinaryOperator;)J")]
		public long accumulateAndGet(long arg0, LongBinaryOperator arg1)
		{
			return Instance.CallMethod<long>("accumulateAndGet", "(JLjava/util/function/LongBinaryOperator;)J", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/LongBinaryOperator;)J")]
		public long getAndAccumulate(long arg0, LongBinaryOperator arg1)
		{
			return Instance.CallMethod<long>("getAndAccumulate", "(JLjava/util/function/LongBinaryOperator;)J", arg0, arg1);
		}
		
		[JavaSignature("(J)J")]
		public long getAndSet(long arg0)
		{
			return Instance.CallMethod<long>("getAndSet", "(J)J", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/LongUnaryOperator;)J")]
		public long getAndUpdate(LongUnaryOperator arg0)
		{
			return Instance.CallMethod<long>("getAndUpdate", "(Ljava/util/function/LongUnaryOperator;)J", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/LongUnaryOperator;)J")]
		public long updateAndGet(LongUnaryOperator arg0)
		{
			return Instance.CallMethod<long>("updateAndGet", "(Ljava/util/function/LongUnaryOperator;)J", arg0);
		}
		
		[JavaSignature("(JJ)Z")]
		public bool weakCompareAndSet(long arg0, long arg1)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(JJ)Z", arg0, arg1);
		}
		
		[JavaSignature("(J)J")]
		public long getAndAdd(long arg0)
		{
			return Instance.CallMethod<long>("getAndAdd", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long addAndGet(long arg0)
		{
			return Instance.CallMethod<long>("addAndGet", "(J)J", arg0);
		}
		
		[JavaSignature("()J")]
		public long decrementAndGet()
		{
			return Instance.CallMethod<long>("decrementAndGet", "()J");
		}
		
		[JavaSignature("()J")]
		public long getAndDecrement()
		{
			return Instance.CallMethod<long>("getAndDecrement", "()J");
		}
		
		[JavaSignature("()J")]
		public long getAndIncrement()
		{
			return Instance.CallMethod<long>("getAndIncrement", "()J");
		}
		
		[JavaSignature("()J")]
		public long incrementAndGet()
		{
			return Instance.CallMethod<long>("incrementAndGet", "()J");
		}
	}
}
