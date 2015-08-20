//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ConcurrentMap")]
	public partial interface ConcurrentMap<K, V> : Map<K, V>
		where K : IJavaObject
		where V : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		new bool @remove(IJavaObject arg0, IJavaObject arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		new bool replace(K arg0, V arg1, V arg2);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		new V replace(K arg0, V arg1);
		
		[JavaSignature("(Ljava/util/function/BiFunction;)V")]
		new void replaceAll(BiFunction<IJavaObject, IJavaObject, V> arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		new V putIfAbsent(K arg0, V arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		new V compute(K arg0, BiFunction<IJavaObject, IJavaObject, V> arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;")]
		new V computeIfAbsent(K arg0, Function<IJavaObject, V> arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		new V computeIfPresent(K arg0, BiFunction<IJavaObject, IJavaObject, V> arg1);
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)V")]
		new void forEach(BiConsumer<IJavaObject, IJavaObject> arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		new V getOrDefault(IJavaObject arg0, V arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		new V merge(K arg0, V arg1, BiFunction<IJavaObject, IJavaObject, V> arg2);
	}
}
