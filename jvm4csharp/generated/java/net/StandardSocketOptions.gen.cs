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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/StandardSocketOptions")]
	public class StandardSocketOptions : Object
	{
		protected StandardSocketOptions(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Boolean> SO_BROADCAST
		{
			get { return Static.GetField<SocketOption<Boolean>>(typeof(StandardSocketOptions), "SO_BROADCAST", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Boolean> SO_KEEPALIVE
		{
			get { return Static.GetField<SocketOption<Boolean>>(typeof(StandardSocketOptions), "SO_KEEPALIVE", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Integer> SO_SNDBUF
		{
			get { return Static.GetField<SocketOption<Integer>>(typeof(StandardSocketOptions), "SO_SNDBUF", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Integer> SO_RCVBUF
		{
			get { return Static.GetField<SocketOption<Integer>>(typeof(StandardSocketOptions), "SO_RCVBUF", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Boolean> SO_REUSEADDR
		{
			get { return Static.GetField<SocketOption<Boolean>>(typeof(StandardSocketOptions), "SO_REUSEADDR", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Integer> SO_LINGER
		{
			get { return Static.GetField<SocketOption<Integer>>(typeof(StandardSocketOptions), "SO_LINGER", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Integer> IP_TOS
		{
			get { return Static.GetField<SocketOption<Integer>>(typeof(StandardSocketOptions), "IP_TOS", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<NetworkInterface> IP_MULTICAST_IF
		{
			get { return Static.GetField<SocketOption<NetworkInterface>>(typeof(StandardSocketOptions), "IP_MULTICAST_IF", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Integer> IP_MULTICAST_TTL
		{
			get { return Static.GetField<SocketOption<Integer>>(typeof(StandardSocketOptions), "IP_MULTICAST_TTL", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Boolean> IP_MULTICAST_LOOP
		{
			get { return Static.GetField<SocketOption<Boolean>>(typeof(StandardSocketOptions), "IP_MULTICAST_LOOP", "Ljava/net/SocketOption;"); }
		}
		
		[JavaSignature("Ljava/net/SocketOption;")]
		public static SocketOption<Boolean> TCP_NODELAY
		{
			get { return Static.GetField<SocketOption<Boolean>>(typeof(StandardSocketOptions), "TCP_NODELAY", "Ljava/net/SocketOption;"); }
		}
	}
}
