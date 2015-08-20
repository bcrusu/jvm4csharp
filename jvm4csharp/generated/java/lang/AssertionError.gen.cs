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
	[JavaProxy("java/lang/AssertionError")]
	public partial class AssertionError : Error
	{
		protected AssertionError(ProxyCtor p) : base(p) {}
		
		public AssertionError(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public AssertionError(long arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(J)V", arg0);
		}
		
		public AssertionError(float arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(F)V", arg0);
		}
		
		public AssertionError(double arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(D)V", arg0);
		}
		
		public AssertionError(String arg0, Throwable arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1);
		}
		
		public AssertionError() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public AssertionError(IJavaObject arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Object;)V", arg0);
		}
		
		public AssertionError(bool arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Z)V", arg0);
		}
		
		public AssertionError(char arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(C)V", arg0);
		}
	}
}
