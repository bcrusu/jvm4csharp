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
using jvm4csharp.java.io;
using jvm4csharp.java.lang.annotation;
using jvm4csharp.java.lang.reflect;
using jvm4csharp.java.net;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Class")]
	public partial class Class<T> : Object, Serializable, GenericDeclaration, Type, AnnotatedElement
		where T : IJavaObject
	{
		protected Class(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Class;")]
		public static Class<IJavaObject> forName(String arg0)
		{
			return Static.CallMethod<Class<IJavaObject>>(typeof(Class<>), "forName", "(Ljava/lang/String;)Ljava/lang/Class;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;")]
		public static Class<IJavaObject> forName(String arg0, bool arg1, ClassLoader arg2)
		{
			return Static.CallMethod<Class<IJavaObject>>(typeof(Class<>), "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public bool isAssignableFrom(Class<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("isAssignableFrom", "(Ljava/lang/Class;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool isInstance(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("isInstance", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()I")]
		public int getModifiers()
		{
			return Instance.CallMethod<int>("getModifiers", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isInterface()
		{
			return Instance.CallMethod<bool>("isInterface", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isArray()
		{
			return Instance.CallMethod<bool>("isArray", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isPrimitive()
		{
			return Instance.CallMethod<bool>("isPrimitive", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getSuperclass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getSuperclass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getComponentType()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getComponentType", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/Class;")]
		public Class<U> asSubclass<U>(Class<U> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<Class<U>>("asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public T cast(IJavaObject arg0)
		{
			return Instance.CallMethod<T>("cast", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool desiredAssertionStatus()
		{
			return Instance.CallMethod<bool>("desiredAssertionStatus", "()Z");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/AnnotatedType;")]
		public ObjectArray<AnnotatedType> getAnnotatedInterfaces()
		{
			return Instance.CallMethod<ObjectArray<AnnotatedType>>("getAnnotatedInterfaces", "()[Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/AnnotatedType;")]
		public AnnotatedType getAnnotatedSuperclass()
		{
			return Instance.CallMethod<AnnotatedType>("getAnnotatedSuperclass", "()Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
		public A getAnnotation<A>(Class<A> arg0)
			where A : Annotation
		{
			return Instance.CallMethod<A>("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<Annotation> getAnnotations()
		{
			return Instance.CallMethod<ObjectArray<Annotation>>("getAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<A> getAnnotationsByType<A>(Class<A> arg0)
			where A : Annotation
		{
			return Instance.CallMethod<ObjectArray<A>>("getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCanonicalName()
		{
			return Instance.CallMethod<String>("getCanonicalName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/ClassLoader;")]
		public ClassLoader getClassLoader()
		{
			return Instance.CallMethod<ClassLoader>("getClassLoader", "()Ljava/lang/ClassLoader;");
		}
		
		[JavaSignature("()[Ljava/lang/Class;")]
		public ObjectArray<Class<IJavaObject>> getClasses()
		{
			return Instance.CallMethod<ObjectArray<Class<IJavaObject>>>("getClasses", "()[Ljava/lang/Class;");
		}
		
		[JavaSignature("([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;")]
		public Constructor<T> getConstructor(ObjectArray<Class<IJavaObject>> arg0)
		{
			return Instance.CallMethod<Constructor<T>>("getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Constructor;")]
		public ObjectArray<Constructor<IJavaObject>> getConstructors()
		{
			return Instance.CallMethod<ObjectArray<Constructor<IJavaObject>>>("getConstructors", "()[Ljava/lang/reflect/Constructor;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
		public A getDeclaredAnnotation<A>(Class<A> arg0)
			where A : Annotation
		{
			return Instance.CallMethod<A>("getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<Annotation> getDeclaredAnnotations()
		{
			return Instance.CallMethod<ObjectArray<Annotation>>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;")]
		public ObjectArray<A> getDeclaredAnnotationsByType<A>(Class<A> arg0)
			where A : Annotation
		{
			return Instance.CallMethod<ObjectArray<A>>("getDeclaredAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/Class;")]
		public ObjectArray<Class<IJavaObject>> getDeclaredClasses()
		{
			return Instance.CallMethod<ObjectArray<Class<IJavaObject>>>("getDeclaredClasses", "()[Ljava/lang/Class;");
		}
		
		[JavaSignature("([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;")]
		public Constructor<T> getDeclaredConstructor(ObjectArray<Class<IJavaObject>> arg0)
		{
			return Instance.CallMethod<Constructor<T>>("getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Constructor;")]
		public ObjectArray<Constructor<IJavaObject>> getDeclaredConstructors()
		{
			return Instance.CallMethod<ObjectArray<Constructor<IJavaObject>>>("getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/reflect/Field;")]
		public Field getDeclaredField(String arg0)
		{
			return Instance.CallMethod<Field>("getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Field;")]
		public ObjectArray<Field> getDeclaredFields()
		{
			return Instance.CallMethod<ObjectArray<Field>>("getDeclaredFields", "()[Ljava/lang/reflect/Field;");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;")]
		public Method getDeclaredMethod(String arg0, ObjectArray<Class<IJavaObject>> arg1)
		{
			return Instance.CallMethod<Method>("getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", arg0, arg1);
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Method;")]
		public ObjectArray<Method> getDeclaredMethods()
		{
			return Instance.CallMethod<ObjectArray<Method>>("getDeclaredMethods", "()[Ljava/lang/reflect/Method;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getDeclaringClass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getDeclaringClass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getEnclosingClass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getEnclosingClass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/Constructor;")]
		public Constructor<IJavaObject> getEnclosingConstructor()
		{
			return Instance.CallMethod<Constructor<IJavaObject>>("getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/Method;")]
		public Method getEnclosingMethod()
		{
			return Instance.CallMethod<Method>("getEnclosingMethod", "()Ljava/lang/reflect/Method;");
		}
		
		[JavaSignature("()[Ljava/lang/Object;")]
		public ObjectArray<T> getEnumConstants()
		{
			return Instance.CallMethod<ObjectArray<T>>("getEnumConstants", "()[Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/reflect/Field;")]
		public Field getField(String arg0)
		{
			return Instance.CallMethod<Field>("getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Field;")]
		public ObjectArray<Field> getFields()
		{
			return Instance.CallMethod<ObjectArray<Field>>("getFields", "()[Ljava/lang/reflect/Field;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Type;")]
		public ObjectArray<Type> getGenericInterfaces()
		{
			return Instance.CallMethod<ObjectArray<Type>>("getGenericInterfaces", "()[Ljava/lang/reflect/Type;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/Type;")]
		public Type getGenericSuperclass()
		{
			return Instance.CallMethod<Type>("getGenericSuperclass", "()Ljava/lang/reflect/Type;");
		}
		
		[JavaSignature("()[Ljava/lang/Class;")]
		public ObjectArray<Class<IJavaObject>> getInterfaces()
		{
			return Instance.CallMethod<ObjectArray<Class<IJavaObject>>>("getInterfaces", "()[Ljava/lang/Class;");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;")]
		public Method getMethod(String arg0, ObjectArray<Class<IJavaObject>> arg1)
		{
			return Instance.CallMethod<Method>("getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", arg0, arg1);
		}
		
		[JavaSignature("()[Ljava/lang/reflect/Method;")]
		public ObjectArray<Method> getMethods()
		{
			return Instance.CallMethod<ObjectArray<Method>>("getMethods", "()[Ljava/lang/reflect/Method;");
		}
		
		[JavaSignature("()Ljava/lang/Package;")]
		public Package getPackage()
		{
			return Instance.CallMethod<Package>("getPackage", "()Ljava/lang/Package;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/net/URL;")]
		public URL getResource(String arg0)
		{
			return Instance.CallMethod<URL>("getResource", "(Ljava/lang/String;)Ljava/net/URL;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/io/InputStream;")]
		public InputStream getResourceAsStream(String arg0)
		{
			return Instance.CallMethod<InputStream>("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/Object;")]
		public ObjectArray<IJavaObject> getSigners()
		{
			return Instance.CallMethod<ObjectArray<IJavaObject>>("getSigners", "()[Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSimpleName()
		{
			return Instance.CallMethod<String>("getSimpleName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getTypeName()
		{
			return Instance.CallMethod<String>("getTypeName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/TypeVariable;")]
		public ObjectArray<TypeVariable<Class<T>>> getTypeParameters()
		{
			return Instance.CallMethod<ObjectArray<TypeVariable<Class<T>>>>("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
		}
		
		[JavaSignature("()Z")]
		public bool isAnnotation()
		{
			return Instance.CallMethod<bool>("isAnnotation", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public bool isAnnotationPresent(Class<Annotation> arg0)
		{
			return Instance.CallMethod<bool>("isAnnotationPresent", "(Ljava/lang/Class;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isAnonymousClass()
		{
			return Instance.CallMethod<bool>("isAnonymousClass", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isEnum()
		{
			return Instance.CallMethod<bool>("isEnum", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isLocalClass()
		{
			return Instance.CallMethod<bool>("isLocalClass", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMemberClass()
		{
			return Instance.CallMethod<bool>("isMemberClass", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isSynthetic()
		{
			return Instance.CallMethod<bool>("isSynthetic", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public T newInstance()
		{
			return Instance.CallMethod<T>("newInstance", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toGenericString()
		{
			return Instance.CallMethod<String>("toGenericString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/reflect/TypeVariable;")]
		ObjectArray<TypeVariable<GenericDeclaration>> GenericDeclaration.getTypeParameters()
		{
			return Instance.CallMethod<ObjectArray<TypeVariable<GenericDeclaration>>>("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
		}
	}
}
