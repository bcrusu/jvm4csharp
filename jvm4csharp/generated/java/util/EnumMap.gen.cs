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
	[JavaProxy("java/util/EnumMap")]
	public partial class EnumMap<K, V> : AbstractMap<K, V>, Serializable, Cloneable
		where K : Enum<K>
		where V : IJavaObject
	{
		protected EnumMap(ProxyCtor p) : base(p) {}
		
		public EnumMap(EnumMap<K, V> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/EnumMap;)V", arg0);
		}
		
		public EnumMap(Class<K> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Class;)V", arg0);
		}
		
		public EnumMap(Map<K, V> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Map;)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;")]
		public V put(K arg0, V arg1)
		{
			return Instance.CallMethod<V>("put", "(Ljava/lang/Enum;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/EnumMap;")]
		public EnumMap<K, V> clone()
		{
			return Instance.CallMethod<EnumMap<K, V>>("clone", "()Ljava/util/EnumMap;");
		}
	}
}
