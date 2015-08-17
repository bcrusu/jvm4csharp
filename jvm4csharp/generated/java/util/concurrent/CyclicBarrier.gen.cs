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
	[JavaProxy("java/util/concurrent/CyclicBarrier")]
	public class CyclicBarrier : Object
	{
		protected CyclicBarrier(ProxyCtor p) : base(p) {}
		
		public CyclicBarrier(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public CyclicBarrier(int arg0, Runnable arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/lang/Runnable;)V", arg0, arg1);
		}
	
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("()I")]
		public int @await()
		{
			return Instance.CallMethod<int>("await", "()I");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)I")]
		public int @await(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<int>("await", "(JLjava/util/concurrent/TimeUnit;)I", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int getNumberWaiting()
		{
			return Instance.CallMethod<int>("getNumberWaiting", "()I");
		}
		
		[JavaSignature("()I")]
		public int getParties()
		{
			return Instance.CallMethod<int>("getParties", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isBroken()
		{
			return Instance.CallMethod<bool>("isBroken", "()Z");
		}
	}
}
