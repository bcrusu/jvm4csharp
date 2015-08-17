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
	[JavaProxy("java/net/IDN")]
	public class IDN : Object
	{
		protected IDN(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int ALLOW_UNASSIGNED
		{
			get { return Static.GetField<int>(typeof(IDN), "ALLOW_UNASSIGNED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int USE_STD3_ASCII_RULES
		{
			get { return Static.GetField<int>(typeof(IDN), "USE_STD3_ASCII_RULES", "I"); }
		}
	
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/String;")]
		public static String toASCII(String arg0, int arg1)
		{
			return Static.CallMethod<String>(typeof(IDN), "toASCII", "(Ljava/lang/String;I)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String toASCII(String arg0)
		{
			return Static.CallMethod<String>(typeof(IDN), "toASCII", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String toUnicode(String arg0)
		{
			return Static.CallMethod<String>(typeof(IDN), "toUnicode", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/String;")]
		public static String toUnicode(String arg0, int arg1)
		{
			return Static.CallMethod<String>(typeof(IDN), "toUnicode", "(Ljava/lang/String;I)Ljava/lang/String;", arg0, arg1);
		}
	}
}
