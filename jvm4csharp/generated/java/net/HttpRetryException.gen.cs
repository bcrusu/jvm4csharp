//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/HttpRetryException")]
	public class HttpRetryException : IOException
	{
		protected HttpRetryException(ProxyCtor p) : base(p) {}
		
		public HttpRetryException(String arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;I)V", arg0, arg1);
		}
		
		public HttpRetryException(String arg0, int arg1, String arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;ILjava/lang/String;)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getLocation()
		{
			return Instance.CallMethod<String>("getLocation", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getReason()
		{
			return Instance.CallMethod<String>("getReason", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int responseCode()
		{
			return Instance.CallMethod<int>("responseCode", "()I");
		}
	}
}
