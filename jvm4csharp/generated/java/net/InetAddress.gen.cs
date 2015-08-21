//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/InetAddress")]
	public partial class InetAddress : Object, Serializable
	{
		protected InetAddress(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()[B")]
		public ByteArray getAddress()
		{
			return Instance.CallMethod<ByteArray>("getAddress", "()[B");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getHostAddress()
		{
			return Instance.CallMethod<String>("getHostAddress", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getHostName()
		{
			return Instance.CallMethod<String>("getHostName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/net/InetAddress;")]
		public static InetAddress getByName(String arg0)
		{
			return Static.CallMethod<InetAddress>(typeof(InetAddress), "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;", arg0);
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public static InetAddress getLoopbackAddress()
		{
			return Static.CallMethod<InetAddress>(typeof(InetAddress), "getLoopbackAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()Z")]
		public bool isAnyLocalAddress()
		{
			return Instance.CallMethod<bool>("isAnyLocalAddress", "()Z");
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public static InetAddress getLocalHost()
		{
			return Static.CallMethod<InetAddress>(typeof(InetAddress), "getLocalHost", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("(Ljava/lang/String;)[Ljava/net/InetAddress;")]
		public static ObjectArray<InetAddress> getAllByName(String arg0)
		{
			return Static.CallMethod<ObjectArray<InetAddress>>(typeof(InetAddress), "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;", arg0);
		}
		
		[JavaSignature("([B)Ljava/net/InetAddress;")]
		public static InetAddress getByAddress(ByteArray arg0)
		{
			return Static.CallMethod<InetAddress>(typeof(InetAddress), "getByAddress", "([B)Ljava/net/InetAddress;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;[B)Ljava/net/InetAddress;")]
		public static InetAddress getByAddress(String arg0, ByteArray arg1)
		{
			return Static.CallMethod<InetAddress>(typeof(InetAddress), "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCanonicalHostName()
		{
			return Instance.CallMethod<String>("getCanonicalHostName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isLinkLocalAddress()
		{
			return Instance.CallMethod<bool>("isLinkLocalAddress", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isLoopbackAddress()
		{
			return Instance.CallMethod<bool>("isLoopbackAddress", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMCGlobal()
		{
			return Instance.CallMethod<bool>("isMCGlobal", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMCLinkLocal()
		{
			return Instance.CallMethod<bool>("isMCLinkLocal", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMCNodeLocal()
		{
			return Instance.CallMethod<bool>("isMCNodeLocal", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMCOrgLocal()
		{
			return Instance.CallMethod<bool>("isMCOrgLocal", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMCSiteLocal()
		{
			return Instance.CallMethod<bool>("isMCSiteLocal", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMulticastAddress()
		{
			return Instance.CallMethod<bool>("isMulticastAddress", "()Z");
		}
		
		[JavaSignature("(I)Z")]
		public bool isReachable(int arg0)
		{
			return Instance.CallMethod<bool>("isReachable", "(I)Z", arg0);
		}
		
		[JavaSignature("(Ljava/net/NetworkInterface;II)Z")]
		public bool isReachable(NetworkInterface arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<bool>("isReachable", "(Ljava/net/NetworkInterface;II)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Z")]
		public bool isSiteLocalAddress()
		{
			return Instance.CallMethod<bool>("isSiteLocalAddress", "()Z");
		}
	}
}
