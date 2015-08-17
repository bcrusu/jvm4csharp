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
	[JavaProxy("java/io/PipedReader")]
	public class PipedReader : Reader
	{
		protected PipedReader(ProxyCtor p) : base(p) {}
		
		public PipedReader(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public PipedReader() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public PipedReader(PipedWriter arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/PipedWriter;I)V", arg0, arg1);
		}
		
		public PipedReader(PipedWriter arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/PipedWriter;)V", arg0);
		}
	
		[JavaSignature("(Ljava/io/PipedWriter;)V")]
		public void connect(PipedWriter arg0)
		{
			Instance.CallMethod("connect", "(Ljava/io/PipedWriter;)V", arg0);
		}
	}
}
