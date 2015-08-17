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
	[JavaProxy("java/util/HashSet")]
	public class HashSet<E> : AbstractSet<E>, Set<E>, Cloneable, Serializable
		where E : IJavaObject
	{
		protected HashSet(ProxyCtor p) : base(p) {}
		
		public HashSet(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public HashSet(int arg0, float arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IF)V", arg0, arg1);
		}
		
		public HashSet(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public HashSet() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject clone()
		{
			return Instance.CallMethod<IJavaObject>("clone", "()Ljava/lang/Object;");
		}
	}
}
