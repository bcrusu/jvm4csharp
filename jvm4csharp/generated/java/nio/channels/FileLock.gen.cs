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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/FileLock")]
	public abstract class FileLock : Object, AutoCloseable
	{
		protected FileLock(ProxyCtor p) : base(p) {}
	
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
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Ljava/nio/channels/FileChannel;")]
		public FileChannel channel()
		{
			return Instance.CallMethod<FileChannel>("channel", "()Ljava/nio/channels/FileChannel;");
		}
		
		[JavaSignature("()V")]
		public void release()
		{
			Instance.CallMethod("release", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isValid()
		{
			return Instance.CallMethod<bool>("isValid", "()Z");
		}
		
		[JavaSignature("()Ljava/nio/channels/Channel;")]
		public Channel acquiredBy()
		{
			return Instance.CallMethod<Channel>("acquiredBy", "()Ljava/nio/channels/Channel;");
		}
		
		[JavaSignature("(JJ)Z")]
		public bool overlaps(long arg0, long arg1)
		{
			return Instance.CallMethod<bool>("overlaps", "(JJ)Z", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool isShared()
		{
			return Instance.CallMethod<bool>("isShared", "()Z");
		}
	}
}
