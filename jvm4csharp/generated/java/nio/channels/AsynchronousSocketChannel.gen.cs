//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;
using jvm4csharp.java.net;
using jvm4csharp.java.nio.channels.spi;
using jvm4csharp.java.util;
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/AsynchronousSocketChannel")]
	public abstract partial class AsynchronousSocketChannel : Object, AsynchronousByteChannel, NetworkChannel
	{
		protected AsynchronousSocketChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/channels/spi/AsynchronousChannelProvider;")]
		public AsynchronousChannelProvider provider()
		{
			return Instance.CallMethod<AsynchronousChannelProvider>("provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;");
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void write<A>(ByteBuffer arg0, A arg1, CompletionHandler<Integer, IJavaObject> arg2)
			where A : IJavaObject
		{
			Instance.CallMethod("write", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;JLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void write<A>(ByteBuffer arg0, long arg1, TimeUnit arg2, A arg3, CompletionHandler<Integer, IJavaObject> arg4)
			where A : IJavaObject
		{
			Instance.CallMethod("write", "(Ljava/nio/ByteBuffer;JLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;")]
		public Future<Integer> write(ByteBuffer arg0)
		{
			return Instance.CallMethod<Future<Integer>>("write", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;IIJLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void write<A>(ObjectArray<ByteBuffer> arg0, int arg1, int arg2, long arg3, TimeUnit arg4, A arg5, CompletionHandler<Long, IJavaObject> arg6)
			where A : IJavaObject
		{
			Instance.CallMethod("write", "([Ljava/nio/ByteBuffer;IIJLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/util/concurrent/Future;")]
		public Future<Void> connect(SocketAddress arg0)
		{
			return Instance.CallMethod<Future<Void>>("connect", "(Ljava/net/SocketAddress;)Ljava/util/concurrent/Future;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void connect<A>(SocketAddress arg0, A arg1, CompletionHandler<Void, IJavaObject> arg2)
			where A : IJavaObject
		{
			Instance.CallMethod("connect", "(Ljava/net/SocketAddress;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;JLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void read<A>(ByteBuffer arg0, long arg1, TimeUnit arg2, A arg3, CompletionHandler<Integer, IJavaObject> arg4)
			where A : IJavaObject
		{
			Instance.CallMethod("read", "(Ljava/nio/ByteBuffer;JLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void read<A>(ByteBuffer arg0, A arg1, CompletionHandler<Integer, IJavaObject> arg2)
			where A : IJavaObject
		{
			Instance.CallMethod("read", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;")]
		public Future<Integer> read(ByteBuffer arg0)
		{
			return Instance.CallMethod<Future<Integer>>("read", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;IIJLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void read<A>(ObjectArray<ByteBuffer> arg0, int arg1, int arg2, long arg3, TimeUnit arg4, A arg5, CompletionHandler<Long, IJavaObject> arg6)
			where A : IJavaObject
		{
			Instance.CallMethod("read", "([Ljava/nio/ByteBuffer;IIJLjava/util/concurrent/TimeUnit;Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}
		
		[JavaSignature("()Ljava/nio/channels/AsynchronousSocketChannel;")]
		public static AsynchronousSocketChannel open()
		{
			return Static.CallMethod<AsynchronousSocketChannel>(typeof(AsynchronousSocketChannel), "open", "()Ljava/nio/channels/AsynchronousSocketChannel;");
		}
		
		[JavaSignature("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;")]
		public static AsynchronousSocketChannel open(AsynchronousChannelGroup arg0)
		{
			return Static.CallMethod<AsynchronousSocketChannel>(typeof(AsynchronousSocketChannel), "open", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/AsynchronousSocketChannel;")]
		public AsynchronousSocketChannel bind(SocketAddress arg0)
		{
			return Instance.CallMethod<AsynchronousSocketChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/AsynchronousSocketChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/AsynchronousSocketChannel;")]
		public AsynchronousSocketChannel setOption<T>(SocketOption<T> arg0, T arg1)
			where T : IJavaObject
		{
			return Instance.CallMethod<AsynchronousSocketChannel>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/AsynchronousSocketChannel;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/nio/channels/AsynchronousSocketChannel;")]
		public AsynchronousSocketChannel shutdownInput()
		{
			return Instance.CallMethod<AsynchronousSocketChannel>("shutdownInput", "()Ljava/nio/channels/AsynchronousSocketChannel;");
		}
		
		[JavaSignature("()Ljava/nio/channels/AsynchronousSocketChannel;")]
		public AsynchronousSocketChannel shutdownOutput()
		{
			return Instance.CallMethod<AsynchronousSocketChannel>("shutdownOutput", "()Ljava/nio/channels/AsynchronousSocketChannel;");
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getLocalAddress()
		{
			return Instance.CallMethod<SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getRemoteAddress()
		{
			return Instance.CallMethod<SocketAddress>("getRemoteAddress", "()Ljava/net/SocketAddress;");
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
