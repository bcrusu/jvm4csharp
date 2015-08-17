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
using jvm4csharp.java.nio.file.attribute;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/FileVisitor")]
	public interface FileVisitor<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;")]
		FileVisitResult postVisitDirectory(T arg0, IOException arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;")]
		FileVisitResult preVisitDirectory(T arg0, BasicFileAttributes arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;")]
		FileVisitResult visitFile(T arg0, BasicFileAttributes arg1);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;")]
		FileVisitResult visitFileFailed(T arg0, IOException arg1);
	}
}
