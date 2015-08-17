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
	[JavaProxy("java/util/concurrent/atomic/DoubleAccumulator")]
	public class DoubleAccumulator : Number, Serializable
	{
		protected DoubleAccumulator(ProxyCtor p) : base(p) {}
		
		public DoubleAccumulator(DoubleBinaryOperator arg0, double arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/function/DoubleBinaryOperator;D)V", arg0, arg1);
		}
	
		[JavaSignature("()D")]
		public double @get()
		{
			return Instance.CallMethod<double>("get", "()D");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("(D)V")]
		public void accumulate(double arg0)
		{
			Instance.CallMethod("accumulate", "(D)V", arg0);
		}
		
		[JavaSignature("()D")]
		public double getThenReset()
		{
			return Instance.CallMethod<double>("getThenReset", "()D");
		}
	}
}
