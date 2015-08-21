//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/PrintWriter")]
	public partial class PrintWriter : Writer
	{
		protected PrintWriter(ProxyCtor p) : base(p) {}
		
		public PrintWriter(OutputStream arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Z)V", arg0, arg1);
		}
		
		public PrintWriter(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public PrintWriter(File arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;)V", arg0);
		}
		
		public PrintWriter(File arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public PrintWriter(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public PrintWriter(Writer arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Writer;)V", arg0);
		}
		
		public PrintWriter(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
		
		public PrintWriter(Writer arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Writer;Z)V", arg0, arg1);
		}
	
		[JavaSignature("(D)V")]
		public void println(double arg0)
		{
			Instance.CallMethod("println", "(D)V", arg0);
		}
		
		[JavaSignature("([C)V")]
		public void println(CharArray arg0)
		{
			Instance.CallMethod("println", "([C)V", arg0);
		}
		
		[JavaSignature("(F)V")]
		public void println(float arg0)
		{
			Instance.CallMethod("println", "(F)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void println(String arg0)
		{
			Instance.CallMethod("println", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void println(IJavaObject arg0)
		{
			Instance.CallMethod("println", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void println(int arg0)
		{
			Instance.CallMethod("println", "(I)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void println(char arg0)
		{
			Instance.CallMethod("println", "(C)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void println(bool arg0)
		{
			Instance.CallMethod("println", "(Z)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void println()
		{
			Instance.CallMethod("println", "()V");
		}
		
		[JavaSignature("(J)V")]
		public void println(long arg0)
		{
			Instance.CallMethod("println", "(J)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;")]
		public new PrintWriter append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<PrintWriter>("append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;")]
		public new PrintWriter append(CharSequence arg0)
		{
			return Instance.CallMethod<PrintWriter>("append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;", arg0);
		}
		
		[JavaSignature("(C)Ljava/io/PrintWriter;")]
		public new PrintWriter append(char arg0)
		{
			return Instance.CallMethod<PrintWriter>("append", "(C)Ljava/io/PrintWriter;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;")]
		public PrintWriter format(Locale arg0, String arg1, ObjectArray<IJavaObject> arg2)
		{
			return Instance.CallMethod<PrintWriter>("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;")]
		public PrintWriter format(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<PrintWriter>("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1);
		}
		
		[JavaSignature("(F)V")]
		public void print(float arg0)
		{
			Instance.CallMethod("print", "(F)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void print(long arg0)
		{
			Instance.CallMethod("print", "(J)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void print(int arg0)
		{
			Instance.CallMethod("print", "(I)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void print(char arg0)
		{
			Instance.CallMethod("print", "(C)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void print(bool arg0)
		{
			Instance.CallMethod("print", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void print(IJavaObject arg0)
		{
			Instance.CallMethod("print", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void print(String arg0)
		{
			Instance.CallMethod("print", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([C)V")]
		public void print(CharArray arg0)
		{
			Instance.CallMethod("print", "([C)V", arg0);
		}
		
		[JavaSignature("(D)V")]
		public void print(double arg0)
		{
			Instance.CallMethod("print", "(D)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool checkError()
		{
			return Instance.CallMethod<bool>("checkError", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;")]
		public PrintWriter printf(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<PrintWriter>("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;")]
		public PrintWriter printf(Locale arg0, String arg1, ObjectArray<IJavaObject> arg2)
		{
			return Instance.CallMethod<PrintWriter>("printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1, arg2);
		}
	}
}
