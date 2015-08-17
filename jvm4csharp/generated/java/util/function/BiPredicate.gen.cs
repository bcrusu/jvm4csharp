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
	[JavaProxy("java/util/function/BiPredicate")]
	public interface BiPredicate<T, U> : IJavaObject
		where T : IJavaObject
		where U : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;")]
		BiPredicate<T, U> and(BiPredicate<IJavaObject, IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;")]
		BiPredicate<T, U> or(BiPredicate<IJavaObject, IJavaObject> arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		bool test(T arg0, U arg1);
		
		[JavaSignature("()Ljava/util/function/BiPredicate;")]
		BiPredicate<T, U> negate();
	}
}
