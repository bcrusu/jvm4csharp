//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/CookieStore")]
	public partial interface CookieStore : IJavaObject
	{
		[JavaSignature("(Ljava/net/URI;Ljava/net/HttpCookie;)V")]
		void @add(URI arg0, HttpCookie arg1);
		
		[JavaSignature("(Ljava/net/URI;Ljava/net/HttpCookie;)Z")]
		bool @remove(URI arg0, HttpCookie arg1);
		
		[JavaSignature("(Ljava/net/URI;)Ljava/util/List;")]
		List<HttpCookie> @get(URI arg0);
		
		[JavaSignature("()Z")]
		bool removeAll();
		
		[JavaSignature("()Ljava/util/List;")]
		List<HttpCookie> getCookies();
		
		[JavaSignature("()Ljava/util/List;")]
		List<URI> getURIs();
	}
}
