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
using jvm4csharp.java.net;
using jvm4csharp.java.nio.channels.spi;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/SocketChannel")]
	public abstract class SocketChannel : AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel, NetworkChannel
	{
		protected SocketChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
		public long write(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
		public long write(ObjectArray<ByteBuffer> arg0)
		{
			return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;)J", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		public int write(ByteBuffer arg0)
		{
			return Instance.CallMethod<int>("write", "(Ljava/nio/ByteBuffer;)I", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Z")]
		public bool connect(SocketAddress arg0)
		{
			return Instance.CallMethod<bool>("connect", "(Ljava/net/SocketAddress;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		public int read(ByteBuffer arg0)
		{
			return Instance.CallMethod<int>("read", "(Ljava/nio/ByteBuffer;)I", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
		public long read(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
		public long read(ObjectArray<ByteBuffer> arg0)
		{
			return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;)J", arg0);
		}
		
		[JavaSignature("()Ljava/nio/channels/SocketChannel;")]
		public static SocketChannel open()
		{
			return Static.CallMethod<SocketChannel>(typeof(SocketChannel), "open", "()Ljava/nio/channels/SocketChannel;");
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;")]
		public static SocketChannel open(SocketAddress arg0)
		{
			return Static.CallMethod<SocketChannel>(typeof(SocketChannel), "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;", arg0);
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getLocalAddress()
		{
			return Instance.CallMethod<SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("()Z")]
		public bool isConnected()
		{
			return Instance.CallMethod<bool>("isConnected", "()Z");
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;")]
		public SocketChannel bind(SocketAddress arg0)
		{
			return Instance.CallMethod<SocketChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/SocketChannel;")]
		public SocketChannel setOption<T>(SocketOption<T> arg0, T arg1)
			where T : IJavaObject
		{
			return Instance.CallMethod<SocketChannel>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/SocketChannel;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/nio/channels/SocketChannel;")]
		public SocketChannel shutdownInput()
		{
			return Instance.CallMethod<SocketChannel>("shutdownInput", "()Ljava/nio/channels/SocketChannel;");
		}
		
		[JavaSignature("()Ljava/nio/channels/SocketChannel;")]
		public SocketChannel shutdownOutput()
		{
			return Instance.CallMethod<SocketChannel>("shutdownOutput", "()Ljava/nio/channels/SocketChannel;");
		}
		
		[JavaSignature("()Ljava/net/Socket;")]
		public Socket socket()
		{
			return Instance.CallMethod<Socket>("socket", "()Ljava/net/Socket;");
		}
		
		[JavaSignature("()Z")]
		public bool finishConnect()
		{
			return Instance.CallMethod<bool>("finishConnect", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isConnectionPending()
		{
			return Instance.CallMethod<bool>("isConnectionPending", "()Z");
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getRemoteAddress()
		{
			return Instance.CallMethod<SocketAddress>("getRemoteAddress", "()Ljava/net/SocketAddress;");
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
