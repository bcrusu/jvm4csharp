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
	[JavaProxy("java/util/NavigableSet")]
	public partial interface NavigableSet<E> : SortedSet<E>
		where E : IJavaObject
	{
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<E> iterator();
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		E floor(E arg0);
		
		[JavaSignature("()Ljava/util/Iterator;")]
		Iterator<E> descendingIterator();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E pollFirst();
		
		[JavaSignature("()Ljava/lang/Object;")]
		E pollLast();
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		E ceiling(E arg0);
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		NavigableSet<E> descendingSet();
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableSet;")]
		NavigableSet<E> headSet(E arg0, bool arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		new SortedSet<E> headSet(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		E higher(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		E lower(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;")]
		new SortedSet<E> subSet(E arg0, E arg1);
		
		[JavaSignature("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;")]
		NavigableSet<E> subSet(E arg0, bool arg1, E arg2, bool arg3);
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableSet;")]
		NavigableSet<E> tailSet(E arg0, bool arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		new SortedSet<E> tailSet(E arg0);
	}
}
