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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/ThreadLocalRandom")]
	public class ThreadLocalRandom : Random
	{
		protected ThreadLocalRandom(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(DD)D")]
		public double nextDouble(double arg0, double arg1)
		{
			return Instance.CallMethod<double>("nextDouble", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public double nextDouble(double arg0)
		{
			return Instance.CallMethod<double>("nextDouble", "(D)D", arg0);
		}
		
		[JavaSignature("(II)I")]
		public int nextInt(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("nextInt", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/ThreadLocalRandom;")]
		public static ThreadLocalRandom current()
		{
			return Static.CallMethod<ThreadLocalRandom>(typeof(ThreadLocalRandom), "current", "()Ljava/util/concurrent/ThreadLocalRandom;");
		}
		
		[JavaSignature("(J)J")]
		public long nextLong(long arg0)
		{
			return Instance.CallMethod<long>("nextLong", "(J)J", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public long nextLong(long arg0, long arg1)
		{
			return Instance.CallMethod<long>("nextLong", "(JJ)J", arg0, arg1);
		}
	}
}
