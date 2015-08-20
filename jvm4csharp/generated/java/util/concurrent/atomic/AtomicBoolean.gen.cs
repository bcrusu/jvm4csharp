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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent.atomic
{
	[JavaProxy("java/util/concurrent/atomic/AtomicBoolean")]
	public partial class AtomicBoolean : Object, Serializable
	{
		protected AtomicBoolean(ProxyCtor p) : base(p) {}
		
		public AtomicBoolean(bool arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Z)V", arg0);
		}
		
		public AtomicBoolean() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()Z")]
		public bool @get()
		{
			return Instance.CallMethod<bool>("get", "()Z");
		}
		
		[JavaSignature("(Z)V")]
		public void @set(bool arg0)
		{
			Instance.CallMethod("set", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void lazySet(bool arg0)
		{
			Instance.CallMethod("lazySet", "(Z)V", arg0);
		}
		
		[JavaSignature("(ZZ)Z")]
		public bool compareAndSet(bool arg0, bool arg1)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(ZZ)Z", arg0, arg1);
		}
		
		[JavaSignature("(Z)Z")]
		public bool getAndSet(bool arg0)
		{
			return Instance.CallMethod<bool>("getAndSet", "(Z)Z", arg0);
		}
		
		[JavaSignature("(ZZ)Z")]
		public bool weakCompareAndSet(bool arg0, bool arg1)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(ZZ)Z", arg0, arg1);
		}
	}
}
