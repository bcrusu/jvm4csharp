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
	[JavaProxy("java/net/InetSocketAddress")]
	public class InetSocketAddress : SocketAddress
	{
		protected InetSocketAddress(ProxyCtor p) : base(p) {}
		
		public InetSocketAddress(String arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;I)V", arg0, arg1);
		}
		
		public InetSocketAddress(InetAddress arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/InetAddress;I)V", arg0, arg1);
		}
		
		public InetSocketAddress(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()Ljava/net/InetAddress;")]
		public InetAddress getAddress()
		{
			return Instance.CallMethod<InetAddress>("getAddress", "()Ljava/net/InetAddress;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getHostName()
		{
			return Instance.CallMethod<String>("getHostName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getPort()
		{
			return Instance.CallMethod<int>("getPort", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isUnresolved()
		{
			return Instance.CallMethod<bool>("isUnresolved", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/net/InetSocketAddress;")]
		public static InetSocketAddress createUnresolved(String arg0, int arg1)
		{
			return Static.CallMethod<InetSocketAddress>(typeof(InetSocketAddress), "createUnresolved", "(Ljava/lang/String;I)Ljava/net/InetSocketAddress;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getHostString()
		{
			return Instance.CallMethod<String>("getHostString", "()Ljava/lang/String;");
		}
	}
}
