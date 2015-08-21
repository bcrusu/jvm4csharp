//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/ContentHandler")]
	public abstract partial class ContentHandler : Object
	{
		protected ContentHandler(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/net/URLConnection;)Ljava/lang/Object;")]
		public IJavaObject getContent(URLConnection arg0)
		{
			return Instance.CallMethod<IJavaObject>("getContent", "(Ljava/net/URLConnection;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/net/URLConnection;[Ljava/lang/Class;)Ljava/lang/Object;")]
		public IJavaObject getContent(URLConnection arg0, ObjectArray<Class<IJavaObject>> arg1)
		{
			return Instance.CallMethod<IJavaObject>("getContent", "(Ljava/net/URLConnection;[Ljava/lang/Class;)Ljava/lang/Object;", arg0, arg1);
		}
	}
}
