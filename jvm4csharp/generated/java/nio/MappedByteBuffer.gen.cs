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
namespace jvm4csharp.java.nio
{
	[JavaProxy("java/nio/MappedByteBuffer")]
	public abstract partial class MappedByteBuffer : ByteBuffer
	{
		protected MappedByteBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/nio/MappedByteBuffer;")]
		public MappedByteBuffer load()
		{
			return Instance.CallMethod<MappedByteBuffer>("load", "()Ljava/nio/MappedByteBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/MappedByteBuffer;")]
		public MappedByteBuffer force()
		{
			return Instance.CallMethod<MappedByteBuffer>("force", "()Ljava/nio/MappedByteBuffer;");
		}
		
		[JavaSignature("()Z")]
		public bool isLoaded()
		{
			return Instance.CallMethod<bool>("isLoaded", "()Z");
		}
	}
}
