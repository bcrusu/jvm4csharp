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
	[JavaProxy("java/util/function/DoubleUnaryOperator")]
	public partial interface DoubleUnaryOperator : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;")]
		DoubleUnaryOperator andThen(DoubleUnaryOperator arg0);
		
		[JavaSignature("(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;")]
		DoubleUnaryOperator compose(DoubleUnaryOperator arg0);
		
		[JavaSignature("(D)D")]
		double applyAsDouble(double arg0);
	}
	
	public static class DoubleUnaryOperator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("()Ljava/util/function/DoubleUnaryOperator;")]
		public static DoubleUnaryOperator identity()
		{
			return Static.CallMethod<DoubleUnaryOperator>(typeof(DoubleUnaryOperator), "identity", "()Ljava/util/function/DoubleUnaryOperator;");
		}
	
	}
}
