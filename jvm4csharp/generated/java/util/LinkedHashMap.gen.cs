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
	[JavaProxy("java/util/LinkedHashMap")]
	public class LinkedHashMap<K, V> : HashMap<K, V>, Map<K, V>
		where K : IJavaObject
		where V : IJavaObject
	{
		protected LinkedHashMap(ProxyCtor p) : base(p) {}
		
		public LinkedHashMap(int arg0, float arg1, bool arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IFZ)V", arg0, arg1, arg2);
		}
		
		public LinkedHashMap(Map<K, V> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Map;)V", arg0);
		}
		
		public LinkedHashMap(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public LinkedHashMap(int arg0, float arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IF)V", arg0, arg1);
		}
		
		public LinkedHashMap() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	}
}
