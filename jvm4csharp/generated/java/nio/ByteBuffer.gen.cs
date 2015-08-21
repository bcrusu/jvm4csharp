//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio
{
	[JavaProxy("java/nio/ByteBuffer")]
	public abstract partial class ByteBuffer : Buffer, Comparable<ByteBuffer>
	{
		protected ByteBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(I)B")]
		public byte @get(int arg0)
		{
			return Instance.CallMethod<byte>("get", "(I)B", arg0);
		}
		
		[JavaSignature("([BII)Ljava/nio/ByteBuffer;")]
		public ByteBuffer @get(ByteArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<ByteBuffer>("get", "([BII)Ljava/nio/ByteBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()B")]
		public byte @get()
		{
			return Instance.CallMethod<byte>("get", "()B");
		}
		
		[JavaSignature("([B)Ljava/nio/ByteBuffer;")]
		public ByteBuffer @get(ByteArray arg0)
		{
			return Instance.CallMethod<ByteBuffer>("get", "([B)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("([BII)Ljava/nio/ByteBuffer;")]
		public ByteBuffer put(ByteArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<ByteBuffer>("put", "([BII)Ljava/nio/ByteBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(B)Ljava/nio/ByteBuffer;")]
		public ByteBuffer put(byte arg0)
		{
			return Instance.CallMethod<ByteBuffer>("put", "(B)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;")]
		public ByteBuffer put(ByteBuffer arg0)
		{
			return Instance.CallMethod<ByteBuffer>("put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(IB)Ljava/nio/ByteBuffer;")]
		public ByteBuffer put(int arg0, byte arg1)
		{
			return Instance.CallMethod<ByteBuffer>("put", "(IB)Ljava/nio/ByteBuffer;", arg0, arg1);
		}
		
		[JavaSignature("([B)Ljava/nio/ByteBuffer;")]
		public ByteBuffer put(ByteArray arg0)
		{
			return Instance.CallMethod<ByteBuffer>("put", "([B)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)I")]
		public int compareTo(ByteBuffer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/ByteBuffer;)I", arg0);
		}
		
		[JavaSignature("()S")]
		public short getShort()
		{
			return Instance.CallMethod<short>("getShort", "()S");
		}
		
		[JavaSignature("(I)S")]
		public short getShort(int arg0)
		{
			return Instance.CallMethod<short>("getShort", "(I)S", arg0);
		}
		
		[JavaSignature("(S)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putShort(short arg0)
		{
			return Instance.CallMethod<ByteBuffer>("putShort", "(S)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(IS)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putShort(int arg0, short arg1)
		{
			return Instance.CallMethod<ByteBuffer>("putShort", "(IS)Ljava/nio/ByteBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(I)C")]
		public char getChar(int arg0)
		{
			return Instance.CallMethod<char>("getChar", "(I)C", arg0);
		}
		
		[JavaSignature("()C")]
		public char getChar()
		{
			return Instance.CallMethod<char>("getChar", "()C");
		}
		
		[JavaSignature("(C)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putChar(char arg0)
		{
			return Instance.CallMethod<ByteBuffer>("putChar", "(C)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(IC)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putChar(int arg0, char arg1)
		{
			return Instance.CallMethod<ByteBuffer>("putChar", "(IC)Ljava/nio/ByteBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public int getInt(int arg0)
		{
			return Instance.CallMethod<int>("getInt", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int getInt()
		{
			return Instance.CallMethod<int>("getInt", "()I");
		}
		
		[JavaSignature("(II)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putInt(int arg0, int arg1)
		{
			return Instance.CallMethod<ByteBuffer>("putInt", "(II)Ljava/nio/ByteBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putInt(int arg0)
		{
			return Instance.CallMethod<ByteBuffer>("putInt", "(I)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("()J")]
		public long getLong()
		{
			return Instance.CallMethod<long>("getLong", "()J");
		}
		
		[JavaSignature("(I)J")]
		public long getLong(int arg0)
		{
			return Instance.CallMethod<long>("getLong", "(I)J", arg0);
		}
		
		[JavaSignature("(IJ)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putLong(int arg0, long arg1)
		{
			return Instance.CallMethod<ByteBuffer>("putLong", "(IJ)Ljava/nio/ByteBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(J)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putLong(long arg0)
		{
			return Instance.CallMethod<ByteBuffer>("putLong", "(J)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("()F")]
		public float getFloat()
		{
			return Instance.CallMethod<float>("getFloat", "()F");
		}
		
		[JavaSignature("(I)F")]
		public float getFloat(int arg0)
		{
			return Instance.CallMethod<float>("getFloat", "(I)F", arg0);
		}
		
		[JavaSignature("(F)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putFloat(float arg0)
		{
			return Instance.CallMethod<ByteBuffer>("putFloat", "(F)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(IF)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putFloat(int arg0, float arg1)
		{
			return Instance.CallMethod<ByteBuffer>("putFloat", "(IF)Ljava/nio/ByteBuffer;", arg0, arg1);
		}
		
		[JavaSignature("()D")]
		public double getDouble()
		{
			return Instance.CallMethod<double>("getDouble", "()D");
		}
		
		[JavaSignature("(I)D")]
		public double getDouble(int arg0)
		{
			return Instance.CallMethod<double>("getDouble", "(I)D", arg0);
		}
		
		[JavaSignature("(D)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putDouble(double arg0)
		{
			return Instance.CallMethod<ByteBuffer>("putDouble", "(D)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(ID)Ljava/nio/ByteBuffer;")]
		public ByteBuffer putDouble(int arg0, double arg1)
		{
			return Instance.CallMethod<ByteBuffer>("putDouble", "(ID)Ljava/nio/ByteBuffer;", arg0, arg1);
		}
		
		[JavaSignature("()[B")]
		public new ByteArray array()
		{
			return Instance.CallMethod<ByteArray>("array", "()[B");
		}
		
		[JavaSignature("([BII)Ljava/nio/ByteBuffer;")]
		public static ByteBuffer wrap(ByteArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<ByteBuffer>(typeof(ByteBuffer), "wrap", "([BII)Ljava/nio/ByteBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)Ljava/nio/ByteBuffer;")]
		public static ByteBuffer wrap(ByteArray arg0)
		{
			return Static.CallMethod<ByteBuffer>(typeof(ByteBuffer), "wrap", "([B)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/ByteBuffer;")]
		public static ByteBuffer allocate(int arg0)
		{
			return Static.CallMethod<ByteBuffer>(typeof(ByteBuffer), "allocate", "(I)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/ByteBuffer;")]
		public ByteBuffer duplicate()
		{
			return Instance.CallMethod<ByteBuffer>("duplicate", "()Ljava/nio/ByteBuffer;");
		}
		
		[JavaSignature("(I)Ljava/nio/ByteBuffer;")]
		public static ByteBuffer allocateDirect(int arg0)
		{
			return Static.CallMethod<ByteBuffer>(typeof(ByteBuffer), "allocateDirect", "(I)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/CharBuffer;")]
		public CharBuffer asCharBuffer()
		{
			return Instance.CallMethod<CharBuffer>("asCharBuffer", "()Ljava/nio/CharBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer asDoubleBuffer()
		{
			return Instance.CallMethod<DoubleBuffer>("asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/FloatBuffer;")]
		public FloatBuffer asFloatBuffer()
		{
			return Instance.CallMethod<FloatBuffer>("asFloatBuffer", "()Ljava/nio/FloatBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/IntBuffer;")]
		public IntBuffer asIntBuffer()
		{
			return Instance.CallMethod<IntBuffer>("asIntBuffer", "()Ljava/nio/IntBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/LongBuffer;")]
		public LongBuffer asLongBuffer()
		{
			return Instance.CallMethod<LongBuffer>("asLongBuffer", "()Ljava/nio/LongBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteBuffer;")]
		public ByteBuffer asReadOnlyBuffer()
		{
			return Instance.CallMethod<ByteBuffer>("asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ShortBuffer;")]
		public ShortBuffer asShortBuffer()
		{
			return Instance.CallMethod<ShortBuffer>("asShortBuffer", "()Ljava/nio/ShortBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteBuffer;")]
		public ByteBuffer compact()
		{
			return Instance.CallMethod<ByteBuffer>("compact", "()Ljava/nio/ByteBuffer;");
		}
		
		[JavaSignature("(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;")]
		public ByteBuffer order(ByteOrder arg0)
		{
			return Instance.CallMethod<ByteBuffer>("order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public ByteOrder order()
		{
			return Instance.CallMethod<ByteOrder>("order", "()Ljava/nio/ByteOrder;");
		}
		
		[JavaSignature("()Ljava/nio/ByteBuffer;")]
		public ByteBuffer slice()
		{
			return Instance.CallMethod<ByteBuffer>("slice", "()Ljava/nio/ByteBuffer;");
		}
	}
}
