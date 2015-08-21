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
using jvm4csharp.java.lang.annotation;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/AnnotatedElement")]
	public partial interface AnnotatedElement : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
		T getAnnotation<T>(Class<T> arg0)
			where T : Annotation;
		
		[JavaSignature("()[Ljava/lang/annotation/Annotation;")]
		ObjectArray<Annotation> getAnnotations();
		
		[JavaSignature("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;")]
		ObjectArray<T> getAnnotationsByType<T>(Class<T> arg0)
			where T : Annotation;
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
		T getDeclaredAnnotation<T>(Class<T> arg0)
			where T : Annotation;
		
		[JavaSignature("()[Ljava/lang/annotation/Annotation;")]
		ObjectArray<Annotation> getDeclaredAnnotations();
		
		[JavaSignature("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;")]
		ObjectArray<T> getDeclaredAnnotationsByType<T>(Class<T> arg0)
			where T : Annotation;
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		bool isAnnotationPresent(Class<Annotation> arg0);
	}
}
