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
using jvm4csharp.java.nio.charset;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/ZipInputStream")]
	public partial class ZipInputStream : InflaterInputStream
	{
		protected ZipInputStream(ProxyCtor p) : base(p) {}
		
		public ZipInputStream(InputStream arg0, Charset arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V", arg0, arg1);
		}
		
		public ZipInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
	
		[JavaSignature("()Ljava/util/zip/ZipEntry;")]
		public ZipEntry getNextEntry()
		{
			return Instance.CallMethod<ZipEntry>("getNextEntry", "()Ljava/util/zip/ZipEntry;");
		}
		
		[JavaSignature("()V")]
		public void closeEntry()
		{
			Instance.CallMethod("closeEntry", "()V");
		}
	}
}
