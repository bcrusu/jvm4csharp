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
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/URISyntaxException")]
	public class URISyntaxException : Exception
	{
		protected URISyntaxException(ProxyCtor p) : base(p) {}
		
		public URISyntaxException(String arg0, String arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;I)V", arg0, arg1, arg2);
		}
		
		public URISyntaxException(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()I")]
		public int getIndex()
		{
			return Instance.CallMethod<int>("getIndex", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getInput()
		{
			return Instance.CallMethod<String>("getInput", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getReason()
		{
			return Instance.CallMethod<String>("getReason", "()Ljava/lang/String;");
		}
	}
}
