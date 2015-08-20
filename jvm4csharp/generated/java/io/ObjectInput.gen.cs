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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/ObjectInput")]
	public partial interface ObjectInput : DataInput, AutoCloseable
	{
		[JavaSignature("()Ljava/lang/Object;")]
		IJavaObject readObject();
		
		[JavaSignature("([BII)I")]
		int read(ByteArray arg0, int arg1, int arg2);
		
		[JavaSignature("([B)I")]
		int read(ByteArray arg0);
		
		[JavaSignature("()I")]
		int read();
		
		[JavaSignature("()V")]
		new void close();
		
		[JavaSignature("()I")]
		int available();
		
		[JavaSignature("(J)J")]
		long skip(long arg0);
	}
}
