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
	[JavaProxy("java/util/concurrent/atomic/AtomicInteger")]
	public partial class AtomicInteger : Number, Serializable
	{
		protected AtomicInteger(ProxyCtor p) : base(p) {}
		
		public AtomicInteger(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public AtomicInteger() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()I")]
		public int @get()
		{
			return Instance.CallMethod<int>("get", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void @set(int arg0)
		{
			Instance.CallMethod("set", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void lazySet(int arg0)
		{
			Instance.CallMethod("lazySet", "(I)V", arg0);
		}
		
		[JavaSignature("(II)Z")]
		public bool compareAndSet(int arg0, int arg1)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(II)Z", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/IntBinaryOperator;)I")]
		public int accumulateAndGet(int arg0, IntBinaryOperator arg1)
		{
			return Instance.CallMethod<int>("accumulateAndGet", "(ILjava/util/function/IntBinaryOperator;)I", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/IntBinaryOperator;)I")]
		public int getAndAccumulate(int arg0, IntBinaryOperator arg1)
		{
			return Instance.CallMethod<int>("getAndAccumulate", "(ILjava/util/function/IntBinaryOperator;)I", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public int getAndSet(int arg0)
		{
			return Instance.CallMethod<int>("getAndSet", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/IntUnaryOperator;)I")]
		public int getAndUpdate(IntUnaryOperator arg0)
		{
			return Instance.CallMethod<int>("getAndUpdate", "(Ljava/util/function/IntUnaryOperator;)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/IntUnaryOperator;)I")]
		public int updateAndGet(IntUnaryOperator arg0)
		{
			return Instance.CallMethod<int>("updateAndGet", "(Ljava/util/function/IntUnaryOperator;)I", arg0);
		}
		
		[JavaSignature("(II)Z")]
		public bool weakCompareAndSet(int arg0, int arg1)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(II)Z", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public int getAndAdd(int arg0)
		{
			return Instance.CallMethod<int>("getAndAdd", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int addAndGet(int arg0)
		{
			return Instance.CallMethod<int>("addAndGet", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int decrementAndGet()
		{
			return Instance.CallMethod<int>("decrementAndGet", "()I");
		}
		
		[JavaSignature("()I")]
		public int getAndDecrement()
		{
			return Instance.CallMethod<int>("getAndDecrement", "()I");
		}
		
		[JavaSignature("()I")]
		public int getAndIncrement()
		{
			return Instance.CallMethod<int>("getAndIncrement", "()I");
		}
		
		[JavaSignature("()I")]
		public int incrementAndGet()
		{
			return Instance.CallMethod<int>("incrementAndGet", "()I");
		}
	}
}
