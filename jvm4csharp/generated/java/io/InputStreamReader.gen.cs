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
using jvm4csharp.java.nio.charset;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/InputStreamReader")]
	public class InputStreamReader : Reader
	{
		protected InputStreamReader(ProxyCtor p) : base(p) {}
		
		public InputStreamReader(InputStream arg0, CharsetDecoder arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/nio/charset/CharsetDecoder;)V", arg0, arg1);
		}
		
		public InputStreamReader(InputStream arg0, Charset arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V", arg0, arg1);
		}
		
		public InputStreamReader(InputStream arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public InputStreamReader(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getEncoding()
		{
			return Instance.CallMethod<String>("getEncoding", "()Ljava/lang/String;");
		}
	}
}
