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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/AbstractMap")]
	public abstract class AbstractMap<K, V> : Object, Map<K, V>
		where K : IJavaObject
		where V : IJavaObject
	{
		protected AbstractMap(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public V @remove(IJavaObject arg0)
		{
			return Instance.CallMethod<V>("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public V @get(IJavaObject arg0)
		{
			return Instance.CallMethod<V>("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public V put(K arg0, V arg1)
		{
			return Instance.CallMethod<V>("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Collection;")]
		public Collection<V> values()
		{
			return Instance.CallMethod<Collection<V>>("values", "()Ljava/util/Collection;");
		}
		
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isEmpty()
		{
			return Instance.CallMethod<bool>("isEmpty", "()Z");
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<Map_.Entry<K, V>> entrySet()
		{
			return Instance.CallMethod<Set<Map_.Entry<K, V>>>("entrySet", "()Ljava/util/Set;");
		}
		
		[JavaSignature("(Ljava/util/Map;)V")]
		public void putAll(Map<K, V> arg0)
		{
			Instance.CallMethod("putAll", "(Ljava/util/Map;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<K> keySet()
		{
			return Instance.CallMethod<Set<K>>("keySet", "()Ljava/util/Set;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool containsKey(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("containsKey", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool containsValue(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("containsValue", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool @remove(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<bool>("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
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
	}
	
	public class AbstractMap
	{
		[JavaProxy("java/util/AbstractMap/SimpleEntry")]
		public class SimpleEntry<K, V> : Object, Map_.Entry<K, V>, Serializable
			where K : IJavaObject
			where V : IJavaObject
		{
			protected SimpleEntry(ProxyCtor p) : base(p) {}
			
			public SimpleEntry(K arg0, V arg1) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1);
			}
			
			public SimpleEntry(Map_.Entry<K, V> arg0) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/util/Map/Entry;)V", arg0);
			}
		
			[JavaSignature("()Ljava/lang/Object;")]
			public V getValue()
			{
				return Instance.CallMethod<V>("getValue", "()Ljava/lang/Object;");
			}
			
			[JavaSignature("()Ljava/lang/Object;")]
			public K getKey()
			{
				return Instance.CallMethod<K>("getKey", "()Ljava/lang/Object;");
			}
			
			[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
			public V setValue(V arg0)
			{
				return Instance.CallMethod<V>("setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
			}
		}
		
		[JavaProxy("java/util/AbstractMap/SimpleImmutableEntry")]
		public class SimpleImmutableEntry<K, V> : Object, Map_.Entry<K, V>, Serializable
			where K : IJavaObject
			where V : IJavaObject
		{
			protected SimpleImmutableEntry(ProxyCtor p) : base(p) {}
			
			public SimpleImmutableEntry(K arg0, V arg1) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1);
			}
			
			public SimpleImmutableEntry(Map_.Entry<K, V> arg0) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/util/Map/Entry;)V", arg0);
			}
		
			[JavaSignature("()Ljava/lang/Object;")]
			public V getValue()
			{
				return Instance.CallMethod<V>("getValue", "()Ljava/lang/Object;");
			}
			
			[JavaSignature("()Ljava/lang/Object;")]
			public K getKey()
			{
				return Instance.CallMethod<K>("getKey", "()Ljava/lang/Object;");
			}
			
			[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
			public V setValue(V arg0)
			{
				return Instance.CallMethod<V>("setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
			}
		}
	}
}
