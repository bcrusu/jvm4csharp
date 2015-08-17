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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file.attribute
{
	[JavaProxy("java/nio/file/attribute/DosFileAttributeView")]
	public interface DosFileAttributeView : BasicFileAttributeView
	{
		[JavaSignature("()Ljava/lang/String;")]
		new String name();
		
		[JavaSignature("(Z)V")]
		void setReadOnly(bool arg0);
		
		[JavaSignature("(Z)V")]
		void setArchive(bool arg0);
		
		[JavaSignature("(Z)V")]
		void setHidden(bool arg0);
		
		[JavaSignature("(Z)V")]
		void setSystem(bool arg0);
		
		[JavaSignature("()Ljava/nio/file/attribute/DosFileAttributes;")]
		new DosFileAttributes readAttributes();
	}
}
