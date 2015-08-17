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
	[JavaProxy("java/io/LineNumberReader")]
	public class LineNumberReader : BufferedReader
	{
		protected LineNumberReader(ProxyCtor p) : base(p) {}
		
		public LineNumberReader(Reader arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;)V", arg0);
		}
		
		public LineNumberReader(Reader arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;I)V", arg0, arg1);
		}
	
		[JavaSignature("()I")]
		public int getLineNumber()
		{
			return Instance.CallMethod<int>("getLineNumber", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void setLineNumber(int arg0)
		{
			Instance.CallMethod("setLineNumber", "(I)V", arg0);
		}
	}
}
