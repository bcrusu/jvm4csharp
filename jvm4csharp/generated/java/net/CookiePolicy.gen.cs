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
	[JavaProxy("java/net/CookiePolicy")]
	public partial interface CookiePolicy : IJavaObject
	{
		[JavaSignature("(Ljava/net/URI;Ljava/net/HttpCookie;)Z")]
		bool shouldAccept(URI arg0, HttpCookie arg1);
	}
	
	public static partial class CookiePolicy_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("Ljava/net/CookiePolicy;")]
		public static CookiePolicy ACCEPT_ALL
		{
			get { return Static.GetField<CookiePolicy>(typeof(CookiePolicy), "ACCEPT_ALL", "Ljava/net/CookiePolicy;"); }
		}
		
		[JavaSignature("Ljava/net/CookiePolicy;")]
		public static CookiePolicy ACCEPT_NONE
		{
			get { return Static.GetField<CookiePolicy>(typeof(CookiePolicy), "ACCEPT_NONE", "Ljava/net/CookiePolicy;"); }
		}
		
		[JavaSignature("Ljava/net/CookiePolicy;")]
		public static CookiePolicy ACCEPT_ORIGINAL_SERVER
		{
			get { return Static.GetField<CookiePolicy>(typeof(CookiePolicy), "ACCEPT_ORIGINAL_SERVER", "Ljava/net/CookiePolicy;"); }
		}
	
	}
}
