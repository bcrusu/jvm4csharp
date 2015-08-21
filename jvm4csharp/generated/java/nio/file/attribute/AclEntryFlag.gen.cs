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
namespace jvm4csharp.java.nio.file.attribute
{
	[JavaProxy("java/nio/file/attribute/AclEntryFlag")]
	public partial class AclEntryFlag : Enum<AclEntryFlag>
	{
		protected AclEntryFlag(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/attribute/AclEntryFlag;")]
		public static AclEntryFlag FILE_INHERIT
		{
			get { return Static.GetField<AclEntryFlag>(typeof(AclEntryFlag), "FILE_INHERIT", "Ljava/nio/file/attribute/AclEntryFlag;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryFlag;")]
		public static AclEntryFlag DIRECTORY_INHERIT
		{
			get { return Static.GetField<AclEntryFlag>(typeof(AclEntryFlag), "DIRECTORY_INHERIT", "Ljava/nio/file/attribute/AclEntryFlag;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryFlag;")]
		public static AclEntryFlag NO_PROPAGATE_INHERIT
		{
			get { return Static.GetField<AclEntryFlag>(typeof(AclEntryFlag), "NO_PROPAGATE_INHERIT", "Ljava/nio/file/attribute/AclEntryFlag;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryFlag;")]
		public static AclEntryFlag INHERIT_ONLY
		{
			get { return Static.GetField<AclEntryFlag>(typeof(AclEntryFlag), "INHERIT_ONLY", "Ljava/nio/file/attribute/AclEntryFlag;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/attribute/AclEntryFlag;")]
		public static ObjectArray<AclEntryFlag> values()
		{
			return Static.CallMethod<ObjectArray<AclEntryFlag>>(typeof(AclEntryFlag), "values", "()[Ljava/nio/file/attribute/AclEntryFlag;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryFlag;")]
		public static AclEntryFlag valueOf(String arg0)
		{
			return Static.CallMethod<AclEntryFlag>(typeof(AclEntryFlag), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryFlag;", arg0);
		}
	}
}
