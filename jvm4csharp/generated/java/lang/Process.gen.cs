//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.util.concurrent;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Process")]
	public abstract class Process : Object
	{
		protected Process(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()V")]
		public void destroy()
		{
			Instance.CallMethod("destroy", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isAlive()
		{
			return Instance.CallMethod<bool>("isAlive", "()Z");
		}
		
		[JavaSignature("()Ljava/io/InputStream;")]
		public InputStream getInputStream()
		{
			return Instance.CallMethod<InputStream>("getInputStream", "()Ljava/io/InputStream;");
		}
		
		[JavaSignature("()Ljava/io/OutputStream;")]
		public OutputStream getOutputStream()
		{
			return Instance.CallMethod<OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
		}
		
		[JavaSignature("()Ljava/lang/Process;")]
		public Process destroyForcibly()
		{
			return Instance.CallMethod<Process>("destroyForcibly", "()Ljava/lang/Process;");
		}
		
		[JavaSignature("()I")]
		public int exitValue()
		{
			return Instance.CallMethod<int>("exitValue", "()I");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Z")]
		public bool waitFor(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<bool>("waitFor", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int waitFor()
		{
			return Instance.CallMethod<int>("waitFor", "()I");
		}
		
		[JavaSignature("()Ljava/io/InputStream;")]
		public InputStream getErrorStream()
		{
			return Instance.CallMethod<InputStream>("getErrorStream", "()Ljava/io/InputStream;");
		}
	}
}
