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
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/WatchKey")]
	public partial interface WatchKey : IJavaObject
	{
		[JavaSignature("()Z")]
		bool reset();
		
		[JavaSignature("()Z")]
		bool isValid();
		
		[JavaSignature("()Ljava/util/List;")]
		List<WatchEvent<IJavaObject>> pollEvents();
		
		[JavaSignature("()Ljava/nio/file/Watchable;")]
		Watchable watchable();
		
		[JavaSignature("()V")]
		void cancel();
	}
}
