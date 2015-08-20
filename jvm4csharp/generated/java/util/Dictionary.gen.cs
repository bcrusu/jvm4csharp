//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Dictionary")]
	public abstract partial class Dictionary<K, V> : Object
		where K : IJavaObject
		where V : IJavaObject
	{
		protected Dictionary(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public V @remove(IJavaObject arg0)
		{
			return Instance.CallMethod<V>("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public V @get(IJavaObject arg0)
		{
			return Instance.CallMethod<V>("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public V put(K arg0, V arg1)
		{
			return Instance.CallMethod<V>("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool isEmpty()
		{
			return Instance.CallMethod<bool>("isEmpty", "()Z");
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<V> elements()
		{
			return Instance.CallMethod<Enumeration<V>>("elements", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<K> keys()
		{
			return Instance.CallMethod<Enumeration<K>>("keys", "()Ljava/util/Enumeration;");
		}
	}
}
