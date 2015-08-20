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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/CopyOnWriteArraySet")]
	public partial class CopyOnWriteArraySet<E> : AbstractSet<E>, Serializable
		where E : IJavaObject
	{
		protected CopyOnWriteArraySet(ProxyCtor p) : base(p) {}
		
		public CopyOnWriteArraySet() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public CopyOnWriteArraySet(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
	}
}
