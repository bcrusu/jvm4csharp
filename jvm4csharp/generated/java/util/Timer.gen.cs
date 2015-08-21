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
	[JavaProxy("java/util/Timer")]
	public partial class Timer : Object
	{
		protected Timer(ProxyCtor p) : base(p) {}
		
		public Timer(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Timer(bool arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Z)V", arg0);
		}
		
		public Timer() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Timer(String arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Z)V", arg0, arg1);
		}
	
		[JavaSignature("(Ljava/util/TimerTask;Ljava/util/Date;J)V")]
		public void schedule(TimerTask arg0, Date arg1, long arg2)
		{
			Instance.CallMethod("schedule", "(Ljava/util/TimerTask;Ljava/util/Date;J)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/TimerTask;Ljava/util/Date;)V")]
		public void schedule(TimerTask arg0, Date arg1)
		{
			Instance.CallMethod("schedule", "(Ljava/util/TimerTask;Ljava/util/Date;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/TimerTask;J)V")]
		public void schedule(TimerTask arg0, long arg1)
		{
			Instance.CallMethod("schedule", "(Ljava/util/TimerTask;J)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/TimerTask;JJ)V")]
		public void schedule(TimerTask arg0, long arg1, long arg2)
		{
			Instance.CallMethod("schedule", "(Ljava/util/TimerTask;JJ)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/TimerTask;Ljava/util/Date;J)V")]
		public void scheduleAtFixedRate(TimerTask arg0, Date arg1, long arg2)
		{
			Instance.CallMethod("scheduleAtFixedRate", "(Ljava/util/TimerTask;Ljava/util/Date;J)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/TimerTask;JJ)V")]
		public void scheduleAtFixedRate(TimerTask arg0, long arg1, long arg2)
		{
			Instance.CallMethod("scheduleAtFixedRate", "(Ljava/util/TimerTask;JJ)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("()I")]
		public int purge()
		{
			return Instance.CallMethod<int>("purge", "()I");
		}
		
		[JavaSignature("()V")]
		public void cancel()
		{
			Instance.CallMethod("cancel", "()V");
		}
	}
}
