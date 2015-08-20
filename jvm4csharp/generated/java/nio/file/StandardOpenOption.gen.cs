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
	[JavaProxy("java/nio/file/StandardOpenOption")]
	public partial class StandardOpenOption : Enum<StandardOpenOption>, OpenOption
	{
		protected StandardOpenOption(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption READ
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "READ", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption WRITE
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "WRITE", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption APPEND
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "APPEND", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption TRUNCATE_EXISTING
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "TRUNCATE_EXISTING", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption CREATE
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "CREATE", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption CREATE_NEW
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "CREATE_NEW", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption DELETE_ON_CLOSE
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "DELETE_ON_CLOSE", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption SPARSE
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "SPARSE", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption SYNC
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "SYNC", "Ljava/nio/file/StandardOpenOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption DSYNC
		{
			get { return Static.GetField<StandardOpenOption>(typeof(StandardOpenOption), "DSYNC", "Ljava/nio/file/StandardOpenOption;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/StandardOpenOption;")]
		public static ObjectArray<StandardOpenOption> values()
		{
			return Static.CallMethod<ObjectArray<StandardOpenOption>>(typeof(StandardOpenOption), "values", "()[Ljava/nio/file/StandardOpenOption;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/StandardOpenOption;")]
		public static StandardOpenOption valueOf(String arg0)
		{
			return Static.CallMethod<StandardOpenOption>(typeof(StandardOpenOption), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/StandardOpenOption;", arg0);
		}
	}
}
