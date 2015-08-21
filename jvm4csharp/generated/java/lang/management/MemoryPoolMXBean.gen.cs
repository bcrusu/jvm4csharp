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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/MemoryPoolMXBean")]
	public partial interface MemoryPoolMXBean : PlatformManagedObject
	{
		[JavaSignature("()Ljava/lang/String;")]
		String getName();
		
		[JavaSignature("()Ljava/lang/management/MemoryType;")]
		MemoryType getType();
		
		[JavaSignature("()Z")]
		bool isValid();
		
		[JavaSignature("()Ljava/lang/management/MemoryUsage;")]
		MemoryUsage getCollectionUsage();
		
		[JavaSignature("()J")]
		long getCollectionUsageThreshold();
		
		[JavaSignature("()J")]
		long getCollectionUsageThresholdCount();
		
		[JavaSignature("()[Ljava/lang/String;")]
		ObjectArray<String> getMemoryManagerNames();
		
		[JavaSignature("()Ljava/lang/management/MemoryUsage;")]
		MemoryUsage getPeakUsage();
		
		[JavaSignature("()Ljava/lang/management/MemoryUsage;")]
		MemoryUsage getUsage();
		
		[JavaSignature("()J")]
		long getUsageThreshold();
		
		[JavaSignature("()J")]
		long getUsageThresholdCount();
		
		[JavaSignature("()Z")]
		bool isCollectionUsageThresholdExceeded();
		
		[JavaSignature("()Z")]
		bool isCollectionUsageThresholdSupported();
		
		[JavaSignature("()Z")]
		bool isUsageThresholdExceeded();
		
		[JavaSignature("()Z")]
		bool isUsageThresholdSupported();
		
		[JavaSignature("()V")]
		void resetPeakUsage();
		
		[JavaSignature("(J)V")]
		void setCollectionUsageThreshold(long arg0);
		
		[JavaSignature("(J)V")]
		void setUsageThreshold(long arg0);
	}
}
