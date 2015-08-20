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
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/MalformedParametersException")]
	public partial class MalformedParametersException : RuntimeException
	{
		protected MalformedParametersException(ProxyCtor p) : base(p) {}
		
		public MalformedParametersException() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public MalformedParametersException(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	}
}
