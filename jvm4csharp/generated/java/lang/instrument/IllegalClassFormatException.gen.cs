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
namespace jvm4csharp.java.lang.instrument
{
	[JavaProxy("java/lang/instrument/IllegalClassFormatException")]
	public class IllegalClassFormatException : Exception
	{
		protected IllegalClassFormatException(ProxyCtor p) : base(p) {}
		
		public IllegalClassFormatException() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public IllegalClassFormatException(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	}
}
