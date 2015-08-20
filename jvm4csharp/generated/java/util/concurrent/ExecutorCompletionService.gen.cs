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
	[JavaProxy("java/util/concurrent/ExecutorCompletionService")]
	public partial class ExecutorCompletionService<V> : Object, CompletionService<V>
		where V : IJavaObject
	{
		protected ExecutorCompletionService(ProxyCtor p) : base(p) {}
		
		public ExecutorCompletionService(Executor arg0, BlockingQueue<Future<V>> arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V", arg0, arg1);
		}
		
		public ExecutorCompletionService(Executor arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/concurrent/Executor;)V", arg0);
		}
	
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;")]
		public Future<V> poll(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<Future<V>>("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/Future;")]
		public Future<V> poll()
		{
			return Instance.CallMethod<Future<V>>("poll", "()Ljava/util/concurrent/Future;");
		}
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;")]
		public Future<V> submit(Runnable arg0, V arg1)
		{
			return Instance.CallMethod<Future<V>>("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;")]
		public Future<V> submit(Callable<V> arg0)
		{
			return Instance.CallMethod<Future<V>>("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/Future;")]
		public Future<V> take()
		{
			return Instance.CallMethod<Future<V>>("take", "()Ljava/util/concurrent/Future;");
		}
	}
}
