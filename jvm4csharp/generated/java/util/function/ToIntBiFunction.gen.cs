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
	[JavaProxy("java/util/function/ToIntBiFunction")]
	public interface ToIntBiFunction<T, U> : IJavaObject
		where T : IJavaObject
		where U : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)I")]
		int applyAsInt(T arg0, U arg1);
	}
}
