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
	[JavaProxy("java/io/PipedWriter")]
	public class PipedWriter : Writer
	{
		protected PipedWriter(ProxyCtor p) : base(p) {}
		
		public PipedWriter(PipedReader arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/PipedReader;)V", arg0);
		}
		
		public PipedWriter() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/io/PipedReader;)V")]
		public void connect(PipedReader arg0)
		{
			Instance.CallMethod("connect", "(Ljava/io/PipedReader;)V", arg0);
		}
	}
}
