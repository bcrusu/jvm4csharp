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
using jvm4csharp.java.lang;
using jvm4csharp.java.nio.channels.spi;
using jvm4csharp.java.nio.file;
using jvm4csharp.java.nio.file.attribute;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/FileChannel")]
	public abstract class FileChannel : AbstractInterruptibleChannel, SeekableByteChannel, GatheringByteChannel, ScatteringByteChannel
	{
		protected FileChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(JJZ)Ljava/nio/channels/FileLock;")]
		public FileLock @lock(long arg0, long arg1, bool arg2)
		{
			return Instance.CallMethod<FileLock>("lock", "(JJZ)Ljava/nio/channels/FileLock;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/nio/channels/FileLock;")]
		public FileLock @lock()
		{
			return Instance.CallMethod<FileLock>("lock", "()Ljava/nio/channels/FileLock;");
		}
		
		[JavaSignature("()J")]
		public long size()
		{
			return Instance.CallMethod<long>("size", "()J");
		}
		
		[JavaSignature("()J")]
		public long position()
		{
			return Instance.CallMethod<long>("position", "()J");
		}
		
		[JavaSignature("(J)Ljava/nio/channels/FileChannel;")]
		public FileChannel position(long arg0)
		{
			return Instance.CallMethod<FileChannel>("position", "(J)Ljava/nio/channels/FileChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;J)I")]
		public int write(ByteBuffer arg0, long arg1)
		{
			return Instance.CallMethod<int>("write", "(Ljava/nio/ByteBuffer;J)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		public int write(ByteBuffer arg0)
		{
			return Instance.CallMethod<int>("write", "(Ljava/nio/ByteBuffer;)I", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
		public long write(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
		public long write(ObjectArray<ByteBuffer> arg0)
		{
			return Instance.CallMethod<long>("write", "([Ljava/nio/ByteBuffer;)J", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;J)I")]
		public int read(ByteBuffer arg0, long arg1)
		{
			return Instance.CallMethod<int>("read", "(Ljava/nio/ByteBuffer;J)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		public int read(ByteBuffer arg0)
		{
			return Instance.CallMethod<int>("read", "(Ljava/nio/ByteBuffer;)I", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;)J")]
		public long read(ObjectArray<ByteBuffer> arg0)
		{
			return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;)J", arg0);
		}
		
		[JavaSignature("([Ljava/nio/ByteBuffer;II)J")]
		public long read(ObjectArray<ByteBuffer> arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<long>("read", "([Ljava/nio/ByteBuffer;II)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(J)Ljava/nio/channels/FileChannel;")]
		public FileChannel truncate(long arg0)
		{
			return Instance.CallMethod<FileChannel>("truncate", "(J)Ljava/nio/channels/FileChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/FileChannel;")]
		public static FileChannel open(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Static.CallMethod<FileChannel>(typeof(FileChannel), "open", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/FileChannel;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;")]
		public static FileChannel open(Path arg0, Set<OpenOption> arg1, ObjectArray<FileAttribute<IJavaObject>> arg2)
		{
			return Static.CallMethod<FileChannel>(typeof(FileChannel), "open", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/nio/channels/FileChannel/MapMode;JJ)Ljava/nio/MappedByteBuffer;")]
		public MappedByteBuffer map(FileChannel.MapMode arg0, long arg1, long arg2)
		{
			return Instance.CallMethod<MappedByteBuffer>("map", "(Ljava/nio/channels/FileChannel/MapMode;JJ)Ljava/nio/MappedByteBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JJZ)Ljava/nio/channels/FileLock;")]
		public FileLock tryLock(long arg0, long arg1, bool arg2)
		{
			return Instance.CallMethod<FileLock>("tryLock", "(JJZ)Ljava/nio/channels/FileLock;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/nio/channels/FileLock;")]
		public FileLock tryLock()
		{
			return Instance.CallMethod<FileLock>("tryLock", "()Ljava/nio/channels/FileLock;");
		}
		
		[JavaSignature("(Z)V")]
		public void force(bool arg0)
		{
			Instance.CallMethod("force", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/nio/channels/ReadableByteChannel;JJ)J")]
		public long transferFrom(ReadableByteChannel arg0, long arg1, long arg2)
		{
			return Instance.CallMethod<long>("transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JJLjava/nio/channels/WritableByteChannel;)J")]
		public long transferTo(long arg0, long arg1, WritableByteChannel arg2)
		{
			return Instance.CallMethod<long>("transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J", arg0, arg1, arg2);
		}
		
		[JavaSignature("(J)Ljava/nio/channels/SeekableByteChannel;")]
		SeekableByteChannel SeekableByteChannel.position(long arg0)
		{
			return Instance.CallMethod<SeekableByteChannel>("position", "(J)Ljava/nio/channels/SeekableByteChannel;", arg0);
		}
		
		[JavaSignature("(J)Ljava/nio/channels/SeekableByteChannel;")]
		SeekableByteChannel SeekableByteChannel.truncate(long arg0)
		{
			return Instance.CallMethod<SeekableByteChannel>("truncate", "(J)Ljava/nio/channels/SeekableByteChannel;", arg0);
		}
	
		[JavaProxy("java/nio/channels/FileChannel/MapMode")]
		public class MapMode : Object
		{
			protected MapMode(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/nio/channels/FileChannel/MapMode;")]
			public static FileChannel.MapMode READ_ONLY
			{
				get { return Static.GetField<FileChannel.MapMode>(typeof(MapMode), "READ_ONLY", "Ljava/nio/channels/FileChannel/MapMode;"); }
			}
			
			[JavaSignature("Ljava/nio/channels/FileChannel/MapMode;")]
			public static FileChannel.MapMode READ_WRITE
			{
				get { return Static.GetField<FileChannel.MapMode>(typeof(MapMode), "READ_WRITE", "Ljava/nio/channels/FileChannel/MapMode;"); }
			}
			
			[JavaSignature("Ljava/nio/channels/FileChannel/MapMode;")]
			public static FileChannel.MapMode PRIVATE
			{
				get { return Static.GetField<FileChannel.MapMode>(typeof(MapMode), "PRIVATE", "Ljava/nio/channels/FileChannel/MapMode;"); }
			}
		}
	}
}
