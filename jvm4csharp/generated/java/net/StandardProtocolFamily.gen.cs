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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/StandardProtocolFamily")]
	public class StandardProtocolFamily : Enum<StandardProtocolFamily>, ProtocolFamily
	{
		protected StandardProtocolFamily(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/net/StandardProtocolFamily;")]
		public static StandardProtocolFamily INET
		{
			get { return Static.GetField<StandardProtocolFamily>(typeof(StandardProtocolFamily), "INET", "Ljava/net/StandardProtocolFamily;"); }
		}
		
		[JavaSignature("Ljava/net/StandardProtocolFamily;")]
		public static StandardProtocolFamily INET6
		{
			get { return Static.GetField<StandardProtocolFamily>(typeof(StandardProtocolFamily), "INET6", "Ljava/net/StandardProtocolFamily;"); }
		}
	
		[JavaSignature("()[Ljava/net/StandardProtocolFamily;")]
		public static ObjectArray<StandardProtocolFamily> values()
		{
			return Static.CallMethod<ObjectArray<StandardProtocolFamily>>(typeof(StandardProtocolFamily), "values", "()[Ljava/net/StandardProtocolFamily;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/net/StandardProtocolFamily;")]
		public static StandardProtocolFamily valueOf(String arg0)
		{
			return Static.CallMethod<StandardProtocolFamily>(typeof(StandardProtocolFamily), "valueOf", "(Ljava/lang/String;)Ljava/net/StandardProtocolFamily;", arg0);
		}
	}
}
