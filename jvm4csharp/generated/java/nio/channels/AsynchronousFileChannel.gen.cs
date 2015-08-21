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
using jvm4csharp.java.nio.file;
using jvm4csharp.java.nio.file.attribute;
using jvm4csharp.java.util;
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/AsynchronousFileChannel")]
	public abstract partial class AsynchronousFileChannel : Object, AsynchronousChannel
	{
		protected AsynchronousFileChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(JJZ)Ljava/util/concurrent/Future;")]
		public Future<FileLock> @lock(long arg0, long arg1, bool arg2)
		{
			return Instance.CallMethod<Future<FileLock>>("lock", "(JJZ)Ljava/util/concurrent/Future;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void @lock<A>(A arg0, CompletionHandler<FileLock, IJavaObject> arg1)
			where A : IJavaObject
		{
			Instance.CallMethod("lock", "(Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1);
		}
		
		[JavaSignature("(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void @lock<A>(long arg0, long arg1, bool arg2, A arg3, CompletionHandler<FileLock, IJavaObject> arg4)
			where A : IJavaObject
		{
			Instance.CallMethod("lock", "(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("()Ljava/util/concurrent/Future;")]
		public Future<FileLock> @lock()
		{
			return Instance.CallMethod<Future<FileLock>>("lock", "()Ljava/util/concurrent/Future;");
		}
		
		[JavaSignature("()J")]
		public long size()
		{
			return Instance.CallMethod<long>("size", "()J");
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void write<A>(ByteBuffer arg0, long arg1, A arg2, CompletionHandler<Integer, IJavaObject> arg3)
			where A : IJavaObject
		{
			Instance.CallMethod("write", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;")]
		public Future<Integer> write(ByteBuffer arg0, long arg1)
		{
			return Instance.CallMethod<Future<Integer>>("write", "(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V")]
		public void read<A>(ByteBuffer arg0, long arg1, A arg2, CompletionHandler<Integer, IJavaObject> arg3)
			where A : IJavaObject
		{
			Instance.CallMethod("read", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;")]
		public Future<Integer> read(ByteBuffer arg0, long arg1)
		{
			return Instance.CallMethod<Future<Integer>>("read", "(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;", arg0, arg1);
		}
		
		[JavaSignature("(J)Ljava/nio/channels/AsynchronousFileChannel;")]
		public AsynchronousFileChannel truncate(long arg0)
		{
			return Instance.CallMethod<AsynchronousFileChannel>("truncate", "(J)Ljava/nio/channels/AsynchronousFileChannel;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;")]
		public static AsynchronousFileChannel open(Path arg0, Set<OpenOption> arg1, ExecutorService arg2, ObjectArray<FileAttribute<IJavaObject>> arg3)
		{
			return Static.CallMethod<AsynchronousFileChannel>(typeof(AsynchronousFileChannel), "open", "(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/AsynchronousFileChannel;")]
		public static AsynchronousFileChannel open(Path arg0, ObjectArray<OpenOption> arg1)
		{
			return Static.CallMethod<AsynchronousFileChannel>(typeof(AsynchronousFileChannel), "open", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/nio/channels/FileLock;")]
		public FileLock tryLock()
		{
			return Instance.CallMethod<FileLock>("tryLock", "()Ljava/nio/channels/FileLock;");
		}
		
		[JavaSignature("(JJZ)Ljava/nio/channels/FileLock;")]
		public FileLock tryLock(long arg0, long arg1, bool arg2)
		{
			return Instance.CallMethod<FileLock>("tryLock", "(JJZ)Ljava/nio/channels/FileLock;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Z)V")]
		public void force(bool arg0)
		{
			Instance.CallMethod("force", "(Z)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isOpen()
		{
			return Instance.CallMethod<bool>("isOpen", "()Z");
		}
	}
}
