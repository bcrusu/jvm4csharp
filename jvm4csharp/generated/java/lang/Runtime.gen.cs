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
using jvm4csharp.java.io;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Runtime")]
	public class Runtime : Object
	{
		protected Runtime(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(I)V")]
		public void exit(int arg0)
		{
			Instance.CallMethod("exit", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void runFinalization()
		{
			Instance.CallMethod("runFinalization", "()V");
		}
		
		[JavaSignature("(Z)V")]
		public static void runFinalizersOnExit(bool arg0)
		{
			Static.CallMethod(typeof(Runtime), "runFinalizersOnExit", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void load(String arg0)
		{
			Instance.CallMethod("load", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void loadLibrary(String arg0)
		{
			Instance.CallMethod("loadLibrary", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void gc()
		{
			Instance.CallMethod("gc", "()V");
		}
		
		[JavaSignature("()Ljava/lang/Runtime;")]
		public static Runtime getRuntime()
		{
			return Static.CallMethod<Runtime>(typeof(Runtime), "getRuntime", "()Ljava/lang/Runtime;");
		}
		
		[JavaSignature("()J")]
		public long freeMemory()
		{
			return Instance.CallMethod<long>("freeMemory", "()J");
		}
		
		[JavaSignature("()J")]
		public long maxMemory()
		{
			return Instance.CallMethod<long>("maxMemory", "()J");
		}
		
		[JavaSignature("(Ljava/lang/Thread;)V")]
		public void addShutdownHook(Thread arg0)
		{
			Instance.CallMethod("addShutdownHook", "(Ljava/lang/Thread;)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int availableProcessors()
		{
			return Instance.CallMethod<int>("availableProcessors", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;")]
		public Process exec(String arg0, ObjectArray<String> arg1)
		{
			return Instance.CallMethod<Process>("exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Process;")]
		public Process exec(String arg0)
		{
			return Instance.CallMethod<Process>("exec", "(Ljava/lang/String;)Ljava/lang/Process;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/String;)Ljava/lang/Process;")]
		public Process exec(ObjectArray<String> arg0)
		{
			return Instance.CallMethod<Process>("exec", "([Ljava/lang/String;)Ljava/lang/Process;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;")]
		public Process exec(ObjectArray<String> arg0, ObjectArray<String> arg1, File arg2)
		{
			return Instance.CallMethod<Process>("exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;")]
		public Process exec(ObjectArray<String> arg0, ObjectArray<String> arg1)
		{
			return Instance.CallMethod<Process>("exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;")]
		public Process exec(String arg0, ObjectArray<String> arg1, File arg2)
		{
			return Instance.CallMethod<Process>("exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)Ljava/io/InputStream;")]
		public InputStream getLocalizedInputStream(InputStream arg0)
		{
			return Instance.CallMethod<InputStream>("getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;", arg0);
		}
		
		[JavaSignature("(Ljava/io/OutputStream;)Ljava/io/OutputStream;")]
		public OutputStream getLocalizedOutputStream(OutputStream arg0)
		{
			return Instance.CallMethod<OutputStream>("getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void halt(int arg0)
		{
			Instance.CallMethod("halt", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread;)Z")]
		public bool removeShutdownHook(Thread arg0)
		{
			return Instance.CallMethod<bool>("removeShutdownHook", "(Ljava/lang/Thread;)Z", arg0);
		}
		
		[JavaSignature("()J")]
		public long totalMemory()
		{
			return Instance.CallMethod<long>("totalMemory", "()J");
		}
		
		[JavaSignature("(Z)V")]
		public void traceInstructions(bool arg0)
		{
			Instance.CallMethod("traceInstructions", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void traceMethodCalls(bool arg0)
		{
			Instance.CallMethod("traceMethodCalls", "(Z)V", arg0);
		}
	}
}
