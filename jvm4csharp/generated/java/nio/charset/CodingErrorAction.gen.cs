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
namespace jvm4csharp.java.nio.charset
{
	[JavaProxy("java/nio/charset/CodingErrorAction")]
	public class CodingErrorAction : Object
	{
		protected CodingErrorAction(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/charset/CodingErrorAction;")]
		public static CodingErrorAction IGNORE
		{
			get { return Static.GetField<CodingErrorAction>(typeof(CodingErrorAction), "IGNORE", "Ljava/nio/charset/CodingErrorAction;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/CodingErrorAction;")]
		public static CodingErrorAction REPLACE
		{
			get { return Static.GetField<CodingErrorAction>(typeof(CodingErrorAction), "REPLACE", "Ljava/nio/charset/CodingErrorAction;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/CodingErrorAction;")]
		public static CodingErrorAction REPORT
		{
			get { return Static.GetField<CodingErrorAction>(typeof(CodingErrorAction), "REPORT", "Ljava/nio/charset/CodingErrorAction;"); }
		}
	}
}
