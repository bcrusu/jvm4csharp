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
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Appendable")]
	public partial interface Appendable : IJavaObject
	{
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;")]
		Appendable append(CharSequence arg0);
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;")]
		Appendable append(CharSequence arg0, int arg1, int arg2);
		
		[JavaSignature("(C)Ljava/lang/Appendable;")]
		Appendable append(char arg0);
	}
}
