//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.nio.channels.spi;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/Selector")]
	public abstract class Selector : Object, Closeable
	{
		protected Selector(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/channels/spi/SelectorProvider;")]
		public SelectorProvider provider()
		{
			return Instance.CallMethod<SelectorProvider>("provider", "()Ljava/nio/channels/spi/SelectorProvider;");
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<SelectionKey> keys()
		{
			return Instance.CallMethod<Set<SelectionKey>>("keys", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/nio/channels/Selector;")]
		public static Selector open()
		{
			return Static.CallMethod<Selector>(typeof(Selector), "open", "()Ljava/nio/channels/Selector;");
		}
		
		[JavaSignature("()Z")]
		public bool isOpen()
		{
			return Instance.CallMethod<bool>("isOpen", "()Z");
		}
		
		[JavaSignature("()I")]
		public int @select()
		{
			return Instance.CallMethod<int>("select", "()I");
		}
		
		[JavaSignature("(J)I")]
		public int @select(long arg0)
		{
			return Instance.CallMethod<int>("select", "(J)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int selectNow()
		{
			return Instance.CallMethod<int>("selectNow", "()I");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<SelectionKey> selectedKeys()
		{
			return Instance.CallMethod<Set<SelectionKey>>("selectedKeys", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/nio/channels/Selector;")]
		public Selector wakeup()
		{
			return Instance.CallMethod<Selector>("wakeup", "()Ljava/nio/channels/Selector;");
		}
	}
}
