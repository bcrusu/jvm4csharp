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
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/AbstractList")]
	public abstract class AbstractList<E> : AbstractCollection<E>, List<E>
		where E : IJavaObject
	{
		protected AbstractList(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(ILjava/lang/Object;)V")]
		public void @add(int arg0, E arg1)
		{
			Instance.CallMethod("add", "(ILjava/lang/Object;)V", arg0, arg1);
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
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int indexOf(IJavaObject arg0)
		{
			return Instance.CallMethod<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int lastIndexOf(IJavaObject arg0)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(II)Ljava/util/List;")]
		public List<E> subList(int arg0, int arg1)
		{
			return Instance.CallMethod<List<E>>("subList", "(II)Ljava/util/List;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/Collection;)Z")]
		public bool addAll(int arg0, Collection<E> arg1)
		{
			return Instance.CallMethod<bool>("addAll", "(ILjava/util/Collection;)Z", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/Object;)Ljava/lang/Object;")]
		public E @set(int arg0, E arg1)
		{
			return Instance.CallMethod<E>("set", "(ILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/util/ListIterator;")]
		public ListIterator<E> listIterator(int arg0)
		{
			return Instance.CallMethod<ListIterator<E>>("listIterator", "(I)Ljava/util/ListIterator;", arg0);
		}
		
		[JavaSignature("()Ljava/util/ListIterator;")]
		public ListIterator<E> listIterator()
		{
			return Instance.CallMethod<ListIterator<E>>("listIterator", "()Ljava/util/ListIterator;");
		}
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)V")]
		public void replaceAll(UnaryOperator<E> arg0)
		{
			Instance.CallMethod("replaceAll", "(Ljava/util/function/UnaryOperator;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)V")]
		public void sort(Comparator<IJavaObject> arg0)
		{
			Instance.CallMethod("sort", "(Ljava/util/Comparator;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<E> stream()
		{
			return Instance.CallMethod<Stream<E>>("stream", "()Ljava/util/stream/Stream;");
		}
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		public bool removeIf(Predicate<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<E> parallelStream()
		{
			return Instance.CallMethod<Stream<E>>("parallelStream", "()Ljava/util/stream/Stream;");
		}
	}
}
