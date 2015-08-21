//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/SwitchPoint")]
	public partial class SwitchPoint : Object
	{
		protected SwitchPoint(ProxyCtor p) : base(p) {}
		
		public SwitchPoint() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle guardWithTest(MethodHandle arg0, MethodHandle arg1)
		{
			return Instance.CallMethod<MethodHandle>("guardWithTest", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool hasBeenInvalidated()
		{
			return Instance.CallMethod<bool>("hasBeenInvalidated", "()Z");
		}
		
		[JavaSignature("([Ljava/lang/invoke/SwitchPoint;)V")]
		public static void invalidateAll(ObjectArray<SwitchPoint> arg0)
		{
			Static.CallMethod(typeof(SwitchPoint), "invalidateAll", "([Ljava/lang/invoke/SwitchPoint;)V", arg0);
		}
	}
}
