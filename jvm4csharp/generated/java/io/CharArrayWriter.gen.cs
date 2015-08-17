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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/CharArrayWriter")]
	public class CharArrayWriter : Writer
	{
		protected CharArrayWriter(ProxyCtor p) : base(p) {}
		
		public CharArrayWriter() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public CharArrayWriter(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;")]
		public new CharArrayWriter append(CharSequence arg0)
		{
			return Instance.CallMethod<CharArrayWriter>("append", "(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;", arg0);
		}
		
		[JavaSignature("(C)Ljava/io/CharArrayWriter;")]
		public new CharArrayWriter append(char arg0)
		{
			return Instance.CallMethod<CharArrayWriter>("append", "(C)Ljava/io/CharArrayWriter;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;")]
		public new CharArrayWriter append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<CharArrayWriter>("append", "(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("()[C")]
		public CharArray toCharArray()
		{
			return Instance.CallMethod<CharArray>("toCharArray", "()[C");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("(Ljava/io/Writer;)V")]
		public void writeTo(Writer arg0)
		{
			Instance.CallMethod("writeTo", "(Ljava/io/Writer;)V", arg0);
		}
	}
}
