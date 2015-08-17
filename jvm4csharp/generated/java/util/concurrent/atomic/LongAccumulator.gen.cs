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
	[JavaProxy("java/util/concurrent/atomic/LongAccumulator")]
	public class LongAccumulator : Number, Serializable
	{
		protected LongAccumulator(ProxyCtor p) : base(p) {}
		
		public LongAccumulator(LongBinaryOperator arg0, long arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/function/LongBinaryOperator;J)V", arg0, arg1);
		}
	
		[JavaSignature("()J")]
		public long @get()
		{
			return Instance.CallMethod<long>("get", "()J");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("(J)V")]
		public void accumulate(long arg0)
		{
			Instance.CallMethod("accumulate", "(J)V", arg0);
		}
		
		[JavaSignature("()J")]
		public long getThenReset()
		{
			return Instance.CallMethod<long>("getThenReset", "()J");
		}
	}
}
