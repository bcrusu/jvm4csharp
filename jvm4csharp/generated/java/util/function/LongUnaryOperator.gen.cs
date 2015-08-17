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
	[JavaProxy("java/util/function/LongUnaryOperator")]
	public interface LongUnaryOperator : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;")]
		LongUnaryOperator andThen(LongUnaryOperator arg0);
		
		[JavaSignature("(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;")]
		LongUnaryOperator compose(LongUnaryOperator arg0);
		
		[JavaSignature("(J)J")]
		long applyAsLong(long arg0);
	}
	
	public static class LongUnaryOperator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("()Ljava/util/function/LongUnaryOperator;")]
		public static LongUnaryOperator identity()
		{
			return Static.CallMethod<LongUnaryOperator>(typeof(LongUnaryOperator), "identity", "()Ljava/util/function/LongUnaryOperator;");
		}
	
	}
}
