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
using jvm4csharp.java.nio.channels.spi;
using jvm4csharp.java.util;
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/AsynchronousServerSocketChannel")]
	public abstract partial class AsynchronousServerSocketChannel : Object, AsynchronousChannel, NetworkChannel
	{
		protected AsynchronousServerSocketChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/channels/spi/AsynchronousChannelProvider;")]
		public AsynchronousChannelProvider provider()
		{
			return Instance.CallMethod<AsynchronousChannelProvider>("provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/Future;")]
		public Future<AsynchronousSocketChannel> accept()
		{
			return Instance.CallMethod<Future<AsynchronousSocketChannel>>("accept", "()Ljava/util/concurrent/Future;");
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void accept<A>(A arg0, CompletionHandler<AsynchronousSocketChannel, IJavaObject> arg1)
			where A : IJavaObject
		{
			Instance.CallMethod("accept", "(Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/nio/channels/AsynchronousServerSocketChannel;")]
		public static AsynchronousServerSocketChannel open()
		{
			return Static.CallMethod<AsynchronousServerSocketChannel>(typeof(AsynchronousServerSocketChannel), "open", "()Ljava/nio/channels/AsynchronousServerSocketChannel;");
		}
		
		[JavaSignature("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;")]
		public static AsynchronousServerSocketChannel open(AsynchronousChannelGroup arg0)
		{
			return Static.CallMethod<AsynchronousServerSocketChannel>(typeof(AsynchronousServerSocketChannel), "open", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;I)Ljava/nio/channels/AsynchronousServerSocketChannel;")]
		public AsynchronousServerSocketChannel bind(SocketAddress arg0, int arg1)
		{
			return Instance.CallMethod<AsynchronousServerSocketChannel>("bind", "(Ljava/net/SocketAddress;I)Ljava/nio/channels/AsynchronousServerSocketChannel;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/AsynchronousServerSocketChannel;")]
		public AsynchronousServerSocketChannel bind(SocketAddress arg0)
		{
			return Instance.CallMethod<AsynchronousServerSocketChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/AsynchronousServerSocketChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/AsynchronousServerSocketChannel;")]
		public AsynchronousServerSocketChannel setOption<T>(SocketOption<T> arg0, T arg1)
			where T : IJavaObject
		{
			return Instance.CallMethod<AsynchronousServerSocketChannel>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/AsynchronousServerSocketChannel;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getLocalAddress()
		{
			return Instance.CallMethod<SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isOpen()
		{
			return Instance.CallMethod<bool>("isOpen", "()Z");
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
