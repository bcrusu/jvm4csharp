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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/MissingFormatWidthException")]
	public partial class MissingFormatWidthException : IllegalFormatException
	{
		protected MissingFormatWidthException(ProxyCtor p) : base(p) {}
		
		public MissingFormatWidthException(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getFormatSpecifier()
		{
			return Instance.CallMethod<String>("getFormatSpecifier", "()Ljava/lang/String;");
		}
	}
}
