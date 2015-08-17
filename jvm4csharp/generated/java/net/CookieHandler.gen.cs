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
	[JavaProxy("java/net/CookieHandler")]
	public abstract class CookieHandler : Object
	{
		protected CookieHandler(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;")]
		public Map<String, List<String>> @get(URI arg0, Map<String, List<String>> arg1)
		{
			return Instance.CallMethod<Map<String, List<String>>>("get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/URI;Ljava/util/Map;)V")]
		public void put(URI arg0, Map<String, List<String>> arg1)
		{
			Instance.CallMethod("put", "(Ljava/net/URI;Ljava/util/Map;)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/net/CookieHandler;")]
		public static CookieHandler getDefault()
		{
			return Static.CallMethod<CookieHandler>(typeof(CookieHandler), "getDefault", "()Ljava/net/CookieHandler;");
		}
		
		[JavaSignature("(Ljava/net/CookieHandler;)V")]
		public static void setDefault(CookieHandler arg0)
		{
			Static.CallMethod(typeof(CookieHandler), "setDefault", "(Ljava/net/CookieHandler;)V", arg0);
		}
	}
}
