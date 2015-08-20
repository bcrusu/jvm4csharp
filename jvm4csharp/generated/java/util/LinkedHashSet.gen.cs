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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/LinkedHashSet")]
	public partial class LinkedHashSet<E> : HashSet<E>, Set<E>, Cloneable, Serializable
		where E : IJavaObject
	{
		protected LinkedHashSet(ProxyCtor p) : base(p) {}
		
		public LinkedHashSet(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public LinkedHashSet() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public LinkedHashSet(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public LinkedHashSet(int arg0, float arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IF)V", arg0, arg1);
		}
	}
}
