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
	[JavaProxy("java/nio/FloatBuffer")]
	public abstract partial class FloatBuffer : Buffer, Comparable<FloatBuffer>
	{
		protected FloatBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([FII)Ljava/nio/FloatBuffer;")]
		public FloatBuffer @get(FloatArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<FloatBuffer>("get", "([FII)Ljava/nio/FloatBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([F)Ljava/nio/FloatBuffer;")]
		public FloatBuffer @get(FloatArray arg0)
		{
			return Instance.CallMethod<FloatBuffer>("get", "([F)Ljava/nio/FloatBuffer;", arg0);
		}
		
		[JavaSignature("()F")]
		public float @get()
		{
			return Instance.CallMethod<float>("get", "()F");
		}
		
		[JavaSignature("(I)F")]
		public float @get(int arg0)
		{
			return Instance.CallMethod<float>("get", "(I)F", arg0);
		}
		
		[JavaSignature("([F)Ljava/nio/FloatBuffer;")]
		public FloatBuffer put(FloatArray arg0)
		{
			return Instance.CallMethod<FloatBuffer>("put", "([F)Ljava/nio/FloatBuffer;", arg0);
		}
		
		[JavaSignature("([FII)Ljava/nio/FloatBuffer;")]
		public FloatBuffer put(FloatArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<FloatBuffer>("put", "([FII)Ljava/nio/FloatBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IF)Ljava/nio/FloatBuffer;")]
		public FloatBuffer put(int arg0, float arg1)
		{
			return Instance.CallMethod<FloatBuffer>("put", "(IF)Ljava/nio/FloatBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;")]
		public FloatBuffer put(FloatBuffer arg0)
		{
			return Instance.CallMethod<FloatBuffer>("put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;", arg0);
		}
		
		[JavaSignature("(F)Ljava/nio/FloatBuffer;")]
		public FloatBuffer put(float arg0)
		{
			return Instance.CallMethod<FloatBuffer>("put", "(F)Ljava/nio/FloatBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/FloatBuffer;)I")]
		public int compareTo(FloatBuffer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/FloatBuffer;)I", arg0);
		}
		
		[JavaSignature("()[F")]
		public new FloatArray array()
		{
			return Instance.CallMethod<FloatArray>("array", "()[F");
		}
		
		[JavaSignature("([FII)Ljava/nio/FloatBuffer;")]
		public static FloatBuffer wrap(FloatArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<FloatBuffer>(typeof(FloatBuffer), "wrap", "([FII)Ljava/nio/FloatBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([F)Ljava/nio/FloatBuffer;")]
		public static FloatBuffer wrap(FloatArray arg0)
		{
			return Static.CallMethod<FloatBuffer>(typeof(FloatBuffer), "wrap", "([F)Ljava/nio/FloatBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/FloatBuffer;")]
		public static FloatBuffer allocate(int arg0)
		{
			return Static.CallMethod<FloatBuffer>(typeof(FloatBuffer), "allocate", "(I)Ljava/nio/FloatBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/FloatBuffer;")]
		public FloatBuffer duplicate()
		{
			return Instance.CallMethod<FloatBuffer>("duplicate", "()Ljava/nio/FloatBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/FloatBuffer;")]
		public FloatBuffer asReadOnlyBuffer()
		{
			return Instance.CallMethod<FloatBuffer>("asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/FloatBuffer;")]
		public FloatBuffer compact()
		{
			return Instance.CallMethod<FloatBuffer>("compact", "()Ljava/nio/FloatBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public ByteOrder order()
		{
			return Instance.CallMethod<ByteOrder>("order", "()Ljava/nio/ByteOrder;");
		}
		
		[JavaSignature("()Ljava/nio/FloatBuffer;")]
		public FloatBuffer slice()
		{
			return Instance.CallMethod<FloatBuffer>("slice", "()Ljava/nio/FloatBuffer;");
		}
	}
}
