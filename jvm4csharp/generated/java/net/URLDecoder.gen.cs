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
	[JavaProxy("java/net/URLDecoder")]
	public class URLDecoder : Object
	{
		protected URLDecoder(ProxyCtor p) : base(p) {}
		
		public URLDecoder() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String decode(String arg0)
		{
			return Static.CallMethod<String>(typeof(URLDecoder), "decode", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public static String decode(String arg0, String arg1)
		{
			return Static.CallMethod<String>(typeof(URLDecoder), "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
	}
}
