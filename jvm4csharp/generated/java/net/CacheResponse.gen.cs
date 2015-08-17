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
	[JavaProxy("java/net/CacheResponse")]
	public abstract class CacheResponse : Object
	{
		protected CacheResponse(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/Map;")]
		public Map<String, List<String>> getHeaders()
		{
			return Instance.CallMethod<Map<String, List<String>>>("getHeaders", "()Ljava/util/Map;");
		}
		
		[JavaSignature("()Ljava/io/InputStream;")]
		public InputStream getBody()
		{
			return Instance.CallMethod<InputStream>("getBody", "()Ljava/io/InputStream;");
		}
	}
}
