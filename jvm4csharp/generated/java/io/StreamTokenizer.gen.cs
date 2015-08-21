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
	[JavaProxy("java/io/StreamTokenizer")]
	public partial class StreamTokenizer : Object
	{
		protected StreamTokenizer(ProxyCtor p) : base(p) {}
		
		public StreamTokenizer(Reader arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;)V", arg0);
		}
		
		public StreamTokenizer(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
	
		[JavaSignature("I")]
		public int ttype
		{
			get { return Instance.GetField<int>("ttype", "I"); }
			set { Instance.SetField("ttype", "I", value); }
		}
		
		[JavaSignature("I")]
		public static int TT_EOF
		{
			get { return Static.GetField<int>(typeof(StreamTokenizer), "TT_EOF", "I"); }
		}
		
		[JavaSignature("I")]
		public static int TT_EOL
		{
			get { return Static.GetField<int>(typeof(StreamTokenizer), "TT_EOL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int TT_NUMBER
		{
			get { return Static.GetField<int>(typeof(StreamTokenizer), "TT_NUMBER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int TT_WORD
		{
			get { return Static.GetField<int>(typeof(StreamTokenizer), "TT_WORD", "I"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public String sval
		{
			get { return Instance.GetField<String>("sval", "Ljava/lang/String;"); }
			set { Instance.SetField("sval", "Ljava/lang/String;", value); }
		}
		
		[JavaSignature("D")]
		public double nval
		{
			get { return Instance.GetField<double>("nval", "D"); }
			set { Instance.SetField("nval", "D", value); }
		}
	
		[JavaSignature("()I")]
		public int nextToken()
		{
			return Instance.CallMethod<int>("nextToken", "()I");
		}
		
		[JavaSignature("()V")]
		public void pushBack()
		{
			Instance.CallMethod("pushBack", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void commentChar(int arg0)
		{
			Instance.CallMethod("commentChar", "(I)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void eolIsSignificant(bool arg0)
		{
			Instance.CallMethod("eolIsSignificant", "(Z)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int lineno()
		{
			return Instance.CallMethod<int>("lineno", "()I");
		}
		
		[JavaSignature("(Z)V")]
		public void lowerCaseMode(bool arg0)
		{
			Instance.CallMethod("lowerCaseMode", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void ordinaryChar(int arg0)
		{
			Instance.CallMethod("ordinaryChar", "(I)V", arg0);
		}
		
		[JavaSignature("(II)V")]
		public void ordinaryChars(int arg0, int arg1)
		{
			Instance.CallMethod("ordinaryChars", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("()V")]
		public void parseNumbers()
		{
			Instance.CallMethod("parseNumbers", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void quoteChar(int arg0)
		{
			Instance.CallMethod("quoteChar", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void resetSyntax()
		{
			Instance.CallMethod("resetSyntax", "()V");
		}
		
		[JavaSignature("(Z)V")]
		public void slashSlashComments(bool arg0)
		{
			Instance.CallMethod("slashSlashComments", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void slashStarComments(bool arg0)
		{
			Instance.CallMethod("slashStarComments", "(Z)V", arg0);
		}
		
		[JavaSignature("(II)V")]
		public void whitespaceChars(int arg0, int arg1)
		{
			Instance.CallMethod("whitespaceChars", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("(II)V")]
		public void wordChars(int arg0, int arg1)
		{
			Instance.CallMethod("wordChars", "(II)V", arg0, arg1);
		}
	}
}
