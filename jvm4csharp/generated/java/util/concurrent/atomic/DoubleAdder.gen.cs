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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent.atomic
{
	[JavaProxy("java/util/concurrent/atomic/DoubleAdder")]
	public class DoubleAdder : Number, Serializable
	{
		protected DoubleAdder(ProxyCtor p) : base(p) {}
		
		public DoubleAdder() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(D)V")]
		public void @add(double arg0)
		{
			Instance.CallMethod("add", "(D)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("()D")]
		public double sum()
		{
			return Instance.CallMethod<double>("sum", "()D");
		}
		
		[JavaSignature("()D")]
		public double sumThenReset()
		{
			return Instance.CallMethod<double>("sumThenReset", "()D");
		}
	}
}
