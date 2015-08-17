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
namespace jvm4csharp.java.nio
{
	[JavaProxy("java/nio/ByteOrder")]
	public class ByteOrder : Object
	{
		protected ByteOrder(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/ByteOrder;")]
		public static ByteOrder BIG_ENDIAN
		{
			get { return Static.GetField<ByteOrder>(typeof(ByteOrder), "BIG_ENDIAN", "Ljava/nio/ByteOrder;"); }
		}
		
		[JavaSignature("Ljava/nio/ByteOrder;")]
		public static ByteOrder LITTLE_ENDIAN
		{
			get { return Static.GetField<ByteOrder>(typeof(ByteOrder), "LITTLE_ENDIAN", "Ljava/nio/ByteOrder;"); }
		}
	
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public static ByteOrder nativeOrder()
		{
			return Static.CallMethod<ByteOrder>(typeof(ByteOrder), "nativeOrder", "()Ljava/nio/ByteOrder;");
		}
	}
}
