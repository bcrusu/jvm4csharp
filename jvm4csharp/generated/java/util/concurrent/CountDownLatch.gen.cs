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
	[JavaProxy("java/util/concurrent/CountDownLatch")]
	public partial class CountDownLatch : Object
	{
		protected CountDownLatch(ProxyCtor p) : base(p) {}
		
		public CountDownLatch(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()V")]
		public void countDown()
		{
			Instance.CallMethod("countDown", "()V");
		}
		
		[JavaSignature("()J")]
		public long getCount()
		{
			return Instance.CallMethod<long>("getCount", "()J");
		}
		
		[JavaSignature("()V")]
		public void @await()
		{
			Instance.CallMethod("await", "()V");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		public bool @await(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<bool>("await", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
		}
	}
}
