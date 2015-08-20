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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/Exchanger")]
	public partial class Exchanger<V> : Object
		where V : IJavaObject
	{
		protected Exchanger(ProxyCtor p) : base(p) {}
		
		public Exchanger() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		public V exchange(V arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<V>("exchange", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public V exchange(V arg0)
		{
			return Instance.CallMethod<V>("exchange", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
	}
}
