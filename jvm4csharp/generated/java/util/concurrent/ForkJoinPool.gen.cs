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
	[JavaProxy("java/util/concurrent/ForkJoinPool")]
	public class ForkJoinPool : AbstractExecutorService
	{
		protected ForkJoinPool(ProxyCtor p) : base(p) {}
		
		public ForkJoinPool() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ForkJoinPool(int arg0, ForkJoinPool.ForkJoinWorkerThreadFactory arg1, Thread.UncaughtExceptionHandler arg2, bool arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/util/concurrent/ForkJoinPool/ForkJoinWorkerThreadFactory;Ljava/lang/Thread/UncaughtExceptionHandler;Z)V", arg0, arg1, arg2, arg3);
		}
		
		public ForkJoinPool(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("Ljava/util/concurrent/ForkJoinPool/ForkJoinWorkerThreadFactory;")]
		public static ForkJoinPool.ForkJoinWorkerThreadFactory defaultForkJoinWorkerThreadFactory
		{
			get { return Static.GetField<ForkJoinPool.ForkJoinWorkerThreadFactory>(typeof(ForkJoinPool), "defaultForkJoinWorkerThreadFactory", "Ljava/util/concurrent/ForkJoinPool/ForkJoinWorkerThreadFactory;"); }
		}
	
		[JavaSignature("(Ljava/util/concurrent/ForkJoinTask;)Ljava/lang/Object;")]
		public T invoke<T>(ForkJoinTask<T> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<T>("invoke", "(Ljava/util/concurrent/ForkJoinTask;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()V")]
		public void shutdown()
		{
			Instance.CallMethod("shutdown", "()V");
		}
		
		[JavaSignature("()Ljava/util/concurrent/ForkJoinPool/ForkJoinWorkerThreadFactory;")]
		public ForkJoinPool.ForkJoinWorkerThreadFactory getFactory()
		{
			return Instance.CallMethod<ForkJoinPool.ForkJoinWorkerThreadFactory>("getFactory", "()Ljava/util/concurrent/ForkJoinPool/ForkJoinWorkerThreadFactory;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ForkJoinTask;)V")]
		public void execute(ForkJoinTask<IJavaObject> arg0)
		{
			Instance.CallMethod("execute", "(Ljava/util/concurrent/ForkJoinTask;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Thread/UncaughtExceptionHandler;")]
		public Thread.UncaughtExceptionHandler getUncaughtExceptionHandler()
		{
			return Instance.CallMethod<Thread.UncaughtExceptionHandler>("getUncaughtExceptionHandler", "()Ljava/lang/Thread/UncaughtExceptionHandler;");
		}
		
		[JavaSignature("()I")]
		public static int getCommonPoolParallelism()
		{
			return Static.CallMethod<int>(typeof(ForkJoinPool), "getCommonPoolParallelism", "()I");
		}
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;")]
		public new ForkJoinTask<T> submit<T>(Callable<T> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<ForkJoinTask<T>>("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ForkJoinTask;")]
		public new ForkJoinTask<T> submit<T>(Runnable arg0, T arg1)
			where T : IJavaObject
		{
			return Instance.CallMethod<ForkJoinTask<T>>("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ForkJoinTask;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;")]
		public new ForkJoinTask<IJavaObject> submit(Runnable arg0)
		{
			return Instance.CallMethod<ForkJoinTask<IJavaObject>>("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/ForkJoinTask;)Ljava/util/concurrent/ForkJoinTask;")]
		public ForkJoinTask<T> submit<T>(ForkJoinTask<T> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<ForkJoinTask<T>>("submit", "(Ljava/util/concurrent/ForkJoinTask;)Ljava/util/concurrent/ForkJoinTask;", arg0);
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		public bool awaitQuiescence(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<bool>("awaitQuiescence", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ForkJoinPool;")]
		public static ForkJoinPool commonPool()
		{
			return Static.CallMethod<ForkJoinPool>(typeof(ForkJoinPool), "commonPool", "()Ljava/util/concurrent/ForkJoinPool;");
		}
		
		[JavaSignature("()I")]
		public int getActiveThreadCount()
		{
			return Instance.CallMethod<int>("getActiveThreadCount", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool getAsyncMode()
		{
			return Instance.CallMethod<bool>("getAsyncMode", "()Z");
		}
		
		[JavaSignature("()I")]
		public int getParallelism()
		{
			return Instance.CallMethod<int>("getParallelism", "()I");
		}
		
		[JavaSignature("()I")]
		public int getPoolSize()
		{
			return Instance.CallMethod<int>("getPoolSize", "()I");
		}
		
		[JavaSignature("()I")]
		public int getQueuedSubmissionCount()
		{
			return Instance.CallMethod<int>("getQueuedSubmissionCount", "()I");
		}
		
		[JavaSignature("()I")]
		public int getRunningThreadCount()
		{
			return Instance.CallMethod<int>("getRunningThreadCount", "()I");
		}
		
		[JavaSignature("()J")]
		public long getStealCount()
		{
			return Instance.CallMethod<long>("getStealCount", "()J");
		}
		
		[JavaSignature("()Z")]
		public bool hasQueuedSubmissions()
		{
			return Instance.CallMethod<bool>("hasQueuedSubmissions", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isQuiescent()
		{
			return Instance.CallMethod<bool>("isQuiescent", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isTerminating()
		{
			return Instance.CallMethod<bool>("isTerminating", "()Z");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ForkJoinPool/ManagedBlocker;)V")]
		public static void managedBlock(ForkJoinPool.ManagedBlocker arg0)
		{
			Static.CallMethod(typeof(ForkJoinPool), "managedBlock", "(Ljava/util/concurrent/ForkJoinPool/ManagedBlocker;)V", arg0);
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
		
		[JavaSignature("()J")]
		public long getQueuedTaskCount()
		{
			return Instance.CallMethod<long>("getQueuedTaskCount", "()J");
		}
	
		[JavaProxy("java/util/concurrent/ForkJoinPool/ForkJoinWorkerThreadFactory")]
		public interface ForkJoinWorkerThreadFactory : IJavaObject
		{
			[JavaSignature("(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;")]
			ForkJoinWorkerThread newThread(ForkJoinPool arg0);
		}
		
		[JavaProxy("java/util/concurrent/ForkJoinPool/ManagedBlocker")]
		public interface ManagedBlocker : IJavaObject
		{
			[JavaSignature("()Z")]
			bool block();
			
			[JavaSignature("()Z")]
			bool isReleasable();
		}
	}
}
