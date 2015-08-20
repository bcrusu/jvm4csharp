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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file.attribute
{
	[JavaProxy("java/nio/file/attribute/AclFileAttributeView")]
	public partial interface AclFileAttributeView : FileOwnerAttributeView
	{
		[JavaSignature("()Ljava/lang/String;")]
		new String name();
		
		[JavaSignature("()Ljava/util/List;")]
		List<AclEntry> getAcl();
		
		[JavaSignature("(Ljava/util/List;)V")]
		void setAcl(List<AclEntry> arg0);
	}
}
