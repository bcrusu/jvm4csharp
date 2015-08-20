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
using jvm4csharp.java.nio.channels;
using jvm4csharp.java.nio.charset;
using jvm4csharp.java.nio.file.attribute;
using jvm4csharp.java.util;
using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/Files")]
	public partial class Files : Object
	{
		protected Files(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/DirectoryStream;")]
		public static DirectoryStream<Path> newDirectoryStream(Path arg0, String arg1)
		{
			return Static.CallMethod<DirectoryStream<Path>>(typeof(Files), "newDirectoryStream", "(Ljava/nio/file/Path;Ljava/lang/String;)Ljava/nio/file/DirectoryStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/DirectoryStream;")]
		public static DirectoryStream<Path> newDirectoryStream(Path arg0)
		{
			return Static.CallMethod<DirectoryStream<Path>>(typeof(Files), "newDirectoryStream", "(Ljava/nio/file/Path;)Ljava/nio/file/DirectoryStream;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/DirectoryStream/Filter;)Ljava/nio/file/DirectoryStream;")]
		public static DirectoryStream<Path> newDirectoryStream(Path arg0, DirectoryStream_.Filter<IJavaObject> arg1)
		{
			return Static.CallMethod<DirectoryStream<Path>>(typeof(Files), "newDirectoryStream", "(Ljava/nio/file/Path;Ljava/nio/file/DirectoryStream/Filter;)Ljava/nio/file/DirectoryStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)J")]
		public static long size(Path arg0)
		{
			return Static.CallMethod<long>(typeof(Files), "size", "(Ljava/nio/file/Path;)J", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;ILjava/util/function/BiPredicate;[Ljava/nio/file/FileVisitOption;)Ljava/util/stream/Stream;")]
		public static Stream<Path> find(Path arg0, int arg1, BiPredicate<Path, BasicFileAttributes> arg2, ObjectArray<FileVisitOption> arg3)
		{
			return Static.CallMethod<Stream<Path>>(typeof(Files), "find", "(Ljava/nio/file/Path;ILjava/util/function/BiPredicate;[Ljava/nio/file/FileVisitOption;)Ljava/util/stream/Stream;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[B[Ljava/nio/file/OpenOption;)Ljava/nio/file/Path;")]
		public static Path write(Path arg0, ByteArray arg1, ObjectArray<OpenOption> arg2)
		{
			return Static.CallMethod<Path>(typeof(Files), "write", "(Ljava/nio/file/Path;[B[Ljava/nio/file/OpenOption;)Ljava/nio/file/Path;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/Iterable;Ljava/nio/charset/Charset;[Ljava/nio/file/OpenOption;)Ljava/nio/file/Path;")]
		public static Path write(Path arg0, Iterable<CharSequence> arg1, Charset arg2, ObjectArray<OpenOption> arg3)
		{
			return Static.CallMethod<Path>(typeof(Files), "write", "(Ljava/nio/file/Path;Ljava/lang/Iterable;Ljava/nio/charset/Charset;[Ljava/nio/file/OpenOption;)Ljava/nio/file/Path;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/Iterable;[Ljava/nio/file/OpenOption;)Ljava/nio/file/Path;")]
		public static Path write(Path arg0, Iterable<CharSequence> arg1, ObjectArray<OpenOption> arg2)
		{
			return Static.CallMethod<Path>(typeof(Files), "write", "(Ljava/nio/file/Path;Ljava/lang/Iterable;[Ljava/nio/file/OpenOption;)Ljava/nio/file/Path;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)V")]
		public static void delete(Path arg0)
		{
			Static.CallMethod(typeof(Files), "delete", "(Ljava/nio/file/Path;)V", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/util/stream/Stream;")]
		public static Stream<Path> list(Path arg0)
		{
			return Static.CallMethod<Stream<Path>>(typeof(Files), "list", "(Ljava/nio/file/Path;)Ljava/util/stream/Stream;", arg0);
		}
		
		[JavaSignature("(Ljava/io/InputStream;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)J")]
		public static long copy(InputStream arg0, Path arg1, ObjectArray<CopyOption> arg2)
		{
			return Static.CallMethod<long>(typeof(Files), "copy", "(Ljava/io/InputStream;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)Ljava/nio/file/Path;")]
		public static Path copy(Path arg0, Path arg1, ObjectArray<CopyOption> arg2)
		{
			return Static.CallMethod<Path>(typeof(Files), "copy", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)Ljava/nio/file/Path;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/io/OutputStream;)J")]
		public static long copy(Path arg0, OutputStream arg1)
		{
			return Static.CallMethod<long>(typeof(Files), "copy", "(Ljava/nio/file/Path;Ljava/io/OutputStream;)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createDirectory(Path arg0, ObjectArray<FileAttribute<IJavaObject>> arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "createDirectory", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createTempFile(Path arg0, String arg1, String arg2, ObjectArray<FileAttribute<IJavaObject>> arg3)
		{
			return Static.CallMethod<Path>(typeof(Files), "createTempFile", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createTempFile(String arg0, String arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			return Static.CallMethod<Path>(typeof(Files), "createTempFile", "(Ljava/lang/String;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z")]
		public static bool exists(Path arg0, ObjectArray<LinkOption> arg1)
		{
			return Static.CallMethod<bool>(typeof(Files), "exists", "(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileTime;")]
		public static FileTime getLastModifiedTime(Path arg0, ObjectArray<LinkOption> arg1)
		{
			return Static.CallMethod<FileTime>(typeof(Files), "getLastModifiedTime", "(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileTime;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z")]
		public static bool isDirectory(Path arg0, ObjectArray<LinkOption> arg1)
		{
			return Static.CallMethod<bool>(typeof(Files), "isDirectory", "(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public static bool isHidden(Path arg0)
		{
			return Static.CallMethod<bool>(typeof(Files), "isHidden", "(Ljava/nio/file/Path;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/attribute/FileTime;)Ljava/nio/file/Path;")]
		public static Path setLastModifiedTime(Path arg0, FileTime arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "setLastModifiedTime", "(Ljava/nio/file/Path;Ljava/nio/file/attribute/FileTime;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/util/stream/Stream;")]
		public static Stream<String> lines(Path arg0, Charset arg1)
		{
			return Static.CallMethod<Stream<String>>(typeof(Files), "lines", "(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/util/stream/Stream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/util/stream/Stream;")]
		public static Stream<String> lines(Path arg0)
		{
			return Static.CallMethod<Stream<String>>(typeof(Files), "lines", "(Ljava/nio/file/Path;)Ljava/util/stream/Stream;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/lang/Object;")]
		public static IJavaObject getAttribute(Path arg0, String arg1, ObjectArray<LinkOption> arg2)
		{
			return Static.CallMethod<IJavaObject>(typeof(Files), "getAttribute", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;")]
		public static Path setAttribute(Path arg0, String arg1, IJavaObject arg2, ObjectArray<LinkOption> arg3)
		{
			return Static.CallMethod<Path>(typeof(Files), "setAttribute", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z")]
		public static bool isRegularFile(Path arg0, ObjectArray<LinkOption> arg1)
		{
			return Static.CallMethod<bool>(typeof(Files), "isRegularFile", "(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public static bool isSymbolicLink(Path arg0)
		{
			return Static.CallMethod<bool>(typeof(Files), "isSymbolicLink", "(Ljava/nio/file/Path;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/io/BufferedReader;")]
		public static BufferedReader newBufferedReader(Path arg0, Charset arg1)
		{
			return Static.CallMethod<BufferedReader>(typeof(Files), "newBufferedReader", "(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/io/BufferedReader;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/io/BufferedReader;")]
		public static BufferedReader newBufferedReader(Path arg0)
		{
			return Static.CallMethod<BufferedReader>(typeof(Files), "newBufferedReader", "(Ljava/nio/file/Path;)Ljava/io/BufferedReader;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/BufferedWriter;")]
		public static BufferedWriter newBufferedWriter(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Static.CallMethod<BufferedWriter>(typeof(Files), "newBufferedWriter", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/BufferedWriter;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/charset/Charset;[Ljava/nio/file/OpenOption;)Ljava/io/BufferedWriter;")]
		public static BufferedWriter newBufferedWriter(Path arg0, Charset arg1, ObjectArray<OpenOption> arg2)
		{
			return Static.CallMethod<BufferedWriter>(typeof(Files), "newBufferedWriter", "(Ljava/nio/file/Path;Ljava/nio/charset/Charset;[Ljava/nio/file/OpenOption;)Ljava/io/BufferedWriter;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z")]
		public static bool notExists(Path arg0, ObjectArray<LinkOption> arg1)
		{
			return Static.CallMethod<bool>(typeof(Files), "notExists", "(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/lang/String;")]
		public static String probeContentType(Path arg0)
		{
			return Static.CallMethod<String>(typeof(Files), "probeContentType", "(Ljava/nio/file/Path;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)[B")]
		public static ByteArray readAllBytes(Path arg0)
		{
			return Static.CallMethod<ByteArray>(typeof(Files), "readAllBytes", "(Ljava/nio/file/Path;)[B", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/util/List;")]
		public static List<String> readAllLines(Path arg0)
		{
			return Static.CallMethod<List<String>>(typeof(Files), "readAllLines", "(Ljava/nio/file/Path;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/util/List;")]
		public static List<String> readAllLines(Path arg0, Charset arg1)
		{
			return Static.CallMethod<List<String>>(typeof(Files), "readAllLines", "(Ljava/nio/file/Path;Ljava/nio/charset/Charset;)Ljava/util/List;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;)Ljava/nio/file/Path;")]
		public static Path setPosixFilePermissions(Path arg0, Set<PosixFilePermission> arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "setPosixFilePermissions", "(Ljava/nio/file/Path;Ljava/util/Set;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/FileVisitor;)Ljava/nio/file/Path;")]
		public static Path walkFileTree(Path arg0, FileVisitor<IJavaObject> arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "walkFileTree", "(Ljava/nio/file/Path;Ljava/nio/file/FileVisitor;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;ILjava/nio/file/FileVisitor;)Ljava/nio/file/Path;")]
		public static Path walkFileTree(Path arg0, Set<FileVisitOption> arg1, int arg2, FileVisitor<IJavaObject> arg3)
		{
			return Static.CallMethod<Path>(typeof(Files), "walkFileTree", "(Ljava/nio/file/Path;Ljava/util/Set;ILjava/nio/file/FileVisitor;)Ljava/nio/file/Path;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public static bool isReadable(Path arg0)
		{
			return Static.CallMethod<bool>(typeof(Files), "isReadable", "(Ljava/nio/file/Path;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public static bool isWritable(Path arg0)
		{
			return Static.CallMethod<bool>(typeof(Files), "isWritable", "(Ljava/nio/file/Path;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;")]
		public static Path createLink(Path arg0, Path arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "createLink", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createSymbolicLink(Path arg0, Path arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			return Static.CallMethod<Path>(typeof(Files), "createSymbolicLink", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;")]
		public static V getFileAttributeView<V>(Path arg0, Class<V> arg1, ObjectArray<LinkOption> arg2)
			where V : FileAttributeView
		{
			return Static.CallMethod<V>(typeof(Files), "getFileAttributeView", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/FileStore;")]
		public static FileStore getFileStore(Path arg0)
		{
			return Static.CallMethod<FileStore>(typeof(Files), "getFileStore", "(Ljava/nio/file/Path;)Ljava/nio/file/FileStore;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;)Z")]
		public static bool isSameFile(Path arg0, Path arg1)
		{
			return Static.CallMethod<bool>(typeof(Files), "isSameFile", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)Ljava/nio/file/Path;")]
		public static Path move(Path arg0, Path arg1, ObjectArray<CopyOption> arg2)
		{
			return Static.CallMethod<Path>(typeof(Files), "move", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)Ljava/nio/file/Path;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;")]
		public static SeekableByteChannel newByteChannel(Path arg0, Set<OpenOption> arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			return Static.CallMethod<SeekableByteChannel>(typeof(Files), "newByteChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/SeekableByteChannel;")]
		public static SeekableByteChannel newByteChannel(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Static.CallMethod<SeekableByteChannel>(typeof(Files), "newByteChannel", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/SeekableByteChannel;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;")]
		public static A readAttributes<A>(Path arg0, Class<A> arg1, ObjectArray<LinkOption> arg2)
			where A : BasicFileAttributes
		{
			return Static.CallMethod<A>(typeof(Files), "readAttributes", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;")]
		public static Map<String, IJavaObject> readAttributes(Path arg0, String arg1, ObjectArray<LinkOption> arg2)
		{
			return Static.CallMethod<Map<String, IJavaObject>>(typeof(Files), "readAttributes", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/nio/file/Path;")]
		public static Path readSymbolicLink(Path arg0)
		{
			return Static.CallMethod<Path>(typeof(Files), "readSymbolicLink", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public static bool deleteIfExists(Path arg0)
		{
			return Static.CallMethod<bool>(typeof(Files), "deleteIfExists", "(Ljava/nio/file/Path;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;")]
		public static InputStream newInputStream(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Static.CallMethod<InputStream>(typeof(Files), "newInputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;")]
		public static OutputStream newOutputStream(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Static.CallMethod<OutputStream>(typeof(Files), "newOutputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/FileVisitOption;)Ljava/util/stream/Stream;")]
		public static Stream<Path> walk(Path arg0, ObjectArray<FileVisitOption> arg1)
		{
			return Static.CallMethod<Stream<Path>>(typeof(Files), "walk", "(Ljava/nio/file/Path;[Ljava/nio/file/FileVisitOption;)Ljava/util/stream/Stream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;I[Ljava/nio/file/FileVisitOption;)Ljava/util/stream/Stream;")]
		public static Stream<Path> walk(Path arg0, int arg1, ObjectArray<FileVisitOption> arg2)
		{
			return Static.CallMethod<Stream<Path>>(typeof(Files), "walk", "(Ljava/nio/file/Path;I[Ljava/nio/file/FileVisitOption;)Ljava/util/stream/Stream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createDirectories(Path arg0, ObjectArray<FileAttribute<IJavaObject>> arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "createDirectories", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createFile(Path arg0, ObjectArray<FileAttribute<IJavaObject>> arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "createFile", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createTempDirectory(Path arg0, String arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			return Static.CallMethod<Path>(typeof(Files), "createTempDirectory", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;")]
		public static Path createTempDirectory(String arg0, ObjectArray<FileAttribute<IJavaObject>> arg1)
		{
			return Static.CallMethod<Path>(typeof(Files), "createTempDirectory", "(Ljava/lang/String;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Ljava/util/Set;")]
		public static Set<PosixFilePermission> getPosixFilePermissions(Path arg0, ObjectArray<LinkOption> arg1)
		{
			return Static.CallMethod<Set<PosixFilePermission>>(typeof(Files), "getPosixFilePermissions", "(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Ljava/util/Set;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;)Z")]
		public static bool isExecutable(Path arg0)
		{
			return Static.CallMethod<bool>(typeof(Files), "isExecutable", "(Ljava/nio/file/Path;)Z", arg0);
		}
	}
}
