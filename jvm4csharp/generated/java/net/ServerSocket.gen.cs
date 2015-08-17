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
	[JavaProxy("java/net/ServerSocket")]
	public class ServerSocket : Object, Closeable
	{
		protected ServerSocket(ProxyCtor p) : base(p) {}
		
		public ServerSocket(int arg0, int arg1, InetAddress arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IILjava/net/InetAddress;)V", arg0, arg1, arg2);
		}
		
		public ServerSocket(int arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(II)V", arg0, arg1);
		}
		
		public ServerSocket(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public ServerSocket() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()Ljava/net/Socket;")]
		public Socket accept()
		{
			return Instance.CallMethod<Socket>("accept", "()Ljava/net/Socket;");
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Ljava/nio/channels/ServerSocketChannel;")]
		public ServerSocketChannel getChannel()
		{
			return Instance.CallMethod<ServerSocketChannel>("getChannel", "()Ljava/nio/channels/ServerSocketChannel;");
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;I)V")]
		public void bind(SocketAddress arg0, int arg1)
		{
			Instance.CallMethod("bind", "(Ljava/net/SocketAddress;I)V", arg0, arg1);
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
		
		[JavaSignature("(III)V")]
		public void setPerformancePreferences(int arg0, int arg1, int arg2)
		{
			Instance.CallMethod("setPerformancePreferences", "(III)V", arg0, arg1, arg2);
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
		
		[JavaSignature("(Ljava/net/SocketImplFactory;)V")]
		public static void setSocketFactory(SocketImplFactory arg0)
		{
			Static.CallMethod(typeof(ServerSocket), "setSocketFactory", "(Ljava/net/SocketImplFactory;)V", arg0);
		}
	}
}
