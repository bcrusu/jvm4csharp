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
	[JavaProxy("java/io/LineNumberInputStream")]
	public class LineNumberInputStream : FilterInputStream
	{
		protected LineNumberInputStream(ProxyCtor p) : base(p) {}
		
		public LineNumberInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
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
