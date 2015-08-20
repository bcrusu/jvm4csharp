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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ForkJoinWorkerThread")]
	public partial class ForkJoinWorkerThread : Thread
	{
		protected ForkJoinWorkerThread(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/concurrent/ForkJoinPool;")]
		public ForkJoinPool getPool()
		{
			return Instance.CallMethod<ForkJoinPool>("getPool", "()Ljava/util/concurrent/ForkJoinPool;");
		}
		
		[JavaSignature("()I")]
		public int getPoolIndex()
		{
			return Instance.CallMethod<int>("getPoolIndex", "()I");
		}
	}
}
