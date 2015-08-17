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
	[JavaProxy("java/nio/file/attribute/FileAttribute")]
	public interface FileAttribute<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("()Ljava/lang/String;")]
		String name();
		
		[JavaSignature("()Ljava/lang/Object;")]
		T @value();
	}
}
