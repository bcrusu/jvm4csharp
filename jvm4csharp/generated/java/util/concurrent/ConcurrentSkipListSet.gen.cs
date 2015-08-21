//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ConcurrentSkipListSet")]
	public partial class ConcurrentSkipListSet<E> : AbstractSet<E>, NavigableSet<E>, Cloneable, Serializable
		where E : IJavaObject
	{
		protected ConcurrentSkipListSet(ProxyCtor p) : base(p) {}
		
		public ConcurrentSkipListSet(SortedSet<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/SortedSet;)V", arg0);
		}
		
		public ConcurrentSkipListSet(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public ConcurrentSkipListSet(Comparator<IJavaObject> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Comparator;)V", arg0);
		}
		
		public ConcurrentSkipListSet() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()Ljava/util/concurrent/ConcurrentSkipListSet;")]
		public ConcurrentSkipListSet<E> clone()
		{
			return Instance.CallMethod<ConcurrentSkipListSet<E>>("clone", "()Ljava/util/concurrent/ConcurrentSkipListSet;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E first()
		{
			return Instance.CallMethod<E>("first", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public E floor(E arg0)
		{
			return Instance.CallMethod<E>("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public E ceiling(E arg0)
		{
			return Instance.CallMethod<E>("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		public NavigableSet<E> descendingSet()
		{
			return Instance.CallMethod<NavigableSet<E>>("descendingSet", "()Ljava/util/NavigableSet;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/NavigableSet;")]
		public NavigableSet<E> headSet(E arg0)
		{
			return Instance.CallMethod<NavigableSet<E>>("headSet", "(Ljava/lang/Object;)Ljava/util/NavigableSet;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableSet;")]
		public NavigableSet<E> headSet(E arg0, bool arg1)
		{
			return Instance.CallMethod<NavigableSet<E>>("headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public E higher(E arg0)
		{
			return Instance.CallMethod<E>("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public E lower(E arg0)
		{
			return Instance.CallMethod<E>("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/NavigableSet;")]
		public NavigableSet<E> subSet(E arg0, E arg1)
		{
			return Instance.CallMethod<NavigableSet<E>>("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/NavigableSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;")]
		public NavigableSet<E> subSet(E arg0, bool arg1, E arg2, bool arg3)
		{
			return Instance.CallMethod<NavigableSet<E>>("subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableSet;")]
		public NavigableSet<E> tailSet(E arg0, bool arg1)
		{
			return Instance.CallMethod<NavigableSet<E>>("tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/NavigableSet;")]
		public NavigableSet<E> tailSet(E arg0)
		{
			return Instance.CallMethod<NavigableSet<E>>("tailSet", "(Ljava/lang/Object;)Ljava/util/NavigableSet;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Iterator;")]
		public Iterator<E> descendingIterator()
		{
			return Instance.CallMethod<Iterator<E>>("descendingIterator", "()Ljava/util/Iterator;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E pollFirst()
		{
			return Instance.CallMethod<E>("pollFirst", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E pollLast()
		{
			return Instance.CallMethod<E>("pollLast", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E last()
		{
			return Instance.CallMethod<E>("last", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/util/Comparator;")]
		public Comparator<IJavaObject> comparator()
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("comparator", "()Ljava/util/Comparator;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> NavigableSet<E>.headSet(E arg0)
		{
			return Instance.CallMethod<SortedSet<E>>("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> NavigableSet<E>.subSet(E arg0, E arg1)
		{
			return Instance.CallMethod<SortedSet<E>>("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> NavigableSet<E>.tailSet(E arg0)
		{
			return Instance.CallMethod<SortedSet<E>>("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> SortedSet<E>.headSet(E arg0)
		{
			return Instance.CallMethod<SortedSet<E>>("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> SortedSet<E>.subSet(E arg0, E arg1)
		{
			return Instance.CallMethod<SortedSet<E>>("subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedSet;")]
		SortedSet<E> SortedSet<E>.tailSet(E arg0)
		{
			return Instance.CallMethod<SortedSet<E>>("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
		}
	}
}
