//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/RuntimeMXBean")]
	public interface RuntimeMXBean : PlatformManagedObject
	{
		[JavaSignature("()Ljava/lang/String;")]
		String getName();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getClassPath();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getBootClassPath();
		
		[JavaSignature("()Ljava/util/List;")]
		List<String> getInputArguments();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getLibraryPath();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getManagementSpecVersion();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getSpecName();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getSpecVendor();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getSpecVersion();
		
		[JavaSignature("()J")]
		long getStartTime();
		
		[JavaSignature("()Ljava/util/Map;")]
		Map<String, String> getSystemProperties();
		
		[JavaSignature("()J")]
		long getUptime();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getVmName();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getVmVendor();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getVmVersion();
		
		[JavaSignature("()Z")]
		bool isBootClassPathSupported();
	}
}
