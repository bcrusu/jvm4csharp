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
	[JavaProxy("java/util/concurrent/CompletionService")]
	public interface CompletionService<V> : IJavaObject
		where V : IJavaObject
	{
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;")]
		Future<V> poll(long arg0, TimeUnit arg1);
		
		[JavaSignature("()Ljava/util/concurrent/Future;")]
		Future<V> poll();
		
		[JavaSignature("(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;")]
		Future<V> submit(Callable<V> arg0);
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;")]
		Future<V> submit(Runnable arg0, V arg1);
		
		[JavaSignature("()Ljava/util/concurrent/Future;")]
		Future<V> take();
	}
}
