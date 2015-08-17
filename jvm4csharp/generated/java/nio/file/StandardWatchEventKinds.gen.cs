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
	[JavaProxy("java/nio/file/StandardWatchEventKinds")]
	public class StandardWatchEventKinds : Object
	{
		protected StandardWatchEventKinds(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/WatchEvent/Kind;")]
		public static WatchEvent_.Kind<IJavaObject> OVERFLOW
		{
			get { return Static.GetField<WatchEvent_.Kind<IJavaObject>>(typeof(StandardWatchEventKinds), "OVERFLOW", "Ljava/nio/file/WatchEvent/Kind;"); }
		}
		
		[JavaSignature("Ljava/nio/file/WatchEvent/Kind;")]
		public static WatchEvent_.Kind<Path> ENTRY_CREATE
		{
			get { return Static.GetField<WatchEvent_.Kind<Path>>(typeof(StandardWatchEventKinds), "ENTRY_CREATE", "Ljava/nio/file/WatchEvent/Kind;"); }
		}
		
		[JavaSignature("Ljava/nio/file/WatchEvent/Kind;")]
		public static WatchEvent_.Kind<Path> ENTRY_DELETE
		{
			get { return Static.GetField<WatchEvent_.Kind<Path>>(typeof(StandardWatchEventKinds), "ENTRY_DELETE", "Ljava/nio/file/WatchEvent/Kind;"); }
		}
		
		[JavaSignature("Ljava/nio/file/WatchEvent/Kind;")]
		public static WatchEvent_.Kind<Path> ENTRY_MODIFY
		{
			get { return Static.GetField<WatchEvent_.Kind<Path>>(typeof(StandardWatchEventKinds), "ENTRY_MODIFY", "Ljava/nio/file/WatchEvent/Kind;"); }
		}
	}
}
