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
	[JavaProxy("java/util/zip/DeflaterInputStream")]
	public class DeflaterInputStream : FilterInputStream
	{
		protected DeflaterInputStream(ProxyCtor p) : base(p) {}
		
		public DeflaterInputStream(InputStream arg0, Deflater arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/util/zip/Deflater;I)V", arg0, arg1, arg2);
		}
		
		public DeflaterInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public DeflaterInputStream(InputStream arg0, Deflater arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/util/zip/Deflater;)V", arg0, arg1);
		}
	}
}
