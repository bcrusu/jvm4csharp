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
	[JavaProxy("java/util/NavigableMap")]
	public partial interface NavigableMap<K, V> : SortedMap<K, V>
		where K : IJavaObject
		where V : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> ceilingEntry(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		K ceilingKey(K arg0);
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		NavigableSet<K> descendingKeySet();
		
		[JavaSignature("()Ljava/util/NavigableMap;")]
		NavigableMap<K, V> descendingMap();
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> firstEntry();
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> floorEntry(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		K floorKey(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableMap;")]
		NavigableMap<K, V> headMap(K arg0, bool arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		new SortedMap<K, V> headMap(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> higherEntry(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		K higherKey(K arg0);
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> lastEntry();
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> lowerEntry(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		K lowerKey(K arg0);
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		NavigableSet<K> navigableKeySet();
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> pollFirstEntry();
		
		[JavaSignature("()Ljava/util/Map/Entry;")]
		Map_.Entry<K, V> pollLastEntry();
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;")]
		new SortedMap<K, V> subMap(K arg0, K arg1);
		
		[JavaSignature("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableMap;")]
		NavigableMap<K, V> subMap(K arg0, bool arg1, K arg2, bool arg3);
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/NavigableMap;")]
		NavigableMap<K, V> tailMap(K arg0, bool arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		new SortedMap<K, V> tailMap(K arg0);
	}
}
