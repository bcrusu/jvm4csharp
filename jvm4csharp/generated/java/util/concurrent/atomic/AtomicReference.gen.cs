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
	[JavaProxy("java/util/concurrent/atomic/AtomicReference")]
	public partial class AtomicReference<V> : Object, Serializable
		where V : IJavaObject
	{
		protected AtomicReference(ProxyCtor p) : base(p) {}
		
		public AtomicReference(V arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Object;)V", arg0);
		}
		
		public AtomicReference() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public V @get()
		{
			return Instance.CallMethod<V>("get", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void @set(V arg0)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void lazySet(V arg0)
		{
			Instance.CallMethod("lazySet", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool compareAndSet(V arg0, V arg1)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		public V accumulateAndGet(V arg0, BinaryOperator<V> arg1)
		{
			return Instance.CallMethod<V>("accumulateAndGet", "(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		public V getAndAccumulate(V arg0, BinaryOperator<V> arg1)
		{
			return Instance.CallMethod<V>("getAndAccumulate", "(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public V getAndSet(V arg0)
		{
			return Instance.CallMethod<V>("getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;")]
		public V getAndUpdate(UnaryOperator<V> arg0)
		{
			return Instance.CallMethod<V>("getAndUpdate", "(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;")]
		public V updateAndGet(UnaryOperator<V> arg0)
		{
			return Instance.CallMethod<V>("updateAndGet", "(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool weakCompareAndSet(V arg0, V arg1)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
		}
	}
}
