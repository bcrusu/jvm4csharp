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
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/AbstractCollection")]
	public abstract partial class AbstractCollection<E> : Object, Collection<E>
		where E : IJavaObject
	{
		protected AbstractCollection(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool @add(E arg0)
		{
			return Instance.CallMethod<bool>("add", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool @remove(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
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
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
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
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool addAll(Collection<E> arg0)
		{
			return Instance.CallMethod<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool containsAll(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool removeAll(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Z")]
		public bool retainAll(Collection<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		public Spliterator<E> spliterator()
		{
			return Instance.CallMethod<Spliterator<E>>("spliterator", "()Ljava/util/Spliterator;");
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
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		public void forEach(Consumer<IJavaObject> arg0)
		{
			Instance.CallMethod("forEach", "(Ljava/util/function/Consumer;)V", arg0);
		}
	}
}
