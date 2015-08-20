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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.charset.spi
{
	[JavaProxy("java/nio/charset/spi/CharsetProvider")]
	public abstract partial class CharsetProvider : Object
	{
		protected CharsetProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/charset/Charset;")]
		public Charset charsetForName(String arg0)
		{
			return Instance.CallMethod<Charset>("charsetForName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Iterator;")]
		public Iterator<Charset> charsets()
		{
			return Instance.CallMethod<Iterator<Charset>>("charsets", "()Ljava/util/Iterator;");
		}
	}
}
