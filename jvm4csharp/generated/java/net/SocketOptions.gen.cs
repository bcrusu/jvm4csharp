//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/SocketOptions")]
	public interface SocketOptions : IJavaObject
	{
		[JavaSignature("(I)Ljava/lang/Object;")]
		IJavaObject getOption(int arg0);
		
		[JavaSignature("(ILjava/lang/Object;)V")]
		void setOption(int arg0, IJavaObject arg1);
	}
	
	public static class SocketOptions_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("I")]
		public static int TCP_NODELAY
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "TCP_NODELAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_BINDADDR
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_BINDADDR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_REUSEADDR
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_REUSEADDR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_BROADCAST
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_BROADCAST", "I"); }
		}
		
		[JavaSignature("I")]
		public static int IP_MULTICAST_IF
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "IP_MULTICAST_IF", "I"); }
		}
		
		[JavaSignature("I")]
		public static int IP_MULTICAST_IF2
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "IP_MULTICAST_IF2", "I"); }
		}
		
		[JavaSignature("I")]
		public static int IP_MULTICAST_LOOP
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "IP_MULTICAST_LOOP", "I"); }
		}
		
		[JavaSignature("I")]
		public static int IP_TOS
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "IP_TOS", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_LINGER
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_LINGER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_TIMEOUT
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_TIMEOUT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_SNDBUF
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_SNDBUF", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_RCVBUF
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_RCVBUF", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_KEEPALIVE
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_KEEPALIVE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SO_OOBINLINE
		{
			get { return Static.GetField<int>(typeof(SocketOptions), "SO_OOBINLINE", "I"); }
		}
	
	}
}
