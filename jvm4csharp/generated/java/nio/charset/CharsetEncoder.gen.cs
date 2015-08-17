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
namespace jvm4csharp.java.nio.charset
{
	[JavaProxy("java/nio/charset/CharsetEncoder")]
	public abstract class CharsetEncoder : Object
	{
		protected CharsetEncoder(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/charset/Charset;")]
		public Charset charset()
		{
			return Instance.CallMethod<Charset>("charset", "()Ljava/nio/charset/Charset;");
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;")]
		public ByteBuffer encode(CharBuffer arg0)
		{
			return Instance.CallMethod<ByteBuffer>("encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;")]
		public CoderResult encode(CharBuffer arg0, ByteBuffer arg1, bool arg2)
		{
			return Instance.CallMethod<CoderResult>("encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;")]
		public CoderResult flush(ByteBuffer arg0)
		{
			return Instance.CallMethod<CoderResult>("flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/charset/CharsetEncoder;")]
		public CharsetEncoder reset()
		{
			return Instance.CallMethod<CharsetEncoder>("reset", "()Ljava/nio/charset/CharsetEncoder;");
		}
		
		[JavaSignature("(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;")]
		public CharsetEncoder onMalformedInput(CodingErrorAction arg0)
		{
			return Instance.CallMethod<CharsetEncoder>("onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;")]
		public CharsetEncoder onUnmappableCharacter(CodingErrorAction arg0)
		{
			return Instance.CallMethod<CharsetEncoder>("onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public bool canEncode(char arg0)
		{
			return Instance.CallMethod<bool>("canEncode", "(C)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Z")]
		public bool canEncode(CharSequence arg0)
		{
			return Instance.CallMethod<bool>("canEncode", "(Ljava/lang/CharSequence;)Z", arg0);
		}
		
		[JavaSignature("([B)Z")]
		public bool isLegalReplacement(ByteArray arg0)
		{
			return Instance.CallMethod<bool>("isLegalReplacement", "([B)Z", arg0);
		}
		
		[JavaSignature("()F")]
		public float averageBytesPerChar()
		{
			return Instance.CallMethod<float>("averageBytesPerChar", "()F");
		}
		
		[JavaSignature("()Ljava/nio/charset/CodingErrorAction;")]
		public CodingErrorAction malformedInputAction()
		{
			return Instance.CallMethod<CodingErrorAction>("malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
		}
		
		[JavaSignature("()F")]
		public float maxBytesPerChar()
		{
			return Instance.CallMethod<float>("maxBytesPerChar", "()F");
		}
		
		[JavaSignature("([B)Ljava/nio/charset/CharsetEncoder;")]
		public CharsetEncoder replaceWith(ByteArray arg0)
		{
			return Instance.CallMethod<CharsetEncoder>("replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;", arg0);
		}
		
		[JavaSignature("()[B")]
		public ByteArray replacement()
		{
			return Instance.CallMethod<ByteArray>("replacement", "()[B");
		}
		
		[JavaSignature("()Ljava/nio/charset/CodingErrorAction;")]
		public CodingErrorAction unmappableCharacterAction()
		{
			return Instance.CallMethod<CodingErrorAction>("unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
		}
	}
}
