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
	[JavaProxy("java/util/zip/InflaterOutputStream")]
	public partial class InflaterOutputStream : FilterOutputStream
	{
		protected InflaterOutputStream(ProxyCtor p) : base(p) {}
		
		public InflaterOutputStream(OutputStream arg0, Inflater arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/zip/Inflater;I)V", arg0, arg1, arg2);
		}
		
		public InflaterOutputStream(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
		
		public InflaterOutputStream(OutputStream arg0, Inflater arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/zip/Inflater;)V", arg0, arg1);
		}
	
		[JavaSignature("()V")]
		public void finish()
		{
			Instance.CallMethod("finish", "()V");
		}
	}
}
