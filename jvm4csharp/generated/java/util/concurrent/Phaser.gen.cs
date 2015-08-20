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
	[JavaProxy("java/util/concurrent/Phaser")]
	public partial class Phaser : Object
	{
		protected Phaser(ProxyCtor p) : base(p) {}
		
		public Phaser(Phaser arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/concurrent/Phaser;I)V", arg0, arg1);
		}
		
		public Phaser(Phaser arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/concurrent/Phaser;)V", arg0);
		}
		
		public Phaser() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Phaser(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()I")]
		public int register()
		{
			return Instance.CallMethod<int>("register", "()I");
		}
		
		[JavaSignature("()Ljava/util/concurrent/Phaser;")]
		public Phaser getParent()
		{
			return Instance.CallMethod<Phaser>("getParent", "()Ljava/util/concurrent/Phaser;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/Phaser;")]
		public Phaser getRoot()
		{
			return Instance.CallMethod<Phaser>("getRoot", "()Ljava/util/concurrent/Phaser;");
		}
		
		[JavaSignature("()I")]
		public int arrive()
		{
			return Instance.CallMethod<int>("arrive", "()I");
		}
		
		[JavaSignature("()I")]
		public int arriveAndAwaitAdvance()
		{
			return Instance.CallMethod<int>("arriveAndAwaitAdvance", "()I");
		}
		
		[JavaSignature("()I")]
		public int arriveAndDeregister()
		{
			return Instance.CallMethod<int>("arriveAndDeregister", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int awaitAdvance(int arg0)
		{
			return Instance.CallMethod<int>("awaitAdvance", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int awaitAdvanceInterruptibly(int arg0)
		{
			return Instance.CallMethod<int>("awaitAdvanceInterruptibly", "(I)I", arg0);
		}
		
		[JavaSignature("(IJLjava/util/concurrent/TimeUnit;)I")]
		public int awaitAdvanceInterruptibly(int arg0, long arg1, TimeUnit arg2)
		{
			return Instance.CallMethod<int>("awaitAdvanceInterruptibly", "(IJLjava/util/concurrent/TimeUnit;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(I)I")]
		public int bulkRegister(int arg0)
		{
			return Instance.CallMethod<int>("bulkRegister", "(I)I", arg0);
		}
		
		[JavaSignature("()V")]
		public void forceTermination()
		{
			Instance.CallMethod("forceTermination", "()V");
		}
		
		[JavaSignature("()I")]
		public int getArrivedParties()
		{
			return Instance.CallMethod<int>("getArrivedParties", "()I");
		}
		
		[JavaSignature("()I")]
		public int getPhase()
		{
			return Instance.CallMethod<int>("getPhase", "()I");
		}
		
		[JavaSignature("()I")]
		public int getRegisteredParties()
		{
			return Instance.CallMethod<int>("getRegisteredParties", "()I");
		}
		
		[JavaSignature("()I")]
		public int getUnarrivedParties()
		{
			return Instance.CallMethod<int>("getUnarrivedParties", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isTerminated()
		{
			return Instance.CallMethod<bool>("isTerminated", "()Z");
		}
	}
}
