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
	[JavaProxy("java/nio/DoubleBuffer")]
	public abstract partial class DoubleBuffer : Buffer, Comparable<DoubleBuffer>
	{
		protected DoubleBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([DII)Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer @get(DoubleArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<DoubleBuffer>("get", "([DII)Ljava/nio/DoubleBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([D)Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer @get(DoubleArray arg0)
		{
			return Instance.CallMethod<DoubleBuffer>("get", "([D)Ljava/nio/DoubleBuffer;", arg0);
		}
		
		[JavaSignature("()D")]
		public double @get()
		{
			return Instance.CallMethod<double>("get", "()D");
		}
		
		[JavaSignature("(I)D")]
		public double @get(int arg0)
		{
			return Instance.CallMethod<double>("get", "(I)D", arg0);
		}
		
		[JavaSignature("([D)Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer put(DoubleArray arg0)
		{
			return Instance.CallMethod<DoubleBuffer>("put", "([D)Ljava/nio/DoubleBuffer;", arg0);
		}
		
		[JavaSignature("([DII)Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer put(DoubleArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<DoubleBuffer>("put", "([DII)Ljava/nio/DoubleBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(ID)Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer put(int arg0, double arg1)
		{
			return Instance.CallMethod<DoubleBuffer>("put", "(ID)Ljava/nio/DoubleBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer put(DoubleBuffer arg0)
		{
			return Instance.CallMethod<DoubleBuffer>("put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;", arg0);
		}
		
		[JavaSignature("(D)Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer put(double arg0)
		{
			return Instance.CallMethod<DoubleBuffer>("put", "(D)Ljava/nio/DoubleBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/DoubleBuffer;)I")]
		public int compareTo(DoubleBuffer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/DoubleBuffer;)I", arg0);
		}
		
		[JavaSignature("()[D")]
		public new DoubleArray array()
		{
			return Instance.CallMethod<DoubleArray>("array", "()[D");
		}
		
		[JavaSignature("([DII)Ljava/nio/DoubleBuffer;")]
		public static DoubleBuffer wrap(DoubleArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<DoubleBuffer>(typeof(DoubleBuffer), "wrap", "([DII)Ljava/nio/DoubleBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([D)Ljava/nio/DoubleBuffer;")]
		public static DoubleBuffer wrap(DoubleArray arg0)
		{
			return Static.CallMethod<DoubleBuffer>(typeof(DoubleBuffer), "wrap", "([D)Ljava/nio/DoubleBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/DoubleBuffer;")]
		public static DoubleBuffer allocate(int arg0)
		{
			return Static.CallMethod<DoubleBuffer>(typeof(DoubleBuffer), "allocate", "(I)Ljava/nio/DoubleBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer duplicate()
		{
			return Instance.CallMethod<DoubleBuffer>("duplicate", "()Ljava/nio/DoubleBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer asReadOnlyBuffer()
		{
			return Instance.CallMethod<DoubleBuffer>("asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer compact()
		{
			return Instance.CallMethod<DoubleBuffer>("compact", "()Ljava/nio/DoubleBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public ByteOrder order()
		{
			return Instance.CallMethod<ByteOrder>("order", "()Ljava/nio/ByteOrder;");
		}
		
		[JavaSignature("()Ljava/nio/DoubleBuffer;")]
		public DoubleBuffer slice()
		{
			return Instance.CallMethod<DoubleBuffer>("slice", "()Ljava/nio/DoubleBuffer;");
		}
	}
}
