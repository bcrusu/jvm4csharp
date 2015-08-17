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
	[JavaProxy("java/net/NoRouteToHostException")]
	public class NoRouteToHostException : SocketException
	{
		protected NoRouteToHostException(ProxyCtor p) : base(p) {}
		
		public NoRouteToHostException(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public NoRouteToHostException() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	}
}
