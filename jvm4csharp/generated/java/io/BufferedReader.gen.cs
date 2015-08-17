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
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/BufferedReader")]
	public class BufferedReader : Reader
	{
		protected BufferedReader(ProxyCtor p) : base(p) {}
		
		public BufferedReader(Reader arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;I)V", arg0, arg1);
		}
		
		public BufferedReader(Reader arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String readLine()
		{
			return Instance.CallMethod<String>("readLine", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<String> lines()
		{
			return Instance.CallMethod<Stream<String>>("lines", "()Ljava/util/stream/Stream;");
		}
	}
}
