//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/ThreadLocal")]
	public class ThreadLocal<T> : Object
		where T : IJavaObject
	{
		protected ThreadLocal(ProxyCtor p) : base(p) {}
		
		public ThreadLocal() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()V")]
		public void @remove()
		{
			Instance.CallMethod("remove", "()V");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public T @get()
		{
			return Instance.CallMethod<T>("get", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void @set(T arg0)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)Ljava/lang/ThreadLocal;")]
		public static ThreadLocal<S> withInitial<S>(Supplier<S> arg0)
			where S : IJavaObject
		{
			return Static.CallMethod<ThreadLocal<S>>(typeof(ThreadLocal<>), "withInitial", "(Ljava/util/function/Supplier;)Ljava/lang/ThreadLocal;", arg0);
		}
	}
}
