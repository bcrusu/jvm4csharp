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
	[JavaProxy("java/util/ListIterator")]
	public interface ListIterator<E> : Iterator<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)V")]
		void @add(E arg0);
		
		[JavaSignature("()V")]
		new void @remove();
		
		[JavaSignature("()Z")]
		new bool hasNext();
		
		[JavaSignature("()Ljava/lang/Object;")]
		new E next();
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void @set(E arg0);
		
		[JavaSignature("()Z")]
		bool hasPrevious();
		
		[JavaSignature("()I")]
		int nextIndex();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E previous();
		
		[JavaSignature("()I")]
		int previousIndex();
	}
}
