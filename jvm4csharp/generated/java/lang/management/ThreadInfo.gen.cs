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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/ThreadInfo")]
	public partial class ThreadInfo : Object
	{
		protected ThreadInfo(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()[Ljava/lang/StackTraceElement;")]
		public ObjectArray<StackTraceElement> getStackTrace()
		{
			return Instance.CallMethod<ObjectArray<StackTraceElement>>("getStackTrace", "()[Ljava/lang/StackTraceElement;");
		}
		
		[JavaSignature("()J")]
		public long getThreadId()
		{
			return Instance.CallMethod<long>("getThreadId", "()J");
		}
		
		[JavaSignature("()Ljava/lang/management/LockInfo;")]
		public LockInfo getLockInfo()
		{
			return Instance.CallMethod<LockInfo>("getLockInfo", "()Ljava/lang/management/LockInfo;");
		}
		
		[JavaSignature("()J")]
		public long getBlockedCount()
		{
			return Instance.CallMethod<long>("getBlockedCount", "()J");
		}
		
		[JavaSignature("()J")]
		public long getBlockedTime()
		{
			return Instance.CallMethod<long>("getBlockedTime", "()J");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getLockName()
		{
			return Instance.CallMethod<String>("getLockName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()J")]
		public long getLockOwnerId()
		{
			return Instance.CallMethod<long>("getLockOwnerId", "()J");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getLockOwnerName()
		{
			return Instance.CallMethod<String>("getLockOwnerName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/management/MonitorInfo;")]
		public ObjectArray<MonitorInfo> getLockedMonitors()
		{
			return Instance.CallMethod<ObjectArray<MonitorInfo>>("getLockedMonitors", "()[Ljava/lang/management/MonitorInfo;");
		}
		
		[JavaSignature("()[Ljava/lang/management/LockInfo;")]
		public ObjectArray<LockInfo> getLockedSynchronizers()
		{
			return Instance.CallMethod<ObjectArray<LockInfo>>("getLockedSynchronizers", "()[Ljava/lang/management/LockInfo;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getThreadName()
		{
			return Instance.CallMethod<String>("getThreadName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/Thread/State;")]
		public Thread.State getThreadState()
		{
			return Instance.CallMethod<Thread.State>("getThreadState", "()Ljava/lang/Thread/State;");
		}
		
		[JavaSignature("()J")]
		public long getWaitedCount()
		{
			return Instance.CallMethod<long>("getWaitedCount", "()J");
		}
		
		[JavaSignature("()J")]
		public long getWaitedTime()
		{
			return Instance.CallMethod<long>("getWaitedTime", "()J");
		}
		
		[JavaSignature("()Z")]
		public bool isInNative()
		{
			return Instance.CallMethod<bool>("isInNative", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isSuspended()
		{
			return Instance.CallMethod<bool>("isSuspended", "()Z");
		}
	}
}
