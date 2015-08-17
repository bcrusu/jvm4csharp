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
using jvm4csharp.java.nio;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/Adler32")]
	public class Adler32 : Object, Checksum
	{
		protected Adler32(ProxyCtor p) : base(p) {}
		
		public Adler32() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(I)V")]
		public void update(int arg0)
		{
			Instance.CallMethod("update", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/nio/ByteBuffer;)V")]
		public void update(ByteBuffer arg0)
		{
			Instance.CallMethod("update", "(Ljava/nio/ByteBuffer;)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public void update(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("update", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)V")]
		public void update(ByteArray arg0)
		{
			Instance.CallMethod("update", "([B)V", arg0);
		}
		
		[JavaSignature("()J")]
		public long getValue()
		{
			return Instance.CallMethod<long>("getValue", "()J");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
	}
}
