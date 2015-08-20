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
	[JavaProxy("java/lang/management/MonitorInfo")]
	public partial class MonitorInfo : LockInfo
	{
		protected MonitorInfo(ProxyCtor p) : base(p) {}
		
		public MonitorInfo(String arg0, int arg1, int arg2, StackTraceElement arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;IILjava/lang/StackTraceElement;)V", arg0, arg1, arg2, arg3);
		}
	
		[JavaSignature("()I")]
		public int getLockedStackDepth()
		{
			return Instance.CallMethod<int>("getLockedStackDepth", "()I");
		}
		
		[JavaSignature("()Ljava/lang/StackTraceElement;")]
		public StackTraceElement getLockedStackFrame()
		{
			return Instance.CallMethod<StackTraceElement>("getLockedStackFrame", "()Ljava/lang/StackTraceElement;");
		}
	}
}
