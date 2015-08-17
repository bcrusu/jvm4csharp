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
	[JavaProxy("java/lang/reflect/InvocationTargetException")]
	public class InvocationTargetException : ReflectiveOperationException
	{
		protected InvocationTargetException(ProxyCtor p) : base(p) {}
		
		public InvocationTargetException(Throwable arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Throwable;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public InvocationTargetException(Throwable arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Throwable;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/Throwable;")]
		public Throwable getTargetException()
		{
			return Instance.CallMethod<Throwable>("getTargetException", "()Ljava/lang/Throwable;");
		}
	}
}
