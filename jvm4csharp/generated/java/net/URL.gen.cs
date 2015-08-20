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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/URL")]
	public partial class URL : Object, Serializable
	{
		protected URL(ProxyCtor p) : base(p) {}
		
		public URL(URL arg0, String arg1, URLStreamHandler arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V", arg0, arg1, arg2);
		}
		
		public URL(URL arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/URL;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public URL(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public URL(String arg0, String arg1, int arg2, String arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", arg0, arg1, arg2, arg3);
		}
		
		public URL(String arg0, String arg1, String arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
		}
		
		public URL(String arg0, String arg1, int arg2, String arg3, URLStreamHandler arg4) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V", arg0, arg1, arg2, arg3, arg4);
		}
	
		[JavaSignature("()Ljava/io/InputStream;")]
		public InputStream openStream()
		{
			return Instance.CallMethod<InputStream>("openStream", "()Ljava/io/InputStream;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getAuthority()
		{
			return Instance.CallMethod<String>("getAuthority", "()Ljava/lang/String;");
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
		
		[JavaSignature("()Ljava/net/URI;")]
		public URI toURI()
		{
			return Instance.CallMethod<URI>("toURI", "()Ljava/net/URI;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getFile()
		{
			return Instance.CallMethod<String>("getFile", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getHost()
		{
			return Instance.CallMethod<String>("getHost", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getProtocol()
		{
			return Instance.CallMethod<String>("getProtocol", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/net/Proxy;)Ljava/net/URLConnection;")]
		public URLConnection openConnection(Proxy arg0)
		{
			return Instance.CallMethod<URLConnection>("openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;", arg0);
		}
		
		[JavaSignature("()Ljava/net/URLConnection;")]
		public URLConnection openConnection()
		{
			return Instance.CallMethod<URLConnection>("openConnection", "()Ljava/net/URLConnection;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject getContent()
		{
			return Instance.CallMethod<IJavaObject>("getContent", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("([Ljava/lang/Class;)Ljava/lang/Object;")]
		public IJavaObject getContent(ObjectArray<Class<IJavaObject>> arg0)
		{
			return Instance.CallMethod<IJavaObject>("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()I")]
		public int getDefaultPort()
		{
			return Instance.CallMethod<int>("getDefaultPort", "()I");
		}
		
		[JavaSignature("()I")]
		public int getPort()
		{
			return Instance.CallMethod<int>("getPort", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRef()
		{
			return Instance.CallMethod<String>("getRef", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getUserInfo()
		{
			return Instance.CallMethod<String>("getUserInfo", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/net/URL;)Z")]
		public bool sameFile(URL arg0)
		{
			return Instance.CallMethod<bool>("sameFile", "(Ljava/net/URL;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/net/URLStreamHandlerFactory;)V")]
		public static void setURLStreamHandlerFactory(URLStreamHandlerFactory arg0)
		{
			Static.CallMethod(typeof(URL), "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toExternalForm()
		{
			return Instance.CallMethod<String>("toExternalForm", "()Ljava/lang/String;");
		}
	}
}
