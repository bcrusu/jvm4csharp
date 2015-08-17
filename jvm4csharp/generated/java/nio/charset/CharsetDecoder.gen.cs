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
namespace jvm4csharp.java.nio.charset
{
	[JavaProxy("java/nio/charset/CharsetDecoder")]
	public abstract class CharsetDecoder : Object
	{
		protected CharsetDecoder(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/charset/Charset;")]
		public Charset charset()
		{
			return Instance.CallMethod<Charset>("charset", "()Ljava/nio/charset/Charset;");
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;")]
		public CoderResult decode(ByteBuffer arg0, CharBuffer arg1, bool arg2)
		{
			return Instance.CallMethod<CoderResult>("decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;")]
		public CharBuffer decode(ByteBuffer arg0)
		{
			return Instance.CallMethod<CharBuffer>("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;")]
		public CoderResult flush(CharBuffer arg0)
		{
			return Instance.CallMethod<CoderResult>("flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/charset/CharsetDecoder;")]
		public CharsetDecoder reset()
		{
			return Instance.CallMethod<CharsetDecoder>("reset", "()Ljava/nio/charset/CharsetDecoder;");
		}
		
		[JavaSignature("(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;")]
		public CharsetDecoder onMalformedInput(CodingErrorAction arg0)
		{
			return Instance.CallMethod<CharsetDecoder>("onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;")]
		public CharsetDecoder onUnmappableCharacter(CodingErrorAction arg0)
		{
			return Instance.CallMethod<CharsetDecoder>("onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/charset/CodingErrorAction;")]
		public CodingErrorAction malformedInputAction()
		{
			return Instance.CallMethod<CodingErrorAction>("malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
		}
		
		[JavaSignature("()F")]
		public float maxCharsPerByte()
		{
			return Instance.CallMethod<float>("maxCharsPerByte", "()F");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;")]
		public CharsetDecoder replaceWith(String arg0)
		{
			return Instance.CallMethod<CharsetDecoder>("replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String replacement()
		{
			return Instance.CallMethod<String>("replacement", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/nio/charset/CodingErrorAction;")]
		public CodingErrorAction unmappableCharacterAction()
		{
			return Instance.CallMethod<CodingErrorAction>("unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
		}
		
		[JavaSignature("()F")]
		public float averageCharsPerByte()
		{
			return Instance.CallMethod<float>("averageCharsPerByte", "()F");
		}
		
		[JavaSignature("()Ljava/nio/charset/Charset;")]
		public Charset detectedCharset()
		{
			return Instance.CallMethod<Charset>("detectedCharset", "()Ljava/nio/charset/Charset;");
		}
		
		[JavaSignature("()Z")]
		public bool isAutoDetecting()
		{
			return Instance.CallMethod<bool>("isAutoDetecting", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isCharsetDetected()
		{
			return Instance.CallMethod<bool>("isCharsetDetected", "()Z");
		}
	}
}
