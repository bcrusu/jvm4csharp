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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Set")]
	public partial interface Set<E> : Collection<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @add(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool @remove(IJavaObject arg0);
		
		[JavaSignature("()V")]
		new void clear();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		new bool contains(IJavaObject arg0);
		
		[JavaSignature("()Z")]
		new bool isEmpty();
		
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<E> iterator();
		
		[JavaSignature("()I")]
		new int size();
		
		[JavaSignature("()[Ljava/lang/Object;")]
		new ObjectArray<IJavaObject> toArray();
		
		[JavaSignature("([Ljava/lang/Object;)[Ljava/lang/Object;")]
		new ObjectArray<T> toArray<T>(ObjectArray<T> arg0)
			where T : IJavaObject;
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		new Spliterator<E> spliterator();
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool addAll(Collection<E> arg0);
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool containsAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool removeAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		new bool retainAll(Collection<IJavaObject> arg0);
	}
}
