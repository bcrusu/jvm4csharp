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
using jvm4csharp.java.nio;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/Reader")]
	public abstract partial class Reader : Object, Readable, Closeable
	{
		protected Reader(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([C)I")]
		public int read(CharArray arg0)
		{
			return Instance.CallMethod<int>("read", "([C)I", arg0);
		}
		
		[JavaSignature("([CII)I")]
		public int read(CharArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<int>("read", "([CII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("()I")]
		public int read()
		{
			return Instance.CallMethod<int>("read", "()I");
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;)I")]
		public int read(CharBuffer arg0)
		{
			return Instance.CallMethod<int>("read", "(Ljava/nio/CharBuffer;)I", arg0);
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void mark(int arg0)
		{
			Instance.CallMethod("mark", "(I)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool markSupported()
		{
			return Instance.CallMethod<bool>("markSupported", "()Z");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("(J)J")]
		public long skip(long arg0)
		{
			return Instance.CallMethod<long>("skip", "(J)J", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool ready()
		{
			return Instance.CallMethod<bool>("ready", "()Z");
		}
	}
}
