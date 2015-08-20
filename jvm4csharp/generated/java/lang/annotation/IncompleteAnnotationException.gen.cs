//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.annotation
{
	[JavaProxy("java/lang/annotation/IncompleteAnnotationException")]
	public partial class IncompleteAnnotationException : RuntimeException
	{
		protected IncompleteAnnotationException(ProxyCtor p) : base(p) {}
		
		public IncompleteAnnotationException(Class<Annotation> arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Class;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<Annotation> annotationType()
		{
			return Instance.CallMethod<Class<Annotation>>("annotationType", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String elementName()
		{
			return Instance.CallMethod<String>("elementName", "()Ljava/lang/String;");
		}
	}
}
