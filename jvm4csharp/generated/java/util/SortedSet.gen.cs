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
	[JavaProxy("java/util/SortedSet")]
	public partial interface SortedSet<E> : Set<E>
		where E : IJavaObject
	{
		[JavaSignature("()Ljava/util/Spliterator;")]
		new Spliterator<E> spliterator();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E first();
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> headSet(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> subSet(E arg0, E arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> tailSet(E arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		E last();
		
		[JavaSignature("()Ljava/util/Comparator;")]
		Comparator<IJavaObject> comparator();
	}
}
