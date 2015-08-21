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
	[JavaProxy("java/lang/reflect/TypeVariable")]
	public partial interface TypeVariable<D> : Type, AnnotatedElement
		where D : GenericDeclaration
	{
		[JavaSignature("()Ljava/lang/String;")]
		String getName();
		
		[JavaSignature("()[Ljava/lang/reflect/AnnotatedType;")]
		ObjectArray<AnnotatedType> getAnnotatedBounds();
		
		[JavaSignature("()[Ljava/lang/reflect/Type;")]
		ObjectArray<Type> getBounds();
		
		[JavaSignature("()Ljava/lang/reflect/GenericDeclaration;")]
		D getGenericDeclaration();
	}
}
