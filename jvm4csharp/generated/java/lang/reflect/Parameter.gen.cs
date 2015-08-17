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
	[JavaProxy("java/lang/reflect/Parameter")]
	public class Parameter : Object, AnnotatedElement
	{
		protected Parameter(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()I")]
		public int getModifiers()
		{
			return Instance.CallMethod<int>("getModifiers", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
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
		
		[JavaSignature("()Z")]
		public bool isSynthetic()
		{
			return Instance.CallMethod<bool>("isSynthetic", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/reflect/AnnotatedType;")]
		public AnnotatedType getAnnotatedType()
		{
			return Instance.CallMethod<AnnotatedType>("getAnnotatedType", "()Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getType()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getType", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/Executable;")]
		public Executable getDeclaringExecutable()
		{
			return Instance.CallMethod<Executable>("getDeclaringExecutable", "()Ljava/lang/reflect/Executable;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/Type;")]
		public Type getParameterizedType()
		{
			return Instance.CallMethod<Type>("getParameterizedType", "()Ljava/lang/reflect/Type;");
		}
		
		[JavaSignature("()Z")]
		public bool isImplicit()
		{
			return Instance.CallMethod<bool>("isImplicit", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isNamePresent()
		{
			return Instance.CallMethod<bool>("isNamePresent", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isVarArgs()
		{
			return Instance.CallMethod<bool>("isVarArgs", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public bool isAnnotationPresent(Class<Annotation> arg0)
		{
			return Instance.CallMethod<bool>("isAnnotationPresent", "(Ljava/lang/Class;)Z", arg0);
		}
	}
}
