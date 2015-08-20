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
	[JavaProxy("java/util/concurrent/ScheduledExecutorService")]
	public partial interface ScheduledExecutorService : ExecutorService
	{
		[JavaSignature("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		ScheduledFuture<IJavaObject> schedule(Runnable arg0, long arg1, TimeUnit arg2);
		
		[JavaSignature("(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		ScheduledFuture<V> schedule<V>(Callable<V> arg0, long arg1, TimeUnit arg2)
			where V : IJavaObject;
		
		[JavaSignature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		ScheduledFuture<IJavaObject> scheduleAtFixedRate(Runnable arg0, long arg1, long arg2, TimeUnit arg3);
		
		[JavaSignature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;")]
		ScheduledFuture<IJavaObject> scheduleWithFixedDelay(Runnable arg0, long arg1, long arg2, TimeUnit arg3);
	}
}
