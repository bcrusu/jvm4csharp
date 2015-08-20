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
	[JavaProxy("java/util/LongSummaryStatistics")]
	public partial class LongSummaryStatistics : Object, LongConsumer, IntConsumer
	{
		protected LongSummaryStatistics(ProxyCtor p) : base(p) {}
		
		public LongSummaryStatistics() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(J)V")]
		public void accept(long arg0)
		{
			Instance.CallMethod("accept", "(J)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void accept(int arg0)
		{
			Instance.CallMethod("accept", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/LongSummaryStatistics;)V")]
		public void combine(LongSummaryStatistics arg0)
		{
			Instance.CallMethod("combine", "(Ljava/util/LongSummaryStatistics;)V", arg0);
		}
		
		[JavaSignature("()D")]
		public double getAverage()
		{
			return Instance.CallMethod<double>("getAverage", "()D");
		}
		
		[JavaSignature("()J")]
		public long getMax()
		{
			return Instance.CallMethod<long>("getMax", "()J");
		}
		
		[JavaSignature("()J")]
		public long getSum()
		{
			return Instance.CallMethod<long>("getSum", "()J");
		}
		
		[JavaSignature("()J")]
		public long getMin()
		{
			return Instance.CallMethod<long>("getMin", "()J");
		}
		
		[JavaSignature("()J")]
		public long getCount()
		{
			return Instance.CallMethod<long>("getCount", "()J");
		}
		
		[JavaSignature("(Ljava/util/function/LongConsumer;)Ljava/util/function/LongConsumer;")]
		public LongConsumer andThen(LongConsumer arg0)
		{
			return Instance.CallMethod<LongConsumer>("andThen", "(Ljava/util/function/LongConsumer;)Ljava/util/function/LongConsumer;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/IntConsumer;)Ljava/util/function/IntConsumer;")]
		public IntConsumer andThen(IntConsumer arg0)
		{
			return Instance.CallMethod<IntConsumer>("andThen", "(Ljava/util/function/IntConsumer;)Ljava/util/function/IntConsumer;", arg0);
		}
	}
}
