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
namespace jvm4csharp.java.nio.charset
{
	[JavaProxy("java/nio/charset/Charset")]
	public abstract class Charset : Object, Comparable<Charset>
	{
		protected Charset(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String name()
		{
			return Instance.CallMethod<String>("name", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/charset/Charset;")]
		public static Charset forName(String arg0)
		{
			return Static.CallMethod<Charset>(typeof(Charset), "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/charset/Charset;)I")]
		public int compareTo(Charset arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/charset/Charset;)I", arg0);
		}
		
		[JavaSignature("(Ljava/nio/charset/Charset;)Z")]
		public bool contains(Charset arg0)
		{
			return Instance.CallMethod<bool>("contains", "(Ljava/nio/charset/Charset;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;")]
		public CharBuffer decode(ByteBuffer arg0)
		{
			return Instance.CallMethod<CharBuffer>("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;")]
		public ByteBuffer encode(CharBuffer arg0)
		{
			return Instance.CallMethod<ByteBuffer>("encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/ByteBuffer;")]
		public ByteBuffer encode(String arg0)
		{
			return Instance.CallMethod<ByteBuffer>("encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isRegistered()
		{
			return Instance.CallMethod<bool>("isRegistered", "()Z");
		}
		
		[JavaSignature("()Ljava/nio/charset/Charset;")]
		public static Charset defaultCharset()
		{
			return Static.CallMethod<Charset>(typeof(Charset), "defaultCharset", "()Ljava/nio/charset/Charset;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public static bool isSupported(String arg0)
		{
			return Static.CallMethod<bool>(typeof(Charset), "isSupported", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/nio/charset/CharsetEncoder;")]
		public CharsetEncoder newEncoder()
		{
			return Instance.CallMethod<CharsetEncoder>("newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<String> aliases()
		{
			return Instance.CallMethod<Set<String>>("aliases", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/util/SortedMap;")]
		public static SortedMap<String, Charset> availableCharsets()
		{
			return Static.CallMethod<SortedMap<String, Charset>>(typeof(Charset), "availableCharsets", "()Ljava/util/SortedMap;");
		}
		
		[JavaSignature("()Z")]
		public bool canEncode()
		{
			return Instance.CallMethod<bool>("canEncode", "()Z");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String displayName(Locale arg0)
		{
			return Instance.CallMethod<String>("displayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String displayName()
		{
			return Instance.CallMethod<String>("displayName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/nio/charset/CharsetDecoder;")]
		public CharsetDecoder newDecoder()
		{
			return Instance.CallMethod<CharsetDecoder>("newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
		}
	}
}
