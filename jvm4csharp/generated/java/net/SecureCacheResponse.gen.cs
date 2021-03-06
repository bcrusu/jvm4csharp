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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/SecureCacheResponse")]
	public abstract partial class SecureCacheResponse : CacheResponse
	{
		protected SecureCacheResponse(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getCipherSuite()
		{
			return Instance.CallMethod<String>("getCipherSuite", "()Ljava/lang/String;");
		}
	}
}
