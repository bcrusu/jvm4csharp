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
	[JavaProxy("java/io/PipedOutputStream")]
	public partial class PipedOutputStream : OutputStream
	{
		protected PipedOutputStream(ProxyCtor p) : base(p) {}
		
		public PipedOutputStream(PipedInputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/PipedInputStream;)V", arg0);
		}
		
		public PipedOutputStream() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/io/PipedInputStream;)V")]
		public void connect(PipedInputStream arg0)
		{
			Instance.CallMethod("connect", "(Ljava/io/PipedInputStream;)V", arg0);
		}
	}
}
