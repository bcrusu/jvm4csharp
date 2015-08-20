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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Collections")]
	public partial class Collections : Object
	{
		protected Collections(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/util/Set;")]
		public static Set<IJavaObject> EMPTY_SET
		{
			get { return Static.GetField<Set<IJavaObject>>(typeof(Collections), "EMPTY_SET", "Ljava/util/Set;"); }
		}
		
		[JavaSignature("Ljava/util/List;")]
		public static List<IJavaObject> EMPTY_LIST
		{
			get { return Static.GetField<List<IJavaObject>>(typeof(Collections), "EMPTY_LIST", "Ljava/util/List;"); }
		}
		
		[JavaSignature("Ljava/util/Map;")]
		public static Map<IJavaObject, IJavaObject> EMPTY_MAP
		{
			get { return Static.GetField<Map<IJavaObject, IJavaObject>>(typeof(Collections), "EMPTY_MAP", "Ljava/util/Map;"); }
		}
	
		[JavaSignature("(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;")]
		public static T min<T>(Collection<T> arg0, Comparator<IJavaObject> arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<T>(typeof(Collections), "min", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/lang/Object;")]
		public static T min<T>(Collection<T> arg0)
			where T : IJavaObject, Comparable<IJavaObject>
		{
			return Static.CallMethod<T>(typeof(Collections), "min", "(Ljava/util/Collection;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;")]
		public static T max<T>(Collection<T> arg0, Comparator<IJavaObject> arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<T>(typeof(Collections), "max", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/lang/Object;")]
		public static T max<T>(Collection<T> arg0)
			where T : IJavaObject, Comparable<IJavaObject>
		{
			return Static.CallMethod<T>(typeof(Collections), "max", "(Ljava/util/Collection;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public static bool replaceAll<T>(List<T> arg0, T arg1, T arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<bool>(typeof(Collections), "replaceAll", "(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/Collection;[Ljava/lang/Object;)Z")]
		public static bool addAll<T>(Collection<IJavaObject> arg0, ObjectArray<T> arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<bool>(typeof(Collections), "addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public static Enumeration<T> emptyEnumeration<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Enumeration<T>>(typeof(Collections), "emptyEnumeration", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("(Ljava/util/Set;)Ljava/util/Set;")]
		public static Set<T> synchronizedSet<T>(Set<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Set<T>>(typeof(Collections), "synchronizedSet", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Map;)Ljava/util/Set;")]
		public static Set<E> newSetFromMap<E>(Map<E, Boolean> arg0)
			where E : IJavaObject
		{
			return Static.CallMethod<Set<E>>(typeof(Collections), "newSetFromMap", "(Ljava/util/Map;)Ljava/util/Set;", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;)Ljava/util/List;")]
		public static List<T> unmodifiableList<T>(List<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<List<T>>(typeof(Collections), "unmodifiableList", "(Ljava/util/List;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Enumeration;)Ljava/util/ArrayList;")]
		public static ArrayList<T> list<T>(Enumeration<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<ArrayList<T>>(typeof(Collections), "list", "(Ljava/util/Enumeration;)Ljava/util/ArrayList;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Iterator;")]
		public static Iterator<T> emptyIterator<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Iterator<T>>(typeof(Collections), "emptyIterator", "()Ljava/util/Iterator;");
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/util/Collection;")]
		public static Collection<T> synchronizedCollection<T>(Collection<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collection<T>>(typeof(Collections), "synchronizedCollection", "(Ljava/util/Collection;)Ljava/util/Collection;", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/List;)V")]
		public static void copy<T>(List<IJavaObject> arg0, List<T> arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Collections), "copy", "(Ljava/util/List;Ljava/util/List;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/lang/Object;)V")]
		public static void fill<T>(List<IJavaObject> arg0, T arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Collections), "fill", "(Ljava/util/List;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/Object;)Ljava/util/List;")]
		public static List<T> nCopies<T>(int arg0, T arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<List<T>>(typeof(Collections), "nCopies", "(ILjava/lang/Object;)Ljava/util/List;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;)V")]
		public static void reverse(List<IJavaObject> arg0)
		{
			Static.CallMethod(typeof(Collections), "reverse", "(Ljava/util/List;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Comparator;")]
		public static Comparator<T> reverseOrder<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Comparator<T>>(typeof(Collections), "reverseOrder", "()Ljava/util/Comparator;");
		}
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Comparator;")]
		public static Comparator<T> reverseOrder<T>(Comparator<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Comparator<T>>(typeof(Collections), "reverseOrder", "(Ljava/util/Comparator;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Comparator;)V")]
		public static void sort<T>(List<T> arg0, Comparator<IJavaObject> arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Collections), "sort", "(Ljava/util/List;Ljava/util/Comparator;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;)V")]
		public static void sort<T>(List<T> arg0)
			where T : Comparable<IJavaObject>
		{
			Static.CallMethod(typeof(Collections), "sort", "(Ljava/util/List;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;)Ljava/util/List;")]
		public static List<T> synchronizedList<T>(List<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<List<T>>(typeof(Collections), "synchronizedList", "(Ljava/util/List;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Deque;)Ljava/util/Queue;")]
		public static Queue<T> asLifoQueue<T>(Deque<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Queue<T>>(typeof(Collections), "asLifoQueue", "(Ljava/util/Deque;)Ljava/util/Queue;", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I")]
		public static int binarySearch<T>(List<T> arg0, T arg1, Comparator<IJavaObject> arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<int>(typeof(Collections), "binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/lang/Object;)I")]
		public static int binarySearch<T>(List<Comparable<IJavaObject>> arg0, T arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<int>(typeof(Collections), "binarySearch", "(Ljava/util/List;Ljava/lang/Object;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;")]
		public static Collection<E> checkedCollection<E>(Collection<E> arg0, Class<E> arg1)
			where E : IJavaObject
		{
			return Static.CallMethod<Collection<E>>(typeof(Collections), "checkedCollection", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;")]
		public static List<E> checkedList<E>(List<E> arg0, Class<E> arg1)
			where E : IJavaObject
		{
			return Static.CallMethod<List<E>>(typeof(Collections), "checkedList", "(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;")]
		public static Map<K, V> checkedMap<K, V>(Map<K, V> arg0, Class<K> arg1, Class<V> arg2)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<Map<K, V>>(typeof(Collections), "checkedMap", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/NavigableMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/NavigableMap;")]
		public static NavigableMap<K, V> checkedNavigableMap<K, V>(NavigableMap<K, V> arg0, Class<K> arg1, Class<V> arg2)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<NavigableMap<K, V>>(typeof(Collections), "checkedNavigableMap", "(Ljava/util/NavigableMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/NavigableMap;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/NavigableSet;Ljava/lang/Class;)Ljava/util/NavigableSet;")]
		public static NavigableSet<E> checkedNavigableSet<E>(NavigableSet<E> arg0, Class<E> arg1)
			where E : IJavaObject
		{
			return Static.CallMethod<NavigableSet<E>>(typeof(Collections), "checkedNavigableSet", "(Ljava/util/NavigableSet;Ljava/lang/Class;)Ljava/util/NavigableSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Queue;Ljava/lang/Class;)Ljava/util/Queue;")]
		public static Queue<E> checkedQueue<E>(Queue<E> arg0, Class<E> arg1)
			where E : IJavaObject
		{
			return Static.CallMethod<Queue<E>>(typeof(Collections), "checkedQueue", "(Ljava/util/Queue;Ljava/lang/Class;)Ljava/util/Queue;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;")]
		public static Set<E> checkedSet<E>(Set<E> arg0, Class<E> arg1)
			where E : IJavaObject
		{
			return Static.CallMethod<Set<E>>(typeof(Collections), "checkedSet", "(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;")]
		public static SortedMap<K, V> checkedSortedMap<K, V>(SortedMap<K, V> arg0, Class<K> arg1, Class<V> arg2)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<SortedMap<K, V>>(typeof(Collections), "checkedSortedMap", "(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;")]
		public static SortedSet<E> checkedSortedSet<E>(SortedSet<E> arg0, Class<E> arg1)
			where E : IJavaObject
		{
			return Static.CallMethod<SortedSet<E>>(typeof(Collections), "checkedSortedSet", "(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Collection;Ljava/util/Collection;)Z")]
		public static bool disjoint(Collection<IJavaObject> arg0, Collection<IJavaObject> arg1)
		{
			return Static.CallMethod<bool>(typeof(Collections), "disjoint", "(Ljava/util/Collection;Ljava/util/Collection;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public static List<T> emptyList<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<List<T>>(typeof(Collections), "emptyList", "()Ljava/util/List;");
		}
		
		[JavaSignature("()Ljava/util/ListIterator;")]
		public static ListIterator<T> emptyListIterator<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<ListIterator<T>>(typeof(Collections), "emptyListIterator", "()Ljava/util/ListIterator;");
		}
		
		[JavaSignature("()Ljava/util/Map;")]
		public static Map<K, V> emptyMap<K, V>()
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<Map<K, V>>(typeof(Collections), "emptyMap", "()Ljava/util/Map;");
		}
		
		[JavaSignature("()Ljava/util/NavigableMap;")]
		public static NavigableMap<K, V> emptyNavigableMap<K, V>()
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<NavigableMap<K, V>>(typeof(Collections), "emptyNavigableMap", "()Ljava/util/NavigableMap;");
		}
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		public static NavigableSet<E> emptyNavigableSet<E>()
			where E : IJavaObject
		{
			return Static.CallMethod<NavigableSet<E>>(typeof(Collections), "emptyNavigableSet", "()Ljava/util/NavigableSet;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public static Set<T> emptySet<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Set<T>>(typeof(Collections), "emptySet", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/util/SortedMap;")]
		public static SortedMap<K, V> emptySortedMap<K, V>()
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<SortedMap<K, V>>(typeof(Collections), "emptySortedMap", "()Ljava/util/SortedMap;");
		}
		
		[JavaSignature("()Ljava/util/SortedSet;")]
		public static SortedSet<E> emptySortedSet<E>()
			where E : IJavaObject
		{
			return Static.CallMethod<SortedSet<E>>(typeof(Collections), "emptySortedSet", "()Ljava/util/SortedSet;");
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/util/Enumeration;")]
		public static Enumeration<T> enumeration<T>(Collection<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Enumeration<T>>(typeof(Collections), "enumeration", "(Ljava/util/Collection;)Ljava/util/Enumeration;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;Ljava/lang/Object;)I")]
		public static int frequency(Collection<IJavaObject> arg0, IJavaObject arg1)
		{
			return Static.CallMethod<int>(typeof(Collections), "frequency", "(Ljava/util/Collection;Ljava/lang/Object;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/List;)I")]
		public static int indexOfSubList(List<IJavaObject> arg0, List<IJavaObject> arg1)
		{
			return Static.CallMethod<int>(typeof(Collections), "indexOfSubList", "(Ljava/util/List;Ljava/util/List;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/List;)I")]
		public static int lastIndexOfSubList(List<IJavaObject> arg0, List<IJavaObject> arg1)
		{
			return Static.CallMethod<int>(typeof(Collections), "lastIndexOfSubList", "(Ljava/util/List;Ljava/util/List;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;I)V")]
		public static void rotate(List<IJavaObject> arg0, int arg1)
		{
			Static.CallMethod(typeof(Collections), "rotate", "(Ljava/util/List;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;)V")]
		public static void shuffle(List<IJavaObject> arg0)
		{
			Static.CallMethod(typeof(Collections), "shuffle", "(Ljava/util/List;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Random;)V")]
		public static void shuffle(List<IJavaObject> arg0, Random arg1)
		{
			Static.CallMethod(typeof(Collections), "shuffle", "(Ljava/util/List;Ljava/util/Random;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Set;")]
		public static Set<T> singleton<T>(T arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Set<T>>(typeof(Collections), "singleton", "(Ljava/lang/Object;)Ljava/util/Set;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/List;")]
		public static List<T> singletonList<T>(T arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<List<T>>(typeof(Collections), "singletonList", "(Ljava/lang/Object;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;")]
		public static Map<K, V> singletonMap<K, V>(K arg0, V arg1)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<Map<K, V>>(typeof(Collections), "singletonMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;II)V")]
		public static void swap(List<IJavaObject> arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Collections), "swap", "(Ljava/util/List;II)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/Map;)Ljava/util/Map;")]
		public static Map<K, V> synchronizedMap<K, V>(Map<K, V> arg0)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<Map<K, V>>(typeof(Collections), "synchronizedMap", "(Ljava/util/Map;)Ljava/util/Map;", arg0);
		}
		
		[JavaSignature("(Ljava/util/NavigableMap;)Ljava/util/NavigableMap;")]
		public static NavigableMap<K, V> synchronizedNavigableMap<K, V>(NavigableMap<K, V> arg0)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<NavigableMap<K, V>>(typeof(Collections), "synchronizedNavigableMap", "(Ljava/util/NavigableMap;)Ljava/util/NavigableMap;", arg0);
		}
		
		[JavaSignature("(Ljava/util/NavigableSet;)Ljava/util/NavigableSet;")]
		public static NavigableSet<T> synchronizedNavigableSet<T>(NavigableSet<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<NavigableSet<T>>(typeof(Collections), "synchronizedNavigableSet", "(Ljava/util/NavigableSet;)Ljava/util/NavigableSet;", arg0);
		}
		
		[JavaSignature("(Ljava/util/SortedMap;)Ljava/util/SortedMap;")]
		public static SortedMap<K, V> synchronizedSortedMap<K, V>(SortedMap<K, V> arg0)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<SortedMap<K, V>>(typeof(Collections), "synchronizedSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;", arg0);
		}
		
		[JavaSignature("(Ljava/util/SortedSet;)Ljava/util/SortedSet;")]
		public static SortedSet<T> synchronizedSortedSet<T>(SortedSet<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<SortedSet<T>>(typeof(Collections), "synchronizedSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/util/Collection;")]
		public static Collection<T> unmodifiableCollection<T>(Collection<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collection<T>>(typeof(Collections), "unmodifiableCollection", "(Ljava/util/Collection;)Ljava/util/Collection;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Map;)Ljava/util/Map;")]
		public static Map<K, V> unmodifiableMap<K, V>(Map<K, V> arg0)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<Map<K, V>>(typeof(Collections), "unmodifiableMap", "(Ljava/util/Map;)Ljava/util/Map;", arg0);
		}
		
		[JavaSignature("(Ljava/util/NavigableMap;)Ljava/util/NavigableMap;")]
		public static NavigableMap<K, V> unmodifiableNavigableMap<K, V>(NavigableMap<K, V> arg0)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<NavigableMap<K, V>>(typeof(Collections), "unmodifiableNavigableMap", "(Ljava/util/NavigableMap;)Ljava/util/NavigableMap;", arg0);
		}
		
		[JavaSignature("(Ljava/util/NavigableSet;)Ljava/util/NavigableSet;")]
		public static NavigableSet<T> unmodifiableNavigableSet<T>(NavigableSet<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<NavigableSet<T>>(typeof(Collections), "unmodifiableNavigableSet", "(Ljava/util/NavigableSet;)Ljava/util/NavigableSet;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Set;)Ljava/util/Set;")]
		public static Set<T> unmodifiableSet<T>(Set<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Set<T>>(typeof(Collections), "unmodifiableSet", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
		}
		
		[JavaSignature("(Ljava/util/SortedMap;)Ljava/util/SortedMap;")]
		public static SortedMap<K, V> unmodifiableSortedMap<K, V>(SortedMap<K, V> arg0)
			where K : IJavaObject
			where V : IJavaObject
		{
			return Static.CallMethod<SortedMap<K, V>>(typeof(Collections), "unmodifiableSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;", arg0);
		}
		
		[JavaSignature("(Ljava/util/SortedSet;)Ljava/util/SortedSet;")]
		public static SortedSet<T> unmodifiableSortedSet<T>(SortedSet<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<SortedSet<T>>(typeof(Collections), "unmodifiableSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;", arg0);
		}
	}
}
