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
namespace jvm4csharp.java.util.function
{
	[JavaProxy("java/util/function/BiFunction")]
	public partial interface BiFunction<T, U, R> : IJavaObject
		where T : IJavaObject
		where U : IJavaObject
		where R : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		R apply(T arg0, U arg1);
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/function/BiFunction;")]
		BiFunction<T, U, V> andThen<V>(Function<IJavaObject, V> arg0)
			where V : IJavaObject;
	}
}
