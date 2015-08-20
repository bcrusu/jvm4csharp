//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/MulticastSocket")]
	public partial class MulticastSocket : DatagramSocket
	{
		protected MulticastSocket(ProxyCtor p) : base(p) {}
		
		public MulticastSocket(SocketAddress arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/SocketAddress;)V", arg0);
		}
		
		public MulticastSocket(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public MulticastSocket() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()I")]
		public int getTimeToLive()
		{
			return Instance.CallMethod<int>("getTimeToLive", "()I");
		}
		
		[JavaSignature("(Ljava/net/DatagramPacket;B)V")]
		public void send(DatagramPacket arg0, byte arg1)
		{
			Instance.CallMethod("send", "(Ljava/net/DatagramPacket;B)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getInterface()
		{
			return Instance.CallMethod<InetAddress>("getInterface", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()Z")]
		public bool getLoopbackMode()
		{
			return Instance.CallMethod<bool>("getLoopbackMode", "()Z");
		}
		
		[JavaSignature("()Ljava/net/NetworkInterface;")]
		public NetworkInterface getNetworkInterface()
		{
			return Instance.CallMethod<NetworkInterface>("getNetworkInterface", "()Ljava/net/NetworkInterface;");
		}
		
		[JavaSignature("()B")]
		public byte getTTL()
		{
			return Instance.CallMethod<byte>("getTTL", "()B");
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V")]
		public void joinGroup(SocketAddress arg0, NetworkInterface arg1)
		{
			Instance.CallMethod("joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)V")]
		public void joinGroup(InetAddress arg0)
		{
			Instance.CallMethod("joinGroup", "(Ljava/net/InetAddress;)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V")]
		public void leaveGroup(SocketAddress arg0, NetworkInterface arg1)
		{
			Instance.CallMethod("leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)V")]
		public void leaveGroup(InetAddress arg0)
		{
			Instance.CallMethod("leaveGroup", "(Ljava/net/InetAddress;)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)V")]
		public void setInterface(InetAddress arg0)
		{
			Instance.CallMethod("setInterface", "(Ljava/net/InetAddress;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setLoopbackMode(bool arg0)
		{
			Instance.CallMethod("setLoopbackMode", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/NetworkInterface;)V")]
		public void setNetworkInterface(NetworkInterface arg0)
		{
			Instance.CallMethod("setNetworkInterface", "(Ljava/net/NetworkInterface;)V", arg0);
		}
		
		[JavaSignature("(B)V")]
		public void setTTL(byte arg0)
		{
			Instance.CallMethod("setTTL", "(B)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setTimeToLive(int arg0)
		{
			Instance.CallMethod("setTimeToLive", "(I)V", arg0);
		}
	}
}
