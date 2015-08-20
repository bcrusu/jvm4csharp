//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang.reflect;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.annotation
{
	[JavaProxy("java/lang/annotation/AnnotationTypeMismatchException")]
	public partial class AnnotationTypeMismatchException : RuntimeException
	{
		protected AnnotationTypeMismatchException(ProxyCtor p) : base(p) {}
		
		public AnnotationTypeMismatchException(Method arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/reflect/Method;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/reflect/Method;")]
		public Method element()
		{
			return Instance.CallMethod<Method>("element", "()Ljava/lang/reflect/Method;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String foundType()
		{
			return Instance.CallMethod<String>("foundType", "()Ljava/lang/String;");
		}
	}
}
