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
	[JavaProxy("java/lang/ref/ReferenceQueue")]
	public partial class ReferenceQueue<T> : Object
		where T : IJavaObject
	{
		protected ReferenceQueue(ProxyCtor p) : base(p) {}
		
		public ReferenceQueue() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(J)Ljava/lang/ref/Reference;")]
		public Reference<T> @remove(long arg0)
		{
			return Instance.CallMethod<Reference<T>>("remove", "(J)Ljava/lang/ref/Reference;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/ref/Reference;")]
		public Reference<T> @remove()
		{
			return Instance.CallMethod<Reference<T>>("remove", "()Ljava/lang/ref/Reference;");
		}
		
		[JavaSignature("()Ljava/lang/ref/Reference;")]
		public Reference<T> poll()
		{
			return Instance.CallMethod<Reference<T>>("poll", "()Ljava/lang/ref/Reference;");
		}
	}
}
