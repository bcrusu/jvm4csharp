//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/BufferedInputStream")]
	public partial class BufferedInputStream : FilterInputStream
	{
		protected BufferedInputStream(ProxyCtor p) : base(p) {}
		
		public BufferedInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public BufferedInputStream(InputStream arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;I)V", arg0, arg1);
		}
	}
}
