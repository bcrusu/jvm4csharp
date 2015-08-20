//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/ProxySelector")]
	public abstract partial class ProxySelector : Object
	{
		protected ProxySelector(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/net/ProxySelector;")]
		public static ProxySelector getDefault()
		{
			return Static.CallMethod<ProxySelector>(typeof(ProxySelector), "getDefault", "()Ljava/net/ProxySelector;");
		}
		
		[JavaSignature("(Ljava/net/ProxySelector;)V")]
		public static void setDefault(ProxySelector arg0)
		{
			Static.CallMethod(typeof(ProxySelector), "setDefault", "(Ljava/net/ProxySelector;)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V")]
		public void connectFailed(URI arg0, SocketAddress arg1, IOException arg2)
		{
			Instance.CallMethod("connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/net/URI;)Ljava/util/List;")]
		public List<Proxy> @select(URI arg0)
		{
			return Instance.CallMethod<List<Proxy>>("select", "(Ljava/net/URI;)Ljava/util/List;", arg0);
		}
	}
}
