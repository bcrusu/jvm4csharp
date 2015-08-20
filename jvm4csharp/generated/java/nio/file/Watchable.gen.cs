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
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/Watchable")]
	public partial interface Watchable : IJavaObject
	{
		[JavaSignature("(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent/Kind;[Ljava/nio/file/WatchEvent/Modifier;)Ljava/nio/file/WatchKey;")]
		WatchKey register(WatchService arg0, ObjectArray<WatchEvent_.Kind<IJavaObject>> arg1, ObjectArray<WatchEvent_.Modifier> arg2);
		
		[JavaSignature("(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent/Kind;)Ljava/nio/file/WatchKey;")]
		WatchKey register(WatchService arg0, ObjectArray<WatchEvent_.Kind<IJavaObject>> arg1);
	}
}
