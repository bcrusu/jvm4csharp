//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/CollationKey")]
	public abstract partial class CollationKey : Object, Comparable<CollationKey>
	{
		protected CollationKey(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/text/CollationKey;)I")]
		public int compareTo(CollationKey arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/text/CollationKey;)I", arg0);
		}
		
		[JavaSignature("()[B")]
		public ByteArray toByteArray()
		{
			return Instance.CallMethod<ByteArray>("toByteArray", "()[B");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSourceString()
		{
			return Instance.CallMethod<String>("getSourceString", "()Ljava/lang/String;");
		}
	}
}
