//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ForkJoinTask")]
	public abstract partial class ForkJoinTask<V> : Object, Future<V>, Serializable
		where V : IJavaObject
	{
		protected ForkJoinTask(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public V invoke()
		{
			return Instance.CallMethod<V>("invoke", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		public V @get(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<V>("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public V @get()
		{
			return Instance.CallMethod<V>("get", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public V @join()
		{
			return Instance.CallMethod<V>("join", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Throwable;")]
		public Throwable getException()
		{
			return Instance.CallMethod<Throwable>("getException", "()Ljava/lang/Throwable;");
		}
		
		[JavaSignature("()V")]
		public void reinitialize()
		{
			Instance.CallMethod("reinitialize", "()V");
		}
		
		[JavaSignature("()Ljava/util/concurrent/ForkJoinPool;")]
		public static ForkJoinPool getPool()
		{
			return Static.CallMethod<ForkJoinPool>(typeof(ForkJoinTask<>), "getPool", "()Ljava/util/concurrent/ForkJoinPool;");
		}
		
		[JavaSignature("(Z)Z")]
		public bool cancel(bool arg0)
		{
			return Instance.CallMethod<bool>("cancel", "(Z)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isDone()
		{
			return Instance.CallMethod<bool>("isDone", "()Z");
		}
		
		[JavaSignature("()Ljava/util/concurrent/ForkJoinTask;")]
		public ForkJoinTask<V> fork()
		{
			return Instance.CallMethod<ForkJoinTask<V>>("fork", "()Ljava/util/concurrent/ForkJoinTask;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void complete(V arg0)
		{
			Instance.CallMethod("complete", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public V getRawResult()
		{
			return Instance.CallMethod<V>("getRawResult", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()V")]
		public void quietlyComplete()
		{
			Instance.CallMethod("quietlyComplete", "()V");
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;")]
		public static ForkJoinTask<IJavaObject> adapt(Runnable arg0)
		{
			return Static.CallMethod<ForkJoinTask<IJavaObject>>(typeof(ForkJoinTask<>), "adapt", "(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;")]
		public static ForkJoinTask<T> adapt<T>(Callable<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<ForkJoinTask<T>>(typeof(ForkJoinTask<>), "adapt", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ForkJoinTask;")]
		public static ForkJoinTask<T> adapt<T>(Runnable arg0, T arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<ForkJoinTask<T>>(typeof(ForkJoinTask<>), "adapt", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/ForkJoinTask;", arg0, arg1);
		}
		
		[JavaSignature("(SS)Z")]
		public bool compareAndSetForkJoinTaskTag(short arg0, short arg1)
		{
			return Instance.CallMethod<bool>("compareAndSetForkJoinTaskTag", "(SS)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Throwable;)V")]
		public void completeExceptionally(Throwable arg0)
		{
			Instance.CallMethod("completeExceptionally", "(Ljava/lang/Throwable;)V", arg0);
		}
		
		[JavaSignature("()S")]
		public short getForkJoinTaskTag()
		{
			return Instance.CallMethod<short>("getForkJoinTaskTag", "()S");
		}
		
		[JavaSignature("()I")]
		public static int getQueuedTaskCount()
		{
			return Static.CallMethod<int>(typeof(ForkJoinTask<>), "getQueuedTaskCount", "()I");
		}
		
		[JavaSignature("()I")]
		public static int getSurplusQueuedTaskCount()
		{
			return Static.CallMethod<int>(typeof(ForkJoinTask<>), "getSurplusQueuedTaskCount", "()I");
		}
		
		[JavaSignature("()V")]
		public static void helpQuiesce()
		{
			Static.CallMethod(typeof(ForkJoinTask<>), "helpQuiesce", "()V");
		}
		
		[JavaSignature("()Z")]
		public static bool inForkJoinPool()
		{
			return Static.CallMethod<bool>(typeof(ForkJoinTask<>), "inForkJoinPool", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isCancelled()
		{
			return Instance.CallMethod<bool>("isCancelled", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isCompletedAbnormally()
		{
			return Instance.CallMethod<bool>("isCompletedAbnormally", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isCompletedNormally()
		{
			return Instance.CallMethod<bool>("isCompletedNormally", "()Z");
		}
		
		[JavaSignature("()V")]
		public void quietlyInvoke()
		{
			Instance.CallMethod("quietlyInvoke", "()V");
		}
		
		[JavaSignature("()V")]
		public void quietlyJoin()
		{
			Instance.CallMethod("quietlyJoin", "()V");
		}
		
		[JavaSignature("(S)S")]
		public short setForkJoinTaskTag(short arg0)
		{
			return Instance.CallMethod<short>("setForkJoinTaskTag", "(S)S", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool tryUnfork()
		{
			return Instance.CallMethod<bool>("tryUnfork", "()Z");
		}
		
		[JavaSignature("([Ljava/util/concurrent/ForkJoinTask;)V")]
		public static void invokeAll(ObjectArray<ForkJoinTask<IJavaObject>> arg0)
		{
			Static.CallMethod(typeof(ForkJoinTask<>), "invokeAll", "([Ljava/util/concurrent/ForkJoinTask;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinTask;)V")]
		public static void invokeAll(ForkJoinTask<IJavaObject> arg0, ForkJoinTask<IJavaObject> arg1)
		{
			Static.CallMethod(typeof(ForkJoinTask<>), "invokeAll", "(Ljava/util/concurrent/ForkJoinTask;Ljava/util/concurrent/ForkJoinTask;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/util/Collection;")]
		public static Collection<T> invokeAll<T>(Collection<T> arg0)
			where T : ForkJoinTask<IJavaObject>
		{
			return Static.CallMethod<Collection<T>>(typeof(ForkJoinTask<>), "invokeAll", "(Ljava/util/Collection;)Ljava/util/Collection;", arg0);
		}
	}
}
