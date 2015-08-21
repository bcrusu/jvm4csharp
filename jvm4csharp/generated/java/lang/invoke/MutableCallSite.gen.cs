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
	[JavaProxy("java/lang/invoke/MutableCallSite")]
	public partial class MutableCallSite : CallSite
	{
		protected MutableCallSite(ProxyCtor p) : base(p) {}
		
		public MutableCallSite(MethodType arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/invoke/MethodType;)V", arg0);
		}
		
		public MutableCallSite(MethodHandle arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/invoke/MethodHandle;)V", arg0);
		}
	
		[JavaSignature("([Ljava/lang/invoke/MutableCallSite;)V")]
		public static void syncAll(ObjectArray<MutableCallSite> arg0)
		{
			Static.CallMethod(typeof(MutableCallSite), "syncAll", "([Ljava/lang/invoke/MutableCallSite;)V", arg0);
		}
	}
}
