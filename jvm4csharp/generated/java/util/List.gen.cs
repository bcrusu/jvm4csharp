//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/List")]
	public interface List<E> : Collection<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @add(E arg0);
		
		[JavaSignature("(ILjava/lang/Object;)V")]
		void @add(int arg0, E arg1);
		
		[JavaSignature("(I)Ljava/lang/Object;")]
		E @remove(int arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @remove(IJavaObject arg0);
		
		[JavaSignature("(I)Ljava/lang/Object;")]
		E @get(int arg0);
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		int indexOf(IJavaObject arg0);
		
		[JavaSignature("()V")]
		new void clear();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool contains(IJavaObject arg0);
		
		[JavaSignature("()Z")]
		new bool isEmpty();
		
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<E> iterator();
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		int lastIndexOf(IJavaObject arg0);
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)V")]
		void replaceAll(UnaryOperator<E> arg0);
		
		[JavaSignature("()I")]
		new int size();
		
		[JavaSignature("(II)Ljava/util/List;")]
		List<E> subList(int arg0, int arg1);
		
		[JavaSignature("()[Ljava/lang/Object;")]
		new ObjectArray<IJavaObject> toArray();
		
		[JavaSignature("([Ljava/lang/Object;)[Ljava/lang/Object;")]
		new ObjectArray<T> toArray<T>(ObjectArray<T> arg0)
			where T : IJavaObject;
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		new Spliterator<E> spliterator();
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool addAll(Collection<E> arg0);
		
		[JavaSignature("(ILjava/util/Collection;)Z")]
		bool addAll(int arg0, Collection<E> arg1);
		
		[JavaSignature("(ILjava/lang/Object;)Ljava/lang/Object;")]
		E @set(int arg0, E arg1);
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool containsAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("(I)Ljava/util/ListIterator;")]
		ListIterator<E> listIterator(int arg0);
		
		[JavaSignature("()Ljava/util/ListIterator;")]
		ListIterator<E> listIterator();
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool removeAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool retainAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Comparator;)V")]
		void sort(Comparator<IJavaObject> arg0);
	}
}
