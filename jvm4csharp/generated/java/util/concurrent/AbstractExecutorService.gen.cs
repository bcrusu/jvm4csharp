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
	[JavaProxy("java/util/concurrent/AbstractExecutorService")]
	public abstract partial class AbstractExecutorService : Object, ExecutorService
	{
		protected AbstractExecutorService(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;")]
		public Future<T> submit<T>(Runnable arg0, T arg1)
			where T : IJavaObject
		{
			return Instance.CallMethod<Future<T>>("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;")]
		public Future<IJavaObject> submit(Runnable arg0)
		{
			return Instance.CallMethod<Future<IJavaObject>>("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;")]
		public Future<T> submit<T>(Callable<T> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<Future<T>>("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;")]
		public List<Future<T>> invokeAll<T>(Collection<Callable<T>> arg0, long arg1, TimeUnit arg2)
			where T : IJavaObject
		{
			return Instance.CallMethod<List<Future<T>>>("invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/util/List;")]
		public List<Future<T>> invokeAll<T>(Collection<Callable<T>> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<List<Future<T>>>("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		public T invokeAny<T>(Collection<Callable<T>> arg0, long arg1, TimeUnit arg2)
			where T : IJavaObject
		{
			return Instance.CallMethod<T>("invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/lang/Object;")]
		public T invokeAny<T>(Collection<Callable<T>> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<T>("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()V")]
		public void shutdown()
		{
			Instance.CallMethod("shutdown", "()V");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		public bool awaitTermination(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<bool>("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool isShutdown()
		{
			return Instance.CallMethod<bool>("isShutdown", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isTerminated()
		{
			return Instance.CallMethod<bool>("isTerminated", "()Z");
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public List<Runnable> shutdownNow()
		{
			return Instance.CallMethod<List<Runnable>>("shutdownNow", "()Ljava/util/List;");
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)V")]
		public void execute(Runnable arg0)
		{
			Instance.CallMethod("execute", "(Ljava/lang/Runnable;)V", arg0);
		}
	}
}
