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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/CopyOnWriteArrayList")]
	public partial class CopyOnWriteArrayList<E> : Object, List<E>, RandomAccess, Cloneable, Serializable
		where E : IJavaObject
	{
		protected CopyOnWriteArrayList(ProxyCtor p) : base(p) {}
		
		public CopyOnWriteArrayList(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public CopyOnWriteArrayList() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public CopyOnWriteArrayList(ObjectArray<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([Ljava/lang/Object;)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool @add(E arg0)
		{
			return Instance.CallMethod<bool>("add", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(ILjava/lang/Object;)V")]
		public void @add(int arg0, E arg1)
		{
			Instance.CallMethod("add", "(ILjava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool @remove(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/Object;")]
		public E @remove(int arg0)
		{
			return Instance.CallMethod<E>("remove", "(I)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/Object;")]
		public E @get(int arg0)
		{
			return Instance.CallMethod<E>("get", "(I)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public int indexOf(E arg0, int arg1)
		{
			return Instance.CallMethod<int>("indexOf", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int indexOf(IJavaObject arg0)
		{
			return Instance.CallMethod<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool contains(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isEmpty()
		{
			return Instance.CallMethod<bool>("isEmpty", "()Z");
		}
		
		[JavaSignature("()Ljava/util/Iterator;")]
		public Iterator<E> iterator()
		{
			return Instance.CallMethod<Iterator<E>>("iterator", "()Ljava/util/Iterator;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int lastIndexOf(IJavaObject arg0)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public int lastIndexOf(E arg0, int arg1)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)V")]
		public void replaceAll(UnaryOperator<E> arg0)
		{
			Instance.CallMethod("replaceAll", "(Ljava/util/function/UnaryOperator;)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("(II)Ljava/util/List;")]
		public List<E> subList(int arg0, int arg1)
		{
			return Instance.CallMethod<List<E>>("subList", "(II)Ljava/util/List;", arg0, arg1);
		}
		
		[JavaSignature("()[Ljava/lang/Object;")]
		public ObjectArray<IJavaObject> toArray()
		{
			return Instance.CallMethod<ObjectArray<IJavaObject>>("toArray", "()[Ljava/lang/Object;");
		}
		
		[JavaSignature("([Ljava/lang/Object;)[Ljava/lang/Object;")]
		public ObjectArray<T> toArray<T>(ObjectArray<T> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<ObjectArray<T>>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		public Spliterator<E> spliterator()
		{
			return Instance.CallMethod<Spliterator<E>>("spliterator", "()Ljava/util/Spliterator;");
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool addAll(Collection<E> arg0)
		{
			return Instance.CallMethod<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("(ILjava/util/Collection;)Z")]
		public bool addAll(int arg0, Collection<E> arg1)
		{
			return Instance.CallMethod<bool>("addAll", "(ILjava/util/Collection;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		public void forEach(Consumer<IJavaObject> arg0)
		{
			Instance.CallMethod("forEach", "(Ljava/util/function/Consumer;)V", arg0);
		}
		
		[JavaSignature("(ILjava/lang/Object;)Ljava/lang/Object;")]
		public E @set(int arg0, E arg1)
		{
			return Instance.CallMethod<E>("set", "(ILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool containsAll(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/ListIterator;")]
		public ListIterator<E> listIterator()
		{
			return Instance.CallMethod<ListIterator<E>>("listIterator", "()Ljava/util/ListIterator;");
		}
		
		[JavaSignature("(I)Ljava/util/ListIterator;")]
		public ListIterator<E> listIterator(int arg0)
		{
			return Instance.CallMethod<ListIterator<E>>("listIterator", "(I)Ljava/util/ListIterator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool removeAll(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		public bool removeIf(Predicate<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool retainAll(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)V")]
		public void sort(Comparator<IJavaObject> arg0)
		{
			Instance.CallMethod("sort", "(Ljava/util/Comparator;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)I")]
		public int addAllAbsent(Collection<E> arg0)
		{
			return Instance.CallMethod<int>("addAllAbsent", "(Ljava/util/Collection;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool addIfAbsent(E arg0)
		{
			return Instance.CallMethod<bool>("addIfAbsent", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<E> stream()
		{
			return Instance.CallMethod<Stream<E>>("stream", "()Ljava/util/stream/Stream;");
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<E> parallelStream()
		{
			return Instance.CallMethod<Stream<E>>("parallelStream", "()Ljava/util/stream/Stream;");
		}
	}
}
