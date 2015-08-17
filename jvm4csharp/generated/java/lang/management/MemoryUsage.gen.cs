//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/MemoryUsage")]
	public class MemoryUsage : Object
	{
		protected MemoryUsage(ProxyCtor p) : base(p) {}
		
		public MemoryUsage(long arg0, long arg1, long arg2, long arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(JJJJ)V", arg0, arg1, arg2, arg3);
		}
	
		[JavaSignature("()J")]
		public long getMax()
		{
			return Instance.CallMethod<long>("getMax", "()J");
		}
		
		[JavaSignature("()J")]
		public long getCommitted()
		{
			return Instance.CallMethod<long>("getCommitted", "()J");
		}
		
		[JavaSignature("()J")]
		public long getInit()
		{
			return Instance.CallMethod<long>("getInit", "()J");
		}
		
		[JavaSignature("()J")]
		public long getUsed()
		{
			return Instance.CallMethod<long>("getUsed", "()J");
		}
	}
}
