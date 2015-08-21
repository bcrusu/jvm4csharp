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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/InputStream")]
	public abstract partial class InputStream : Object, Closeable
	{
		protected InputStream(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([BII)I")]
		public int read(ByteArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<int>("read", "([BII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)I")]
		public int read(ByteArray arg0)
		{
			return Instance.CallMethod<int>("read", "([B)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int read()
		{
			return Instance.CallMethod<int>("read", "()I");
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()I")]
		public int available()
		{
			return Instance.CallMethod<int>("available", "()I");
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
	}
}
