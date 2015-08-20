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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/NetworkInterface")]
	public partial class NetworkInterface : Object
	{
		protected NetworkInterface(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/net/NetworkInterface;")]
		public static NetworkInterface getByName(String arg0)
		{
			return Static.CallMethod<NetworkInterface>(typeof(NetworkInterface), "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/net/NetworkInterface;")]
		public NetworkInterface getParent()
		{
			return Instance.CallMethod<NetworkInterface>("getParent", "()Ljava/net/NetworkInterface;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayName()
		{
			return Instance.CallMethod<String>("getDisplayName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getIndex()
		{
			return Instance.CallMethod<int>("getIndex", "()I");
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<InetAddress> getInetAddresses()
		{
			return Instance.CallMethod<Enumeration<InetAddress>>("getInetAddresses", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public static Enumeration<NetworkInterface> getNetworkInterfaces()
		{
			return Static.CallMethod<Enumeration<NetworkInterface>>(typeof(NetworkInterface), "getNetworkInterfaces", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("(I)Ljava/net/NetworkInterface;")]
		public static NetworkInterface getByIndex(int arg0)
		{
			return Static.CallMethod<NetworkInterface>(typeof(NetworkInterface), "getByIndex", "(I)Ljava/net/NetworkInterface;", arg0);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;")]
		public static NetworkInterface getByInetAddress(InetAddress arg0)
		{
			return Static.CallMethod<NetworkInterface>(typeof(NetworkInterface), "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;", arg0);
		}
		
		[JavaSignature("()[B")]
		public ByteArray getHardwareAddress()
		{
			return Instance.CallMethod<ByteArray>("getHardwareAddress", "()[B");
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public List<InterfaceAddress> getInterfaceAddresses()
		{
			return Instance.CallMethod<List<InterfaceAddress>>("getInterfaceAddresses", "()Ljava/util/List;");
		}
		
		[JavaSignature("()I")]
		public int getMTU()
		{
			return Instance.CallMethod<int>("getMTU", "()I");
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<NetworkInterface> getSubInterfaces()
		{
			return Instance.CallMethod<Enumeration<NetworkInterface>>("getSubInterfaces", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("()Z")]
		public bool isLoopback()
		{
			return Instance.CallMethod<bool>("isLoopback", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isPointToPoint()
		{
			return Instance.CallMethod<bool>("isPointToPoint", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isUp()
		{
			return Instance.CallMethod<bool>("isUp", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isVirtual()
		{
			return Instance.CallMethod<bool>("isVirtual", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool supportsMulticast()
		{
			return Instance.CallMethod<bool>("supportsMulticast", "()Z");
		}
	}
}
