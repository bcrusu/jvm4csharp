//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/SequenceInputStream")]
	public class SequenceInputStream : InputStream
	{
		protected SequenceInputStream(ProxyCtor p) : base(p) {}
		
		public SequenceInputStream(Enumeration<InputStream> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Enumeration;)V", arg0);
		}
		
		public SequenceInputStream(InputStream arg0, InputStream arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/io/InputStream;)V", arg0, arg1);
		}
	}
}
