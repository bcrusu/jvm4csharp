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
namespace jvm4csharp.java.nio
{
	[JavaProxy("java/nio/IntBuffer")]
	public abstract class IntBuffer : Buffer, Comparable<IntBuffer>
	{
		protected IntBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([III)Ljava/nio/IntBuffer;")]
		public IntBuffer @get(IntArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<IntBuffer>("get", "([III)Ljava/nio/IntBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([I)Ljava/nio/IntBuffer;")]
		public IntBuffer @get(IntArray arg0)
		{
			return Instance.CallMethod<IntBuffer>("get", "([I)Ljava/nio/IntBuffer;", arg0);
		}
		
		[JavaSignature("()I")]
		public int @get()
		{
			return Instance.CallMethod<int>("get", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int @get(int arg0)
		{
			return Instance.CallMethod<int>("get", "(I)I", arg0);
		}
		
		[JavaSignature("([I)Ljava/nio/IntBuffer;")]
		public IntBuffer put(IntArray arg0)
		{
			return Instance.CallMethod<IntBuffer>("put", "([I)Ljava/nio/IntBuffer;", arg0);
		}
		
		[JavaSignature("([III)Ljava/nio/IntBuffer;")]
		public IntBuffer put(IntArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<IntBuffer>("put", "([III)Ljava/nio/IntBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(II)Ljava/nio/IntBuffer;")]
		public IntBuffer put(int arg0, int arg1)
		{
			return Instance.CallMethod<IntBuffer>("put", "(II)Ljava/nio/IntBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;")]
		public IntBuffer put(IntBuffer arg0)
		{
			return Instance.CallMethod<IntBuffer>("put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/IntBuffer;")]
		public IntBuffer put(int arg0)
		{
			return Instance.CallMethod<IntBuffer>("put", "(I)Ljava/nio/IntBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/IntBuffer;)I")]
		public int compareTo(IntBuffer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/IntBuffer;)I", arg0);
		}
		
		[JavaSignature("()[I")]
		public new IntArray array()
		{
			return Instance.CallMethod<IntArray>("array", "()[I");
		}
		
		[JavaSignature("([III)Ljava/nio/IntBuffer;")]
		public static IntBuffer wrap(IntArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<IntBuffer>(typeof(IntBuffer), "wrap", "([III)Ljava/nio/IntBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([I)Ljava/nio/IntBuffer;")]
		public static IntBuffer wrap(IntArray arg0)
		{
			return Static.CallMethod<IntBuffer>(typeof(IntBuffer), "wrap", "([I)Ljava/nio/IntBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/IntBuffer;")]
		public static IntBuffer allocate(int arg0)
		{
			return Static.CallMethod<IntBuffer>(typeof(IntBuffer), "allocate", "(I)Ljava/nio/IntBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/IntBuffer;")]
		public IntBuffer duplicate()
		{
			return Instance.CallMethod<IntBuffer>("duplicate", "()Ljava/nio/IntBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/IntBuffer;")]
		public IntBuffer asReadOnlyBuffer()
		{
			return Instance.CallMethod<IntBuffer>("asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/IntBuffer;")]
		public IntBuffer compact()
		{
			return Instance.CallMethod<IntBuffer>("compact", "()Ljava/nio/IntBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public ByteOrder order()
		{
			return Instance.CallMethod<ByteOrder>("order", "()Ljava/nio/ByteOrder;");
		}
		
		[JavaSignature("()Ljava/nio/IntBuffer;")]
		public IntBuffer slice()
		{
			return Instance.CallMethod<IntBuffer>("slice", "()Ljava/nio/IntBuffer;");
		}
	}
}
