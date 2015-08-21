//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;
using jvm4csharp.java.nio.channels;
using jvm4csharp.java.nio.file.attribute;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/SecureDirectoryStream")]
	public partial interface SecureDirectoryStream<T> : DirectoryStream<T>
		where T : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;[Ljava/nio/file/LinkOption;)Ljava/nio/file/SecureDirectoryStream;")]
		SecureDirectoryStream<T> newDirectoryStream(T arg0, ObjectArray<LinkOption> arg1);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void deleteDirectory(T arg0);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void deleteFile(T arg0);
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/nio/file/attribute/FileAttributeView;")]
		V getFileAttributeView<V>(Class<V> arg0)
			where V : FileAttributeView;
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;")]
		V getFileAttributeView<V>(T arg0, Class<V> arg1, ObjectArray<LinkOption> arg2)
			where V : FileAttributeView;
		
		[JavaSignature("(Ljava/lang/Object;Ljava/nio/file/SecureDirectoryStream;Ljava/lang/Object;)V")]
		void move(T arg0, SecureDirectoryStream<T> arg1, T arg2);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;")]
		SeekableByteChannel newByteChannel(T arg0, Set<OpenOption> arg1, ObjectArray<FileAttribute<IJavaObject>> arg2);
	}
}
