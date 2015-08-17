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
	[JavaProxy("java/util/zip/DeflaterOutputStream")]
	public class DeflaterOutputStream : FilterOutputStream
	{
		protected DeflaterOutputStream(ProxyCtor p) : base(p) {}
		
		public DeflaterOutputStream(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
		
		public DeflaterOutputStream(OutputStream arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Z)V", arg0, arg1);
		}
		
		public DeflaterOutputStream(OutputStream arg0, Deflater arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/zip/Deflater;)V", arg0, arg1);
		}
		
		public DeflaterOutputStream(OutputStream arg0, Deflater arg1, int arg2, bool arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/zip/Deflater;IZ)V", arg0, arg1, arg2, arg3);
		}
		
		public DeflaterOutputStream(OutputStream arg0, Deflater arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/zip/Deflater;I)V", arg0, arg1, arg2);
		}
		
		public DeflaterOutputStream(OutputStream arg0, Deflater arg1, bool arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/zip/Deflater;Z)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("()V")]
		public void finish()
		{
			Instance.CallMethod("finish", "()V");
		}
	}
}
