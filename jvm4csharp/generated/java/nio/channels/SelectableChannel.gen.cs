//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.nio.channels.spi;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/SelectableChannel")]
	public abstract partial class SelectableChannel : AbstractInterruptibleChannel, Channel
	{
		protected SelectableChannel(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;")]
		public SelectionKey register(Selector arg0, int arg1)
		{
			return Instance.CallMethod<SelectionKey>("register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;")]
		public SelectionKey register(Selector arg0, int arg1, IJavaObject arg2)
		{
			return Instance.CallMethod<SelectionKey>("register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Z")]
		public bool isRegistered()
		{
			return Instance.CallMethod<bool>("isRegistered", "()Z");
		}
		
		[JavaSignature("()Ljava/nio/channels/spi/SelectorProvider;")]
		public SelectorProvider provider()
		{
			return Instance.CallMethod<SelectorProvider>("provider", "()Ljava/nio/channels/spi/SelectorProvider;");
		}
		
		[JavaSignature("(Z)Ljava/nio/channels/SelectableChannel;")]
		public SelectableChannel configureBlocking(bool arg0)
		{
			return Instance.CallMethod<SelectableChannel>("configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject blockingLock()
		{
			return Instance.CallMethod<IJavaObject>("blockingLock", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Z")]
		public bool isBlocking()
		{
			return Instance.CallMethod<bool>("isBlocking", "()Z");
		}
		
		[JavaSignature("(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;")]
		public SelectionKey keyFor(Selector arg0)
		{
			return Instance.CallMethod<SelectionKey>("keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", arg0);
		}
		
		[JavaSignature("()I")]
		public int validOps()
		{
			return Instance.CallMethod<int>("validOps", "()I");
		}
	}
}
