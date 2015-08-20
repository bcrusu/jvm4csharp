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
	[JavaProxy("java/util/regex/PatternSyntaxException")]
	public partial class PatternSyntaxException : IllegalArgumentException
	{
		protected PatternSyntaxException(ProxyCtor p) : base(p) {}
		
		public PatternSyntaxException(String arg0, String arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;I)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("()I")]
		public int getIndex()
		{
			return Instance.CallMethod<int>("getIndex", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDescription()
		{
			return Instance.CallMethod<String>("getDescription", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPattern()
		{
			return Instance.CallMethod<String>("getPattern", "()Ljava/lang/String;");
		}
	}
}
