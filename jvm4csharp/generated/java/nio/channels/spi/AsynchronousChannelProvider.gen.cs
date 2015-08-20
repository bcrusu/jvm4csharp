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
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels.spi
{
	[JavaProxy("java/nio/channels/spi/AsynchronousChannelProvider")]
	public abstract partial class AsynchronousChannelProvider : Object
	{
		protected AsynchronousChannelProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/channels/spi/AsynchronousChannelProvider;")]
		public static AsynchronousChannelProvider provider()
		{
			return Static.CallMethod<AsynchronousChannelProvider>(typeof(AsynchronousChannelProvider), "provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;")]
		public AsynchronousChannelGroup openAsynchronousChannelGroup(ExecutorService arg0, int arg1)
		{
			return Instance.CallMethod<AsynchronousChannelGroup>("openAsynchronousChannelGroup", "(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;")]
		public AsynchronousChannelGroup openAsynchronousChannelGroup(int arg0, ThreadFactory arg1)
		{
			return Instance.CallMethod<AsynchronousChannelGroup>("openAsynchronousChannelGroup", "(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;")]
		public AsynchronousServerSocketChannel openAsynchronousServerSocketChannel(AsynchronousChannelGroup arg0)
		{
			return Instance.CallMethod<AsynchronousServerSocketChannel>("openAsynchronousServerSocketChannel", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;")]
		public AsynchronousSocketChannel openAsynchronousSocketChannel(AsynchronousChannelGroup arg0)
		{
			return Instance.CallMethod<AsynchronousSocketChannel>("openAsynchronousSocketChannel", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;", arg0);
		}
	}
}
