//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/Inet6Address")]
	public class Inet6Address : InetAddress
	{
		protected Inet6Address(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;")]
		public static Inet6Address getByAddress(String arg0, ByteArray arg1, NetworkInterface arg2)
		{
			return Static.CallMethod<Inet6Address>(typeof(Inet6Address), "getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;[BI)Ljava/net/Inet6Address;")]
		public static Inet6Address getByAddress(String arg0, ByteArray arg1, int arg2)
		{
			return Static.CallMethod<Inet6Address>(typeof(Inet6Address), "getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()I")]
		public int getScopeId()
		{
			return Instance.CallMethod<int>("getScopeId", "()I");
		}
		
		[JavaSignature("()Ljava/net/NetworkInterface;")]
		public NetworkInterface getScopedInterface()
		{
			return Instance.CallMethod<NetworkInterface>("getScopedInterface", "()Ljava/net/NetworkInterface;");
		}
		
		[JavaSignature("()Z")]
		public bool isIPv4CompatibleAddress()
		{
			return Instance.CallMethod<bool>("isIPv4CompatibleAddress", "()Z");
		}
	}
}
