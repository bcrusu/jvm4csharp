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
	[JavaProxy("java/io/OutputStream")]
	public abstract partial class OutputStream : Object, Closeable, Flushable
	{
		protected OutputStream(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([BII)V")]
		public void write(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("write", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)V")]
		public void write(ByteArray arg0)
		{
			Instance.CallMethod("write", "([B)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void write(int arg0)
		{
			Instance.CallMethod("write", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()V")]
		public void flush()
		{
			Instance.CallMethod("flush", "()V");
		}
	}
}
