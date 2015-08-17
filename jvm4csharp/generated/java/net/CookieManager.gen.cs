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
	[JavaProxy("java/net/CookieManager")]
	public class CookieManager : CookieHandler
	{
		protected CookieManager(ProxyCtor p) : base(p) {}
		
		public CookieManager() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public CookieManager(CookieStore arg0, CookiePolicy arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/CookieStore;Ljava/net/CookiePolicy;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/net/CookieStore;")]
		public CookieStore getCookieStore()
		{
			return Instance.CallMethod<CookieStore>("getCookieStore", "()Ljava/net/CookieStore;");
		}
		
		[JavaSignature("(Ljava/net/CookiePolicy;)V")]
		public void setCookiePolicy(CookiePolicy arg0)
		{
			Instance.CallMethod("setCookiePolicy", "(Ljava/net/CookiePolicy;)V", arg0);
		}
	}
}
