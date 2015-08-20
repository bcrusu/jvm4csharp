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
	[JavaProxy("java/lang/reflect/UndeclaredThrowableException")]
	public partial class UndeclaredThrowableException : RuntimeException
	{
		protected UndeclaredThrowableException(ProxyCtor p) : base(p) {}
		
		public UndeclaredThrowableException(Throwable arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Throwable;)V", arg0);
		}
		
		public UndeclaredThrowableException(Throwable arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Throwable;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/Throwable;")]
		public Throwable getUndeclaredThrowable()
		{
			return Instance.CallMethod<Throwable>("getUndeclaredThrowable", "()Ljava/lang/Throwable;");
		}
	}
}
