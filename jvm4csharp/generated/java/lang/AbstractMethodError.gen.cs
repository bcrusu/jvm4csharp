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
	[JavaProxy("java/lang/AbstractMethodError")]
	public class AbstractMethodError : IncompatibleClassChangeError
	{
		protected AbstractMethodError(ProxyCtor p) : base(p) {}
		
		public AbstractMethodError() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public AbstractMethodError(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	}
}