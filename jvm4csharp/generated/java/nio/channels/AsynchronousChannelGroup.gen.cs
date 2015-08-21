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
using jvm4csharp.java.nio.channels.spi;
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/AsynchronousChannelGroup")]
	public abstract partial class AsynchronousChannelGroup : Object
	{
		protected AsynchronousChannelGroup(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()V")]
		public void shutdown()
		{
			Instance.CallMethod("shutdown", "()V");
		}
		
		[JavaSignature("()Ljava/nio/channels/spi/AsynchronousChannelProvider;")]
		public AsynchronousChannelProvider provider()
		{
			return Instance.CallMethod<AsynchronousChannelProvider>("provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;")]
		public static AsynchronousChannelGroup withCachedThreadPool(ExecutorService arg0, int arg1)
		{
			return Static.CallMethod<AsynchronousChannelGroup>(typeof(AsynchronousChannelGroup), "withCachedThreadPool", "(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;")]
		public static AsynchronousChannelGroup withFixedThreadPool(int arg0, ThreadFactory arg1)
		{
			return Static.CallMethod<AsynchronousChannelGroup>(typeof(AsynchronousChannelGroup), "withFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/ExecutorService;)Ljava/nio/channels/AsynchronousChannelGroup;")]
		public static AsynchronousChannelGroup withThreadPool(ExecutorService arg0)
		{
			return Static.CallMethod<AsynchronousChannelGroup>(typeof(AsynchronousChannelGroup), "withThreadPool", "(Ljava/util/concurrent/ExecutorService;)Ljava/nio/channels/AsynchronousChannelGroup;", arg0);
		}
		
		[JavaSignature("()V")]
		public void shutdownNow()
		{
			Instance.CallMethod("shutdownNow", "()V");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		public bool awaitTermination(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<bool>("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool isShutdown()
		{
			return Instance.CallMethod<bool>("isShutdown", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isTerminated()
		{
			return Instance.CallMethod<bool>("isTerminated", "()Z");
		}
	}
}
