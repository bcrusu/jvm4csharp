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
	[JavaProxy("java/io/PipedInputStream")]
	public partial class PipedInputStream : InputStream
	{
		protected PipedInputStream(ProxyCtor p) : base(p) {}
		
		public PipedInputStream(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public PipedInputStream() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public PipedInputStream(PipedOutputStream arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/PipedOutputStream;I)V", arg0, arg1);
		}
		
		public PipedInputStream(PipedOutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/PipedOutputStream;)V", arg0);
		}
	
		[JavaSignature("(Ljava/io/PipedOutputStream;)V")]
		public void connect(PipedOutputStream arg0)
		{
			Instance.CallMethod("connect", "(Ljava/io/PipedOutputStream;)V", arg0);
		}
	}
}
