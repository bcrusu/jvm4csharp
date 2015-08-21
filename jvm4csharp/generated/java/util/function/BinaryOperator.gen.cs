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
	[JavaProxy("java/util/function/BinaryOperator")]
	public partial interface BinaryOperator<T> : BiFunction<T, T, T>
		where T : IJavaObject
	{
	}
	
	public static partial class BinaryOperator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;")]
		public static BinaryOperator<T1> maxBy<T1>(Comparator<IJavaObject> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<BinaryOperator<T1>>(typeof(BinaryOperator<>), "maxBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;")]
		public static BinaryOperator<T1> minBy<T1>(Comparator<IJavaObject> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<BinaryOperator<T1>>(typeof(BinaryOperator<>), "minBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", arg0);
		}
	
	}
}
