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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/StringWriter")]
	public partial class StringWriter : Writer
	{
		protected StringWriter(ProxyCtor p) : base(p) {}
		
		public StringWriter() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public StringWriter(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/io/StringWriter;")]
		public new StringWriter append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<StringWriter>("append", "(Ljava/lang/CharSequence;II)Ljava/io/StringWriter;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(C)Ljava/io/StringWriter;")]
		public new StringWriter append(char arg0)
		{
			return Instance.CallMethod<StringWriter>("append", "(C)Ljava/io/StringWriter;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/io/StringWriter;")]
		public new StringWriter append(CharSequence arg0)
		{
			return Instance.CallMethod<StringWriter>("append", "(Ljava/lang/CharSequence;)Ljava/io/StringWriter;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/StringBuffer;")]
		public StringBuffer getBuffer()
		{
			return Instance.CallMethod<StringBuffer>("getBuffer", "()Ljava/lang/StringBuffer;");
		}
	}
}
