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
	[JavaProxy("java/util/IntSummaryStatistics")]
	public partial class IntSummaryStatistics : Object, IntConsumer
	{
		protected IntSummaryStatistics(ProxyCtor p) : base(p) {}
		
		public IntSummaryStatistics() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(I)V")]
		public void accept(int arg0)
		{
			Instance.CallMethod("accept", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/IntSummaryStatistics;)V")]
		public void combine(IntSummaryStatistics arg0)
		{
			Instance.CallMethod("combine", "(Ljava/util/IntSummaryStatistics;)V", arg0);
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
		
		[JavaSignature("()I")]
		public int getMax()
		{
			return Instance.CallMethod<int>("getMax", "()I");
		}
		
		[JavaSignature("()J")]
		public long getSum()
		{
			return Instance.CallMethod<long>("getSum", "()J");
		}
		
		[JavaSignature("()I")]
		public int getMin()
		{
			return Instance.CallMethod<int>("getMin", "()I");
		}
		
		[JavaSignature("(Ljava/util/function/IntConsumer;)Ljava/util/function/IntConsumer;")]
		public IntConsumer andThen(IntConsumer arg0)
		{
			return Instance.CallMethod<IntConsumer>("andThen", "(Ljava/util/function/IntConsumer;)Ljava/util/function/IntConsumer;", arg0);
		}
	}
}
