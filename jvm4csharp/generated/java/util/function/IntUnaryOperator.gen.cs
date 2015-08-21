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
	[JavaProxy("java/util/function/IntUnaryOperator")]
	public partial interface IntUnaryOperator : IJavaObject
	{
		[JavaSignature("(I)I")]
		int applyAsInt(int arg0);
		
		[JavaSignature("(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;")]
		IntUnaryOperator andThen(IntUnaryOperator arg0);
		
		[JavaSignature("(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;")]
		IntUnaryOperator compose(IntUnaryOperator arg0);
	}
	
	public static partial class IntUnaryOperator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("()Ljava/util/function/IntUnaryOperator;")]
		public static IntUnaryOperator identity()
		{
			return Static.CallMethod<IntUnaryOperator>(typeof(IntUnaryOperator), "identity", "()Ljava/util/function/IntUnaryOperator;");
		}
	
	}
}
