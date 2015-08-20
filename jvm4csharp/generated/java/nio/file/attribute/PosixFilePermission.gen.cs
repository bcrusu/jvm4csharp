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
namespace jvm4csharp.java.nio.file.attribute
{
	[JavaProxy("java/nio/file/attribute/PosixFilePermission")]
	public partial class PosixFilePermission : Enum<PosixFilePermission>
	{
		protected PosixFilePermission(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission OWNER_READ
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "OWNER_READ", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission OWNER_WRITE
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "OWNER_WRITE", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission OWNER_EXECUTE
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "OWNER_EXECUTE", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission GROUP_READ
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "GROUP_READ", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission GROUP_WRITE
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "GROUP_WRITE", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission GROUP_EXECUTE
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "GROUP_EXECUTE", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission OTHERS_READ
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "OTHERS_READ", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission OTHERS_WRITE
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "OTHERS_WRITE", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission OTHERS_EXECUTE
		{
			get { return Static.GetField<PosixFilePermission>(typeof(PosixFilePermission), "OTHERS_EXECUTE", "Ljava/nio/file/attribute/PosixFilePermission;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/attribute/PosixFilePermission;")]
		public static ObjectArray<PosixFilePermission> values()
		{
			return Static.CallMethod<ObjectArray<PosixFilePermission>>(typeof(PosixFilePermission), "values", "()[Ljava/nio/file/attribute/PosixFilePermission;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/attribute/PosixFilePermission;")]
		public static PosixFilePermission valueOf(String arg0)
		{
			return Static.CallMethod<PosixFilePermission>(typeof(PosixFilePermission), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/PosixFilePermission;", arg0);
		}
	}
}
