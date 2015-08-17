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
	[JavaProxy("java/nio/file/attribute/UserDefinedFileAttributeView")]
	public interface UserDefinedFileAttributeView : FileAttributeView
	{
		[JavaSignature("()Ljava/lang/String;")]
		new String name();
		
		[JavaSignature("(Ljava/lang/String;)I")]
		int size(String arg0);
		
		[JavaSignature("(Ljava/lang/String;Ljava/nio/ByteBuffer;)I")]
		int write(String arg0, ByteBuffer arg1);
		
		[JavaSignature("(Ljava/lang/String;)V")]
		void delete(String arg0);
		
		[JavaSignature("(Ljava/lang/String;Ljava/nio/ByteBuffer;)I")]
		int read(String arg0, ByteBuffer arg1);
		
		[JavaSignature("()Ljava/util/List;")]
		List<String> list();
	}
}
