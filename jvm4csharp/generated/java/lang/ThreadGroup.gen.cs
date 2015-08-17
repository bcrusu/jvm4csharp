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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/ThreadGroup")]
	public class ThreadGroup : Object, Thread.UncaughtExceptionHandler
	{
		protected ThreadGroup(ProxyCtor p) : base(p) {}
		
		public ThreadGroup(ThreadGroup arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/ThreadGroup;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public ThreadGroup(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/Thread;Ljava/lang/Throwable;)V")]
		public void uncaughtException(Thread arg0, Throwable arg1)
		{
			Instance.CallMethod("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/ThreadGroup;")]
		public ThreadGroup getParent()
		{
			return Instance.CallMethod<ThreadGroup>("getParent", "()Ljava/lang/ThreadGroup;");
		}
		
		[JavaSignature("()V")]
		public void checkAccess()
		{
			Instance.CallMethod("checkAccess", "()V");
		}
		
		[JavaSignature("(Z)V")]
		public void setDaemon(bool arg0)
		{
			Instance.CallMethod("setDaemon", "(Z)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int activeCount()
		{
			return Instance.CallMethod<int>("activeCount", "()I");
		}
		
		[JavaSignature("()V")]
		public void destroy()
		{
			Instance.CallMethod("destroy", "()V");
		}
		
		[JavaSignature("([Ljava/lang/ThreadGroup;)I")]
		public int enumerate(ObjectArray<ThreadGroup> arg0)
		{
			return Instance.CallMethod<int>("enumerate", "([Ljava/lang/ThreadGroup;)I", arg0);
		}
		
		[JavaSignature("([Ljava/lang/ThreadGroup;Z)I")]
		public int enumerate(ObjectArray<ThreadGroup> arg0, bool arg1)
		{
			return Instance.CallMethod<int>("enumerate", "([Ljava/lang/ThreadGroup;Z)I", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Thread;Z)I")]
		public int enumerate(ObjectArray<Thread> arg0, bool arg1)
		{
			return Instance.CallMethod<int>("enumerate", "([Ljava/lang/Thread;Z)I", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Thread;)I")]
		public int enumerate(ObjectArray<Thread> arg0)
		{
			return Instance.CallMethod<int>("enumerate", "([Ljava/lang/Thread;)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int getMaxPriority()
		{
			return Instance.CallMethod<int>("getMaxPriority", "()I");
		}
		
		[JavaSignature("()V")]
		public void interrupt()
		{
			Instance.CallMethod("interrupt", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isDaemon()
		{
			return Instance.CallMethod<bool>("isDaemon", "()Z");
		}
		
		[JavaSignature("()V")]
		public void resume()
		{
			Instance.CallMethod("resume", "()V");
		}
		
		[JavaSignature("()V")]
		public void stop()
		{
			Instance.CallMethod("stop", "()V");
		}
		
		[JavaSignature("()V")]
		public void suspend()
		{
			Instance.CallMethod("suspend", "()V");
		}
		
		[JavaSignature("()I")]
		public int activeGroupCount()
		{
			return Instance.CallMethod<int>("activeGroupCount", "()I");
		}
		
		[JavaSignature("(Z)Z")]
		public bool allowThreadSuspension(bool arg0)
		{
			return Instance.CallMethod<bool>("allowThreadSuspension", "(Z)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isDestroyed()
		{
			return Instance.CallMethod<bool>("isDestroyed", "()Z");
		}
		
		[JavaSignature("()V")]
		public void list()
		{
			Instance.CallMethod("list", "()V");
		}
		
		[JavaSignature("(Ljava/lang/ThreadGroup;)Z")]
		public bool parentOf(ThreadGroup arg0)
		{
			return Instance.CallMethod<bool>("parentOf", "(Ljava/lang/ThreadGroup;)Z", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMaxPriority(int arg0)
		{
			Instance.CallMethod("setMaxPriority", "(I)V", arg0);
		}
	}
}
