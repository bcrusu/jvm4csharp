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
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file.attribute
{
	[JavaProxy("java/nio/file/attribute/FileTime")]
	public class FileTime : Object, Comparable<FileTime>
	{
		protected FileTime(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/nio/file/attribute/FileTime;)I")]
		public int compareTo(FileTime arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/file/attribute/FileTime;)I", arg0);
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/nio/file/attribute/FileTime;")]
		public static FileTime @from(long arg0, TimeUnit arg1)
		{
			return Static.CallMethod<FileTime>(typeof(FileTime), "from", "(JLjava/util/concurrent/TimeUnit;)Ljava/nio/file/attribute/FileTime;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/TimeUnit;)J")]
		public long to(TimeUnit arg0)
		{
			return Instance.CallMethod<long>("to", "(Ljava/util/concurrent/TimeUnit;)J", arg0);
		}
		
		[JavaSignature("(J)Ljava/nio/file/attribute/FileTime;")]
		public static FileTime fromMillis(long arg0)
		{
			return Static.CallMethod<FileTime>(typeof(FileTime), "fromMillis", "(J)Ljava/nio/file/attribute/FileTime;", arg0);
		}
		
		[JavaSignature("()J")]
		public long toMillis()
		{
			return Instance.CallMethod<long>("toMillis", "()J");
		}
	}
}
