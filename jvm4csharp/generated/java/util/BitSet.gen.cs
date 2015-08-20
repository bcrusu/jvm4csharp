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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.nio;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/BitSet")]
	public partial class BitSet : Object, Cloneable, Serializable
	{
		protected BitSet(ProxyCtor p) : base(p) {}
		
		public BitSet(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public BitSet() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/util/BitSet;)V")]
		public void and(BitSet arg0)
		{
			Instance.CallMethod("and", "(Ljava/util/BitSet;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/BitSet;)V")]
		public void andNot(BitSet arg0)
		{
			Instance.CallMethod("andNot", "(Ljava/util/BitSet;)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int cardinality()
		{
			return Instance.CallMethod<int>("cardinality", "()I");
		}
		
		[JavaSignature("(Ljava/util/BitSet;)Z")]
		public bool intersects(BitSet arg0)
		{
			return Instance.CallMethod<bool>("intersects", "(Ljava/util/BitSet;)Z", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int nextSetBit(int arg0)
		{
			return Instance.CallMethod<int>("nextSetBit", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/BitSet;)V")]
		public void or(BitSet arg0)
		{
			Instance.CallMethod("or", "(Ljava/util/BitSet;)V", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int previousClearBit(int arg0)
		{
			return Instance.CallMethod<int>("previousClearBit", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int previousSetBit(int arg0)
		{
			return Instance.CallMethod<int>("previousSetBit", "(I)I", arg0);
		}
		
		[JavaSignature("()[B")]
		public ByteArray toByteArray()
		{
			return Instance.CallMethod<ByteArray>("toByteArray", "()[B");
		}
		
		[JavaSignature("()[J")]
		public LongArray toLongArray()
		{
			return Instance.CallMethod<LongArray>("toLongArray", "()[J");
		}
		
		[JavaSignature("(Ljava/util/BitSet;)V")]
		public void xor(BitSet arg0)
		{
			Instance.CallMethod("xor", "(Ljava/util/BitSet;)V", arg0);
		}
		
		[JavaSignature("(II)Ljava/util/BitSet;")]
		public BitSet @get(int arg0, int arg1)
		{
			return Instance.CallMethod<BitSet>("get", "(II)Ljava/util/BitSet;", arg0, arg1);
		}
		
		[JavaSignature("(I)Z")]
		public bool @get(int arg0)
		{
			return Instance.CallMethod<bool>("get", "(I)Z", arg0);
		}
		
		[JavaSignature("([B)Ljava/util/BitSet;")]
		public static BitSet valueOf(ByteArray arg0)
		{
			return Static.CallMethod<BitSet>(typeof(BitSet), "valueOf", "([B)Ljava/util/BitSet;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)Ljava/util/BitSet;")]
		public static BitSet valueOf(ByteBuffer arg0)
		{
			return Static.CallMethod<BitSet>(typeof(BitSet), "valueOf", "(Ljava/nio/ByteBuffer;)Ljava/util/BitSet;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/LongBuffer;)Ljava/util/BitSet;")]
		public static BitSet valueOf(LongBuffer arg0)
		{
			return Static.CallMethod<BitSet>(typeof(BitSet), "valueOf", "(Ljava/nio/LongBuffer;)Ljava/util/BitSet;", arg0);
		}
		
		[JavaSignature("([J)Ljava/util/BitSet;")]
		public static BitSet valueOf(LongArray arg0)
		{
			return Static.CallMethod<BitSet>(typeof(BitSet), "valueOf", "([J)Ljava/util/BitSet;", arg0);
		}
		
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void clear(int arg0)
		{
			Instance.CallMethod("clear", "(I)V", arg0);
		}
		
		[JavaSignature("(II)V")]
		public void clear(int arg0, int arg1)
		{
			Instance.CallMethod("clear", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool isEmpty()
		{
			return Instance.CallMethod<bool>("isEmpty", "()Z");
		}
		
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream stream()
		{
			return Instance.CallMethod<IntStream>("stream", "()Ljava/util/stream/IntStream;");
		}
		
		[JavaSignature("(IZ)V")]
		public void @set(int arg0, bool arg1)
		{
			Instance.CallMethod("set", "(IZ)V", arg0, arg1);
		}
		
		[JavaSignature("(IIZ)V")]
		public void @set(int arg0, int arg1, bool arg2)
		{
			Instance.CallMethod("set", "(IIZ)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(II)V")]
		public void @set(int arg0, int arg1)
		{
			Instance.CallMethod("set", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("(I)V")]
		public void @set(int arg0)
		{
			Instance.CallMethod("set", "(I)V", arg0);
		}
		
		[JavaSignature("(II)V")]
		public void flip(int arg0, int arg1)
		{
			Instance.CallMethod("flip", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("(I)V")]
		public void flip(int arg0)
		{
			Instance.CallMethod("flip", "(I)V", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int nextClearBit(int arg0)
		{
			return Instance.CallMethod<int>("nextClearBit", "(I)I", arg0);
		}
	}
}
