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
	[JavaProxy("java/nio/file/attribute/AclEntryType")]
	public partial class AclEntryType : Enum<AclEntryType>
	{
		protected AclEntryType(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/attribute/AclEntryType;")]
		public static AclEntryType ALLOW
		{
			get { return Static.GetField<AclEntryType>(typeof(AclEntryType), "ALLOW", "Ljava/nio/file/attribute/AclEntryType;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryType;")]
		public static AclEntryType DENY
		{
			get { return Static.GetField<AclEntryType>(typeof(AclEntryType), "DENY", "Ljava/nio/file/attribute/AclEntryType;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryType;")]
		public static AclEntryType AUDIT
		{
			get { return Static.GetField<AclEntryType>(typeof(AclEntryType), "AUDIT", "Ljava/nio/file/attribute/AclEntryType;"); }
		}
		
		[JavaSignature("Ljava/nio/file/attribute/AclEntryType;")]
		public static AclEntryType ALARM
		{
			get { return Static.GetField<AclEntryType>(typeof(AclEntryType), "ALARM", "Ljava/nio/file/attribute/AclEntryType;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/attribute/AclEntryType;")]
		public static ObjectArray<AclEntryType> values()
		{
			return Static.CallMethod<ObjectArray<AclEntryType>>(typeof(AclEntryType), "values", "()[Ljava/nio/file/attribute/AclEntryType;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryType;")]
		public static AclEntryType valueOf(String arg0)
		{
			return Static.CallMethod<AclEntryType>(typeof(AclEntryType), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryType;", arg0);
		}
	}
}
