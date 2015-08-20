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
	[JavaProxy("java/util/concurrent/FutureTask")]
	public partial class FutureTask<V> : Object, RunnableFuture<V>
		where V : IJavaObject
	{
		protected FutureTask(ProxyCtor p) : base(p) {}
		
		public FutureTask(Runnable arg0, V arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Runnable;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		public FutureTask(Callable<V> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/concurrent/Callable;)V", arg0);
		}
	
		[JavaSignature("()V")]
		public void run()
		{
			Instance.CallMethod("run", "()V");
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
		
		[JavaSignature("()Z")]
		public bool isCancelled()
		{
			return Instance.CallMethod<bool>("isCancelled", "()Z");
		}
	}
}
