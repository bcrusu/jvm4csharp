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
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/LockInfo")]
	public partial class LockInfo : Object
	{
		protected LockInfo(ProxyCtor p) : base(p) {}
		
		public LockInfo(String arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;I)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getClassName()
		{
			return Instance.CallMethod<String>("getClassName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getIdentityHashCode()
		{
			return Instance.CallMethod<int>("getIdentityHashCode", "()I");
		}
	}
}
