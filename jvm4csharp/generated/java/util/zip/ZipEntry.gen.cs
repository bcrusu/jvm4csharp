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
using jvm4csharp.java.nio.file.attribute;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/ZipEntry")]
	public class ZipEntry : Object, Cloneable
	{
		protected ZipEntry(ProxyCtor p) : base(p) {}
		
		public ZipEntry(ZipEntry arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/zip/ZipEntry;)V", arg0);
		}
		
		public ZipEntry(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("I")]
		public static int STORED
		{
			get { return Static.GetField<int>(typeof(ZipEntry), "STORED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DEFLATED
		{
			get { return Static.GetField<int>(typeof(ZipEntry), "DEFLATED", "I"); }
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getMethod()
		{
			return Instance.CallMethod<int>("getMethod", "()I");
		}
		
		[JavaSignature("()J")]
		public long getSize()
		{
			return Instance.CallMethod<long>("getSize", "()J");
		}
		
		[JavaSignature("()Ljava/nio/file/attribute/FileTime;")]
		public FileTime getLastModifiedTime()
		{
			return Instance.CallMethod<FileTime>("getLastModifiedTime", "()Ljava/nio/file/attribute/FileTime;");
		}
		
		[JavaSignature("()Z")]
		public bool isDirectory()
		{
			return Instance.CallMethod<bool>("isDirectory", "()Z");
		}
		
		[JavaSignature("(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;")]
		public ZipEntry setLastModifiedTime(FileTime arg0)
		{
			return Instance.CallMethod<ZipEntry>("setLastModifiedTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setSize(long arg0)
		{
			Instance.CallMethod("setSize", "(J)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getComment()
		{
			return Instance.CallMethod<String>("getComment", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()J")]
		public long getCompressedSize()
		{
			return Instance.CallMethod<long>("getCompressedSize", "()J");
		}
		
		[JavaSignature("()J")]
		public long getCrc()
		{
			return Instance.CallMethod<long>("getCrc", "()J");
		}
		
		[JavaSignature("()Ljava/nio/file/attribute/FileTime;")]
		public FileTime getCreationTime()
		{
			return Instance.CallMethod<FileTime>("getCreationTime", "()Ljava/nio/file/attribute/FileTime;");
		}
		
		[JavaSignature("()[B")]
		public ByteArray getExtra()
		{
			return Instance.CallMethod<ByteArray>("getExtra", "()[B");
		}
		
		[JavaSignature("()Ljava/nio/file/attribute/FileTime;")]
		public FileTime getLastAccessTime()
		{
			return Instance.CallMethod<FileTime>("getLastAccessTime", "()Ljava/nio/file/attribute/FileTime;");
		}
		
		[JavaSignature("()J")]
		public long getTime()
		{
			return Instance.CallMethod<long>("getTime", "()J");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setComment(String arg0)
		{
			Instance.CallMethod("setComment", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setCompressedSize(long arg0)
		{
			Instance.CallMethod("setCompressedSize", "(J)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setCrc(long arg0)
		{
			Instance.CallMethod("setCrc", "(J)V", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;")]
		public ZipEntry setCreationTime(FileTime arg0)
		{
			return Instance.CallMethod<ZipEntry>("setCreationTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
		}
		
		[JavaSignature("([B)V")]
		public void setExtra(ByteArray arg0)
		{
			Instance.CallMethod("setExtra", "([B)V", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;")]
		public ZipEntry setLastAccessTime(FileTime arg0)
		{
			return Instance.CallMethod<ZipEntry>("setLastAccessTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMethod(int arg0)
		{
			Instance.CallMethod("setMethod", "(I)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setTime(long arg0)
		{
			Instance.CallMethod("setTime", "(J)V", arg0);
		}
	}
}
