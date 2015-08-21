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
	[JavaProxy("java/lang/management/MemoryManagerMXBean")]
	public partial interface MemoryManagerMXBean : PlatformManagedObject
	{
		[JavaSignature("()Ljava/lang/String;")]
		String getName();
		
		[JavaSignature("()Z")]
		bool isValid();
		
		[JavaSignature("()[Ljava/lang/String;")]
		ObjectArray<String> getMemoryPoolNames();
	}
}
