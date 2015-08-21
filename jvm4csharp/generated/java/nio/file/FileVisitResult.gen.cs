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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/FileVisitResult")]
	public partial class FileVisitResult : Enum<FileVisitResult>
	{
		protected FileVisitResult(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/FileVisitResult;")]
		public static FileVisitResult CONTINUE
		{
			get { return Static.GetField<FileVisitResult>(typeof(FileVisitResult), "CONTINUE", "Ljava/nio/file/FileVisitResult;"); }
		}
		
		[JavaSignature("Ljava/nio/file/FileVisitResult;")]
		public static FileVisitResult TERMINATE
		{
			get { return Static.GetField<FileVisitResult>(typeof(FileVisitResult), "TERMINATE", "Ljava/nio/file/FileVisitResult;"); }
		}
		
		[JavaSignature("Ljava/nio/file/FileVisitResult;")]
		public static FileVisitResult SKIP_SUBTREE
		{
			get { return Static.GetField<FileVisitResult>(typeof(FileVisitResult), "SKIP_SUBTREE", "Ljava/nio/file/FileVisitResult;"); }
		}
		
		[JavaSignature("Ljava/nio/file/FileVisitResult;")]
		public static FileVisitResult SKIP_SIBLINGS
		{
			get { return Static.GetField<FileVisitResult>(typeof(FileVisitResult), "SKIP_SIBLINGS", "Ljava/nio/file/FileVisitResult;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/FileVisitResult;")]
		public static ObjectArray<FileVisitResult> values()
		{
			return Static.CallMethod<ObjectArray<FileVisitResult>>(typeof(FileVisitResult), "values", "()[Ljava/nio/file/FileVisitResult;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/FileVisitResult;")]
		public static FileVisitResult valueOf(String arg0)
		{
			return Static.CallMethod<FileVisitResult>(typeof(FileVisitResult), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/FileVisitResult;", arg0);
		}
	}
}
