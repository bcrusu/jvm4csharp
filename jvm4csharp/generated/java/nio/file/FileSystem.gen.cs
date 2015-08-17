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
using jvm4csharp.java.nio.file.attribute;
using jvm4csharp.java.nio.file.spi;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/FileSystem")]
	public abstract class FileSystem : Object, Closeable
	{
		protected FileSystem(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/file/spi/FileSystemProvider;")]
		public FileSystemProvider provider()
		{
			return Instance.CallMethod<FileSystemProvider>("provider", "()Ljava/nio/file/spi/FileSystemProvider;");
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;")]
		public Path getPath(String arg0, ObjectArray<String> arg1)
		{
			return Instance.CallMethod<Path>("getPath", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSeparator()
		{
			return Instance.CallMethod<String>("getSeparator", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isReadOnly()
		{
			return Instance.CallMethod<bool>("isReadOnly", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isOpen()
		{
			return Instance.CallMethod<bool>("isOpen", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/Iterable;")]
		public Iterable<FileStore> getFileStores()
		{
			return Instance.CallMethod<Iterable<FileStore>>("getFileStores", "()Ljava/lang/Iterable;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/PathMatcher;")]
		public PathMatcher getPathMatcher(String arg0)
		{
			return Instance.CallMethod<PathMatcher>("getPathMatcher", "(Ljava/lang/String;)Ljava/nio/file/PathMatcher;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Iterable;")]
		public Iterable<Path> getRootDirectories()
		{
			return Instance.CallMethod<Iterable<Path>>("getRootDirectories", "()Ljava/lang/Iterable;");
		}
		
		[JavaSignature("()Ljava/nio/file/attribute/UserPrincipalLookupService;")]
		public UserPrincipalLookupService getUserPrincipalLookupService()
		{
			return Instance.CallMethod<UserPrincipalLookupService>("getUserPrincipalLookupService", "()Ljava/nio/file/attribute/UserPrincipalLookupService;");
		}
		
		[JavaSignature("()Ljava/nio/file/WatchService;")]
		public WatchService newWatchService()
		{
			return Instance.CallMethod<WatchService>("newWatchService", "()Ljava/nio/file/WatchService;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<String> supportedFileAttributeViews()
		{
			return Instance.CallMethod<Set<String>>("supportedFileAttributeViews", "()Ljava/util/Set;");
		}
	}
}
