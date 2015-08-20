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
using jvm4csharp.java.nio.file.attribute;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/SimpleFileVisitor")]
	public partial class SimpleFileVisitor<T> : Object, FileVisitor<T>
		where T : IJavaObject
	{
		protected SimpleFileVisitor(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;")]
		public FileVisitResult postVisitDirectory(T arg0, IOException arg1)
		{
			return Instance.CallMethod<FileVisitResult>("postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;")]
		public FileVisitResult preVisitDirectory(T arg0, BasicFileAttributes arg1)
		{
			return Instance.CallMethod<FileVisitResult>("preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;")]
		public FileVisitResult visitFile(T arg0, BasicFileAttributes arg1)
		{
			return Instance.CallMethod<FileVisitResult>("visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;")]
		public FileVisitResult visitFileFailed(T arg0, IOException arg1)
		{
			return Instance.CallMethod<FileVisitResult>("visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
		}
	}
}
