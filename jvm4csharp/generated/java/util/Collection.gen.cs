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
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Collection")]
	public interface Collection<E> : Iterable<E>
		where E : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool @add(E arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool @remove(IJavaObject arg0);
		
		[JavaSignature("()V")]
		void clear();
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool contains(IJavaObject arg0);
		
		[JavaSignature("()Z")]
		bool isEmpty();
		
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<E> iterator();
		
		[JavaSignature("()I")]
		int size();
		
		[JavaSignature("([Ljava/lang/Object;)[Ljava/lang/Object;")]
		ObjectArray<T> toArray<T>(ObjectArray<T> arg0)
			where T : IJavaObject;
		
		[JavaSignature("()[Ljava/lang/Object;")]
		ObjectArray<IJavaObject> toArray();
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		new Spliterator<E> spliterator();
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		bool addAll(Collection<E> arg0);
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		Stream<E> stream();
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		bool containsAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		bool removeAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		bool removeIf(Predicate<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		bool retainAll(Collection<IJavaObject> arg0);
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		Stream<E> parallelStream();
	}
}
