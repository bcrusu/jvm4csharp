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
	[JavaProxy("java/nio/file/attribute/PosixFilePermissions")]
	public partial class PosixFilePermissions : Object
	{
		protected PosixFilePermissions(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/Set;)Ljava/lang/String;")]
		public static String toString(Set<PosixFilePermission> arg0)
		{
			return Static.CallMethod<String>(typeof(PosixFilePermissions), "toString", "(Ljava/util/Set;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Set;")]
		public static Set<PosixFilePermission> fromString(String arg0)
		{
			return Static.CallMethod<Set<PosixFilePermission>>(typeof(PosixFilePermissions), "fromString", "(Ljava/lang/String;)Ljava/util/Set;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Set;)Ljava/nio/file/attribute/FileAttribute;")]
		public static FileAttribute<Set<PosixFilePermission>> asFileAttribute(Set<PosixFilePermission> arg0)
		{
			return Static.CallMethod<FileAttribute<Set<PosixFilePermission>>>(typeof(PosixFilePermissions), "asFileAttribute", "(Ljava/util/Set;)Ljava/nio/file/attribute/FileAttribute;", arg0);
		}
	}
}
