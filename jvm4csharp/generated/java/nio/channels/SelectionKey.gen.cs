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
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/SelectionKey")]
	public abstract partial class SelectionKey : Object
	{
		protected SelectionKey(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int OP_READ
		{
			get { return Static.GetField<int>(typeof(SelectionKey), "OP_READ", "I"); }
		}
		
		[JavaSignature("I")]
		public static int OP_WRITE
		{
			get { return Static.GetField<int>(typeof(SelectionKey), "OP_WRITE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int OP_CONNECT
		{
			get { return Static.GetField<int>(typeof(SelectionKey), "OP_CONNECT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int OP_ACCEPT
		{
			get { return Static.GetField<int>(typeof(SelectionKey), "OP_ACCEPT", "I"); }
		}
	
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject attach(IJavaObject arg0)
		{
			return Instance.CallMethod<IJavaObject>("attach", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/channels/SelectableChannel;")]
		public SelectableChannel channel()
		{
			return Instance.CallMethod<SelectableChannel>("channel", "()Ljava/nio/channels/SelectableChannel;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject attachment()
		{
			return Instance.CallMethod<IJavaObject>("attachment", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Z")]
		public bool isValid()
		{
			return Instance.CallMethod<bool>("isValid", "()Z");
		}
		
		[JavaSignature("()I")]
		public int interestOps()
		{
			return Instance.CallMethod<int>("interestOps", "()I");
		}
		
		[JavaSignature("(I)Ljava/nio/channels/SelectionKey;")]
		public SelectionKey interestOps(int arg0)
		{
			return Instance.CallMethod<SelectionKey>("interestOps", "(I)Ljava/nio/channels/SelectionKey;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isAcceptable()
		{
			return Instance.CallMethod<bool>("isAcceptable", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isConnectable()
		{
			return Instance.CallMethod<bool>("isConnectable", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isReadable()
		{
			return Instance.CallMethod<bool>("isReadable", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isWritable()
		{
			return Instance.CallMethod<bool>("isWritable", "()Z");
		}
		
		[JavaSignature("()I")]
		public int readyOps()
		{
			return Instance.CallMethod<int>("readyOps", "()I");
		}
		
		[JavaSignature("()Ljava/nio/channels/Selector;")]
		public Selector selector()
		{
			return Instance.CallMethod<Selector>("selector", "()Ljava/nio/channels/Selector;");
		}
		
		[JavaSignature("()V")]
		public void cancel()
		{
			Instance.CallMethod("cancel", "()V");
		}
	}
}
