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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/TimerTask")]
	public abstract class TimerTask : Object, Runnable
	{
		protected TimerTask(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()V")]
		public void run()
		{
			Instance.CallMethod("run", "()V");
		}
		
		[JavaSignature("()J")]
		public long scheduledExecutionTime()
		{
			return Instance.CallMethod<long>("scheduledExecutionTime", "()J");
		}
		
		[JavaSignature("()Z")]
		public bool cancel()
		{
			return Instance.CallMethod<bool>("cancel", "()Z");
		}
	}
}
