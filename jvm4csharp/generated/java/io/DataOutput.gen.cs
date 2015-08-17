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
	[JavaProxy("java/io/DataOutput")]
	public interface DataOutput : IJavaObject
	{
		[JavaSignature("(F)V")]
		void writeFloat(float arg0);
		
		[JavaSignature("([BII)V")]
		void write(ByteArray arg0, int arg1, int arg2);
		
		[JavaSignature("([B)V")]
		void write(ByteArray arg0);
		
		[JavaSignature("(I)V")]
		void write(int arg0);
		
		[JavaSignature("(I)V")]
		void writeInt(int arg0);
		
		[JavaSignature("(I)V")]
		void writeChar(int arg0);
		
		[JavaSignature("(Ljava/lang/String;)V")]
		void writeBytes(String arg0);
		
		[JavaSignature("(Ljava/lang/String;)V")]
		void writeUTF(String arg0);
		
		[JavaSignature("(J)V")]
		void writeLong(long arg0);
		
		[JavaSignature("(I)V")]
		void writeShort(int arg0);
		
		[JavaSignature("(D)V")]
		void writeDouble(double arg0);
		
		[JavaSignature("(I)V")]
		void writeByte(int arg0);
		
		[JavaSignature("(Z)V")]
		void writeBoolean(bool arg0);
		
		[JavaSignature("(Ljava/lang/String;)V")]
		void writeChars(String arg0);
	}
}
