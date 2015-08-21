//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/Proxy")]
	public partial class Proxy : Object
	{
		protected Proxy(ProxyCtor p) : base(p) {}
		
		public Proxy(Proxy_.Type arg0, SocketAddress arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/Proxy/Type;Ljava/net/SocketAddress;)V", arg0, arg1);
		}
	
		[JavaSignature("Ljava/net/Proxy;")]
		public static Proxy NO_PROXY
		{
			get { return Static.GetField<Proxy>(typeof(Proxy), "NO_PROXY", "Ljava/net/Proxy;"); }
		}
	
		[JavaSignature("()Ljava/net/Proxy/Type;")]
		public Proxy_.Type type()
		{
			return Instance.CallMethod<Proxy_.Type>("type", "()Ljava/net/Proxy/Type;");
		}
		
		[JavaSignature("()Ljava/net/SocketAddress;")]
		public SocketAddress address()
		{
			return Instance.CallMethod<SocketAddress>("address", "()Ljava/net/SocketAddress;");
		}
	}
	
	public static partial class Proxy_
	{
		[JavaProxy("java/net/Proxy/Type")]
		public partial class Type : Enum<Proxy_.Type>
		{
			protected Type(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/net/Proxy/Type;")]
			public static Proxy_.Type DIRECT
			{
				get { return Static.GetField<Proxy_.Type>(typeof(Type), "DIRECT", "Ljava/net/Proxy/Type;"); }
			}
			
			[JavaSignature("Ljava/net/Proxy/Type;")]
			public static Proxy_.Type HTTP
			{
				get { return Static.GetField<Proxy_.Type>(typeof(Type), "HTTP", "Ljava/net/Proxy/Type;"); }
			}
			
			[JavaSignature("Ljava/net/Proxy/Type;")]
			public static Proxy_.Type SOCKS
			{
				get { return Static.GetField<Proxy_.Type>(typeof(Type), "SOCKS", "Ljava/net/Proxy/Type;"); }
			}
		
			[JavaSignature("()[Ljava/net/Proxy/Type;")]
			public static ObjectArray<Proxy_.Type> values()
			{
				return Static.CallMethod<ObjectArray<Proxy_.Type>>(typeof(Type), "values", "()[Ljava/net/Proxy/Type;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/net/Proxy/Type;")]
			public static Proxy_.Type valueOf(String arg0)
			{
				return Static.CallMethod<Proxy_.Type>(typeof(Type), "valueOf", "(Ljava/lang/String;)Ljava/net/Proxy/Type;", arg0);
			}
		}
	}
}
