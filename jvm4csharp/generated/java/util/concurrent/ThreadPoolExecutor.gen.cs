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
	[JavaProxy("java/util/concurrent/ThreadPoolExecutor")]
	public class ThreadPoolExecutor : AbstractExecutorService
	{
		protected ThreadPoolExecutor(ProxyCtor p) : base(p) {}
		
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, TimeUnit arg3, BlockingQueue<Runnable> arg4, ThreadFactory arg5) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, TimeUnit arg3, BlockingQueue<Runnable> arg4, RejectedExecutionHandler arg5) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/RejectedExecutionHandler;)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, TimeUnit arg3, BlockingQueue<Runnable> arg4, ThreadFactory arg5, RejectedExecutionHandler arg6) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}
		
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, TimeUnit arg3, BlockingQueue<Runnable> arg4) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;)V", arg0, arg1, arg2, arg3, arg4);
		}
	
		[JavaSignature("(Ljava/lang/Runnable;)Z")]
		public bool @remove(Runnable arg0)
		{
			return Instance.CallMethod<bool>("remove", "(Ljava/lang/Runnable;)Z", arg0);
		}
		
		[JavaSignature("()V")]
		public void shutdown()
		{
			Instance.CallMethod("shutdown", "()V");
		}
		
		[JavaSignature("()I")]
		public int getMaximumPoolSize()
		{
			return Instance.CallMethod<int>("getMaximumPoolSize", "()I");
		}
		
		[JavaSignature("(Z)V")]
		public void allowCoreThreadTimeOut(bool arg0)
		{
			Instance.CallMethod("allowCoreThreadTimeOut", "(Z)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool allowsCoreThreadTimeOut()
		{
			return Instance.CallMethod<bool>("allowsCoreThreadTimeOut", "()Z");
		}
		
		[JavaSignature("()I")]
		public int getActiveCount()
		{
			return Instance.CallMethod<int>("getActiveCount", "()I");
		}
		
		[JavaSignature("()J")]
		public long getCompletedTaskCount()
		{
			return Instance.CallMethod<long>("getCompletedTaskCount", "()J");
		}
		
		[JavaSignature("()I")]
		public int getCorePoolSize()
		{
			return Instance.CallMethod<int>("getCorePoolSize", "()I");
		}
		
		[JavaSignature("(Ljava/util/concurrent/TimeUnit;)J")]
		public long getKeepAliveTime(TimeUnit arg0)
		{
			return Instance.CallMethod<long>("getKeepAliveTime", "(Ljava/util/concurrent/TimeUnit;)J", arg0);
		}
		
		[JavaSignature("()I")]
		public int getLargestPoolSize()
		{
			return Instance.CallMethod<int>("getLargestPoolSize", "()I");
		}
		
		[JavaSignature("()Ljava/util/concurrent/BlockingQueue;")]
		public BlockingQueue<Runnable> getQueue()
		{
			return Instance.CallMethod<BlockingQueue<Runnable>>("getQueue", "()Ljava/util/concurrent/BlockingQueue;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/RejectedExecutionHandler;")]
		public RejectedExecutionHandler getRejectedExecutionHandler()
		{
			return Instance.CallMethod<RejectedExecutionHandler>("getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;");
		}
		
		[JavaSignature("()J")]
		public long getTaskCount()
		{
			return Instance.CallMethod<long>("getTaskCount", "()J");
		}
		
		[JavaSignature("()Ljava/util/concurrent/ThreadFactory;")]
		public ThreadFactory getThreadFactory()
		{
			return Instance.CallMethod<ThreadFactory>("getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
		}
		
		[JavaSignature("()I")]
		public int prestartAllCoreThreads()
		{
			return Instance.CallMethod<int>("prestartAllCoreThreads", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool prestartCoreThread()
		{
			return Instance.CallMethod<bool>("prestartCoreThread", "()Z");
		}
		
		[JavaSignature("()V")]
		public void purge()
		{
			Instance.CallMethod("purge", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void setCorePoolSize(int arg0)
		{
			Instance.CallMethod("setCorePoolSize", "(I)V", arg0);
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)V")]
		public void setKeepAliveTime(long arg0, TimeUnit arg1)
		{
			Instance.CallMethod("setKeepAliveTime", "(JLjava/util/concurrent/TimeUnit;)V", arg0, arg1);
		}
		
		[JavaSignature("(I)V")]
		public void setMaximumPoolSize(int arg0)
		{
			Instance.CallMethod("setMaximumPoolSize", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/RejectedExecutionHandler;)V")]
		public void setRejectedExecutionHandler(RejectedExecutionHandler arg0)
		{
			Instance.CallMethod("setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/ThreadFactory;)V")]
		public void setThreadFactory(ThreadFactory arg0)
		{
			Instance.CallMethod("setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int getPoolSize()
		{
			return Instance.CallMethod<int>("getPoolSize", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isTerminating()
		{
			return Instance.CallMethod<bool>("isTerminating", "()Z");
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
	
		[JavaProxy("java/util/concurrent/ThreadPoolExecutor/AbortPolicy")]
		public class AbortPolicy : Object, RejectedExecutionHandler
		{
			protected AbortPolicy(ProxyCtor p) : base(p) {}
			
			public AbortPolicy() : base(ProxyCtor.I)
			{
				Instance.CallConstructor("()V");
			}
		
			[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V")]
			public void rejectedExecution(Runnable arg0, ThreadPoolExecutor arg1)
			{
				Instance.CallMethod("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", arg0, arg1);
			}
		}
		
		[JavaProxy("java/util/concurrent/ThreadPoolExecutor/CallerRunsPolicy")]
		public class CallerRunsPolicy : Object, RejectedExecutionHandler
		{
			protected CallerRunsPolicy(ProxyCtor p) : base(p) {}
			
			public CallerRunsPolicy() : base(ProxyCtor.I)
			{
				Instance.CallConstructor("()V");
			}
		
			[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V")]
			public void rejectedExecution(Runnable arg0, ThreadPoolExecutor arg1)
			{
				Instance.CallMethod("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", arg0, arg1);
			}
		}
		
		[JavaProxy("java/util/concurrent/ThreadPoolExecutor/DiscardOldestPolicy")]
		public class DiscardOldestPolicy : Object, RejectedExecutionHandler
		{
			protected DiscardOldestPolicy(ProxyCtor p) : base(p) {}
			
			public DiscardOldestPolicy() : base(ProxyCtor.I)
			{
				Instance.CallConstructor("()V");
			}
		
			[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V")]
			public void rejectedExecution(Runnable arg0, ThreadPoolExecutor arg1)
			{
				Instance.CallMethod("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", arg0, arg1);
			}
		}
		
		[JavaProxy("java/util/concurrent/ThreadPoolExecutor/DiscardPolicy")]
		public class DiscardPolicy : Object, RejectedExecutionHandler
		{
			protected DiscardPolicy(ProxyCtor p) : base(p) {}
			
			public DiscardPolicy() : base(ProxyCtor.I)
			{
				Instance.CallConstructor("()V");
			}
		
			[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V")]
			public void rejectedExecution(Runnable arg0, ThreadPoolExecutor arg1)
			{
				Instance.CallMethod("rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", arg0, arg1);
			}
		}
	}
}
