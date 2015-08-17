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
	[JavaProxy("java/lang/invoke/CallSite")]
	public abstract class CallSite : Object
	{
		protected CallSite(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/invoke/MethodType;")]
		public MethodType type()
		{
			return Instance.CallMethod<MethodType>("type", "()Ljava/lang/invoke/MethodType;");
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle dynamicInvoker()
		{
			return Instance.CallMethod<MethodHandle>("dynamicInvoker", "()Ljava/lang/invoke/MethodHandle;");
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle getTarget()
		{
			return Instance.CallMethod<MethodHandle>("getTarget", "()Ljava/lang/invoke/MethodHandle;");
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;)V")]
		public void setTarget(MethodHandle arg0)
		{
			Instance.CallMethod("setTarget", "(Ljava/lang/invoke/MethodHandle;)V", arg0);
		}
	}
}
