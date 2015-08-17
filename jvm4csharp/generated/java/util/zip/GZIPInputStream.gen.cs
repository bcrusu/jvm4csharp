//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/GZIPInputStream")]
	public class GZIPInputStream : InflaterInputStream
	{
		protected GZIPInputStream(ProxyCtor p) : base(p) {}
		
		public GZIPInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public GZIPInputStream(InputStream arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;I)V", arg0, arg1);
		}
	
		[JavaSignature("I")]
		public static int GZIP_MAGIC
		{
			get { return Static.GetField<int>(typeof(GZIPInputStream), "GZIP_MAGIC", "I"); }
		}
	}
}
