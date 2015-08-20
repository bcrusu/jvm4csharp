//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent.atomic
{
	[JavaProxy("java/util/concurrent/atomic/AtomicMarkableReference")]
	public partial class AtomicMarkableReference<V> : Object
		where V : IJavaObject
	{
		protected AtomicMarkableReference(ProxyCtor p) : base(p) {}
		
		public AtomicMarkableReference(V arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Object;Z)V", arg0, arg1);
		}
	
		[JavaSignature("([Z)Ljava/lang/Object;")]
		public V @get(BooleanArray arg0)
		{
			return Instance.CallMethod<V>("get", "([Z)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)V")]
		public void @set(V arg0, bool arg1)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;Z)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z")]
		public bool compareAndSet(V arg0, V arg1, bool arg2, bool arg3)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z")]
		public bool weakCompareAndSet(V arg0, V arg1, bool arg2, bool arg3)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)Z")]
		public bool attemptMark(V arg0, bool arg1)
		{
			return Instance.CallMethod<bool>("attemptMark", "(Ljava/lang/Object;Z)Z", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool isMarked()
		{
			return Instance.CallMethod<bool>("isMarked", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public V getReference()
		{
			return Instance.CallMethod<V>("getReference", "()Ljava/lang/Object;");
		}
	}
}
