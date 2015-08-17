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
	[JavaProxy("java/nio/ShortBuffer")]
	public abstract class ShortBuffer : Buffer, Comparable<ShortBuffer>
	{
		protected ShortBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([SII)Ljava/nio/ShortBuffer;")]
		public ShortBuffer @get(ShortArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<ShortBuffer>("get", "([SII)Ljava/nio/ShortBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([S)Ljava/nio/ShortBuffer;")]
		public ShortBuffer @get(ShortArray arg0)
		{
			return Instance.CallMethod<ShortBuffer>("get", "([S)Ljava/nio/ShortBuffer;", arg0);
		}
		
		[JavaSignature("()S")]
		public short @get()
		{
			return Instance.CallMethod<short>("get", "()S");
		}
		
		[JavaSignature("(I)S")]
		public short @get(int arg0)
		{
			return Instance.CallMethod<short>("get", "(I)S", arg0);
		}
		
		[JavaSignature("([S)Ljava/nio/ShortBuffer;")]
		public ShortBuffer put(ShortArray arg0)
		{
			return Instance.CallMethod<ShortBuffer>("put", "([S)Ljava/nio/ShortBuffer;", arg0);
		}
		
		[JavaSignature("([SII)Ljava/nio/ShortBuffer;")]
		public ShortBuffer put(ShortArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<ShortBuffer>("put", "([SII)Ljava/nio/ShortBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IS)Ljava/nio/ShortBuffer;")]
		public ShortBuffer put(int arg0, short arg1)
		{
			return Instance.CallMethod<ShortBuffer>("put", "(IS)Ljava/nio/ShortBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;")]
		public ShortBuffer put(ShortBuffer arg0)
		{
			return Instance.CallMethod<ShortBuffer>("put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;", arg0);
		}
		
		[JavaSignature("(S)Ljava/nio/ShortBuffer;")]
		public ShortBuffer put(short arg0)
		{
			return Instance.CallMethod<ShortBuffer>("put", "(S)Ljava/nio/ShortBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ShortBuffer;)I")]
		public int compareTo(ShortBuffer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/ShortBuffer;)I", arg0);
		}
		
		[JavaSignature("()[S")]
		public new ShortArray array()
		{
			return Instance.CallMethod<ShortArray>("array", "()[S");
		}
		
		[JavaSignature("([SII)Ljava/nio/ShortBuffer;")]
		public static ShortBuffer wrap(ShortArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<ShortBuffer>(typeof(ShortBuffer), "wrap", "([SII)Ljava/nio/ShortBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([S)Ljava/nio/ShortBuffer;")]
		public static ShortBuffer wrap(ShortArray arg0)
		{
			return Static.CallMethod<ShortBuffer>(typeof(ShortBuffer), "wrap", "([S)Ljava/nio/ShortBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/ShortBuffer;")]
		public static ShortBuffer allocate(int arg0)
		{
			return Static.CallMethod<ShortBuffer>(typeof(ShortBuffer), "allocate", "(I)Ljava/nio/ShortBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/ShortBuffer;")]
		public ShortBuffer duplicate()
		{
			return Instance.CallMethod<ShortBuffer>("duplicate", "()Ljava/nio/ShortBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ShortBuffer;")]
		public ShortBuffer asReadOnlyBuffer()
		{
			return Instance.CallMethod<ShortBuffer>("asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ShortBuffer;")]
		public ShortBuffer compact()
		{
			return Instance.CallMethod<ShortBuffer>("compact", "()Ljava/nio/ShortBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public ByteOrder order()
		{
			return Instance.CallMethod<ByteOrder>("order", "()Ljava/nio/ByteOrder;");
		}
		
		[JavaSignature("()Ljava/nio/ShortBuffer;")]
		public ShortBuffer slice()
		{
			return Instance.CallMethod<ShortBuffer>("slice", "()Ljava/nio/ShortBuffer;");
		}
	}
}
