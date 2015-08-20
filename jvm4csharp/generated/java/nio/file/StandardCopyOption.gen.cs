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
	[JavaProxy("java/nio/file/StandardCopyOption")]
	public partial class StandardCopyOption : Enum<StandardCopyOption>, CopyOption
	{
		protected StandardCopyOption(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/StandardCopyOption;")]
		public static StandardCopyOption REPLACE_EXISTING
		{
			get { return Static.GetField<StandardCopyOption>(typeof(StandardCopyOption), "REPLACE_EXISTING", "Ljava/nio/file/StandardCopyOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardCopyOption;")]
		public static StandardCopyOption COPY_ATTRIBUTES
		{
			get { return Static.GetField<StandardCopyOption>(typeof(StandardCopyOption), "COPY_ATTRIBUTES", "Ljava/nio/file/StandardCopyOption;"); }
		}
		
		[JavaSignature("Ljava/nio/file/StandardCopyOption;")]
		public static StandardCopyOption ATOMIC_MOVE
		{
			get { return Static.GetField<StandardCopyOption>(typeof(StandardCopyOption), "ATOMIC_MOVE", "Ljava/nio/file/StandardCopyOption;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/StandardCopyOption;")]
		public static ObjectArray<StandardCopyOption> values()
		{
			return Static.CallMethod<ObjectArray<StandardCopyOption>>(typeof(StandardCopyOption), "values", "()[Ljava/nio/file/StandardCopyOption;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/StandardCopyOption;")]
		public static StandardCopyOption valueOf(String arg0)
		{
			return Static.CallMethod<StandardCopyOption>(typeof(StandardCopyOption), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/StandardCopyOption;", arg0);
		}
	}
}
