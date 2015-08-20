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
namespace jvm4csharp.java.util.logging
{
	[JavaProxy("java/util/logging/MemoryHandler")]
	public partial class MemoryHandler : Handler
	{
		protected MemoryHandler(ProxyCtor p) : base(p) {}
		
		public MemoryHandler(Handler arg0, int arg1, Level arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/logging/Handler;ILjava/util/logging/Level;)V", arg0, arg1, arg2);
		}
		
		public MemoryHandler() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()V")]
		public void push()
		{
			Instance.CallMethod("push", "()V");
		}
		
		[JavaSignature("()Ljava/util/logging/Level;")]
		public Level getPushLevel()
		{
			return Instance.CallMethod<Level>("getPushLevel", "()Ljava/util/logging/Level;");
		}
		
		[JavaSignature("(Ljava/util/logging/Level;)V")]
		public void setPushLevel(Level arg0)
		{
			Instance.CallMethod("setPushLevel", "(Ljava/util/logging/Level;)V", arg0);
		}
	}
}
