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
	[JavaProxy("java/io/DataInputStream")]
	public partial class DataInputStream : FilterInputStream, DataInput
	{
		protected DataInputStream(ProxyCtor p) : base(p) {}
		
		public DataInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
	
		[JavaSignature("()F")]
		public float readFloat()
		{
			return Instance.CallMethod<float>("readFloat", "()F");
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
		
		[JavaSignature("()C")]
		public char readChar()
		{
			return Instance.CallMethod<char>("readChar", "()C");
		}
		
		[JavaSignature("([B)V")]
		public void readFully(ByteArray arg0)
		{
			Instance.CallMethod("readFully", "([B)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public void readFully(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("readFully", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String readUTF()
		{
			return Instance.CallMethod<String>("readUTF", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/io/DataInput;)Ljava/lang/String;")]
		public static String readUTF(DataInput arg0)
		{
			return Static.CallMethod<String>(typeof(DataInputStream), "readUTF", "(Ljava/io/DataInput;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()J")]
		public long readLong()
		{
			return Instance.CallMethod<long>("readLong", "()J");
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
	}
}
