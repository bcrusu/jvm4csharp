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
	[JavaProxy("java/lang/ref/PhantomReference")]
	public partial class PhantomReference<T> : Reference<T>
		where T : IJavaObject
	{
		protected PhantomReference(ProxyCtor p) : base(p) {}
		
		public PhantomReference(T arg0, ReferenceQueue<IJavaObject> arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V", arg0, arg1);
		}
	}
}
