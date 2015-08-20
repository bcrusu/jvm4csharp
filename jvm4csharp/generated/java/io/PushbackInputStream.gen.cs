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
	[JavaProxy("java/io/PushbackInputStream")]
	public partial class PushbackInputStream : FilterInputStream
	{
		protected PushbackInputStream(ProxyCtor p) : base(p) {}
		
		public PushbackInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public PushbackInputStream(InputStream arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;I)V", arg0, arg1);
		}
	
		[JavaSignature("([B)V")]
		public void unread(ByteArray arg0)
		{
			Instance.CallMethod("unread", "([B)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void unread(int arg0)
		{
			Instance.CallMethod("unread", "(I)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public void unread(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("unread", "([BII)V", arg0, arg1, arg2);
		}
	}
}
