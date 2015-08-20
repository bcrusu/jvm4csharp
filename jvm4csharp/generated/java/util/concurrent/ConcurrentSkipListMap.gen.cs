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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ConcurrentSkipListMap")]
	public partial class ConcurrentSkipListMap<K, V> : AbstractMap<K, V>, ConcurrentNavigableMap<K, V>, Cloneable, Serializable
		where K : IJavaObject
		where V : IJavaObject
	{
		protected ConcurrentSkipListMap(ProxyCtor p) : base(p) {}
		
		public ConcurrentSkipListMap() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ConcurrentSkipListMap(Map<K, V> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Map;)V", arg0);
		}
		
		public ConcurrentSkipListMap(SortedMap<K, V> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/SortedMap;)V", arg0);
		}
		
		public ConcurrentSkipListMap(Comparator<IJavaObject> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Comparator;)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool @remove(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<bool>("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ConcurrentSkipListMap;")]
		public ConcurrentSkipListMap<K, V> clone()
		{
			return Instance.CallMethod<ConcurrentSkipListMap<K, V>>("clone", "()Ljava/util/concurrent/ConcurrentSkipListMap;");
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public V replace(K arg0, V arg1)
		{
			return Instance.CallMethod<V>("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool replace(K arg0, V arg1, V arg2)
		{
			return Instance.CallMethod<bool>("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;)V")]
		public void replaceAll(BiFunction<IJavaObject, IJavaObject, V> arg0)
		{
			Instance.CallMethod("replaceAll", "(Ljava/util/function/BiFunction;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public V putIfAbsent(K arg0, V arg1)
		{
			return Instance.CallMethod<V>("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		public new NavigableSet<K> keySet()
		{
			return Instance.CallMethod<NavigableSet<K>>("keySet", "()Ljava/util/NavigableSet;");
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public V compute(K arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
		{
			return Instance.CallMethod<V>("compute", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;")]
		public V computeIfAbsent(K arg0, Function<IJavaObject, V> arg1)
		{
			return Instance.CallMethod<V>("computeIfAbsent", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public V computeIfPresent(K arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
		{
			return Instance.CallMethod<V>("computeIfPresent", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)V")]
		public void forEach(BiConsumer<IJavaObject, IJavaObject> arg0)
		{
			Instance.CallMethod("forEach", "(Ljava/util/function/BiConsumer;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public V getOrDefault(IJavaObject arg0, V arg1)
		{
			return Instance.CallMethod<V>("getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public V merge(K arg0, V arg1, BiFunction<IJavaObject, IJavaObject, V> arg2)
		{
			return Instance.CallMethod<V>("merge", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> ceilingEntry(K arg0)
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map/Entry;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public K ceilingKey(K arg0)
		{
			return Instance.CallMethod<K>("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		public NavigableSet<K> descendingKeySet()
		{
			return Instance.CallMethod<NavigableSet<K>>("descendingKeySet", "()Ljava/util/NavigableSet;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/ConcurrentNavigableMap;")]
		public ConcurrentNavigableMap<K, V> descendingMap()
		{
			return Instance.CallMethod<ConcurrentNavigableMap<K, V>>("descendingMap", "()Ljava/util/concurrent/ConcurrentNavigableMap;");
		}
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> firstEntry()
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("firstEntry", "()Ljava/util/Map/Entry;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> floorEntry(K arg0)
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map/Entry;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public K floorKey(K arg0)
		{
			return Instance.CallMethod<K>("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		public ConcurrentNavigableMap<K, V> headMap(K arg0, bool arg1)
		{
			return Instance.CallMethod<ConcurrentNavigableMap<K, V>>("headMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		public ConcurrentNavigableMap<K, V> headMap(K arg0)
		{
			return Instance.CallMethod<ConcurrentNavigableMap<K, V>>("headMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> higherEntry(K arg0)
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map/Entry;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public K higherKey(K arg0)
		{
			return Instance.CallMethod<K>("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> lastEntry()
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("lastEntry", "()Ljava/util/Map/Entry;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> lowerEntry(K arg0)
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map/Entry;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public K lowerKey(K arg0)
		{
			return Instance.CallMethod<K>("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		public NavigableSet<K> navigableKeySet()
		{
			return Instance.CallMethod<NavigableSet<K>>("navigableKeySet", "()Ljava/util/NavigableSet;");
		}
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> pollFirstEntry()
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("pollFirstEntry", "()Ljava/util/Map/Entry;");
		}
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> pollLastEntry()
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("pollLastEntry", "()Ljava/util/Map/Entry;");
		}
		
		[JavaSignature("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		public ConcurrentNavigableMap<K, V> subMap(K arg0, bool arg1, K arg2, bool arg3)
		{
			return Instance.CallMethod<ConcurrentNavigableMap<K, V>>("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		public ConcurrentNavigableMap<K, V> subMap(K arg0, K arg1)
		{
			return Instance.CallMethod<ConcurrentNavigableMap<K, V>>("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		public ConcurrentNavigableMap<K, V> tailMap(K arg0)
		{
			return Instance.CallMethod<ConcurrentNavigableMap<K, V>>("tailMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		public ConcurrentNavigableMap<K, V> tailMap(K arg0, bool arg1)
		{
			return Instance.CallMethod<ConcurrentNavigableMap<K, V>>("tailMap", "(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public K firstKey()
		{
			return Instance.CallMethod<K>("firstKey", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public K lastKey()
		{
			return Instance.CallMethod<K>("lastKey", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/util/Comparator;")]
		public Comparator<IJavaObject> comparator()
		{
			return Instance.CallMethod<Comparator<IJavaObject>>("comparator", "()Ljava/util/Comparator;");
		}
		
		[JavaSignature("()Ljava/util/NavigableMap;")]
		NavigableMap<K, V> NavigableMap<K, V>.descendingMap()
		{
			return Instance.CallMethod<NavigableMap<K, V>>("descendingMap", "()Ljava/util/NavigableMap;");
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableMap;")]
		NavigableMap<K, V> NavigableMap<K, V>.headMap(K arg0, bool arg1)
		{
			return Instance.CallMethod<NavigableMap<K, V>>("headMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> NavigableMap<K, V>.headMap(K arg0)
		{
			return Instance.CallMethod<SortedMap<K, V>>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> NavigableMap<K, V>.subMap(K arg0, K arg1)
		{
			return Instance.CallMethod<SortedMap<K, V>>("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;")]
		NavigableMap<K, V> NavigableMap<K, V>.subMap(K arg0, bool arg1, K arg2, bool arg3)
		{
			return Instance.CallMethod<NavigableMap<K, V>>("subMap", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableMap;")]
		NavigableMap<K, V> NavigableMap<K, V>.tailMap(K arg0, bool arg1)
		{
			return Instance.CallMethod<NavigableMap<K, V>>("tailMap", "(Ljava/lang/Object;Z)Ljava/util/NavigableMap;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> NavigableMap<K, V>.tailMap(K arg0)
		{
			return Instance.CallMethod<SortedMap<K, V>>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> SortedMap<K, V>.headMap(K arg0)
		{
			return Instance.CallMethod<SortedMap<K, V>>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> SortedMap<K, V>.subMap(K arg0, K arg1)
		{
			return Instance.CallMethod<SortedMap<K, V>>("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> SortedMap<K, V>.tailMap(K arg0)
		{
			return Instance.CallMethod<SortedMap<K, V>>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
		}
	}
}
