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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Queue")]
	public interface Queue<E> : Collection<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @add(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		E @remove();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E poll();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E peek();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E element();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool offer(E arg0);
	}
}
