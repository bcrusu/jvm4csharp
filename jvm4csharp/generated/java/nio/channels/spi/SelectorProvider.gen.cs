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
namespace jvm4csharp.java.nio.channels.spi
{
	[JavaProxy("java/nio/channels/spi/SelectorProvider")]
	public abstract class SelectorProvider : Object
	{
		protected SelectorProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/channels/Channel;")]
		public Channel inheritedChannel()
		{
			return Instance.CallMethod<Channel>("inheritedChannel", "()Ljava/nio/channels/Channel;");
		}
		
		[JavaSignature("()Ljava/nio/channels/spi/SelectorProvider;")]
		public static SelectorProvider provider()
		{
			return Static.CallMethod<SelectorProvider>(typeof(SelectorProvider), "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
		}
		
		[JavaSignature("()Ljava/nio/channels/spi/AbstractSelector;")]
		public AbstractSelector openSelector()
		{
			return Instance.CallMethod<AbstractSelector>("openSelector", "()Ljava/nio/channels/spi/AbstractSelector;");
		}
		
		[JavaSignature("()Ljava/nio/channels/DatagramChannel;")]
		public DatagramChannel openDatagramChannel()
		{
			return Instance.CallMethod<DatagramChannel>("openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;");
		}
		
		[JavaSignature("(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;")]
		public DatagramChannel openDatagramChannel(ProtocolFamily arg0)
		{
			return Instance.CallMethod<DatagramChannel>("openDatagramChannel", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/channels/Pipe;")]
		public Pipe openPipe()
		{
			return Instance.CallMethod<Pipe>("openPipe", "()Ljava/nio/channels/Pipe;");
		}
		
		[JavaSignature("()Ljava/nio/channels/ServerSocketChannel;")]
		public ServerSocketChannel openServerSocketChannel()
		{
			return Instance.CallMethod<ServerSocketChannel>("openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;");
		}
		
		[JavaSignature("()Ljava/nio/channels/SocketChannel;")]
		public SocketChannel openSocketChannel()
		{
			return Instance.CallMethod<SocketChannel>("openSocketChannel", "()Ljava/nio/channels/SocketChannel;");
		}
	}
}
