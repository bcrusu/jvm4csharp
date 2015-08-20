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
	[JavaProxy("java/util/zip/InflaterInputStream")]
	public partial class InflaterInputStream : FilterInputStream
	{
		protected InflaterInputStream(ProxyCtor p) : base(p) {}
		
		public InflaterInputStream(InputStream arg0, Inflater arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V", arg0, arg1);
		}
		
		public InflaterInputStream(InputStream arg0, Inflater arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V", arg0, arg1, arg2);
		}
		
		public InflaterInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
	}
}
