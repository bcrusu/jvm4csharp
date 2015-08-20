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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/Checksum")]
	public partial interface Checksum : IJavaObject
	{
		[JavaSignature("(I)V")]
		void update(int arg0);
		
		[JavaSignature("([BII)V")]
		void update(ByteArray arg0, int arg1, int arg2);
		
		[JavaSignature("()J")]
		long getValue();
		
		[JavaSignature("()V")]
		void reset();
	}
}
