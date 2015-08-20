//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.net;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/MulticastChannel")]
	public partial interface MulticastChannel : NetworkChannel
	{
		[JavaSignature("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;")]
		MembershipKey @join(InetAddress arg0, NetworkInterface arg1);
		
		[JavaSignature("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;")]
		MembershipKey @join(InetAddress arg0, NetworkInterface arg1, InetAddress arg2);
		
		[JavaSignature("()V")]
		new void close();
	}
}
