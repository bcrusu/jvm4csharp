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
using jvm4csharp.java.nio.channels;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/DatagramSocket")]
	public partial class DatagramSocket : Object, Closeable
	{
		protected DatagramSocket(ProxyCtor p) : base(p) {}
		
		public DatagramSocket(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public DatagramSocket(SocketAddress arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/SocketAddress;)V", arg0);
		}
		
		public DatagramSocket() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public DatagramSocket(int arg0, InetAddress arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/net/InetAddress;)V", arg0, arg1);
		}
	
		[JavaSignature("(Ljava/net/InetAddress;I)V")]
		public void connect(InetAddress arg0, int arg1)
		{
			Instance.CallMethod("connect", "(Ljava/net/InetAddress;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)V")]
		public void connect(SocketAddress arg0)
		{
			Instance.CallMethod("connect", "(Ljava/net/SocketAddress;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()I")]
		public int getPort()
		{
			return Instance.CallMethod<int>("getPort", "()I");
		}
		
		[JavaSignature("()Ljava/nio/channels/DatagramChannel;")]
		public DatagramChannel getChannel()
		{
			return Instance.CallMethod<DatagramChannel>("getChannel", "()Ljava/nio/channels/DatagramChannel;");
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)V")]
		public void bind(SocketAddress arg0)
		{
			Instance.CallMethod("bind", "(Ljava/net/SocketAddress;)V", arg0);
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getInetAddress()
		{
			return Instance.CallMethod<InetAddress>("getInetAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()I")]
		public int getLocalPort()
		{
			return Instance.CallMethod<int>("getLocalPort", "()I");
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getLocalSocketAddress()
		{
			return Instance.CallMethod<SocketAddress>("getLocalSocketAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("()I")]
		public int getReceiveBufferSize()
		{
			return Instance.CallMethod<int>("getReceiveBufferSize", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool getReuseAddress()
		{
			return Instance.CallMethod<bool>("getReuseAddress", "()Z");
		}
		
		[JavaSignature("()I")]
		public int getSoTimeout()
		{
			return Instance.CallMethod<int>("getSoTimeout", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isBound()
		{
			return Instance.CallMethod<bool>("isBound", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isClosed()
		{
			return Instance.CallMethod<bool>("isClosed", "()Z");
		}
		
		[JavaSignature("(I)V")]
		public void setReceiveBufferSize(int arg0)
		{
			Instance.CallMethod("setReceiveBufferSize", "(I)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setReuseAddress(bool arg0)
		{
			Instance.CallMethod("setReuseAddress", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setSoTimeout(int arg0)
		{
			Instance.CallMethod("setSoTimeout", "(I)V", arg0);
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getLocalAddress()
		{
			return Instance.CallMethod<InetAddress>("getLocalAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getRemoteSocketAddress()
		{
			return Instance.CallMethod<SocketAddress>("getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("()I")]
		public int getSendBufferSize()
		{
			return Instance.CallMethod<int>("getSendBufferSize", "()I");
		}
		
		[JavaSignature("()I")]
		public int getTrafficClass()
		{
			return Instance.CallMethod<int>("getTrafficClass", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isConnected()
		{
			return Instance.CallMethod<bool>("isConnected", "()Z");
		}
		
		[JavaSignature("(I)V")]
		public void setSendBufferSize(int arg0)
		{
			Instance.CallMethod("setSendBufferSize", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setTrafficClass(int arg0)
		{
			Instance.CallMethod("setTrafficClass", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/DatagramPacket;)V")]
		public void receive(DatagramPacket arg0)
		{
			Instance.CallMethod("receive", "(Ljava/net/DatagramPacket;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void disconnect()
		{
			Instance.CallMethod("disconnect", "()V");
		}
		
		[JavaSignature("(Ljava/net/DatagramPacket;)V")]
		public void send(DatagramPacket arg0)
		{
			Instance.CallMethod("send", "(Ljava/net/DatagramPacket;)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool getBroadcast()
		{
			return Instance.CallMethod<bool>("getBroadcast", "()Z");
		}
		
		[JavaSignature("(Z)V")]
		public void setBroadcast(bool arg0)
		{
			Instance.CallMethod("setBroadcast", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/DatagramSocketImplFactory;)V")]
		public static void setDatagramSocketImplFactory(DatagramSocketImplFactory arg0)
		{
			Static.CallMethod(typeof(DatagramSocket), "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V", arg0);
		}
	}
}
