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
	[JavaProxy("java/io/DataInput")]
	public interface DataInput : IJavaObject
	{
		[JavaSignature("()F")]
		float readFloat();
		
		[JavaSignature("()Ljava/lang/String;")]
		String readLine();
		
		[JavaSignature("()I")]
		int readInt();
		
		[JavaSignature("()C")]
		char readChar();
		
		[JavaSignature("([B)V")]
		void readFully(ByteArray arg0);
		
		[JavaSignature("([BII)V")]
		void readFully(ByteArray arg0, int arg1, int arg2);
		
		[JavaSignature("()Ljava/lang/String;")]
		String readUTF();
		
		[JavaSignature("()J")]
		long readLong();
		
		[JavaSignature("()B")]
		byte readByte();
		
		[JavaSignature("()S")]
		short readShort();
		
		[JavaSignature("()Z")]
		bool readBoolean();
		
		[JavaSignature("()D")]
		double readDouble();
		
		[JavaSignature("()I")]
		int readUnsignedByte();
		
		[JavaSignature("()I")]
		int readUnsignedShort();
		
		[JavaSignature("(I)I")]
		int skipBytes(int arg0);
	}
}
