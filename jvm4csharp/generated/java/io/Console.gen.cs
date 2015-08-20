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
	[JavaProxy("java/io/Console")]
	public partial class Console : Object, Flushable
	{
		protected Console(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;")]
		public Console format(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<Console>("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;", arg0, arg1);
		}
		
		[JavaSignature("()V")]
		public void flush()
		{
			Instance.CallMethod("flush", "()V");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;")]
		public String readLine(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<String>("readLine", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String readLine()
		{
			return Instance.CallMethod<String>("readLine", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;")]
		public Console printf(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<Console>("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/io/Reader;")]
		public Reader reader()
		{
			return Instance.CallMethod<Reader>("reader", "()Ljava/io/Reader;");
		}
		
		[JavaSignature("()Ljava/io/PrintWriter;")]
		public PrintWriter writer()
		{
			return Instance.CallMethod<PrintWriter>("writer", "()Ljava/io/PrintWriter;");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)[C")]
		public CharArray readPassword(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<CharArray>("readPassword", "(Ljava/lang/String;[Ljava/lang/Object;)[C", arg0, arg1);
		}
		
		[JavaSignature("()[C")]
		public CharArray readPassword()
		{
			return Instance.CallMethod<CharArray>("readPassword", "()[C");
		}
	}
}
