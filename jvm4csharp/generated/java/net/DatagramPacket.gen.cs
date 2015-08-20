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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/DatagramPacket")]
	public partial class DatagramPacket : Object
	{
		protected DatagramPacket(ProxyCtor p) : base(p) {}
		
		public DatagramPacket(ByteArray arg0, int arg1, SocketAddress arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BILjava/net/SocketAddress;)V", arg0, arg1, arg2);
		}
		
		public DatagramPacket(ByteArray arg0, int arg1, InetAddress arg2, int arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BILjava/net/InetAddress;I)V", arg0, arg1, arg2, arg3);
		}
		
		public DatagramPacket(ByteArray arg0, int arg1, int arg2, SocketAddress arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BIILjava/net/SocketAddress;)V", arg0, arg1, arg2, arg3);
		}
		
		public DatagramPacket(ByteArray arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BII)V", arg0, arg1, arg2);
		}
		
		public DatagramPacket(ByteArray arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BI)V", arg0, arg1);
		}
		
		public DatagramPacket(ByteArray arg0, int arg1, int arg2, InetAddress arg3, int arg4) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BIILjava/net/InetAddress;I)V", arg0, arg1, arg2, arg3, arg4);
		}
	
		[JavaSignature("()I")]
		public int getLength()
		{
			return Instance.CallMethod<int>("getLength", "()I");
		}
		
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getAddress()
		{
			return Instance.CallMethod<InetAddress>("getAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("(I)V")]
		public void setLength(int arg0)
		{
			Instance.CallMethod("setLength", "(I)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int getPort()
		{
			return Instance.CallMethod<int>("getPort", "()I");
		}
		
		[JavaSignature("()I")]
		public int getOffset()
		{
			return Instance.CallMethod<int>("getOffset", "()I");
		}
		
		[JavaSignature("()[B")]
		public ByteArray getData()
		{
			return Instance.CallMethod<ByteArray>("getData", "()[B");
		}
		
		[JavaSignature("(Ljava/net/InetAddress;)V")]
		public void setAddress(InetAddress arg0)
		{
			Instance.CallMethod("setAddress", "(Ljava/net/InetAddress;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setPort(int arg0)
		{
			Instance.CallMethod("setPort", "(I)V", arg0);
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress getSocketAddress()
		{
			return Instance.CallMethod<SocketAddress>("getSocketAddress", "()Ljava/net/SocketAddress;");
		}
		
		[JavaSignature("([B)V")]
		public void setData(ByteArray arg0)
		{
			Instance.CallMethod("setData", "([B)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public void setData(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("setData", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/net/SocketAddress;)V")]
		public void setSocketAddress(SocketAddress arg0)
		{
			Instance.CallMethod("setSocketAddress", "(Ljava/net/SocketAddress;)V", arg0);
		}
	}
}
