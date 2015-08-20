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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ConcurrentHashMap")]
	public partial class ConcurrentHashMap<K, V> : AbstractMap<K, V>, ConcurrentMap<K, V>, Serializable
		where K : IJavaObject
		where V : IJavaObject
	{
		protected ConcurrentHashMap(ProxyCtor p) : base(p) {}
		
		public ConcurrentHashMap(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public ConcurrentHashMap() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ConcurrentHashMap(int arg0, float arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IF)V", arg0, arg1);
		}
		
		public ConcurrentHashMap(int arg0, float arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IFI)V", arg0, arg1, arg2);
		}
		
		public ConcurrentHashMap(Map<K, V> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Map;)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool @remove(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<bool>("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool contains(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
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
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<V> elements()
		{
			return Instance.CallMethod<Enumeration<V>>("elements", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentHashMap/KeySetView;")]
		public ConcurrentHashMap.KeySetView<K, V> keySet(V arg0)
		{
			return Instance.CallMethod<ConcurrentHashMap.KeySetView<K, V>>("keySet", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentHashMap/KeySetView;", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ConcurrentHashMap/KeySetView;")]
		public new ConcurrentHashMap.KeySetView<K, V> keySet()
		{
			return Instance.CallMethod<ConcurrentHashMap.KeySetView<K, V>>("keySet", "()Ljava/util/concurrent/ConcurrentHashMap/KeySetView;");
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<K> keys()
		{
			return Instance.CallMethod<Enumeration<K>>("keys", "()Ljava/util/Enumeration;");
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
		
		[JavaSignature("(JLjava/util/function/BiConsumer;)V")]
		public void forEach(long arg0, BiConsumer<IJavaObject, IJavaObject> arg1)
		{
			Instance.CallMethod("forEach", "(JLjava/util/function/BiConsumer;)V", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/BiFunction;Ljava/util/function/Consumer;)V")]
		public void forEach<U>(long arg0, BiFunction<IJavaObject, IJavaObject, U> arg1, Consumer<IJavaObject> arg2)
			where U : IJavaObject
		{
			Instance.CallMethod("forEach", "(JLjava/util/function/BiFunction;Ljava/util/function/Consumer;)V", arg0, arg1, arg2);
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
		
		[JavaSignature("(JLjava/util/function/BiFunction;)Ljava/lang/Object;")]
		public U search<U>(long arg0, BiFunction<IJavaObject, IJavaObject, U> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("search", "(JLjava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/Consumer;)V")]
		public void forEachEntry(long arg0, Consumer<IJavaObject> arg1)
		{
			Instance.CallMethod("forEachEntry", "(JLjava/util/function/Consumer;)V", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/Function;Ljava/util/function/Consumer;)V")]
		public void forEachEntry<U>(long arg0, Function<Map_.Entry<K, V>, U> arg1, Consumer<IJavaObject> arg2)
			where U : IJavaObject
		{
			Instance.CallMethod("forEachEntry", "(JLjava/util/function/Function;Ljava/util/function/Consumer;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JLjava/util/function/Function;Ljava/util/function/Consumer;)V")]
		public void forEachKey<U>(long arg0, Function<IJavaObject, U> arg1, Consumer<IJavaObject> arg2)
			where U : IJavaObject
		{
			Instance.CallMethod("forEachKey", "(JLjava/util/function/Function;Ljava/util/function/Consumer;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JLjava/util/function/Consumer;)V")]
		public void forEachKey(long arg0, Consumer<IJavaObject> arg1)
		{
			Instance.CallMethod("forEachKey", "(JLjava/util/function/Consumer;)V", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/Consumer;)V")]
		public void forEachValue(long arg0, Consumer<IJavaObject> arg1)
		{
			Instance.CallMethod("forEachValue", "(JLjava/util/function/Consumer;)V", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/Function;Ljava/util/function/Consumer;)V")]
		public void forEachValue<U>(long arg0, Function<IJavaObject, U> arg1, Consumer<IJavaObject> arg2)
			where U : IJavaObject
		{
			Instance.CallMethod("forEachValue", "(JLjava/util/function/Function;Ljava/util/function/Consumer;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("()J")]
		public long mappingCount()
		{
			return Instance.CallMethod<long>("mappingCount", "()J");
		}
		
		[JavaSignature("()Ljava/util/concurrent/ConcurrentHashMap/KeySetView;")]
		public static ConcurrentHashMap.KeySetView<K1, Boolean> newKeySet<K1>()
			where K1 : IJavaObject
		{
			return Static.CallMethod<ConcurrentHashMap.KeySetView<K1, Boolean>>(typeof(ConcurrentHashMap<,>), "newKeySet", "()Ljava/util/concurrent/ConcurrentHashMap/KeySetView;");
		}
		
		[JavaSignature("(I)Ljava/util/concurrent/ConcurrentHashMap/KeySetView;")]
		public static ConcurrentHashMap.KeySetView<K1, Boolean> newKeySet<K1>(int arg0)
			where K1 : IJavaObject
		{
			return Static.CallMethod<ConcurrentHashMap.KeySetView<K1, Boolean>>(typeof(ConcurrentHashMap<,>), "newKeySet", "(I)Ljava/util/concurrent/ConcurrentHashMap/KeySetView;", arg0);
		}
		
		[JavaSignature("(JLjava/util/function/BiFunction;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public U reduce<U>(long arg0, BiFunction<IJavaObject, IJavaObject, U> arg1, BiFunction<IJavaObject, IJavaObject, U> arg2)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("reduce", "(JLjava/util/function/BiFunction;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JLjava/util/function/Function;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public U reduceEntries<U>(long arg0, Function<Map_.Entry<K, V>, U> arg1, BiFunction<IJavaObject, IJavaObject, U> arg2)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("reduceEntries", "(JLjava/util/function/Function;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JLjava/util/function/BiFunction;)Ljava/util/Map/Entry;")]
		public Map_.Entry<K, V> reduceEntries(long arg0, BiFunction<Map_.Entry<K, V>, Map_.Entry<K, V>, Map_.Entry<K, V>> arg1)
		{
			return Instance.CallMethod<Map_.Entry<K, V>>("reduceEntries", "(JLjava/util/function/BiFunction;)Ljava/util/Map/Entry;", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/ToDoubleFunction;DLjava/util/function/DoubleBinaryOperator;)D")]
		public double reduceEntriesToDouble(long arg0, ToDoubleFunction<Map_.Entry<K, V>> arg1, double arg2, DoubleBinaryOperator arg3)
		{
			return Instance.CallMethod<double>("reduceEntriesToDouble", "(JLjava/util/function/ToDoubleFunction;DLjava/util/function/DoubleBinaryOperator;)D", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToIntFunction;ILjava/util/function/IntBinaryOperator;)I")]
		public int reduceEntriesToInt(long arg0, ToIntFunction<Map_.Entry<K, V>> arg1, int arg2, IntBinaryOperator arg3)
		{
			return Instance.CallMethod<int>("reduceEntriesToInt", "(JLjava/util/function/ToIntFunction;ILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToLongFunction;JLjava/util/function/LongBinaryOperator;)J")]
		public long reduceEntriesToLong(long arg0, ToLongFunction<Map_.Entry<K, V>> arg1, long arg2, LongBinaryOperator arg3)
		{
			return Instance.CallMethod<long>("reduceEntriesToLong", "(JLjava/util/function/ToLongFunction;JLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/Function;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public U reduceKeys<U>(long arg0, Function<IJavaObject, U> arg1, BiFunction<IJavaObject, IJavaObject, U> arg2)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("reduceKeys", "(JLjava/util/function/Function;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JLjava/util/function/BiFunction;)Ljava/lang/Object;")]
		public K reduceKeys(long arg0, BiFunction<IJavaObject, IJavaObject, K> arg1)
		{
			return Instance.CallMethod<K>("reduceKeys", "(JLjava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/ToDoubleFunction;DLjava/util/function/DoubleBinaryOperator;)D")]
		public double reduceKeysToDouble(long arg0, ToDoubleFunction<IJavaObject> arg1, double arg2, DoubleBinaryOperator arg3)
		{
			return Instance.CallMethod<double>("reduceKeysToDouble", "(JLjava/util/function/ToDoubleFunction;DLjava/util/function/DoubleBinaryOperator;)D", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToIntFunction;ILjava/util/function/IntBinaryOperator;)I")]
		public int reduceKeysToInt(long arg0, ToIntFunction<IJavaObject> arg1, int arg2, IntBinaryOperator arg3)
		{
			return Instance.CallMethod<int>("reduceKeysToInt", "(JLjava/util/function/ToIntFunction;ILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToLongFunction;JLjava/util/function/LongBinaryOperator;)J")]
		public long reduceKeysToLong(long arg0, ToLongFunction<IJavaObject> arg1, long arg2, LongBinaryOperator arg3)
		{
			return Instance.CallMethod<long>("reduceKeysToLong", "(JLjava/util/function/ToLongFunction;JLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToDoubleBiFunction;DLjava/util/function/DoubleBinaryOperator;)D")]
		public double reduceToDouble(long arg0, ToDoubleBiFunction<IJavaObject, IJavaObject> arg1, double arg2, DoubleBinaryOperator arg3)
		{
			return Instance.CallMethod<double>("reduceToDouble", "(JLjava/util/function/ToDoubleBiFunction;DLjava/util/function/DoubleBinaryOperator;)D", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToIntBiFunction;ILjava/util/function/IntBinaryOperator;)I")]
		public int reduceToInt(long arg0, ToIntBiFunction<IJavaObject, IJavaObject> arg1, int arg2, IntBinaryOperator arg3)
		{
			return Instance.CallMethod<int>("reduceToInt", "(JLjava/util/function/ToIntBiFunction;ILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToLongBiFunction;JLjava/util/function/LongBinaryOperator;)J")]
		public long reduceToLong(long arg0, ToLongBiFunction<IJavaObject, IJavaObject> arg1, long arg2, LongBinaryOperator arg3)
		{
			return Instance.CallMethod<long>("reduceToLong", "(JLjava/util/function/ToLongBiFunction;JLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/Function;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public U reduceValues<U>(long arg0, Function<IJavaObject, U> arg1, BiFunction<IJavaObject, IJavaObject, U> arg2)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("reduceValues", "(JLjava/util/function/Function;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JLjava/util/function/BiFunction;)Ljava/lang/Object;")]
		public V reduceValues(long arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
		{
			return Instance.CallMethod<V>("reduceValues", "(JLjava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/ToDoubleFunction;DLjava/util/function/DoubleBinaryOperator;)D")]
		public double reduceValuesToDouble(long arg0, ToDoubleFunction<IJavaObject> arg1, double arg2, DoubleBinaryOperator arg3)
		{
			return Instance.CallMethod<double>("reduceValuesToDouble", "(JLjava/util/function/ToDoubleFunction;DLjava/util/function/DoubleBinaryOperator;)D", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToIntFunction;ILjava/util/function/IntBinaryOperator;)I")]
		public int reduceValuesToInt(long arg0, ToIntFunction<IJavaObject> arg1, int arg2, IntBinaryOperator arg3)
		{
			return Instance.CallMethod<int>("reduceValuesToInt", "(JLjava/util/function/ToIntFunction;ILjava/util/function/IntBinaryOperator;)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/ToLongFunction;JLjava/util/function/LongBinaryOperator;)J")]
		public long reduceValuesToLong(long arg0, ToLongFunction<IJavaObject> arg1, long arg2, LongBinaryOperator arg3)
		{
			return Instance.CallMethod<long>("reduceValuesToLong", "(JLjava/util/function/ToLongFunction;JLjava/util/function/LongBinaryOperator;)J", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(JLjava/util/function/Function;)Ljava/lang/Object;")]
		public U searchEntries<U>(long arg0, Function<Map_.Entry<K, V>, U> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("searchEntries", "(JLjava/util/function/Function;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/Function;)Ljava/lang/Object;")]
		public U searchKeys<U>(long arg0, Function<IJavaObject, U> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("searchKeys", "(JLjava/util/function/Function;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(JLjava/util/function/Function;)Ljava/lang/Object;")]
		public U searchValues<U>(long arg0, Function<IJavaObject, U> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<U>("searchValues", "(JLjava/util/function/Function;)Ljava/lang/Object;", arg0, arg1);
		}
	}
	
	public class ConcurrentHashMap
	{
		[JavaProxy("java/util/concurrent/ConcurrentHashMap/KeySetView")]
		public partial class KeySetView<K, V> : Object, Set<K>, Serializable, Collection<K>
			where K : IJavaObject
			where V : IJavaObject
		{
			protected KeySetView(ProxyCtor p) : base(p) {}
		
			[JavaSignature("(Ljava/lang/Object;)Z")]
			public bool @add(K arg0)
			{
				return Instance.CallMethod<bool>("add", "(Ljava/lang/Object;)Z", arg0);
			}
			
			[JavaSignature("()Ljava/util/Spliterator;")]
			public Spliterator<K> spliterator()
			{
				return Instance.CallMethod<Spliterator<K>>("spliterator", "()Ljava/util/Spliterator;");
			}
			
			[JavaSignature("(Ljava/util/Collection;)Z")]
			public bool addAll(Collection<K> arg0)
			{
				return Instance.CallMethod<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			public void forEach(Consumer<IJavaObject> arg0)
			{
				Instance.CallMethod("forEach", "(Ljava/util/function/Consumer;)V", arg0);
			}
			
			[JavaSignature("()Ljava/lang/Object;")]
			public V getMappedValue()
			{
				return Instance.CallMethod<V>("getMappedValue", "()Ljava/lang/Object;");
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
			public Iterator<K> iterator()
			{
				return Instance.CallMethod<Iterator<K>>("iterator", "()Ljava/util/Iterator;");
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
			
			[JavaSignature("()Ljava/util/stream/Stream;")]
			public Stream<K> stream()
			{
				return Instance.CallMethod<Stream<K>>("stream", "()Ljava/util/stream/Stream;");
			}
			
			[JavaSignature("(Ljava/util/function/Predicate;)Z")]
			public bool removeIf(Predicate<IJavaObject> arg0)
			{
				return Instance.CallMethod<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
			}
			
			[JavaSignature("()Ljava/util/stream/Stream;")]
			public Stream<K> parallelStream()
			{
				return Instance.CallMethod<Stream<K>>("parallelStream", "()Ljava/util/stream/Stream;");
			}
		}
	}
}
