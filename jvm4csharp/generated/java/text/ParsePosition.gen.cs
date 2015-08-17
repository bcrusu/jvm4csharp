//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/ParsePosition")]
	public class ParsePosition : Object
	{
		protected ParsePosition(ProxyCtor p) : base(p) {}
		
		public ParsePosition(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()I")]
		public int getIndex()
		{
			return Instance.CallMethod<int>("getIndex", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void setErrorIndex(int arg0)
		{
			Instance.CallMethod("setErrorIndex", "(I)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int getErrorIndex()
		{
			return Instance.CallMethod<int>("getErrorIndex", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void setIndex(int arg0)
		{
			Instance.CallMethod("setIndex", "(I)V", arg0);
		}
	}
}
