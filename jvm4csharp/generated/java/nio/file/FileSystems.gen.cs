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
using jvm4csharp.java.net;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/FileSystems")]
	public partial class FileSystems : Object
	{
		protected FileSystems(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/file/FileSystem;")]
		public static FileSystem getDefault()
		{
			return Static.CallMethod<FileSystem>(typeof(FileSystems), "getDefault", "()Ljava/nio/file/FileSystem;");
		}
		
		[JavaSignature("(Ljava/net/URI;)Ljava/nio/file/FileSystem;")]
		public static FileSystem getFileSystem(URI arg0)
		{
			return Static.CallMethod<FileSystem>(typeof(FileSystems), "getFileSystem", "(Ljava/net/URI;)Ljava/nio/file/FileSystem;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/ClassLoader;)Ljava/nio/file/FileSystem;")]
		public static FileSystem newFileSystem(Path arg0, ClassLoader arg1)
		{
			return Static.CallMethod<FileSystem>(typeof(FileSystems), "newFileSystem", "(Ljava/nio/file/Path;Ljava/lang/ClassLoader;)Ljava/nio/file/FileSystem;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/URI;Ljava/util/Map;Ljava/lang/ClassLoader;)Ljava/nio/file/FileSystem;")]
		public static FileSystem newFileSystem(URI arg0, Map<String, IJavaObject> arg1, ClassLoader arg2)
		{
			return Static.CallMethod<FileSystem>(typeof(FileSystems), "newFileSystem", "(Ljava/net/URI;Ljava/util/Map;Ljava/lang/ClassLoader;)Ljava/nio/file/FileSystem;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;")]
		public static FileSystem newFileSystem(URI arg0, Map<String, IJavaObject> arg1)
		{
			return Static.CallMethod<FileSystem>(typeof(FileSystems), "newFileSystem", "(Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;", arg0, arg1);
		}
	}
}
