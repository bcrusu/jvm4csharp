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
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/AnnotatedWildcardType")]
	public partial interface AnnotatedWildcardType : AnnotatedType
	{
		[JavaSignature("()[Ljava/lang/reflect/AnnotatedType;")]
		ObjectArray<AnnotatedType> getAnnotatedLowerBounds();
		
		[JavaSignature("()[Ljava/lang/reflect/AnnotatedType;")]
		ObjectArray<AnnotatedType> getAnnotatedUpperBounds();
	}
}
