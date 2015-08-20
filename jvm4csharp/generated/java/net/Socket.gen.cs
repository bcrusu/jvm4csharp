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
	[JavaProxy("java/net/Socket")]
	public partial class Socket : Object, Closeable
	{
		protected Socket(ProxyCtor p) : base(p) {}
		
		public Socket(String arg0, int arg1, InetAddress arg2, int arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;ILjava/net/InetAddress;I)V", arg0, arg1, arg2, arg3);
		}
		
		public Socket(InetAddress arg0, int arg1, InetAddress arg2, int arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V", arg0, arg1, arg2, arg3);
		}
		
		public Socket(String arg0, int arg1, bool arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;IZ)V", arg0, arg1, arg2);
		}
		
		public Socket(InetAddress arg0, int arg1, bool arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/InetAddress;IZ)V", arg0, arg1, arg2);
		}
		
		public Socket() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Socket(Proxy arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/Proxy;)V", arg0);
		}
		
		public Socket(String arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;I)V", arg0, arg1);
		}
		
		public Socket(InetAddress arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/InetAddress;I)V", arg0, arg1);
		}
	
		[JavaSignature("(Ljava/net/SocketAddress;I)V")]
		public void connect(SocketAddress arg0, int arg1)
		{
			Instance.CallMethod("connect", "(Ljava/net/SocketAddress;I)V", arg0, arg1);
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
		
		[JavaSignature("()Ljava/io/InputStream;")]
		public InputStream getInputStream()
		{
			return Instance.CallMethod<InputStream>("getInputStream", "()Ljava/io/InputStream;");
		}
		
		[JavaSignature("()I")]
		public int getPort()
		{
			return Instance.CallMethod<int>("getPort", "()I");
		}
		
		[JavaSignature("()Ljava/nio/channels/SocketChannel;")]
		public SocketChannel getChannel()
		{
			return Instance.CallMethod<SocketChannel>("getChannel", "()Ljava/nio/channels/SocketChannel;");
		}
		
		[JavaSignature("()Ljava/io/OutputStream;")]
		public OutputStream getOutputStream()
		{
			return Instance.CallMethod<OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
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
		
		[JavaSignature("(I)V")]
		public void sendUrgentData(int arg0)
		{
			Instance.CallMethod("sendUrgentData", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void shutdownInput()
		{
			Instance.CallMethod("shutdownInput", "()V");
		}
		
		[JavaSignature("()V")]
		public void shutdownOutput()
		{
			Instance.CallMethod("shutdownOutput", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool getKeepAlive()
		{
			return Instance.CallMethod<bool>("getKeepAlive", "()Z");
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getLocalAddress()
		{
			return Instance.CallMethod<InetAddress>("getLocalAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()Z")]
		public bool getOOBInline()
		{
			return Instance.CallMethod<bool>("getOOBInline", "()Z");
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
		public int getSoLinger()
		{
			return Instance.CallMethod<int>("getSoLinger", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool getTcpNoDelay()
		{
			return Instance.CallMethod<bool>("getTcpNoDelay", "()Z");
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
		
		[JavaSignature("()Z")]
		public bool isInputShutdown()
		{
			return Instance.CallMethod<bool>("isInputShutdown", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isOutputShutdown()
		{
			return Instance.CallMethod<bool>("isOutputShutdown", "()Z");
		}
		
		[JavaSignature("(Z)V")]
		public void setKeepAlive(bool arg0)
		{
			Instance.CallMethod("setKeepAlive", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setOOBInline(bool arg0)
		{
			Instance.CallMethod("setOOBInline", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setSendBufferSize(int arg0)
		{
			Instance.CallMethod("setSendBufferSize", "(I)V", arg0);
		}
		
		[JavaSignature("(ZI)V")]
		public void setSoLinger(bool arg0, int arg1)
		{
			Instance.CallMethod("setSoLinger", "(ZI)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/SocketImplFactory;)V")]
		public static void setSocketImplFactory(SocketImplFactory arg0)
		{
			Static.CallMethod(typeof(Socket), "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setTcpNoDelay(bool arg0)
		{
			Instance.CallMethod("setTcpNoDelay", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setTrafficClass(int arg0)
		{
			Instance.CallMethod("setTrafficClass", "(I)V", arg0);
		}
	}
}
