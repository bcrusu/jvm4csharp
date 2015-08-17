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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Stack")]
	public class Stack<E> : Vector<E>
		where E : IJavaObject
	{
		protected Stack(ProxyCtor p) : base(p) {}
		
		public Stack() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public E pop()
		{
			return Instance.CallMethod<E>("pop", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public E push(E arg0)
		{
			return Instance.CallMethod<E>("push", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E peek()
		{
			return Instance.CallMethod<E>("peek", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Z")]
		public bool empty()
		{
			return Instance.CallMethod<bool>("empty", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int search(IJavaObject arg0)
		{
			return Instance.CallMethod<int>("search", "(Ljava/lang/Object;)I", arg0);
		}
	}
}
