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
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/LambdaConversionException")]
	public class LambdaConversionException : Exception
	{
		protected LambdaConversionException(ProxyCtor p) : base(p) {}
		
		public LambdaConversionException(String arg0, Throwable arg1, bool arg2, bool arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/Throwable;ZZ)V", arg0, arg1, arg2, arg3);
		}
		
		public LambdaConversionException(Throwable arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Throwable;)V", arg0);
		}
		
		public LambdaConversionException(String arg0, Throwable arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1);
		}
		
		public LambdaConversionException(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public LambdaConversionException() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	}
}
