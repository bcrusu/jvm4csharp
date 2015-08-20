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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ConcurrentNavigableMap")]
	public partial interface ConcurrentNavigableMap<K, V> : ConcurrentMap<K, V>, NavigableMap<K, V>
		where K : IJavaObject
		where V : IJavaObject
	{
		[JavaSignature("()Ljava/util/NavigableSet;")]
		new NavigableSet<K> keySet();
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		new NavigableSet<K> descendingKeySet();
		
		[JavaSignature("()Ljava/util/concurrent/ConcurrentNavigableMap;")]
		new ConcurrentNavigableMap<K, V> descendingMap();
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		new ConcurrentNavigableMap<K, V> headMap(K arg0, bool arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		new ConcurrentNavigableMap<K, V> headMap(K arg0);
		
		[JavaSignature("()Ljava/util/NavigableSet;")]
		new NavigableSet<K> navigableKeySet();
		
		[JavaSignature("(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		new ConcurrentNavigableMap<K, V> subMap(K arg0, bool arg1, K arg2, bool arg3);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		new ConcurrentNavigableMap<K, V> subMap(K arg0, K arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		new ConcurrentNavigableMap<K, V> tailMap(K arg0);
		
		[JavaSignature("(Ljava/lang/Object;Z)Ljava/util/concurrent/ConcurrentNavigableMap;")]
		new ConcurrentNavigableMap<K, V> tailMap(K arg0, bool arg1);
	}
}
