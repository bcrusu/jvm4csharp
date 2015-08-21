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
	[JavaProxy("java/util/function/Predicate")]
	public partial interface Predicate<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)Z")]
		bool test(T arg0);
		
		[JavaSignature("(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;")]
		Predicate<T> and(Predicate<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;")]
		Predicate<T> or(Predicate<IJavaObject> arg0);
		
		[JavaSignature("()Ljava/util/function/Predicate;")]
		Predicate<T> negate();
	}
	
	public static partial class Predicate_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/function/Predicate;")]
		public static Predicate<T1> isEqual<T1>(IJavaObject arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Predicate<T1>>(typeof(Predicate<>), "isEqual", "(Ljava/lang/Object;)Ljava/util/function/Predicate;", arg0);
		}
	
	}
}
