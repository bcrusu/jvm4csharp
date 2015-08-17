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
	[JavaProxy("java/io/ObjectOutput")]
	public interface ObjectOutput : DataOutput, AutoCloseable
	{
		[JavaSignature("([B)V")]
		new void write(ByteArray arg0);
		
		[JavaSignature("(I)V")]
		new void write(int arg0);
		
		[JavaSignature("([BII)V")]
		new void write(ByteArray arg0, int arg1, int arg2);
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		void writeObject(IJavaObject arg0);
		
		[JavaSignature("()V")]
		new void close();
		
		[JavaSignature("()V")]
		void flush();
	}
}
