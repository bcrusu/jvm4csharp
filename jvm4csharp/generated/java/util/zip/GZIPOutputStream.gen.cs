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
	[JavaProxy("java/util/zip/GZIPOutputStream")]
	public class GZIPOutputStream : DeflaterOutputStream
	{
		protected GZIPOutputStream(ProxyCtor p) : base(p) {}
		
		public GZIPOutputStream(OutputStream arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Z)V", arg0, arg1);
		}
		
		public GZIPOutputStream(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
		
		public GZIPOutputStream(OutputStream arg0, int arg1, bool arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;IZ)V", arg0, arg1, arg2);
		}
		
		public GZIPOutputStream(OutputStream arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;I)V", arg0, arg1);
		}
	}
}
