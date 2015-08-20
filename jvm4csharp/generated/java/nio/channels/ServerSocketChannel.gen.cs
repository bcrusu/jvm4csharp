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
using jvm4csharp.java.nio.channels.spi;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/ServerSocketChannel")]
	public abstract partial class ServerSocketChannel : AbstractSelectableChannel, NetworkChannel
	{
		protected ServerSocketChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/channels/SocketChannel;")]
		public SocketChannel accept()
		{
			return Instance.CallMethod<SocketChannel>("accept", "()Ljava/nio/channels/SocketChannel;");
		}
		
		[JavaSignature("()Ljava/nio/channels/ServerSocketChannel;")]
		public static ServerSocketChannel open()
		{
			return Static.CallMethod<ServerSocketChannel>(typeof(ServerSocketChannel), "open", "()Ljava/nio/channels/ServerSocketChannel;");
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;I)Ljava/nio/channels/ServerSocketChannel;")]
		public ServerSocketChannel bind(SocketAddress arg0, int arg1)
		{
			return Instance.CallMethod<ServerSocketChannel>("bind", "(Ljava/net/SocketAddress;I)Ljava/nio/channels/ServerSocketChannel;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/ServerSocketChannel;")]
		public ServerSocketChannel bind(SocketAddress arg0)
		{
			return Instance.CallMethod<ServerSocketChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/ServerSocketChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/ServerSocketChannel;")]
		public ServerSocketChannel setOption<T>(SocketOption<T> arg0, T arg1)
			where T : IJavaObject
		{
			return Instance.CallMethod<ServerSocketChannel>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/ServerSocketChannel;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getLocalAddress()
		{
			return Instance.CallMethod<SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("()Ljava/net/ServerSocket;")]
		public ServerSocket socket()
		{
			return Instance.CallMethod<ServerSocket>("socket", "()Ljava/net/ServerSocket;");
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;")]
		NetworkChannel NetworkChannel.bind(SocketAddress arg0)
		{
			return Instance.CallMethod<NetworkChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketOption;)Ljava/lang/Object;")]
		public T getOption<T>(SocketOption<T> arg0)
			where T : IJavaObject
		{
			return Instance.CallMethod<T>("getOption", "(Ljava/net/SocketOption;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;")]
		NetworkChannel NetworkChannel.setOption<T>(SocketOption<T> arg0, T arg1)
		{
			return Instance.CallMethod<NetworkChannel>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<SocketOption<IJavaObject>> supportedOptions()
		{
			return Instance.CallMethod<Set<SocketOption<IJavaObject>>>("supportedOptions", "()Ljava/util/Set;");
		}
	}
}
