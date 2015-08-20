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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Thread")]
	public partial class Thread : Object, Runnable
	{
		protected Thread(ProxyCtor p) : base(p) {}
		
		public Thread(Runnable arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Runnable;)V", arg0);
		}
		
		public Thread() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Thread(ThreadGroup arg0, Runnable arg1, String arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V", arg0, arg1, arg2);
		}
		
		public Thread(Runnable arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Runnable;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Thread(ThreadGroup arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/ThreadGroup;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Thread(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Thread(ThreadGroup arg0, Runnable arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V", arg0, arg1);
		}
		
		public Thread(ThreadGroup arg0, Runnable arg1, String arg2, long arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V", arg0, arg1, arg2, arg3);
		}
	
		[JavaSignature("I")]
		public static int MIN_PRIORITY
		{
			get { return Static.GetField<int>(typeof(Thread), "MIN_PRIORITY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NORM_PRIORITY
		{
			get { return Static.GetField<int>(typeof(Thread), "NORM_PRIORITY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_PRIORITY
		{
			get { return Static.GetField<int>(typeof(Thread), "MAX_PRIORITY", "I"); }
		}
	
		[JavaSignature("()V")]
		public void run()
		{
			Instance.CallMethod("run", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isInterrupted()
		{
			return Instance.CallMethod<bool>("isInterrupted", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/Thread;")]
		public static Thread currentThread()
		{
			return Static.CallMethod<Thread>(typeof(Thread), "currentThread", "()Ljava/lang/Thread;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(J)V")]
		public void @join(long arg0)
		{
			Instance.CallMethod("join", "(J)V", arg0);
		}
		
		[JavaSignature("(JI)V")]
		public void @join(long arg0, int arg1)
		{
			Instance.CallMethod("join", "(JI)V", arg0, arg1);
		}
		
		[JavaSignature("()V")]
		public void @join()
		{
			Instance.CallMethod("join", "()V");
		}
		
		[JavaSignature("()Ljava/lang/ThreadGroup;")]
		public ThreadGroup getThreadGroup()
		{
			return Instance.CallMethod<ThreadGroup>("getThreadGroup", "()Ljava/lang/ThreadGroup;");
		}
		
		[JavaSignature("()[Ljava/lang/StackTraceElement;")]
		public ObjectArray<StackTraceElement> getStackTrace()
		{
			return Instance.CallMethod<ObjectArray<StackTraceElement>>("getStackTrace", "()[Ljava/lang/StackTraceElement;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public static bool holdsLock(IJavaObject arg0)
		{
			return Static.CallMethod<bool>(typeof(Thread), "holdsLock", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()V")]
		public void checkAccess()
		{
			Instance.CallMethod("checkAccess", "()V");
		}
		
		[JavaSignature("()V")]
		public static void dumpStack()
		{
			Static.CallMethod(typeof(Thread), "dumpStack", "()V");
		}
		
		[JavaSignature("(Z)V")]
		public void setDaemon(bool arg0)
		{
			Instance.CallMethod("setDaemon", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setPriority(int arg0)
		{
			Instance.CallMethod("setPriority", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void start()
		{
			Instance.CallMethod("start", "()V");
		}
		
		[JavaSignature("()I")]
		public static int activeCount()
		{
			return Static.CallMethod<int>(typeof(Thread), "activeCount", "()I");
		}
		
		[JavaSignature("()I")]
		public int countStackFrames()
		{
			return Instance.CallMethod<int>("countStackFrames", "()I");
		}
		
		[JavaSignature("()V")]
		public void destroy()
		{
			Instance.CallMethod("destroy", "()V");
		}
		
		[JavaSignature("([Ljava/lang/Thread;)I")]
		public static int enumerate(ObjectArray<Thread> arg0)
		{
			return Static.CallMethod<int>(typeof(Thread), "enumerate", "([Ljava/lang/Thread;)I", arg0);
		}
		
		[JavaSignature("()Ljava/util/Map;")]
		public static Map<Thread, ObjectArray<StackTraceElement>> getAllStackTraces()
		{
			return Static.CallMethod<Map<Thread, ObjectArray<StackTraceElement>>>(typeof(Thread), "getAllStackTraces", "()Ljava/util/Map;");
		}
		
		[JavaSignature("()Ljava/lang/ClassLoader;")]
		public ClassLoader getContextClassLoader()
		{
			return Instance.CallMethod<ClassLoader>("getContextClassLoader", "()Ljava/lang/ClassLoader;");
		}
		
		[JavaSignature("()Ljava/lang/Thread/UncaughtExceptionHandler;")]
		public static Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler()
		{
			return Static.CallMethod<Thread.UncaughtExceptionHandler>(typeof(Thread), "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread/UncaughtExceptionHandler;");
		}
		
		[JavaSignature("()J")]
		public long getId()
		{
			return Instance.CallMethod<long>("getId", "()J");
		}
		
		[JavaSignature("()I")]
		public int getPriority()
		{
			return Instance.CallMethod<int>("getPriority", "()I");
		}
		
		[JavaSignature("()Ljava/lang/Thread/State;")]
		public Thread.State getState()
		{
			return Instance.CallMethod<Thread.State>("getState", "()Ljava/lang/Thread/State;");
		}
		
		[JavaSignature("()Ljava/lang/Thread/UncaughtExceptionHandler;")]
		public Thread.UncaughtExceptionHandler getUncaughtExceptionHandler()
		{
			return Instance.CallMethod<Thread.UncaughtExceptionHandler>("getUncaughtExceptionHandler", "()Ljava/lang/Thread/UncaughtExceptionHandler;");
		}
		
		[JavaSignature("()V")]
		public void interrupt()
		{
			Instance.CallMethod("interrupt", "()V");
		}
		
		[JavaSignature("()Z")]
		public static bool interrupted()
		{
			return Static.CallMethod<bool>(typeof(Thread), "interrupted", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isAlive()
		{
			return Instance.CallMethod<bool>("isAlive", "()Z");
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
		
		[JavaSignature("(Ljava/lang/ClassLoader;)V")]
		public void setContextClassLoader(ClassLoader arg0)
		{
			Instance.CallMethod("setContextClassLoader", "(Ljava/lang/ClassLoader;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread/UncaughtExceptionHandler;)V")]
		public static void setDefaultUncaughtExceptionHandler(Thread.UncaughtExceptionHandler arg0)
		{
			Static.CallMethod(typeof(Thread), "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread/UncaughtExceptionHandler;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setName(String arg0)
		{
			Instance.CallMethod("setName", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread/UncaughtExceptionHandler;)V")]
		public void setUncaughtExceptionHandler(Thread.UncaughtExceptionHandler arg0)
		{
			Instance.CallMethod("setUncaughtExceptionHandler", "(Ljava/lang/Thread/UncaughtExceptionHandler;)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public static void sleep(long arg0)
		{
			Static.CallMethod(typeof(Thread), "sleep", "(J)V", arg0);
		}
		
		[JavaSignature("(JI)V")]
		public static void sleep(long arg0, int arg1)
		{
			Static.CallMethod(typeof(Thread), "sleep", "(JI)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Throwable;)V")]
		public void stop(Throwable arg0)
		{
			Instance.CallMethod("stop", "(Ljava/lang/Throwable;)V", arg0);
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
		
		[JavaSignature("()V")]
		public static void @yield()
		{
			Static.CallMethod(typeof(Thread), "yield", "()V");
		}
	
		[JavaProxy("java/lang/Thread/State")]
		public partial class State : Enum<Thread.State>
		{
			protected State(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/lang/Thread/State;")]
			public static Thread.State NEW
			{
				get { return Static.GetField<Thread.State>(typeof(State), "NEW", "Ljava/lang/Thread/State;"); }
			}
			
			[JavaSignature("Ljava/lang/Thread/State;")]
			public static Thread.State RUNNABLE
			{
				get { return Static.GetField<Thread.State>(typeof(State), "RUNNABLE", "Ljava/lang/Thread/State;"); }
			}
			
			[JavaSignature("Ljava/lang/Thread/State;")]
			public static Thread.State BLOCKED
			{
				get { return Static.GetField<Thread.State>(typeof(State), "BLOCKED", "Ljava/lang/Thread/State;"); }
			}
			
			[JavaSignature("Ljava/lang/Thread/State;")]
			public static Thread.State WAITING
			{
				get { return Static.GetField<Thread.State>(typeof(State), "WAITING", "Ljava/lang/Thread/State;"); }
			}
			
			[JavaSignature("Ljava/lang/Thread/State;")]
			public static Thread.State TIMED_WAITING
			{
				get { return Static.GetField<Thread.State>(typeof(State), "TIMED_WAITING", "Ljava/lang/Thread/State;"); }
			}
			
			[JavaSignature("Ljava/lang/Thread/State;")]
			public static Thread.State TERMINATED
			{
				get { return Static.GetField<Thread.State>(typeof(State), "TERMINATED", "Ljava/lang/Thread/State;"); }
			}
		
			[JavaSignature("()[Ljava/lang/Thread/State;")]
			public static ObjectArray<Thread.State> values()
			{
				return Static.CallMethod<ObjectArray<Thread.State>>(typeof(State), "values", "()[Ljava/lang/Thread/State;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/lang/Thread/State;")]
			public static Thread.State valueOf(String arg0)
			{
				return Static.CallMethod<Thread.State>(typeof(State), "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread/State;", arg0);
			}
		}
		
		[JavaProxy("java/lang/Thread/UncaughtExceptionHandler")]
		public partial interface UncaughtExceptionHandler : IJavaObject
		{
			[JavaSignature("(Ljava/lang/Thread;Ljava/lang/Throwable;)V")]
			void uncaughtException(Thread arg0, Throwable arg1);
		}
	}
}
