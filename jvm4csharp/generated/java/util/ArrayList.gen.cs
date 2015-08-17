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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/ArrayList")]
	public class ArrayList<E> : AbstractList<E>, List<E>, RandomAccess, Cloneable, Serializable
		where E : IJavaObject
	{
		protected ArrayList(ProxyCtor p) : base(p) {}
		
		public ArrayList(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public ArrayList() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ArrayList(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject clone()
		{
			return Instance.CallMethod<IJavaObject>("clone", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)V")]
		public void replaceAll(UnaryOperator<E> arg0)
		{
			Instance.CallMethod("replaceAll", "(Ljava/util/function/UnaryOperator;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void ensureCapacity(int arg0)
		{
			Instance.CallMethod("ensureCapacity", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void trimToSize()
		{
			Instance.CallMethod("trimToSize", "()V");
		}
		
		[JavaSignature("(Ljava/util/Comparator;)V")]
		public void sort(Comparator<IJavaObject> arg0)
		{
			Instance.CallMethod("sort", "(Ljava/util/Comparator;)V", arg0);
		}
	}
}
