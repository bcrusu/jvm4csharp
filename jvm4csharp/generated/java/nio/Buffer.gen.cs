//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio
{
	[JavaProxy("java/nio/Buffer")]
	public abstract class Buffer : Object
	{
		protected Buffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(I)Ljava/nio/Buffer;")]
		public Buffer limit(int arg0)
		{
			return Instance.CallMethod<Buffer>("limit", "(I)Ljava/nio/Buffer;", arg0);
		}
		
		[JavaSignature("()I")]
		public int limit()
		{
			return Instance.CallMethod<int>("limit", "()I");
		}
		
		[JavaSignature("()Ljava/nio/Buffer;")]
		public Buffer clear()
		{
			return Instance.CallMethod<Buffer>("clear", "()Ljava/nio/Buffer;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject array()
		{
			return Instance.CallMethod<IJavaObject>("array", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()I")]
		public int arrayOffset()
		{
			return Instance.CallMethod<int>("arrayOffset", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool hasArray()
		{
			return Instance.CallMethod<bool>("hasArray", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isDirect()
		{
			return Instance.CallMethod<bool>("isDirect", "()Z");
		}
		
		[JavaSignature("(I)Ljava/nio/Buffer;")]
		public Buffer position(int arg0)
		{
			return Instance.CallMethod<Buffer>("position", "(I)Ljava/nio/Buffer;", arg0);
		}
		
		[JavaSignature("()I")]
		public int position()
		{
			return Instance.CallMethod<int>("position", "()I");
		}
		
		[JavaSignature("()I")]
		public int remaining()
		{
			return Instance.CallMethod<int>("remaining", "()I");
		}
		
		[JavaSignature("()I")]
		public int capacity()
		{
			return Instance.CallMethod<int>("capacity", "()I");
		}
		
		[JavaSignature("()Ljava/nio/Buffer;")]
		public Buffer mark()
		{
			return Instance.CallMethod<Buffer>("mark", "()Ljava/nio/Buffer;");
		}
		
		[JavaSignature("()Ljava/nio/Buffer;")]
		public Buffer reset()
		{
			return Instance.CallMethod<Buffer>("reset", "()Ljava/nio/Buffer;");
		}
		
		[JavaSignature("()Ljava/nio/Buffer;")]
		public Buffer flip()
		{
			return Instance.CallMethod<Buffer>("flip", "()Ljava/nio/Buffer;");
		}
		
		[JavaSignature("()Z")]
		public bool hasRemaining()
		{
			return Instance.CallMethod<bool>("hasRemaining", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isReadOnly()
		{
			return Instance.CallMethod<bool>("isReadOnly", "()Z");
		}
		
		[JavaSignature("()Ljava/nio/Buffer;")]
		public Buffer rewind()
		{
			return Instance.CallMethod<Buffer>("rewind", "()Ljava/nio/Buffer;");
		}
	}
}
