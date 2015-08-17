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
using jvm4csharp.java.nio;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Base64")]
	public class Base64 : Object
	{
		protected Base64(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/Base64/Decoder;")]
		public static Base64.Decoder getMimeDecoder()
		{
			return Static.CallMethod<Base64.Decoder>(typeof(Base64), "getMimeDecoder", "()Ljava/util/Base64/Decoder;");
		}
		
		[JavaSignature("()Ljava/util/Base64/Decoder;")]
		public static Base64.Decoder getDecoder()
		{
			return Static.CallMethod<Base64.Decoder>(typeof(Base64), "getDecoder", "()Ljava/util/Base64/Decoder;");
		}
		
		[JavaSignature("()Ljava/util/Base64/Encoder;")]
		public static Base64.Encoder getEncoder()
		{
			return Static.CallMethod<Base64.Encoder>(typeof(Base64), "getEncoder", "()Ljava/util/Base64/Encoder;");
		}
		
		[JavaSignature("(I[B)Ljava/util/Base64/Encoder;")]
		public static Base64.Encoder getMimeEncoder(int arg0, ByteArray arg1)
		{
			return Static.CallMethod<Base64.Encoder>(typeof(Base64), "getMimeEncoder", "(I[B)Ljava/util/Base64/Encoder;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Base64/Encoder;")]
		public static Base64.Encoder getMimeEncoder()
		{
			return Static.CallMethod<Base64.Encoder>(typeof(Base64), "getMimeEncoder", "()Ljava/util/Base64/Encoder;");
		}
		
		[JavaSignature("()Ljava/util/Base64/Decoder;")]
		public static Base64.Decoder getUrlDecoder()
		{
			return Static.CallMethod<Base64.Decoder>(typeof(Base64), "getUrlDecoder", "()Ljava/util/Base64/Decoder;");
		}
		
		[JavaSignature("()Ljava/util/Base64/Encoder;")]
		public static Base64.Encoder getUrlEncoder()
		{
			return Static.CallMethod<Base64.Encoder>(typeof(Base64), "getUrlEncoder", "()Ljava/util/Base64/Encoder;");
		}
	
		[JavaProxy("java/util/Base64/Decoder")]
		public class Decoder : Object
		{
			protected Decoder(ProxyCtor p) : base(p) {}
		
			[JavaSignature("([B)[B")]
			public ByteArray decode(ByteArray arg0)
			{
				return Instance.CallMethod<ByteArray>("decode", "([B)[B", arg0);
			}
			
			[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;")]
			public ByteBuffer decode(ByteBuffer arg0)
			{
				return Instance.CallMethod<ByteBuffer>("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", arg0);
			}
			
			[JavaSignature("([B[B)I")]
			public int decode(ByteArray arg0, ByteArray arg1)
			{
				return Instance.CallMethod<int>("decode", "([B[B)I", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;)[B")]
			public ByteArray decode(String arg0)
			{
				return Instance.CallMethod<ByteArray>("decode", "(Ljava/lang/String;)[B", arg0);
			}
			
			[JavaSignature("(Ljava/io/InputStream;)Ljava/io/InputStream;")]
			public InputStream wrap(InputStream arg0)
			{
				return Instance.CallMethod<InputStream>("wrap", "(Ljava/io/InputStream;)Ljava/io/InputStream;", arg0);
			}
		}
		
		[JavaProxy("java/util/Base64/Encoder")]
		public class Encoder : Object
		{
			protected Encoder(ProxyCtor p) : base(p) {}
		
			[JavaSignature("([B)[B")]
			public ByteArray encode(ByteArray arg0)
			{
				return Instance.CallMethod<ByteArray>("encode", "([B)[B", arg0);
			}
			
			[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;")]
			public ByteBuffer encode(ByteBuffer arg0)
			{
				return Instance.CallMethod<ByteBuffer>("encode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", arg0);
			}
			
			[JavaSignature("([B[B)I")]
			public int encode(ByteArray arg0, ByteArray arg1)
			{
				return Instance.CallMethod<int>("encode", "([B[B)I", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/io/OutputStream;)Ljava/io/OutputStream;")]
			public OutputStream wrap(OutputStream arg0)
			{
				return Instance.CallMethod<OutputStream>("wrap", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", arg0);
			}
			
			[JavaSignature("([B)Ljava/lang/String;")]
			public String encodeToString(ByteArray arg0)
			{
				return Instance.CallMethod<String>("encodeToString", "([B)Ljava/lang/String;", arg0);
			}
			
			[JavaSignature("()Ljava/util/Base64/Encoder;")]
			public Base64.Encoder withoutPadding()
			{
				return Instance.CallMethod<Base64.Encoder>("withoutPadding", "()Ljava/util/Base64/Encoder;");
			}
		}
	}
}
