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
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/NoSuchFieldError")]
	public class NoSuchFieldError : IncompatibleClassChangeError
	{
		protected NoSuchFieldError(ProxyCtor p) : base(p) {}
		
		public NoSuchFieldError() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public NoSuchFieldError(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	}
}
