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
using jvm4csharp.java.nio.channels;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/System")]
	public class System : Object
	{
		protected System(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/io/InputStream;")]
		public static InputStream @in
		{
			get { return Static.GetField<InputStream>(typeof(System), "in", "Ljava/io/InputStream;"); }
		}
		
		[JavaSignature("Ljava/io/PrintStream;")]
		public static PrintStream @out
		{
			get { return Static.GetField<PrintStream>(typeof(System), "out", "Ljava/io/PrintStream;"); }
		}
		
		[JavaSignature("Ljava/io/PrintStream;")]
		public static PrintStream err
		{
			get { return Static.GetField<PrintStream>(typeof(System), "err", "Ljava/io/PrintStream;"); }
		}
	
		[JavaSignature("(I)V")]
		public static void exit(int arg0)
		{
			Static.CallMethod(typeof(System), "exit", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public static void runFinalization()
		{
			Static.CallMethod(typeof(System), "runFinalization", "()V");
		}
		
		[JavaSignature("(Z)V")]
		public static void runFinalizersOnExit(bool arg0)
		{
			Static.CallMethod(typeof(System), "runFinalizersOnExit", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public static String setProperty(String arg0, String arg1)
		{
			return Static.CallMethod<String>(typeof(System), "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String getProperty(String arg0)
		{
			return Static.CallMethod<String>(typeof(System), "getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public static String getProperty(String arg0, String arg1)
		{
			return Static.CallMethod<String>(typeof(System), "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public static int identityHashCode(IJavaObject arg0)
		{
			return Static.CallMethod<int>(typeof(System), "identityHashCode", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("()J")]
		public static long currentTimeMillis()
		{
			return Static.CallMethod<long>(typeof(System), "currentTimeMillis", "()J");
		}
		
		[JavaSignature("()J")]
		public static long nanoTime()
		{
			return Static.CallMethod<long>(typeof(System), "nanoTime", "()J");
		}
		
		[JavaSignature("(Ljava/lang/Object;ILjava/lang/Object;II)V")]
		public static void arraycopy(IJavaObject arg0, int arg1, IJavaObject arg2, int arg3, int arg4)
		{
			Static.CallMethod(typeof(System), "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("()Ljava/lang/SecurityManager;")]
		public static SecurityManager getSecurityManager()
		{
			return Static.CallMethod<SecurityManager>(typeof(System), "getSecurityManager", "()Ljava/lang/SecurityManager;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public static void load(String arg0)
		{
			Static.CallMethod(typeof(System), "load", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public static void loadLibrary(String arg0)
		{
			Static.CallMethod(typeof(System), "loadLibrary", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String mapLibraryName(String arg0)
		{
			return Static.CallMethod<String>(typeof(System), "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String clearProperty(String arg0)
		{
			return Static.CallMethod<String>(typeof(System), "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/io/Console;")]
		public static Console console()
		{
			return Static.CallMethod<Console>(typeof(System), "console", "()Ljava/io/Console;");
		}
		
		[JavaSignature("()V")]
		public static void gc()
		{
			Static.CallMethod(typeof(System), "gc", "()V");
		}
		
		[JavaSignature("()Ljava/util/Properties;")]
		public static Properties getProperties()
		{
			return Static.CallMethod<Properties>(typeof(System), "getProperties", "()Ljava/util/Properties;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String getenv(String arg0)
		{
			return Static.CallMethod<String>(typeof(System), "getenv", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Map;")]
		public static Map<String, String> getenv()
		{
			return Static.CallMethod<Map<String, String>>(typeof(System), "getenv", "()Ljava/util/Map;");
		}
		
		[JavaSignature("()Ljava/nio/channels/Channel;")]
		public static Channel inheritedChannel()
		{
			return Static.CallMethod<Channel>(typeof(System), "inheritedChannel", "()Ljava/nio/channels/Channel;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public static String lineSeparator()
		{
			return Static.CallMethod<String>(typeof(System), "lineSeparator", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/io/PrintStream;)V")]
		public static void setErr(PrintStream arg0)
		{
			Static.CallMethod(typeof(System), "setErr", "(Ljava/io/PrintStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)V")]
		public static void setIn(InputStream arg0)
		{
			Static.CallMethod(typeof(System), "setIn", "(Ljava/io/InputStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/PrintStream;)V")]
		public static void setOut(PrintStream arg0)
		{
			Static.CallMethod(typeof(System), "setOut", "(Ljava/io/PrintStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/Properties;)V")]
		public static void setProperties(Properties arg0)
		{
			Static.CallMethod(typeof(System), "setProperties", "(Ljava/util/Properties;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/SecurityManager;)V")]
		public static void setSecurityManager(SecurityManager arg0)
		{
			Static.CallMethod(typeof(System), "setSecurityManager", "(Ljava/lang/SecurityManager;)V", arg0);
		}
	}
}
