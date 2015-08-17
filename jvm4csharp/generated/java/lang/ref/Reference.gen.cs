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
namespace jvm4csharp.java.lang.@ref
{
	[JavaProxy("java/lang/ref/Reference")]
	public abstract class Reference<T> : Object
		where T : IJavaObject
	{
		protected Reference(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public T @get()
		{
			return Instance.CallMethod<T>("get", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool enqueue()
		{
			return Instance.CallMethod<bool>("enqueue", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isEnqueued()
		{
			return Instance.CallMethod<bool>("isEnqueued", "()Z");
		}
	}
}
