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
	[JavaProxy("java/lang/management/ThreadMXBean")]
	public interface ThreadMXBean : PlatformManagedObject
	{
		[JavaSignature("(ZZ)[Ljava/lang/management/ThreadInfo;")]
		ObjectArray<ThreadInfo> dumpAllThreads(bool arg0, bool arg1);
		
		[JavaSignature("()[J")]
		LongArray findDeadlockedThreads();
		
		[JavaSignature("()[J")]
		LongArray findMonitorDeadlockedThreads();
		
		[JavaSignature("()[J")]
		LongArray getAllThreadIds();
		
		[JavaSignature("()J")]
		long getCurrentThreadCpuTime();
		
		[JavaSignature("()J")]
		long getCurrentThreadUserTime();
		
		[JavaSignature("()I")]
		int getDaemonThreadCount();
		
		[JavaSignature("()I")]
		int getPeakThreadCount();
		
		[JavaSignature("()I")]
		int getThreadCount();
		
		[JavaSignature("(J)J")]
		long getThreadCpuTime(long arg0);
		
		[JavaSignature("(J)Ljava/lang/management/ThreadInfo;")]
		ThreadInfo getThreadInfo(long arg0);
		
		[JavaSignature("([J)[Ljava/lang/management/ThreadInfo;")]
		ObjectArray<ThreadInfo> getThreadInfo(LongArray arg0);
		
		[JavaSignature("([JZZ)[Ljava/lang/management/ThreadInfo;")]
		ObjectArray<ThreadInfo> getThreadInfo(LongArray arg0, bool arg1, bool arg2);
		
		[JavaSignature("([JI)[Ljava/lang/management/ThreadInfo;")]
		ObjectArray<ThreadInfo> getThreadInfo(LongArray arg0, int arg1);
		
		[JavaSignature("(JI)Ljava/lang/management/ThreadInfo;")]
		ThreadInfo getThreadInfo(long arg0, int arg1);
		
		[JavaSignature("(J)J")]
		long getThreadUserTime(long arg0);
		
		[JavaSignature("()J")]
		long getTotalStartedThreadCount();
		
		[JavaSignature("()Z")]
		bool isCurrentThreadCpuTimeSupported();
		
		[JavaSignature("()Z")]
		bool isObjectMonitorUsageSupported();
		
		[JavaSignature("()Z")]
		bool isSynchronizerUsageSupported();
		
		[JavaSignature("()Z")]
		bool isThreadContentionMonitoringEnabled();
		
		[JavaSignature("()Z")]
		bool isThreadContentionMonitoringSupported();
		
		[JavaSignature("()Z")]
		bool isThreadCpuTimeEnabled();
		
		[JavaSignature("()Z")]
		bool isThreadCpuTimeSupported();
		
		[JavaSignature("()V")]
		void resetPeakThreadCount();
		
		[JavaSignature("(Z)V")]
		void setThreadContentionMonitoringEnabled(bool arg0);
		
		[JavaSignature("(Z)V")]
		void setThreadCpuTimeEnabled(bool arg0);
	}
}
