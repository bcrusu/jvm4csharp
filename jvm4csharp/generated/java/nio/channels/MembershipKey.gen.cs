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
using jvm4csharp.java.net;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/MembershipKey")]
	public abstract class MembershipKey : Object
	{
		protected MembershipKey(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress @group()
		{
			return Instance.CallMethod<InetAddress>("group", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()Ljava/nio/channels/MulticastChannel;")]
		public MulticastChannel channel()
		{
			return Instance.CallMethod<MulticastChannel>("channel", "()Ljava/nio/channels/MulticastChannel;");
		}
		
		[JavaSignature("()Z")]
		public bool isValid()
		{
			return Instance.CallMethod<bool>("isValid", "()Z");
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;")]
		public MembershipKey block(InetAddress arg0)
		{
			return Instance.CallMethod<MembershipKey>("block", "(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", arg0);
		}
		
		[JavaSignature("()V")]
		public void drop()
		{
			Instance.CallMethod("drop", "()V");
		}
		
		[JavaSignature("()Ljava/net/NetworkInterface;")]
		public NetworkInterface networkInterface()
		{
			return Instance.CallMethod<NetworkInterface>("networkInterface", "()Ljava/net/NetworkInterface;");
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress sourceAddress()
		{
			return Instance.CallMethod<InetAddress>("sourceAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;")]
		public MembershipKey unblock(InetAddress arg0)
		{
			return Instance.CallMethod<MembershipKey>("unblock", "(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", arg0);
		}
	}
}
