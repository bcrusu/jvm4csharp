//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels.spi
{
	[JavaProxy("java/nio/channels/spi/AbstractInterruptibleChannel")]
	public abstract partial class AbstractInterruptibleChannel : Object, Channel, InterruptibleChannel
	{
		protected AbstractInterruptibleChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isOpen()
		{
			return Instance.CallMethod<bool>("isOpen", "()Z");
		}
	}
}
