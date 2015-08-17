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
using jvm4csharp.java.nio.channels;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/RandomAccessFile")]
	public class RandomAccessFile : Object, DataOutput, DataInput, Closeable
	{
		protected RandomAccessFile(ProxyCtor p) : base(p) {}
		
		public RandomAccessFile(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public RandomAccessFile(File arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()F")]
		public float readFloat()
		{
			return Instance.CallMethod<float>("readFloat", "()F");
		}
		
		[JavaSignature("(F)V")]
		public void writeFloat(float arg0)
		{
			Instance.CallMethod("writeFloat", "(F)V", arg0);
		}
		
		[JavaSignature("()J")]
		public long length()
		{
			return Instance.CallMethod<long>("length", "()J");
		}
		
		[JavaSignature("([BII)V")]
		public void write(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("write", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)V")]
		public void write(ByteArray arg0)
		{
			Instance.CallMethod("write", "([B)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void write(int arg0)
		{
			Instance.CallMethod("write", "(I)V", arg0);
		}
		
		[JavaSignature("([B)I")]
		public int read(ByteArray arg0)
		{
			return Instance.CallMethod<int>("read", "([B)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int read()
		{
			return Instance.CallMethod<int>("read", "()I");
		}
		
		[JavaSignature("([BII)I")]
		public int read(ByteArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<int>("read", "([BII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String readLine()
		{
			return Instance.CallMethod<String>("readLine", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int readInt()
		{
			return Instance.CallMethod<int>("readInt", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void writeInt(int arg0)
		{
			Instance.CallMethod("writeInt", "(I)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setLength(long arg0)
		{
			Instance.CallMethod("setLength", "(J)V", arg0);
		}
		
		[JavaSignature("()C")]
		public char readChar()
		{
			return Instance.CallMethod<char>("readChar", "()C");
		}
		
		[JavaSignature("(I)V")]
		public void writeChar(int arg0)
		{
			Instance.CallMethod("writeChar", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeBytes(String arg0)
		{
			Instance.CallMethod("writeBytes", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public void readFully(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("readFully", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)V")]
		public void readFully(ByteArray arg0)
		{
			Instance.CallMethod("readFully", "([B)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String readUTF()
		{
			return Instance.CallMethod<String>("readUTF", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeUTF(String arg0)
		{
			Instance.CallMethod("writeUTF", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/nio/channels/FileChannel;")]
		public FileChannel getChannel()
		{
			return Instance.CallMethod<FileChannel>("getChannel", "()Ljava/nio/channels/FileChannel;");
		}
		
		[JavaSignature("()Ljava/io/FileDescriptor;")]
		public FileDescriptor getFD()
		{
			return Instance.CallMethod<FileDescriptor>("getFD", "()Ljava/io/FileDescriptor;");
		}
		
		[JavaSignature("()J")]
		public long readLong()
		{
			return Instance.CallMethod<long>("readLong", "()J");
		}
		
		[JavaSignature("(J)V")]
		public void writeLong(long arg0)
		{
			Instance.CallMethod("writeLong", "(J)V", arg0);
		}
		
		[JavaSignature("()B")]
		public byte readByte()
		{
			return Instance.CallMethod<byte>("readByte", "()B");
		}
		
		[JavaSignature("()S")]
		public short readShort()
		{
			return Instance.CallMethod<short>("readShort", "()S");
		}
		
		[JavaSignature("()Z")]
		public bool readBoolean()
		{
			return Instance.CallMethod<bool>("readBoolean", "()Z");
		}
		
		[JavaSignature("()D")]
		public double readDouble()
		{
			return Instance.CallMethod<double>("readDouble", "()D");
		}
		
		[JavaSignature("()I")]
		public int readUnsignedByte()
		{
			return Instance.CallMethod<int>("readUnsignedByte", "()I");
		}
		
		[JavaSignature("()I")]
		public int readUnsignedShort()
		{
			return Instance.CallMethod<int>("readUnsignedShort", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int skipBytes(int arg0)
		{
			return Instance.CallMethod<int>("skipBytes", "(I)I", arg0);
		}
		
		[JavaSignature("()J")]
		public long getFilePointer()
		{
			return Instance.CallMethod<long>("getFilePointer", "()J");
		}
		
		[JavaSignature("(J)V")]
		public void seek(long arg0)
		{
			Instance.CallMethod("seek", "(J)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeShort(int arg0)
		{
			Instance.CallMethod("writeShort", "(I)V", arg0);
		}
		
		[JavaSignature("(D)V")]
		public void writeDouble(double arg0)
		{
			Instance.CallMethod("writeDouble", "(D)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeByte(int arg0)
		{
			Instance.CallMethod("writeByte", "(I)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void writeBoolean(bool arg0)
		{
			Instance.CallMethod("writeBoolean", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeChars(String arg0)
		{
			Instance.CallMethod("writeChars", "(Ljava/lang/String;)V", arg0);
		}
	}
}
