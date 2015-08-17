//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/CharSequence")]
	public interface CharSequence : IJavaObject
	{
		[JavaSignature("(I)C")]
		char charAt(int arg0);
		
		[JavaSignature("()I")]
		int length();
		
		[JavaSignature("(II)Ljava/lang/CharSequence;")]
		CharSequence subSequence(int arg0, int arg1);
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		IntStream chars();
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		IntStream codePoints();
	}
}
