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
	[JavaProxy("java/util/function/BiConsumer")]
	public partial interface BiConsumer<T, U> : IJavaObject
		where T : IJavaObject
		where U : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/BiConsumer;)Ljava/util/function/BiConsumer;")]
		BiConsumer<T, U> andThen(BiConsumer<IJavaObject, IJavaObject> arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)V")]
		void accept(T arg0, U arg1);
	}
}
