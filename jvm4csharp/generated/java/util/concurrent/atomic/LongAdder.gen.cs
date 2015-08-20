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
	[JavaProxy("java/util/concurrent/atomic/LongAdder")]
	public partial class LongAdder : Number, Serializable
	{
		protected LongAdder(ProxyCtor p) : base(p) {}
		
		public LongAdder() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(J)V")]
		public void @add(long arg0)
		{
			Instance.CallMethod("add", "(J)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void increment()
		{
			Instance.CallMethod("increment", "()V");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("()J")]
		public long sum()
		{
			return Instance.CallMethod<long>("sum", "()J");
		}
		
		[JavaSignature("()V")]
		public void decrement()
		{
			Instance.CallMethod("decrement", "()V");
		}
		
		[JavaSignature("()J")]
		public long sumThenReset()
		{
			return Instance.CallMethod<long>("sumThenReset", "()J");
		}
	}
}
