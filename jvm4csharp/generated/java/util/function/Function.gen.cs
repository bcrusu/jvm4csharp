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
	[JavaProxy("java/util/function/Function")]
	public partial interface Function<T, R> : IJavaObject
		where T : IJavaObject
		where R : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/function/Function;")]
		Function<T, V> andThen<V>(Function<IJavaObject, V> arg0)
			where V : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/function/Function;")]
		Function<V, R> compose<V>(Function<IJavaObject, T> arg0)
			where V : IJavaObject;
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		R apply(T arg0);
	}
	
	public static class Function_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("()Ljava/util/function/Function;")]
		public static Function<T1, T1> identity<T1>()
			where T1 : IJavaObject
		{
			return Static.CallMethod<Function<T1, T1>>(typeof(Function<,>), "identity", "()Ljava/util/function/Function;");
		}
	
	}
}
