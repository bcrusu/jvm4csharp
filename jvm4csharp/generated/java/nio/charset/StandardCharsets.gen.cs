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
	[JavaProxy("java/nio/charset/StandardCharsets")]
	public class StandardCharsets : Object
	{
		protected StandardCharsets(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/charset/Charset;")]
		public static Charset US_ASCII
		{
			get { return Static.GetField<Charset>(typeof(StandardCharsets), "US_ASCII", "Ljava/nio/charset/Charset;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/Charset;")]
		public static Charset ISO_8859_1
		{
			get { return Static.GetField<Charset>(typeof(StandardCharsets), "ISO_8859_1", "Ljava/nio/charset/Charset;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/Charset;")]
		public static Charset UTF_8
		{
			get { return Static.GetField<Charset>(typeof(StandardCharsets), "UTF_8", "Ljava/nio/charset/Charset;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/Charset;")]
		public static Charset UTF_16BE
		{
			get { return Static.GetField<Charset>(typeof(StandardCharsets), "UTF_16BE", "Ljava/nio/charset/Charset;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/Charset;")]
		public static Charset UTF_16LE
		{
			get { return Static.GetField<Charset>(typeof(StandardCharsets), "UTF_16LE", "Ljava/nio/charset/Charset;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/Charset;")]
		public static Charset UTF_16
		{
			get { return Static.GetField<Charset>(typeof(StandardCharsets), "UTF_16", "Ljava/nio/charset/Charset;"); }
		}
	}
}
