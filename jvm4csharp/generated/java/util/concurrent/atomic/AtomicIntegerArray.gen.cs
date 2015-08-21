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
	[JavaProxy("java/util/concurrent/atomic/AtomicIntegerArray")]
	public partial class AtomicIntegerArray : Object, Serializable
	{
		protected AtomicIntegerArray(ProxyCtor p) : base(p) {}
		
		public AtomicIntegerArray(IntArray arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([I)V", arg0);
		}
		
		public AtomicIntegerArray(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("(I)I")]
		public int @get(int arg0)
		{
			return Instance.CallMethod<int>("get", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("(II)V")]
		public void @set(int arg0, int arg1)
		{
			Instance.CallMethod("set", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("(II)V")]
		public void lazySet(int arg0, int arg1)
		{
			Instance.CallMethod("lazySet", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("(III)Z")]
		public bool compareAndSet(int arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(III)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IILjava/util/function/IntBinaryOperator;)I")]
		public int accumulateAndGet(int arg0, int arg1, IntBinaryOperator arg2)
		{
			return Instance.CallMethod<int>("accumulateAndGet", "(IILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IILjava/util/function/IntBinaryOperator;)I")]
		public int getAndAccumulate(int arg0, int arg1, IntBinaryOperator arg2)
		{
			return Instance.CallMethod<int>("getAndAccumulate", "(IILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(II)I")]
		public int getAndSet(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("getAndSet", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/IntUnaryOperator;)I")]
		public int getAndUpdate(int arg0, IntUnaryOperator arg1)
		{
			return Instance.CallMethod<int>("getAndUpdate", "(ILjava/util/function/IntUnaryOperator;)I", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/IntUnaryOperator;)I")]
		public int updateAndGet(int arg0, IntUnaryOperator arg1)
		{
			return Instance.CallMethod<int>("updateAndGet", "(ILjava/util/function/IntUnaryOperator;)I", arg0, arg1);
		}
		
		[JavaSignature("(III)Z")]
		public bool weakCompareAndSet(int arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(III)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(II)I")]
		public int getAndAdd(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("getAndAdd", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public int addAndGet(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("addAndGet", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public int decrementAndGet(int arg0)
		{
			return Instance.CallMethod<int>("decrementAndGet", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int getAndDecrement(int arg0)
		{
			return Instance.CallMethod<int>("getAndDecrement", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int getAndIncrement(int arg0)
		{
			return Instance.CallMethod<int>("getAndIncrement", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int incrementAndGet(int arg0)
		{
			return Instance.CallMethod<int>("incrementAndGet", "(I)I", arg0);
		}
	}
}
