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
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/ZipFile")]
	public partial class ZipFile : Object, Closeable
	{
		protected ZipFile(ProxyCtor p) : base(p) {}
		
		public ZipFile(String arg0, Charset arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/nio/charset/Charset;)V", arg0, arg1);
		}
		
		public ZipFile(File arg0, int arg1, Charset arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;ILjava/nio/charset/Charset;)V", arg0, arg1, arg2);
		}
		
		public ZipFile(File arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;)V", arg0);
		}
		
		public ZipFile(File arg0, Charset arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Ljava/nio/charset/Charset;)V", arg0, arg1);
		}
		
		public ZipFile(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public ZipFile(File arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;I)V", arg0, arg1);
		}
	
		[JavaSignature("I")]
		public static int OPEN_READ
		{
			get { return Static.GetField<int>(typeof(ZipFile), "OPEN_READ", "I"); }
		}
		
		[JavaSignature("I")]
		public static int OPEN_DELETE
		{
			get { return Static.GetField<int>(typeof(ZipFile), "OPEN_DELETE", "I"); }
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<ZipEntry> stream()
		{
			return Instance.CallMethod<Stream<ZipEntry>>("stream", "()Ljava/util/stream/Stream;");
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;")]
		public InputStream getInputStream(ZipEntry arg0)
		{
			return Instance.CallMethod<InputStream>("getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<ZipEntry> entries()
		{
			return Instance.CallMethod<Enumeration<ZipEntry>>("entries", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/zip/ZipEntry;")]
		public ZipEntry getEntry(String arg0)
		{
			return Instance.CallMethod<ZipEntry>("getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getComment()
		{
			return Instance.CallMethod<String>("getComment", "()Ljava/lang/String;");
		}
	}
}
