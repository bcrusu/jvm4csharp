//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent.atomic
{
	[JavaProxy("java/util/concurrent/atomic/AtomicLongArray")]
	public partial class AtomicLongArray : Object, Serializable
	{
		protected AtomicLongArray(ProxyCtor p) : base(p) {}
		
		public AtomicLongArray(LongArray arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([J)V", arg0);
		}
		
		public AtomicLongArray(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("(I)J")]
		public long @get(int arg0)
		{
			return Instance.CallMethod<long>("get", "(I)J", arg0);
		}
		
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("(IJ)V")]
		public void @set(int arg0, long arg1)
		{
			Instance.CallMethod("set", "(IJ)V", arg0, arg1);
		}
		
		[JavaSignature("(IJ)V")]
		public void lazySet(int arg0, long arg1)
		{
			Instance.CallMethod("lazySet", "(IJ)V", arg0, arg1);
		}
		
		[JavaSignature("(IJJ)Z")]
		public bool compareAndSet(int arg0, long arg1, long arg2)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(IJJ)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IJLjava/util/function/LongBinaryOperator;)J")]
		public long accumulateAndGet(int arg0, long arg1, LongBinaryOperator arg2)
		{
			return Instance.CallMethod<long>("accumulateAndGet", "(IJLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IJLjava/util/function/LongBinaryOperator;)J")]
		public long getAndAccumulate(int arg0, long arg1, LongBinaryOperator arg2)
		{
			return Instance.CallMethod<long>("getAndAccumulate", "(IJLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IJ)J")]
		public long getAndSet(int arg0, long arg1)
		{
			return Instance.CallMethod<long>("getAndSet", "(IJ)J", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/LongUnaryOperator;)J")]
		public long getAndUpdate(int arg0, LongUnaryOperator arg1)
		{
			return Instance.CallMethod<long>("getAndUpdate", "(ILjava/util/function/LongUnaryOperator;)J", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/LongUnaryOperator;)J")]
		public long updateAndGet(int arg0, LongUnaryOperator arg1)
		{
			return Instance.CallMethod<long>("updateAndGet", "(ILjava/util/function/LongUnaryOperator;)J", arg0, arg1);
		}
		
		[JavaSignature("(IJJ)Z")]
		public bool weakCompareAndSet(int arg0, long arg1, long arg2)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(IJJ)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IJ)J")]
		public long getAndAdd(int arg0, long arg1)
		{
			return Instance.CallMethod<long>("getAndAdd", "(IJ)J", arg0, arg1);
		}
		
		[JavaSignature("(IJ)J")]
		public long addAndGet(int arg0, long arg1)
		{
			return Instance.CallMethod<long>("addAndGet", "(IJ)J", arg0, arg1);
		}
		
		[JavaSignature("(I)J")]
		public long decrementAndGet(int arg0)
		{
			return Instance.CallMethod<long>("decrementAndGet", "(I)J", arg0);
		}
		
		[JavaSignature("(I)J")]
		public long getAndDecrement(int arg0)
		{
			return Instance.CallMethod<long>("getAndDecrement", "(I)J", arg0);
		}
		
		[JavaSignature("(I)J")]
		public long getAndIncrement(int arg0)
		{
			return Instance.CallMethod<long>("getAndIncrement", "(I)J", arg0);
		}
		
		[JavaSignature("(I)J")]
		public long incrementAndGet(int arg0)
		{
			return Instance.CallMethod<long>("incrementAndGet", "(I)J", arg0);
		}
	}
}
