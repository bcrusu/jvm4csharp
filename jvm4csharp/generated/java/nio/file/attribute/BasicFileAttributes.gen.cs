//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file.attribute
{
	[JavaProxy("java/nio/file/attribute/BasicFileAttributes")]
	public interface BasicFileAttributes : IJavaObject
	{
		[JavaSignature("()J")]
		long size();
		
		[JavaSignature("()Z")]
		bool isDirectory();
		
		[JavaSignature("()Z")]
		bool isOther();
		
		[JavaSignature("()Ljava/nio/file/attribute/FileTime;")]
		FileTime creationTime();
		
		[JavaSignature("()Ljava/lang/Object;")]
		IJavaObject fileKey();
		
		[JavaSignature("()Z")]
		bool isRegularFile();
		
		[JavaSignature("()Z")]
		bool isSymbolicLink();
		
		[JavaSignature("()Ljava/nio/file/attribute/FileTime;")]
		FileTime lastAccessTime();
		
		[JavaSignature("()Ljava/nio/file/attribute/FileTime;")]
		FileTime lastModifiedTime();
	}
}
