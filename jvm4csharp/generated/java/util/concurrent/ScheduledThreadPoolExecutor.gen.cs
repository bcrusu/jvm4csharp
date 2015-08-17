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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ScheduledThreadPoolExecutor")]
	public class ScheduledThreadPoolExecutor : ThreadPoolExecutor, ScheduledExecutorService
	{
		protected ScheduledThreadPoolExecutor(ProxyCtor p) : base(p) {}
		
		public ScheduledThreadPoolExecutor(int arg0, ThreadFactory arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/util/concurrent/ThreadFactory;)V", arg0, arg1);
		}
		
		public ScheduledThreadPoolExecutor(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public ScheduledThreadPoolExecutor(int arg0, ThreadFactory arg1, RejectedExecutionHandler arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V", arg0, arg1, arg2);
		}
		
		public ScheduledThreadPoolExecutor(int arg0, RejectedExecutionHandler arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/util/concurrent/RejectedExecutionHandler;)V", arg0, arg1);
		}
	
		[JavaSignature("()Z")]
		public bool getContinueExistingPeriodicTasksAfterShutdownPolicy()
		{
			return Instance.CallMethod<bool>("getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool getExecuteExistingDelayedTasksAfterShutdownPolicy()
		{
			return Instance.CallMethod<bool>("getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool getRemoveOnCancelPolicy()
		{
			return Instance.CallMethod<bool>("getRemoveOnCancelPolicy", "()Z");
		}
		
		[JavaSignature("(Z)V")]
		public void setContinueExistingPeriodicTasksAfterShutdownPolicy(bool arg0)
		{
			Instance.CallMethod("setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setExecuteExistingDelayedTasksAfterShutdownPolicy(bool arg0)
		{
			Instance.CallMethod("setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setRemoveOnCancelPolicy(bool arg0)
		{
			Instance.CallMethod("setRemoveOnCancelPolicy", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		public ScheduledFuture<V> schedule<V>(Callable<V> arg0, long arg1, TimeUnit arg2)
			where V : IJavaObject
		{
			return Instance.CallMethod<ScheduledFuture<V>>("schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		public ScheduledFuture<IJavaObject> schedule(Runnable arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<ScheduledFuture<IJavaObject>>("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		public ScheduledFuture<IJavaObject> scheduleAtFixedRate(Runnable arg0, long arg1, long arg2, TimeUnit arg3)
		{
			return Instance.CallMethod<ScheduledFuture<IJavaObject>>("scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		public ScheduledFuture<IJavaObject> scheduleWithFixedDelay(Runnable arg0, long arg1, long arg2, TimeUnit arg3)
		{
			return Instance.CallMethod<ScheduledFuture<IJavaObject>>("scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", arg0, arg1, arg2, arg3);
		}
	}
}
