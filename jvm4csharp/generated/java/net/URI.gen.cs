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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/URI")]
	public class URI : Object, Comparable<URI>, Serializable
	{
		protected URI(ProxyCtor p) : base(p) {}
		
		public URI(String arg0, String arg1, String arg2, String arg3, String arg4) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		public URI(String arg0, String arg1, String arg2, int arg3, String arg4, String arg5, String arg6) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}
		
		public URI(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public URI(String arg0, String arg1, String arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
		}
		
		public URI(String arg0, String arg1, String arg2, String arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3);
		}
	
		[JavaSignature("(Ljava/net/URI;)I")]
		public int compareTo(URI arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/net/URI;)I", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isAbsolute()
		{
			return Instance.CallMethod<bool>("isAbsolute", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/net/URI;")]
		public URI resolve(String arg0)
		{
			return Instance.CallMethod<URI>("resolve", "(Ljava/lang/String;)Ljava/net/URI;", arg0);
		}
		
		[JavaSignature("(Ljava/net/URI;)Ljava/net/URI;")]
		public URI resolve(URI arg0)
		{
			return Instance.CallMethod<URI>("resolve", "(Ljava/net/URI;)Ljava/net/URI;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/net/URI;")]
		public static URI create(String arg0)
		{
			return Static.CallMethod<URI>(typeof(URI), "create", "(Ljava/lang/String;)Ljava/net/URI;", arg0);
		}
		
		[JavaSignature("()Ljava/net/URI;")]
		public URI normalize()
		{
			return Instance.CallMethod<URI>("normalize", "()Ljava/net/URI;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getAuthority()
		{
			return Instance.CallMethod<String>("getAuthority", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getFragment()
		{
			return Instance.CallMethod<String>("getFragment", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPath()
		{
			return Instance.CallMethod<String>("getPath", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getQuery()
		{
			return Instance.CallMethod<String>("getQuery", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getScheme()
		{
			return Instance.CallMethod<String>("getScheme", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isOpaque()
		{
			return Instance.CallMethod<bool>("isOpaque", "()Z");
		}
		
		[JavaSignature("()Ljava/net/URL;")]
		public URL toURL()
		{
			return Instance.CallMethod<URL>("toURL", "()Ljava/net/URL;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getHost()
		{
			return Instance.CallMethod<String>("getHost", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getPort()
		{
			return Instance.CallMethod<int>("getPort", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getUserInfo()
		{
			return Instance.CallMethod<String>("getUserInfo", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/net/URI;)Ljava/net/URI;")]
		public URI relativize(URI arg0)
		{
			return Instance.CallMethod<URI>("relativize", "(Ljava/net/URI;)Ljava/net/URI;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSchemeSpecificPart()
		{
			return Instance.CallMethod<String>("getSchemeSpecificPart", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRawAuthority()
		{
			return Instance.CallMethod<String>("getRawAuthority", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRawFragment()
		{
			return Instance.CallMethod<String>("getRawFragment", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRawPath()
		{
			return Instance.CallMethod<String>("getRawPath", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRawQuery()
		{
			return Instance.CallMethod<String>("getRawQuery", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRawSchemeSpecificPart()
		{
			return Instance.CallMethod<String>("getRawSchemeSpecificPart", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRawUserInfo()
		{
			return Instance.CallMethod<String>("getRawUserInfo", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/net/URI;")]
		public URI parseServerAuthority()
		{
			return Instance.CallMethod<URI>("parseServerAuthority", "()Ljava/net/URI;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toASCIIString()
		{
			return Instance.CallMethod<String>("toASCIIString", "()Ljava/lang/String;");
		}
	}
}
