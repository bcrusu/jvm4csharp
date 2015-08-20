//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.regex
{
	[JavaProxy("java/util/regex/MatchResult")]
	public partial interface MatchResult : IJavaObject
	{
		[JavaSignature("()Ljava/lang/String;")]
		String @group();
		
		[JavaSignature("(I)Ljava/lang/String;")]
		String @group(int arg0);
		
		[JavaSignature("(I)I")]
		int start(int arg0);
		
		[JavaSignature("()I")]
		int start();
		
		[JavaSignature("(I)I")]
		int end(int arg0);
		
		[JavaSignature("()I")]
		int end();
		
		[JavaSignature("()I")]
		int groupCount();
	}
}
