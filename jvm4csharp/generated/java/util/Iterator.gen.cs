//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Iterator")]
	public interface Iterator<E> : IJavaObject
		where E : IJavaObject
	{
		[JavaSignature("()V")]
		void @remove();
		
		[JavaSignature("()Z")]
		bool hasNext();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E next();
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		void forEachRemaining(Consumer<IJavaObject> arg0);
	}
}
