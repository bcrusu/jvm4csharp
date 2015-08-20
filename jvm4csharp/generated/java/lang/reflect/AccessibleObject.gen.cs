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
using jvm4csharp.java.lang.annotation;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/AccessibleObject")]
	public partial class AccessibleObject : Object, AnnotatedElement
	{
		protected AccessibleObject(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
		public T getAnnotation<T>(Class<T> arg0)
			where T : Annotation
		{
			return Instance.CallMethod<T>("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<Annotation> getAnnotations()
		{
			return Instance.CallMethod<ObjectArray<Annotation>>("getAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<T> getAnnotationsByType<T>(Class<T> arg0)
			where T : Annotation
		{
			return Instance.CallMethod<ObjectArray<T>>("getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
		public T getDeclaredAnnotation<T>(Class<T> arg0)
			where T : Annotation
		{
			return Instance.CallMethod<T>("getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<Annotation> getDeclaredAnnotations()
		{
			return Instance.CallMethod<ObjectArray<Annotation>>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<T> getDeclaredAnnotationsByType<T>(Class<T> arg0)
			where T : Annotation
		{
			return Instance.CallMethod<ObjectArray<T>>("getDeclaredAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public bool isAnnotationPresent(Class<Annotation> arg0)
		{
			return Instance.CallMethod<bool>("isAnnotationPresent", "(Ljava/lang/Class;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isAccessible()
		{
			return Instance.CallMethod<bool>("isAccessible", "()Z");
		}
		
		[JavaSignature("([Ljava/lang/reflect/AccessibleObject;Z)V")]
		public static void setAccessible(ObjectArray<AccessibleObject> arg0, bool arg1)
		{
			Static.CallMethod(typeof(AccessibleObject), "setAccessible", "([Ljava/lang/reflect/AccessibleObject;Z)V", arg0, arg1);
		}
		
		[JavaSignature("(Z)V")]
		public void setAccessible(bool arg0)
		{
			Instance.CallMethod("setAccessible", "(Z)V", arg0);
		}
	}
}
