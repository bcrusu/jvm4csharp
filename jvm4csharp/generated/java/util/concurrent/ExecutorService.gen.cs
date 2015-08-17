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
	[JavaProxy("java/util/concurrent/ExecutorService")]
	public interface ExecutorService : Executor
	{
		[JavaSignature("()V")]
		void shutdown();
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;")]
		Future<T> submit<T>(Callable<T> arg0)
			where T : IJavaObject;
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;")]
		Future<T> submit<T>(Runnable arg0, T arg1)
			where T : IJavaObject;
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;")]
		Future<IJavaObject> submit(Runnable arg0);
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		bool awaitTermination(long arg0, TimeUnit arg1);
		
		[JavaSignature("(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;")]
		List<Future<T>> invokeAll<T>(Collection<Callable<T>> arg0, long arg1, TimeUnit arg2)
			where T : IJavaObject;
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/util/List;")]
		List<Future<T>> invokeAll<T>(Collection<Callable<T>> arg0)
			where T : IJavaObject;
		
		[JavaSignature("(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		T invokeAny<T>(Collection<Callable<T>> arg0, long arg1, TimeUnit arg2)
			where T : IJavaObject;
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/lang/Object;")]
		T invokeAny<T>(Collection<Callable<T>> arg0)
			where T : IJavaObject;
		
		[JavaSignature("()Z")]
		bool isShutdown();
		
		[JavaSignature("()Z")]
		bool isTerminated();
		
		[JavaSignature("()Ljava/util/List;")]
		List<Runnable> shutdownNow();
	}
}
