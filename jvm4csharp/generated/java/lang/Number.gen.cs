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
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Number")]
	public abstract class Number : Object, Serializable
	{
		protected Number(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()B")]
		public byte byteValue()
		{
			return Instance.CallMethod<byte>("byteValue", "()B");
		}
		
		[JavaSignature("()S")]
		public short shortValue()
		{
			return Instance.CallMethod<short>("shortValue", "()S");
		}
		
		[JavaSignature("()I")]
		public int intValue()
		{
			return Instance.CallMethod<int>("intValue", "()I");
		}
		
		[JavaSignature("()J")]
		public long longValue()
		{
			return Instance.CallMethod<long>("longValue", "()J");
		}
		
		[JavaSignature("()F")]
		public float floatValue()
		{
			return Instance.CallMethod<float>("floatValue", "()F");
		}
		
		[JavaSignature("()D")]
		public double doubleValue()
		{
			return Instance.CallMethod<double>("doubleValue", "()D");
		}
	}
}
