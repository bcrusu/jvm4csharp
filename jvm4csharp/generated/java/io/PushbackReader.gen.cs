//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/PushbackReader")]
	public class PushbackReader : FilterReader
	{
		protected PushbackReader(ProxyCtor p) : base(p) {}
		
		public PushbackReader(Reader arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;I)V", arg0, arg1);
		}
		
		public PushbackReader(Reader arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;)V", arg0);
		}
	
		[JavaSignature("([C)V")]
		public void unread(CharArray arg0)
		{
			Instance.CallMethod("unread", "([C)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void unread(int arg0)
		{
			Instance.CallMethod("unread", "(I)V", arg0);
		}
		
		[JavaSignature("([CII)V")]
		public void unread(CharArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("unread", "([CII)V", arg0, arg1, arg2);
		}
	}
}
