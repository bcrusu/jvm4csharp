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
	[JavaProxy("java/util/function/LongPredicate")]
	public partial interface LongPredicate : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;")]
		LongPredicate and(LongPredicate arg0);
		
		[JavaSignature("(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;")]
		LongPredicate or(LongPredicate arg0);
		
		[JavaSignature("(J)Z")]
		bool test(long arg0);
		
		[JavaSignature("()Ljava/util/function/LongPredicate;")]
		LongPredicate negate();
	}
}
