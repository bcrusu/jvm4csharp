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
	[JavaProxy("java/nio/channels/DatagramChannel")]
	public abstract class DatagramChannel : AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel, MulticastChannel
	{
		protected DatagramChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
		public long write(ObjectArray<ByteBuffer> arg0)
		{
			return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;)J", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
		public long write(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		public int write(ByteBuffer arg0)
		{
			return Instance.CallMethod<int>("write", "(Ljava/nio/ByteBuffer;)I", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;")]
		public DatagramChannel connect(SocketAddress arg0)
		{
			return Instance.CallMethod<DatagramChannel>("connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		public int read(ByteBuffer arg0)
		{
			return Instance.CallMethod<int>("read", "(Ljava/nio/ByteBuffer;)I", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
		public long read(ObjectArray<ByteBuffer> arg0)
		{
			return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;)J", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
		public long read(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;")]
		public static DatagramChannel open(ProtocolFamily arg0)
		{
			return Static.CallMethod<DatagramChannel>(typeof(DatagramChannel), "open", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/channels/DatagramChannel;")]
		public static DatagramChannel open()
		{
			return Static.CallMethod<DatagramChannel>(typeof(DatagramChannel), "open", "()Ljava/nio/channels/DatagramChannel;");
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
		
		[JavaSignature("(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;")]
		public DatagramChannel bind(SocketAddress arg0)
		{
			return Instance.CallMethod<DatagramChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/DatagramChannel;")]
		public DatagramChannel setOption<T>(SocketOption<T> arg0, T arg1)
			where T : IJavaObject
		{
			return Instance.CallMethod<DatagramChannel>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/DatagramChannel;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/net/DatagramSocket;")]
		public DatagramSocket socket()
		{
			return Instance.CallMethod<DatagramSocket>("socket", "()Ljava/net/DatagramSocket;");
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;")]
		public SocketAddress receive(ByteBuffer arg0)
		{
			return Instance.CallMethod<SocketAddress>("receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", arg0);
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getRemoteAddress()
		{
			return Instance.CallMethod<SocketAddress>("getRemoteAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("()Ljava/nio/channels/DatagramChannel;")]
		public DatagramChannel disconnect()
		{
			return Instance.CallMethod<DatagramChannel>("disconnect", "()Ljava/nio/channels/DatagramChannel;");
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I")]
		public int send(ByteBuffer arg0, SocketAddress arg1)
		{
			return Instance.CallMethod<int>("send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;")]
		public MembershipKey @join(InetAddress arg0, NetworkInterface arg1)
		{
			return Instance.CallMethod<MembershipKey>("join", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;")]
		public MembershipKey @join(InetAddress arg0, NetworkInterface arg1, InetAddress arg2)
		{
			return Instance.CallMethod<MembershipKey>("join", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", arg0, arg1, arg2);
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
