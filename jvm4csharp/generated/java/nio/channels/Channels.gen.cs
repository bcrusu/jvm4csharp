//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.nio.charset;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/Channels")]
	public partial class Channels : Object
	{
		protected Channels(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/charset/CharsetDecoder;I)Ljava/io/Reader;")]
		public static Reader newReader(ReadableByteChannel arg0, CharsetDecoder arg1, int arg2)
		{
			return Static.CallMethod<Reader>(typeof(Channels), "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/charset/CharsetDecoder;I)Ljava/io/Reader;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)Ljava/io/Reader;")]
		public static Reader newReader(ReadableByteChannel arg0, String arg1)
		{
			return Static.CallMethod<Reader>(typeof(Channels), "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)Ljava/io/Reader;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/channels/AsynchronousByteChannel;)Ljava/io/InputStream;")]
		public static InputStream newInputStream(AsynchronousByteChannel arg0)
		{
			return Static.CallMethod<InputStream>(typeof(Channels), "newInputStream", "(Ljava/nio/channels/AsynchronousByteChannel;)Ljava/io/InputStream;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;")]
		public static InputStream newInputStream(ReadableByteChannel arg0)
		{
			return Static.CallMethod<InputStream>(typeof(Channels), "newInputStream", "(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/channels/AsynchronousByteChannel;)Ljava/io/OutputStream;")]
		public static OutputStream newOutputStream(AsynchronousByteChannel arg0)
		{
			return Static.CallMethod<OutputStream>(typeof(Channels), "newOutputStream", "(Ljava/nio/channels/AsynchronousByteChannel;)Ljava/io/OutputStream;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;")]
		public static OutputStream newOutputStream(WritableByteChannel arg0)
		{
			return Static.CallMethod<OutputStream>(typeof(Channels), "newOutputStream", "(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;", arg0);
		}
		
		[JavaSignature("(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;")]
		public static WritableByteChannel newChannel(OutputStream arg0)
		{
			return Static.CallMethod<WritableByteChannel>(typeof(Channels), "newChannel", "(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;")]
		public static ReadableByteChannel newChannel(InputStream arg0)
		{
			return Static.CallMethod<ReadableByteChannel>(typeof(Channels), "newChannel", "(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/channels/WritableByteChannel;Ljava/lang/String;)Ljava/io/Writer;")]
		public static Writer newWriter(WritableByteChannel arg0, String arg1)
		{
			return Static.CallMethod<Writer>(typeof(Channels), "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/lang/String;)Ljava/io/Writer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/channels/WritableByteChannel;Ljava/nio/charset/CharsetEncoder;I)Ljava/io/Writer;")]
		public static Writer newWriter(WritableByteChannel arg0, CharsetEncoder arg1, int arg2)
		{
			return Static.CallMethod<Writer>(typeof(Channels), "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/nio/charset/CharsetEncoder;I)Ljava/io/Writer;", arg0, arg1, arg2);
		}
	}
}
