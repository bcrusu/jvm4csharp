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
using jvm4csharp.java.net;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/Path")]
	public partial interface Path : Comparable<Path>, Iterable<Path>, Watchable
	{
		[JavaSignature("(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent/Kind;[Ljava/nio/file/WatchEvent/Modifier;)Ljava/nio/file/WatchKey;")]
		new WatchKey register(WatchService arg0, ObjectArray<WatchEvent_.Kind<IJavaObject>> arg1, ObjectArray<WatchEvent_.Modifier> arg2);
		
		[JavaSignature("(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent/Kind;)Ljava/nio/file/WatchKey;")]
		new WatchKey register(WatchService arg0, ObjectArray<WatchEvent_.Kind<IJavaObject>> arg1);
		
		[JavaSignature("(Ljava/nio/file/Path;)I")]
		new int compareTo(Path arg0);
		
		[JavaSignature("(I)Ljava/nio/file/Path;")]
		Path getName(int arg0);
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		bool endsWith(Path arg0);
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		bool endsWith(String arg0);
		
		[JavaSignature("()Ljava/util/Iterator;")]
		new Iterator<Path> iterator();
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		bool startsWith(String arg0);
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		bool startsWith(Path arg0);
		
		[JavaSignature("()Ljava/nio/file/Path;")]
		Path getParent();
		
		[JavaSignature("()Z")]
		bool isAbsolute();
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/Path;")]
		Path resolve(Path arg0);
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/Path;")]
		Path resolve(String arg0);
		
		[JavaSignature("()Ljava/nio/file/Path;")]
		Path getRoot();
		
		[JavaSignature("()Ljava/nio/file/Path;")]
		Path normalize();
		
		[JavaSignature("()Ljava/nio/file/FileSystem;")]
		FileSystem getFileSystem();
		
		[JavaSignature("()Ljava/nio/file/Path;")]
		Path getFileName();
		
		[JavaSignature("()I")]
		int getNameCount();
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/Path;")]
		Path relativize(Path arg0);
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/Path;")]
		Path resolveSibling(Path arg0);
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/Path;")]
		Path resolveSibling(String arg0);
		
		[JavaSignature("(II)Ljava/nio/file/Path;")]
		Path subpath(int arg0, int arg1);
		
		[JavaSignature("()Ljava/nio/file/Path;")]
		Path toAbsolutePath();
		
		[JavaSignature("()Ljava/io/File;")]
		File toFile();
		
		[JavaSignature("([Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;")]
		Path toRealPath(ObjectArray<LinkOption> arg0);
		
		[JavaSignature("()Ljava/net/URI;")]
		URI toUri();
	}
}
