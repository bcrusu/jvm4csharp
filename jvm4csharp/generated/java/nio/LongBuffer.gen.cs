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
	[JavaProxy("java/nio/LongBuffer")]
	public abstract partial class LongBuffer : Buffer, Comparable<LongBuffer>
	{
		protected LongBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([JII)Ljava/nio/LongBuffer;")]
		public LongBuffer @get(LongArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<LongBuffer>("get", "([JII)Ljava/nio/LongBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([J)Ljava/nio/LongBuffer;")]
		public LongBuffer @get(LongArray arg0)
		{
			return Instance.CallMethod<LongBuffer>("get", "([J)Ljava/nio/LongBuffer;", arg0);
		}
		
		[JavaSignature("()J")]
		public long @get()
		{
			return Instance.CallMethod<long>("get", "()J");
		}
		
		[JavaSignature("(I)J")]
		public long @get(int arg0)
		{
			return Instance.CallMethod<long>("get", "(I)J", arg0);
		}
		
		[JavaSignature("([J)Ljava/nio/LongBuffer;")]
		public LongBuffer put(LongArray arg0)
		{
			return Instance.CallMethod<LongBuffer>("put", "([J)Ljava/nio/LongBuffer;", arg0);
		}
		
		[JavaSignature("([JII)Ljava/nio/LongBuffer;")]
		public LongBuffer put(LongArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<LongBuffer>("put", "([JII)Ljava/nio/LongBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IJ)Ljava/nio/LongBuffer;")]
		public LongBuffer put(int arg0, long arg1)
		{
			return Instance.CallMethod<LongBuffer>("put", "(IJ)Ljava/nio/LongBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;")]
		public LongBuffer put(LongBuffer arg0)
		{
			return Instance.CallMethod<LongBuffer>("put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;", arg0);
		}
		
		[JavaSignature("(J)Ljava/nio/LongBuffer;")]
		public LongBuffer put(long arg0)
		{
			return Instance.CallMethod<LongBuffer>("put", "(J)Ljava/nio/LongBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/LongBuffer;)I")]
		public int compareTo(LongBuffer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/LongBuffer;)I", arg0);
		}
		
		[JavaSignature("()[J")]
		public new LongArray array()
		{
			return Instance.CallMethod<LongArray>("array", "()[J");
		}
		
		[JavaSignature("([JII)Ljava/nio/LongBuffer;")]
		public static LongBuffer wrap(LongArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<LongBuffer>(typeof(LongBuffer), "wrap", "([JII)Ljava/nio/LongBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([J)Ljava/nio/LongBuffer;")]
		public static LongBuffer wrap(LongArray arg0)
		{
			return Static.CallMethod<LongBuffer>(typeof(LongBuffer), "wrap", "([J)Ljava/nio/LongBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/LongBuffer;")]
		public static LongBuffer allocate(int arg0)
		{
			return Static.CallMethod<LongBuffer>(typeof(LongBuffer), "allocate", "(I)Ljava/nio/LongBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/LongBuffer;")]
		public LongBuffer duplicate()
		{
			return Instance.CallMethod<LongBuffer>("duplicate", "()Ljava/nio/LongBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/LongBuffer;")]
		public LongBuffer asReadOnlyBuffer()
		{
			return Instance.CallMethod<LongBuffer>("asReadOnlyBuffer", "()Ljava/nio/LongBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/LongBuffer;")]
		public LongBuffer compact()
		{
			return Instance.CallMethod<LongBuffer>("compact", "()Ljava/nio/LongBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public ByteOrder order()
		{
			return Instance.CallMethod<ByteOrder>("order", "()Ljava/nio/ByteOrder;");
		}
		
		[JavaSignature("()Ljava/nio/LongBuffer;")]
		public LongBuffer slice()
		{
			return Instance.CallMethod<LongBuffer>("slice", "()Ljava/nio/LongBuffer;");
		}
	}
}
