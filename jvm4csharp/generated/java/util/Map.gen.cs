//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Map")]
	public partial interface Map<K, V> : IJavaObject
		where K : IJavaObject
		where V : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		V @remove(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		bool @remove(IJavaObject arg0, IJavaObject arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		V @get(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		V put(K arg0, V arg1);
		
		[JavaSignature("()Ljava/util/Collection;")]
		Collection<V> values();
		
		[JavaSignature("()V")]
		void clear();
		
		[JavaSignature("()Z")]
		bool isEmpty();
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		V replace(K arg0, V arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		bool replace(K arg0, V arg1, V arg2);
		
		[JavaSignature("(Ljava/util/function/BiFunction;)V")]
		void replaceAll(BiFunction<IJavaObject, IJavaObject, V> arg0);
		
		[JavaSignature("()I")]
		int size();
		
		[JavaSignature("()Ljava/util/Set;")]
		Set<Map_.Entry<K, V>> entrySet();
		
		[JavaSignature("(Ljava/util/Map;)V")]
		void putAll(Map<K, V> arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		V putIfAbsent(K arg0, V arg1);
		
		[JavaSignature("()Ljava/util/Set;")]
		Set<K> keySet();
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		V compute(K arg0, BiFunction<IJavaObject, IJavaObject, V> arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;")]
		V computeIfAbsent(K arg0, Function<IJavaObject, V> arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		V computeIfPresent(K arg0, BiFunction<IJavaObject, IJavaObject, V> arg1);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool containsKey(IJavaObject arg0);
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool containsValue(IJavaObject arg0);
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)V")]
		void forEach(BiConsumer<IJavaObject, IJavaObject> arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		V getOrDefault(IJavaObject arg0, V arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		V merge(K arg0, V arg1, BiFunction<IJavaObject, IJavaObject, V> arg2);
	}
	
	public static partial class Map_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
	
		[JavaProxy("java/util/Map/Entry")]
		public partial interface Entry<K, V> : IJavaObject
			where K : IJavaObject
			where V : IJavaObject
		{
			[JavaSignature("()Ljava/lang/Object;")]
			V getValue();
			
			[JavaSignature("()Ljava/lang/Object;")]
			K getKey();
			
			[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
			V setValue(V arg0);
		}
		
		public static partial class Entry_
		{
			private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
			
			[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Comparator;")]
			public static Comparator<Map_.Entry<K1, V1>> comparingByKey<K1, V1>(Comparator<IJavaObject> arg0)
				where K1 : IJavaObject
				where V1 : IJavaObject
			{
				return Static.CallMethod<Comparator<Map_.Entry<K1, V1>>>(typeof(Entry<,>), "comparingByKey", "(Ljava/util/Comparator;)Ljava/util/Comparator;", arg0);
			}
			
			[JavaSignature("()Ljava/util/Comparator;")]
			public static Comparator<Map_.Entry<K1, V1>> comparingByKey<K1, V1>()
				where K1 : Comparable<IJavaObject>
				where V1 : IJavaObject
			{
				return Static.CallMethod<Comparator<Map_.Entry<K1, V1>>>(typeof(Entry<,>), "comparingByKey", "()Ljava/util/Comparator;");
			}
			
			[JavaSignature("()Ljava/util/Comparator;")]
			public static Comparator<Map_.Entry<K1, V1>> comparingByValue<K1, V1>()
				where K1 : IJavaObject
				where V1 : Comparable<IJavaObject>
			{
				return Static.CallMethod<Comparator<Map_.Entry<K1, V1>>>(typeof(Entry<,>), "comparingByValue", "()Ljava/util/Comparator;");
			}
			
			[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Comparator;")]
			public static Comparator<Map_.Entry<K1, V1>> comparingByValue<K1, V1>(Comparator<IJavaObject> arg0)
				where K1 : IJavaObject
				where V1 : IJavaObject
			{
				return Static.CallMethod<Comparator<Map_.Entry<K1, V1>>>(typeof(Entry<,>), "comparingByValue", "(Ljava/util/Comparator;)Ljava/util/Comparator;", arg0);
			}
		
		}
	}
}
