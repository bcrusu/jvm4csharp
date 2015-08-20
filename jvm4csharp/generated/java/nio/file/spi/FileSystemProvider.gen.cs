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
using jvm4csharp.java.nio.channels;
using jvm4csharp.java.nio.file.attribute;
using jvm4csharp.java.util;
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file.spi
{
	[JavaProxy("java/nio/file/spi/FileSystemProvider")]
	public abstract partial class FileSystemProvider : Object
	{
		protected FileSystemProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/DirectoryStream/Filter;)Ljava/nio/file/DirectoryStream;")]
		public DirectoryStream<Path> newDirectoryStream(Path arg0, DirectoryStream_.Filter<IJavaObject> arg1)
		{
			return Instance.CallMethod<DirectoryStream<Path>>("newDirectoryStream", "(Ljava/nio/file/Path;Ljava/nio/file/DirectoryStream/Filter;)Ljava/nio/file/DirectoryStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/AccessMode;)V")]
		public void checkAccess(Path arg0, ObjectArray<AccessMode> arg1)
		{
			Instance.CallMethod("checkAccess", "(Ljava/nio/file/Path;[Ljava/nio/file/AccessMode;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)V")]
		public void delete(Path arg0)
		{
			Instance.CallMethod("delete", "(Ljava/nio/file/Path;)V", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V")]
		public void copy(Path arg0, Path arg1, ObjectArray<CopyOption> arg2)
		{
			Instance.CallMethod("copy", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V")]
		public void createDirectory(Path arg0, ObjectArray<FileAttribute<IJavaObject>> arg1)
		{
			Instance.CallMethod("createDirectory", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/URI;)Ljava/nio/file/FileSystem;")]
		public FileSystem getFileSystem(URI arg0)
		{
			return Instance.CallMethod<FileSystem>("getFileSystem", "(Ljava/net/URI;)Ljava/nio/file/FileSystem;", arg0);
		}
		
		[JavaSignature("(Ljava/net/URI;)Ljava/nio/file/Path;")]
		public Path getPath(URI arg0)
		{
			return Instance.CallMethod<Path>("getPath", "(Ljava/net/URI;)Ljava/nio/file/Path;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getScheme()
		{
			return Instance.CallMethod<String>("getScheme", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public bool isHidden(Path arg0)
		{
			return Instance.CallMethod<bool>("isHidden", "(Ljava/nio/file/Path;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)V")]
		public void setAttribute(Path arg0, String arg1, IJavaObject arg2, ObjectArray<LinkOption> arg3)
		{
			Instance.CallMethod("setAttribute", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public static List<FileSystemProvider> installedProviders()
		{
			return Static.CallMethod<List<FileSystemProvider>>(typeof(FileSystemProvider), "installedProviders", "()Ljava/util/List;");
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Map;)Ljava/nio/file/FileSystem;")]
		public FileSystem newFileSystem(Path arg0, Map<String, IJavaObject> arg1)
		{
			return Instance.CallMethod<FileSystem>("newFileSystem", "(Ljava/nio/file/Path;Ljava/util/Map;)Ljava/nio/file/FileSystem;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;")]
		public FileSystem newFileSystem(URI arg0, Map<String, IJavaObject> arg1)
		{
			return Instance.CallMethod<FileSystem>("newFileSystem", "(Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;)V")]
		public void createLink(Path arg0, Path arg1)
		{
			Instance.CallMethod("createLink", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V")]
		public void createSymbolicLink(Path arg0, Path arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			Instance.CallMethod("createSymbolicLink", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;")]
		public V getFileAttributeView<V>(Path arg0, Class<V> arg1, ObjectArray<LinkOption> arg2)
			where V : FileAttributeView
		{
			return Instance.CallMethod<V>("getFileAttributeView", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/FileStore;")]
		public FileStore getFileStore(Path arg0)
		{
			return Instance.CallMethod<FileStore>("getFileStore", "(Ljava/nio/file/Path;)Ljava/nio/file/FileStore;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;)Z")]
		public bool isSameFile(Path arg0, Path arg1)
		{
			return Instance.CallMethod<bool>("isSameFile", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V")]
		public void move(Path arg0, Path arg1, ObjectArray<CopyOption> arg2)
		{
			Instance.CallMethod("move", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;")]
		public AsynchronousFileChannel newAsynchronousFileChannel(Path arg0, Set<OpenOption> arg1, ExecutorService arg2, ObjectArray<FileAttribute<IJavaObject>> arg3)
		{
			return Instance.CallMethod<AsynchronousFileChannel>("newAsynchronousFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;")]
		public SeekableByteChannel newByteChannel(Path arg0, Set<OpenOption> arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			return Instance.CallMethod<SeekableByteChannel>("newByteChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;")]
		public FileChannel newFileChannel(Path arg0, Set<OpenOption> arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			return Instance.CallMethod<FileChannel>("newFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;")]
		public Map<String, IJavaObject> readAttributes(Path arg0, String arg1, ObjectArray<LinkOption> arg2)
		{
			return Instance.CallMethod<Map<String, IJavaObject>>("readAttributes", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;")]
		public A readAttributes<A>(Path arg0, Class<A> arg1, ObjectArray<LinkOption> arg2)
			where A : BasicFileAttributes
		{
			return Instance.CallMethod<A>("readAttributes", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/Path;")]
		public Path readSymbolicLink(Path arg0)
		{
			return Instance.CallMethod<Path>("readSymbolicLink", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public bool deleteIfExists(Path arg0)
		{
			return Instance.CallMethod<bool>("deleteIfExists", "(Ljava/nio/file/Path;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;")]
		public InputStream newInputStream(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Instance.CallMethod<InputStream>("newInputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;")]
		public OutputStream newOutputStream(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Instance.CallMethod<OutputStream>("newOutputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;", arg0, arg1);
		}
	}
}
