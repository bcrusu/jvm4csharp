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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/FileVisitOption")]
	public class FileVisitOption : Enum<FileVisitOption>
	{
		protected FileVisitOption(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/FileVisitOption;")]
		public static FileVisitOption FOLLOW_LINKS
		{
			get { return Static.GetField<FileVisitOption>(typeof(FileVisitOption), "FOLLOW_LINKS", "Ljava/nio/file/FileVisitOption;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/FileVisitOption;")]
		public static ObjectArray<FileVisitOption> values()
		{
			return Static.CallMethod<ObjectArray<FileVisitOption>>(typeof(FileVisitOption), "values", "()[Ljava/nio/file/FileVisitOption;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/FileVisitOption;")]
		public static FileVisitOption valueOf(String arg0)
		{
			return Static.CallMethod<FileVisitOption>(typeof(FileVisitOption), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/FileVisitOption;", arg0);
		}
	}
}
