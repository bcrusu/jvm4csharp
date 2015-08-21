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
using jvm4csharp.java.lang.reflect;
using jvm4csharp.java.net;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Package")]
	public partial class Package : Object, AnnotatedElement
	{
		protected Package(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
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
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Package;")]
		public static Package getPackage(String arg0)
		{
			return Static.CallMethod<Package>(typeof(Package), "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public bool isAnnotationPresent(Class<Annotation> arg0)
		{
			return Instance.CallMethod<bool>("isAnnotationPresent", "(Ljava/lang/Class;)Z", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/Package;")]
		public static ObjectArray<Package> getPackages()
		{
			return Static.CallMethod<ObjectArray<Package>>(typeof(Package), "getPackages", "()[Ljava/lang/Package;");
		}
		
		[JavaSignature("(Ljava/net/URL;)Z")]
		public bool isSealed(URL arg0)
		{
			return Instance.CallMethod<bool>("isSealed", "(Ljava/net/URL;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isSealed()
		{
			return Instance.CallMethod<bool>("isSealed", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool isCompatibleWith(String arg0)
		{
			return Instance.CallMethod<bool>("isCompatibleWith", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getImplementationTitle()
		{
			return Instance.CallMethod<String>("getImplementationTitle", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getImplementationVendor()
		{
			return Instance.CallMethod<String>("getImplementationVendor", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getImplementationVersion()
		{
			return Instance.CallMethod<String>("getImplementationVersion", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSpecificationTitle()
		{
			return Instance.CallMethod<String>("getSpecificationTitle", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSpecificationVendor()
		{
			return Instance.CallMethod<String>("getSpecificationVendor", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSpecificationVersion()
		{
			return Instance.CallMethod<String>("getSpecificationVersion", "()Ljava/lang/String;");
		}
	}
}
