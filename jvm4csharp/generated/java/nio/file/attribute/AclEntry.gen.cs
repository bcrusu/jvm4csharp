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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file.attribute
{
	[JavaProxy("java/nio/file/attribute/AclEntry")]
	public class AclEntry : Object
	{
		protected AclEntry(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/file/attribute/AclEntryType;")]
		public AclEntryType type()
		{
			return Instance.CallMethod<AclEntryType>("type", "()Ljava/nio/file/attribute/AclEntryType;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<AclEntryFlag> flags()
		{
			return Instance.CallMethod<Set<AclEntryFlag>>("flags", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<AclEntryPermission> permissions()
		{
			return Instance.CallMethod<Set<AclEntryPermission>>("permissions", "()Ljava/util/Set;");
		}
		
		[JavaSignature("(Ljava/nio/file/attribute/AclEntry;)Ljava/nio/file/attribute/AclEntry/Builder;")]
		public static AclEntry.Builder newBuilder(AclEntry arg0)
		{
			return Static.CallMethod<AclEntry.Builder>(typeof(AclEntry), "newBuilder", "(Ljava/nio/file/attribute/AclEntry;)Ljava/nio/file/attribute/AclEntry/Builder;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/file/attribute/AclEntry/Builder;")]
		public static AclEntry.Builder newBuilder()
		{
			return Static.CallMethod<AclEntry.Builder>(typeof(AclEntry), "newBuilder", "()Ljava/nio/file/attribute/AclEntry/Builder;");
		}
		
		[JavaProxy("java/nio/file/attribute/AclEntry/Builder")]
		public class Builder : Object
		{
			protected Builder(ProxyCtor p) : base(p) {}
		
			[JavaSignature("([Ljava/nio/file/attribute/AclEntryFlag;)Ljava/nio/file/attribute/AclEntry/Builder;")]
			public AclEntry.Builder setFlags(ObjectArray<AclEntryFlag> arg0)
			{
				return Instance.CallMethod<AclEntry.Builder>("setFlags", "([Ljava/nio/file/attribute/AclEntryFlag;)Ljava/nio/file/attribute/AclEntry/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/util/Set;)Ljava/nio/file/attribute/AclEntry/Builder;")]
			public AclEntry.Builder setFlags(Set<AclEntryFlag> arg0)
			{
				return Instance.CallMethod<AclEntry.Builder>("setFlags", "(Ljava/util/Set;)Ljava/nio/file/attribute/AclEntry/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/nio/file/attribute/AclEntryType;)Ljava/nio/file/attribute/AclEntry/Builder;")]
			public AclEntry.Builder setType(AclEntryType arg0)
			{
				return Instance.CallMethod<AclEntry.Builder>("setType", "(Ljava/nio/file/attribute/AclEntryType;)Ljava/nio/file/attribute/AclEntry/Builder;", arg0);
			}
			
			[JavaSignature("()Ljava/nio/file/attribute/AclEntry;")]
			public AclEntry build()
			{
				return Instance.CallMethod<AclEntry>("build", "()Ljava/nio/file/attribute/AclEntry;");
			}
			
			[JavaSignature("(Ljava/util/Set;)Ljava/nio/file/attribute/AclEntry/Builder;")]
			public AclEntry.Builder setPermissions(Set<AclEntryPermission> arg0)
			{
				return Instance.CallMethod<AclEntry.Builder>("setPermissions", "(Ljava/util/Set;)Ljava/nio/file/attribute/AclEntry/Builder;", arg0);
			}
			
			[JavaSignature("([Ljava/nio/file/attribute/AclEntryPermission;)Ljava/nio/file/attribute/AclEntry/Builder;")]
			public AclEntry.Builder setPermissions(ObjectArray<AclEntryPermission> arg0)
			{
				return Instance.CallMethod<AclEntry.Builder>("setPermissions", "([Ljava/nio/file/attribute/AclEntryPermission;)Ljava/nio/file/attribute/AclEntry/Builder;", arg0);
			}
		}
	}
}