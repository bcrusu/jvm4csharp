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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/ResponseCache")]
	public abstract class ResponseCache : Object
	{
		protected ResponseCache(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;")]
		public CacheResponse @get(URI arg0, String arg1, Map<String, List<String>> arg2)
		{
			return Instance.CallMethod<CacheResponse>("get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;")]
		public CacheRequest put(URI arg0, URLConnection arg1)
		{
			return Instance.CallMethod<CacheRequest>("put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/net/ResponseCache;")]
		public static ResponseCache getDefault()
		{
			return Static.CallMethod<ResponseCache>(typeof(ResponseCache), "getDefault", "()Ljava/net/ResponseCache;");
		}
		
		[JavaSignature("(Ljava/net/ResponseCache;)V")]
		public static void setDefault(ResponseCache arg0)
		{
			Static.CallMethod(typeof(ResponseCache), "setDefault", "(Ljava/net/ResponseCache;)V", arg0);
		}
	}
}
