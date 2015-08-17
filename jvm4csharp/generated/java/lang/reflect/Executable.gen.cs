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
	[JavaProxy("java/lang/reflect/Executable")]
	public abstract class Executable : AccessibleObject, Member, GenericDeclaration
	{
		protected Executable(ProxyCtor p) : base(p) {}
	
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
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getDeclaringClass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getDeclaringClass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()[Ljava/lang/Class;")]
		public ObjectArray<Class<IJavaObject>> getParameterTypes()
		{
			return Instance.CallMethod<ObjectArray<Class<IJavaObject>>>("getParameterTypes", "()[Ljava/lang/Class;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/TypeVariable;")]
		public ObjectArray<TypeVariable<GenericDeclaration>> getTypeParameters()
		{
			return Instance.CallMethod<ObjectArray<TypeVariable<GenericDeclaration>>>("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
		}
		
		[JavaSignature("()Z")]
		public bool isSynthetic()
		{
			return Instance.CallMethod<bool>("isSynthetic", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toGenericString()
		{
			return Instance.CallMethod<String>("toGenericString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/AnnotatedType;")]
		public ObjectArray<AnnotatedType> getAnnotatedParameterTypes()
		{
			return Instance.CallMethod<ObjectArray<AnnotatedType>>("getAnnotatedParameterTypes", "()[Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("()[Ljava/lang/annotation/Annotation[];")]
		public ObjectArray<ObjectArray<Annotation>> getParameterAnnotations()
		{
			return Instance.CallMethod<ObjectArray<ObjectArray<Annotation>>>("getParameterAnnotations", "()[Ljava/lang/annotation/Annotation[];");
		}
		
		[JavaSignature("()I")]
		public int getParameterCount()
		{
			return Instance.CallMethod<int>("getParameterCount", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isVarArgs()
		{
			return Instance.CallMethod<bool>("isVarArgs", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/reflect/AnnotatedType;")]
		public AnnotatedType getAnnotatedReturnType()
		{
			return Instance.CallMethod<AnnotatedType>("getAnnotatedReturnType", "()Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("()[Ljava/lang/Class;")]
		public ObjectArray<Class<IJavaObject>> getExceptionTypes()
		{
			return Instance.CallMethod<ObjectArray<Class<IJavaObject>>>("getExceptionTypes", "()[Ljava/lang/Class;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Type;")]
		public ObjectArray<Type> getGenericExceptionTypes()
		{
			return Instance.CallMethod<ObjectArray<Type>>("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Type;")]
		public ObjectArray<Type> getGenericParameterTypes()
		{
			return Instance.CallMethod<ObjectArray<Type>>("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/AnnotatedType;")]
		public ObjectArray<AnnotatedType> getAnnotatedExceptionTypes()
		{
			return Instance.CallMethod<ObjectArray<AnnotatedType>>("getAnnotatedExceptionTypes", "()[Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/AnnotatedType;")]
		public AnnotatedType getAnnotatedReceiverType()
		{
			return Instance.CallMethod<AnnotatedType>("getAnnotatedReceiverType", "()Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Parameter;")]
		public ObjectArray<Parameter> getParameters()
		{
			return Instance.CallMethod<ObjectArray<Parameter>>("getParameters", "()[Ljava/lang/reflect/Parameter;");
		}
	}
}
