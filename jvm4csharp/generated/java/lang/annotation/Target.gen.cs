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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.annotation
{
	[JavaProxy("java/lang/annotation/Target")]
	public partial interface Target : Annotation
	{
		[JavaSignature("()[Ljava/lang/annotation/ElementType;")]
		ObjectArray<ElementType> @value();
	}
}
