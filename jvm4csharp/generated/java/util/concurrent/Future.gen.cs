//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/Future")]
	public interface Future<V> : IJavaObject
		where V : IJavaObject
	{
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		V @get(long arg0, TimeUnit arg1);
		
		[JavaSignature("()Ljava/lang/Object;")]
		V @get();
		
		[JavaSignature("(Z)Z")]
		bool cancel(bool arg0);
		
		[JavaSignature("()Z")]
		bool isDone();
		
		[JavaSignature("()Z")]
		bool isCancelled();
	}
}
