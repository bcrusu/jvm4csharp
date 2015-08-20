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
	[JavaProxy("java/io/BufferedWriter")]
	public partial class BufferedWriter : Writer
	{
		protected BufferedWriter(ProxyCtor p) : base(p) {}
		
		public BufferedWriter(Writer arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Writer;)V", arg0);
		}
		
		public BufferedWriter(Writer arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Writer;I)V", arg0, arg1);
		}
	
		[JavaSignature("()V")]
		public void newLine()
		{
			Instance.CallMethod("newLine", "()V");
		}
	}
}
