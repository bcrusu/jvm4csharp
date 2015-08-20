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
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/WatchEvent")]
	public partial interface WatchEvent<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("()Ljava/lang/Object;")]
		T context();
		
		[JavaSignature("()I")]
		int count();
		
		[JavaSignature("()Ljava/nio/file/WatchEvent/Kind;")]
		WatchEvent_.Kind<T> kind();
	}
	
	public static class WatchEvent_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
	
		[JavaProxy("java/nio/file/WatchEvent/Kind")]
		public partial interface Kind<T> : IJavaObject
			where T : IJavaObject
		{
			[JavaSignature("()Ljava/lang/String;")]
			String name();
			
			[JavaSignature("()Ljava/lang/Class;")]
			Class<T> type();
		}
		
		[JavaProxy("java/nio/file/WatchEvent/Modifier")]
		public partial interface Modifier : IJavaObject
		{
			[JavaSignature("()Ljava/lang/String;")]
			String name();
		}
	}
}
