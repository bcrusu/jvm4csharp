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
	[JavaProxy("java/util/concurrent/atomic/AtomicReferenceArray")]
	public partial class AtomicReferenceArray<E> : Object, Serializable
		where E : IJavaObject
	{
		protected AtomicReferenceArray(ProxyCtor p) : base(p) {}
		
		public AtomicReferenceArray(ObjectArray<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([Ljava/lang/Object;)V", arg0);
		}
		
		public AtomicReferenceArray(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("(I)Ljava/lang/Object;")]
		public E @get(int arg0)
		{
			return Instance.CallMethod<E>("get", "(I)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("(ILjava/lang/Object;)V")]
		public void @set(int arg0, E arg1)
		{
			Instance.CallMethod("set", "(ILjava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/Object;)V")]
		public void lazySet(int arg0, E arg1)
		{
			Instance.CallMethod("lazySet", "(ILjava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/Object;Ljava/lang/Object;)Z")]
		public bool compareAndSet(int arg0, E arg1, E arg2)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(ILjava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		public E accumulateAndGet(int arg0, E arg1, BinaryOperator<E> arg2)
		{
			return Instance.CallMethod<E>("accumulateAndGet", "(ILjava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(ILjava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		public E getAndAccumulate(int arg0, E arg1, BinaryOperator<E> arg2)
		{
			return Instance.CallMethod<E>("getAndAccumulate", "(ILjava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(ILjava/lang/Object;)Ljava/lang/Object;")]
		public E getAndSet(int arg0, E arg1)
		{
			return Instance.CallMethod<E>("getAndSet", "(ILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/UnaryOperator;)Ljava/lang/Object;")]
		public E getAndUpdate(int arg0, UnaryOperator<E> arg1)
		{
			return Instance.CallMethod<E>("getAndUpdate", "(ILjava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/UnaryOperator;)Ljava/lang/Object;")]
		public E updateAndGet(int arg0, UnaryOperator<E> arg1)
		{
			return Instance.CallMethod<E>("updateAndGet", "(ILjava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/Object;Ljava/lang/Object;)Z")]
		public bool weakCompareAndSet(int arg0, E arg1, E arg2)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
		}
	}
}
