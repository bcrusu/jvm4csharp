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
	[JavaProxy("java/nio/file/attribute/AclEntryPermission")]
	public class AclEntryPermission : Enum<AclEntryPermission>
	{
		protected AclEntryPermission(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission READ_DATA
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "READ_DATA", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission WRITE_DATA
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "WRITE_DATA", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission APPEND_DATA
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "APPEND_DATA", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission READ_NAMED_ATTRS
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "READ_NAMED_ATTRS", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission WRITE_NAMED_ATTRS
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "WRITE_NAMED_ATTRS", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission EXECUTE
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "EXECUTE", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission DELETE_CHILD
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "DELETE_CHILD", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission READ_ATTRIBUTES
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "READ_ATTRIBUTES", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission WRITE_ATTRIBUTES
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "WRITE_ATTRIBUTES", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission DELETE
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "DELETE", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission READ_ACL
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "READ_ACL", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission WRITE_ACL
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "WRITE_ACL", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission WRITE_OWNER
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "WRITE_OWNER", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission SYNCHRONIZE
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "SYNCHRONIZE", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission LIST_DIRECTORY
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "LIST_DIRECTORY", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission ADD_FILE
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "ADD_FILE", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission ADD_SUBDIRECTORY
		{
			get { return Static.GetField<AclEntryPermission>(typeof(AclEntryPermission), "ADD_SUBDIRECTORY", "Ljava/nio/file/attribute/AclEntryPermission;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/attribute/AclEntryPermission;")]
		public static ObjectArray<AclEntryPermission> values()
		{
			return Static.CallMethod<ObjectArray<AclEntryPermission>>(typeof(AclEntryPermission), "values", "()[Ljava/nio/file/attribute/AclEntryPermission;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryPermission;")]
		public static AclEntryPermission valueOf(String arg0)
		{
			return Static.CallMethod<AclEntryPermission>(typeof(AclEntryPermission), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryPermission;", arg0);
		}
	}
}
