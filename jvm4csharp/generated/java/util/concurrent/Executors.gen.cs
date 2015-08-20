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
	[JavaProxy("java/util/concurrent/Executors")]
	public partial class Executors : Object
	{
		protected Executors(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(I)Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newFixedThreadPool(int arg0)
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;", arg0);
		}
		
		[JavaSignature("(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newFixedThreadPool(int arg0, ThreadFactory arg1)
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;")]
		public static Callable<IJavaObject> callable(Runnable arg0)
		{
			return Static.CallMethod<Callable<IJavaObject>>(typeof(Executors), "callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;")]
		public static Callable<T> callable<T>(Runnable arg0, T arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<Callable<T>>(typeof(Executors), "callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ThreadFactory;")]
		public static ThreadFactory defaultThreadFactory()
		{
			return Static.CallMethod<ThreadFactory>(typeof(Executors), "defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newCachedThreadPool(ThreadFactory arg0)
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newCachedThreadPool()
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
		}
		
		[JavaSignature("(I)Ljava/util/concurrent/ScheduledExecutorService;")]
		public static ScheduledExecutorService newScheduledThreadPool(int arg0)
		{
			return Static.CallMethod<ScheduledExecutorService>(typeof(Executors), "newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
		}
		
		[JavaSignature("(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;")]
		public static ScheduledExecutorService newScheduledThreadPool(int arg0, ThreadFactory arg1)
		{
			return Static.CallMethod<ScheduledExecutorService>(typeof(Executors), "newScheduledThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newSingleThreadExecutor()
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newSingleThreadExecutor(ThreadFactory arg0)
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ScheduledExecutorService;")]
		public static ScheduledExecutorService newSingleThreadScheduledExecutor()
		{
			return Static.CallMethod<ScheduledExecutorService>(typeof(Executors), "newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;")]
		public static ScheduledExecutorService newSingleThreadScheduledExecutor(ThreadFactory arg0)
		{
			return Static.CallMethod<ScheduledExecutorService>(typeof(Executors), "newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
		}
		
		[JavaSignature("(I)Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newWorkStealingPool(int arg0)
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newWorkStealingPool", "(I)Ljava/util/concurrent/ExecutorService;", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService newWorkStealingPool()
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "newWorkStealingPool", "()Ljava/util/concurrent/ExecutorService;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;")]
		public static Callable<T> privilegedCallable<T>(Callable<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Callable<T>>(typeof(Executors), "privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;")]
		public static Callable<T> privilegedCallableUsingCurrentClassLoader<T>(Callable<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Callable<T>>(typeof(Executors), "privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ThreadFactory;")]
		public static ThreadFactory privilegedThreadFactory()
		{
			return Static.CallMethod<ThreadFactory>(typeof(Executors), "privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;")]
		public static ExecutorService unconfigurableExecutorService(ExecutorService arg0)
		{
			return Static.CallMethod<ExecutorService>(typeof(Executors), "unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;")]
		public static ScheduledExecutorService unconfigurableScheduledExecutorService(ScheduledExecutorService arg0)
		{
			return Static.CallMethod<ScheduledExecutorService>(typeof(Executors), "unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
		}
	}
}
