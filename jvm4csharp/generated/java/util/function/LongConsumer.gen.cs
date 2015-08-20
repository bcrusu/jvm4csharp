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
	[JavaProxy("java/util/function/LongConsumer")]
	public partial interface LongConsumer : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/LongConsumer;)Ljava/util/function/LongConsumer;")]
		LongConsumer andThen(LongConsumer arg0);
		
		[JavaSignature("(J)V")]
		void accept(long arg0);
	}
}
