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
	[JavaProxy("java/util/SortedMap")]
	public partial interface SortedMap<K, V> : Map<K, V>
		where K : IJavaObject
		where V : IJavaObject
	{
		[JavaSignature("()Ljava/util/Collection;")]
		new Collection<V> values();
		
		[JavaSignature("()Ljava/util/Set;")]
		new Set<Map_.Entry<K, V>> entrySet();
		
		[JavaSignature("()Ljava/util/Set;")]
		new Set<K> keySet();
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> headMap(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> subMap(K arg0, K arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/SortedMap;")]
		SortedMap<K, V> tailMap(K arg0);
		
		[JavaSignature("()Ljava/lang/Object;")]
		K firstKey();
		
		[JavaSignature("()Ljava/lang/Object;")]
		K lastKey();
		
		[JavaSignature("()Ljava/util/Comparator;")]
		Comparator<IJavaObject> comparator();
	}
}
