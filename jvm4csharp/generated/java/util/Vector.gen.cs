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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Vector")]
	public partial class Vector<E> : AbstractList<E>, List<E>, RandomAccess, Cloneable, Serializable
		where E : IJavaObject
	{
		protected Vector(ProxyCtor p) : base(p) {}
		
		public Vector(Collection<E> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Collection;)V", arg0);
		}
		
		public Vector() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Vector(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public Vector(int arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(II)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject clone()
		{
			return Instance.CallMethod<IJavaObject>("clone", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public int indexOf(IJavaObject arg0, int arg1)
		{
			return Instance.CallMethod<int>("indexOf", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public int lastIndexOf(IJavaObject arg0, int arg1)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/UnaryOperator;)V")]
		public void replaceAll(UnaryOperator<E> arg0)
		{
			Instance.CallMethod("replaceAll", "(Ljava/util/function/UnaryOperator;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void addElement(E arg0)
		{
			Instance.CallMethod("addElement", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/Object;")]
		public E elementAt(int arg0)
		{
			return Instance.CallMethod<E>("elementAt", "(I)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<E> elements()
		{
			return Instance.CallMethod<Enumeration<E>>("elements", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("()I")]
		public int capacity()
		{
			return Instance.CallMethod<int>("capacity", "()I");
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
		
		[JavaSignature("([Ljava/lang/Object;)V")]
		public void copyInto(ObjectArray<IJavaObject> arg0)
		{
			Instance.CallMethod("copyInto", "([Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E firstElement()
		{
			return Instance.CallMethod<E>("firstElement", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;I)V")]
		public void insertElementAt(E arg0, int arg1)
		{
			Instance.CallMethod("insertElementAt", "(Ljava/lang/Object;I)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public E lastElement()
		{
			return Instance.CallMethod<E>("lastElement", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()V")]
		public void removeAllElements()
		{
			Instance.CallMethod("removeAllElements", "()V");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool removeElement(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("removeElement", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void removeElementAt(int arg0)
		{
			Instance.CallMethod("removeElementAt", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)V")]
		public void setElementAt(E arg0, int arg1)
		{
			Instance.CallMethod("setElementAt", "(Ljava/lang/Object;I)V", arg0, arg1);
		}
		
		[JavaSignature("(I)V")]
		public void setSize(int arg0)
		{
			Instance.CallMethod("setSize", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)V")]
		public void sort(Comparator<IJavaObject> arg0)
		{
			Instance.CallMethod("sort", "(Ljava/util/Comparator;)V", arg0);
		}
	}
}
