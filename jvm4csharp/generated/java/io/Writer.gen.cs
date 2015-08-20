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
	[JavaProxy("java/io/Writer")]
	public abstract partial class Writer : Object, Appendable, Closeable, Flushable
	{
		protected Writer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/io/Writer;")]
		public Writer append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<Writer>("append", "(Ljava/lang/CharSequence;II)Ljava/io/Writer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(C)Ljava/io/Writer;")]
		public Writer append(char arg0)
		{
			return Instance.CallMethod<Writer>("append", "(C)Ljava/io/Writer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/io/Writer;")]
		public Writer append(CharSequence arg0)
		{
			return Instance.CallMethod<Writer>("append", "(Ljava/lang/CharSequence;)Ljava/io/Writer;", arg0);
		}
		
		[JavaSignature("([C)V")]
		public void write(CharArray arg0)
		{
			Instance.CallMethod("write", "([C)V", arg0);
		}
		
		[JavaSignature("([CII)V")]
		public void write(CharArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("write", "([CII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(I)V")]
		public void write(int arg0)
		{
			Instance.CallMethod("write", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;II)V")]
		public void write(String arg0, int arg1, int arg2)
		{
			Instance.CallMethod("write", "(Ljava/lang/String;II)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void write(String arg0)
		{
			Instance.CallMethod("write", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()V")]
		public void flush()
		{
			Instance.CallMethod("flush", "()V");
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;")]
		Appendable Appendable.append(CharSequence arg0)
		{
			return Instance.CallMethod<Appendable>("append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;")]
		Appendable Appendable.append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<Appendable>("append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(C)Ljava/lang/Appendable;")]
		Appendable Appendable.append(char arg0)
		{
			return Instance.CallMethod<Appendable>("append", "(C)Ljava/lang/Appendable;", arg0);
		}
	}
}
