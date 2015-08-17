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
	[JavaProxy("java/util/concurrent/atomic/AtomicStampedReference")]
	public class AtomicStampedReference<V> : Object
		where V : IJavaObject
	{
		protected AtomicStampedReference(ProxyCtor p) : base(p) {}
		
		public AtomicStampedReference(V arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Object;I)V", arg0, arg1);
		}
	
		[JavaSignature("([I)Ljava/lang/Object;")]
		public V @get(IntArray arg0)
		{
			return Instance.CallMethod<V>("get", "([I)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)V")]
		public void @set(V arg0, int arg1)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;II)Z")]
		public bool compareAndSet(V arg0, V arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<bool>("compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;II)Z")]
		public bool weakCompareAndSet(V arg0, V arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<bool>("weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public V getReference()
		{
			return Instance.CallMethod<V>("getReference", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;I)Z")]
		public bool attemptStamp(V arg0, int arg1)
		{
			return Instance.CallMethod<bool>("attemptStamp", "(Ljava/lang/Object;I)Z", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int getStamp()
		{
			return Instance.CallMethod<int>("getStamp", "()I");
		}
	}
}
