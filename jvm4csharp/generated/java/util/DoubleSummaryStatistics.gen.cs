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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/DoubleSummaryStatistics")]
	public partial class DoubleSummaryStatistics : Object, DoubleConsumer
	{
		protected DoubleSummaryStatistics(ProxyCtor p) : base(p) {}
		
		public DoubleSummaryStatistics() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(D)V")]
		public void accept(double arg0)
		{
			Instance.CallMethod("accept", "(D)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/DoubleSummaryStatistics;)V")]
		public void combine(DoubleSummaryStatistics arg0)
		{
			Instance.CallMethod("combine", "(Ljava/util/DoubleSummaryStatistics;)V", arg0);
		}
		
		[JavaSignature("()J")]
		public long getCount()
		{
			return Instance.CallMethod<long>("getCount", "()J");
		}
		
		[JavaSignature("()D")]
		public double getAverage()
		{
			return Instance.CallMethod<double>("getAverage", "()D");
		}
		
		[JavaSignature("()D")]
		public double getMax()
		{
			return Instance.CallMethod<double>("getMax", "()D");
		}
		
		[JavaSignature("()D")]
		public double getSum()
		{
			return Instance.CallMethod<double>("getSum", "()D");
		}
		
		[JavaSignature("()D")]
		public double getMin()
		{
			return Instance.CallMethod<double>("getMin", "()D");
		}
		
		[JavaSignature("(Ljava/util/function/DoubleConsumer;)Ljava/util/function/DoubleConsumer;")]
		public DoubleConsumer andThen(DoubleConsumer arg0)
		{
			return Instance.CallMethod<DoubleConsumer>("andThen", "(Ljava/util/function/DoubleConsumer;)Ljava/util/function/DoubleConsumer;", arg0);
		}
	}
}
