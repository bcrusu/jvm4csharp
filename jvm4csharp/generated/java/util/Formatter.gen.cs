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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Formatter")]
	public partial class Formatter : Object, Closeable, Flushable
	{
		protected Formatter(ProxyCtor p) : base(p) {}
		
		public Formatter(File arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Formatter(File arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;)V", arg0);
		}
		
		public Formatter(String arg0, String arg1, Locale arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V", arg0, arg1, arg2);
		}
		
		public Formatter(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Formatter(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Formatter(OutputStream arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Formatter(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
		
		public Formatter(PrintStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/PrintStream;)V", arg0);
		}
		
		public Formatter(File arg0, String arg1, Locale arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V", arg0, arg1, arg2);
		}
		
		public Formatter() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Formatter(OutputStream arg0, String arg1, Locale arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V", arg0, arg1, arg2);
		}
		
		public Formatter(Appendable arg0, Locale arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Appendable;Ljava/util/Locale;)V", arg0, arg1);
		}
		
		public Formatter(Locale arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Locale;)V", arg0);
		}
		
		public Formatter(Appendable arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Appendable;)V", arg0);
		}
	
		[JavaSignature("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;")]
		public Formatter format(Locale arg0, String arg1, ObjectArray<IJavaObject> arg2)
		{
			return Instance.CallMethod<Formatter>("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;")]
		public Formatter format(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<Formatter>("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Appendable;")]
		public Appendable @out()
		{
			return Instance.CallMethod<Appendable>("out", "()Ljava/lang/Appendable;");
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
		
		[JavaSignature("()Ljava/util/Locale;")]
		public Locale locale()
		{
			return Instance.CallMethod<Locale>("locale", "()Ljava/util/Locale;");
		}
		
		[JavaSignature("()Ljava/io/IOException;")]
		public IOException ioException()
		{
			return Instance.CallMethod<IOException>("ioException", "()Ljava/io/IOException;");
		}
	
		[JavaProxy("java/util/Formatter/BigDecimalLayoutForm")]
		public partial class BigDecimalLayoutForm : Enum<Formatter.BigDecimalLayoutForm>
		{
			protected BigDecimalLayoutForm(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/util/Formatter/BigDecimalLayoutForm;")]
			public static Formatter.BigDecimalLayoutForm SCIENTIFIC
			{
				get { return Static.GetField<Formatter.BigDecimalLayoutForm>(typeof(BigDecimalLayoutForm), "SCIENTIFIC", "Ljava/util/Formatter/BigDecimalLayoutForm;"); }
			}
			
			[JavaSignature("Ljava/util/Formatter/BigDecimalLayoutForm;")]
			public static Formatter.BigDecimalLayoutForm DECIMAL_FLOAT
			{
				get { return Static.GetField<Formatter.BigDecimalLayoutForm>(typeof(BigDecimalLayoutForm), "DECIMAL_FLOAT", "Ljava/util/Formatter/BigDecimalLayoutForm;"); }
			}
		
			[JavaSignature("()[Ljava/util/Formatter/BigDecimalLayoutForm;")]
			public static ObjectArray<Formatter.BigDecimalLayoutForm> values()
			{
				return Static.CallMethod<ObjectArray<Formatter.BigDecimalLayoutForm>>(typeof(BigDecimalLayoutForm), "values", "()[Ljava/util/Formatter/BigDecimalLayoutForm;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Formatter/BigDecimalLayoutForm;")]
			public static Formatter.BigDecimalLayoutForm valueOf(String arg0)
			{
				return Static.CallMethod<Formatter.BigDecimalLayoutForm>(typeof(BigDecimalLayoutForm), "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter/BigDecimalLayoutForm;", arg0);
			}
		}
	}
}
