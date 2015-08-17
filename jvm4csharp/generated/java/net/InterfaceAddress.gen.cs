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
	[JavaProxy("java/net/InterfaceAddress")]
	public class InterfaceAddress : Object
	{
		protected InterfaceAddress(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getAddress()
		{
			return Instance.CallMethod<InetAddress>("getAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()S")]
		public short getNetworkPrefixLength()
		{
			return Instance.CallMethod<short>("getNetworkPrefixLength", "()S");
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getBroadcast()
		{
			return Instance.CallMethod<InetAddress>("getBroadcast", "()Ljava/net/InetAddress;");
		}
	}
}
