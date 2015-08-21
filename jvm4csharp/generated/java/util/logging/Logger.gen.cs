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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.logging
{
	[JavaProxy("java/util/logging/Logger")]
	public partial class Logger : Object
	{
		protected Logger(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/lang/String;")]
		public static String GLOBAL_LOGGER_NAME
		{
			get { return Static.GetField<String>(typeof(Logger), "GLOBAL_LOGGER_NAME", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Logger;")]
		public static Logger @global
		{
			get { return Static.GetField<Logger>(typeof(Logger), "global", "Ljava/util/logging/Logger;"); }
		}
	
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V")]
		public void log(Level arg0, String arg1, IJavaObject arg2)
		{
			Instance.CallMethod("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/util/function/Supplier;)V")]
		public void log(Level arg0, Supplier<String> arg1)
		{
			Instance.CallMethod("log", "(Ljava/util/logging/Level;Ljava/util/function/Supplier;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;)V")]
		public void log(Level arg0, String arg1)
		{
			Instance.CallMethod("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/logging/LogRecord;)V")]
		public void log(LogRecord arg0)
		{
			Instance.CallMethod("log", "(Ljava/util/logging/LogRecord;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;[Ljava/lang/Object;)V")]
		public void log(Level arg0, String arg1, ObjectArray<IJavaObject> arg2)
		{
			Instance.CallMethod("log", "(Ljava/util/logging/Level;Ljava/lang/String;[Ljava/lang/Object;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V")]
		public void log(Level arg0, Throwable arg1, Supplier<String> arg2)
		{
			Instance.CallMethod("log", "(Ljava/util/logging/Level;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V")]
		public void log(Level arg0, String arg1, Throwable arg2)
		{
			Instance.CallMethod("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/logging/Logger;")]
		public Logger getParent()
		{
			return Instance.CallMethod<Logger>("getParent", "()Ljava/util/logging/Logger;");
		}
		
		[JavaSignature("(Ljava/util/logging/Logger;)V")]
		public void setParent(Logger arg0)
		{
			Instance.CallMethod("setParent", "(Ljava/util/logging/Logger;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/logging/Logger;")]
		public static Logger getLogger(String arg0)
		{
			return Static.CallMethod<Logger>(typeof(Logger), "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;")]
		public static Logger getLogger(String arg0, String arg1)
		{
			return Static.CallMethod<Logger>(typeof(Logger), "getLogger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void warning(String arg0)
		{
			Instance.CallMethod("warning", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)V")]
		public void warning(Supplier<String> arg0)
		{
			Instance.CallMethod("warning", "(Ljava/util/function/Supplier;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)V")]
		public void info(Supplier<String> arg0)
		{
			Instance.CallMethod("info", "(Ljava/util/function/Supplier;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void info(String arg0)
		{
			Instance.CallMethod("info", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Filter;)V")]
		public void setFilter(Filter arg0)
		{
			Instance.CallMethod("setFilter", "(Ljava/util/logging/Filter;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/logging/Filter;")]
		public Filter getFilter()
		{
			return Instance.CallMethod<Filter>("getFilter", "()Ljava/util/logging/Filter;");
		}
		
		[JavaSignature("()Ljava/util/logging/Level;")]
		public Level getLevel()
		{
			return Instance.CallMethod<Level>("getLevel", "()Ljava/util/logging/Level;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getResourceBundleName()
		{
			return Instance.CallMethod<String>("getResourceBundleName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/ResourceBundle;")]
		public ResourceBundle getResourceBundle()
		{
			return Instance.CallMethod<ResourceBundle>("getResourceBundle", "()Ljava/util/ResourceBundle;");
		}
		
		[JavaSignature("(Ljava/util/ResourceBundle;)V")]
		public void setResourceBundle(ResourceBundle arg0)
		{
			Instance.CallMethod("setResourceBundle", "(Ljava/util/ResourceBundle;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;)V")]
		public void setLevel(Level arg0)
		{
			Instance.CallMethod("setLevel", "(Ljava/util/logging/Level;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void config(String arg0)
		{
			Instance.CallMethod("config", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)V")]
		public void config(Supplier<String> arg0)
		{
			Instance.CallMethod("config", "(Ljava/util/function/Supplier;)V", arg0);
		}
		
		[JavaSignature("()[Ljava/util/logging/Handler;")]
		public ObjectArray<Handler> getHandlers()
		{
			return Instance.CallMethod<ObjectArray<Handler>>("getHandlers", "()[Ljava/util/logging/Handler;");
		}
		
		[JavaSignature("(Ljava/util/logging/Handler;)V")]
		public void removeHandler(Handler arg0)
		{
			Instance.CallMethod("removeHandler", "(Ljava/util/logging/Handler;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setUseParentHandlers(bool arg0)
		{
			Instance.CallMethod("setUseParentHandlers", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Handler;)V")]
		public void addHandler(Handler arg0)
		{
			Instance.CallMethod("addHandler", "(Ljava/util/logging/Handler;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;)Z")]
		public bool isLoggable(Level arg0)
		{
			return Instance.CallMethod<bool>("isLoggable", "(Ljava/util/logging/Level;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V")]
		public void entering(String arg0, String arg1, ObjectArray<IJavaObject> arg2)
		{
			Instance.CallMethod("entering", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)V")]
		public void entering(String arg0, String arg1)
		{
			Instance.CallMethod("entering", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V")]
		public void entering(String arg0, String arg1, IJavaObject arg2)
		{
			Instance.CallMethod("entering", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V")]
		public void exiting(String arg0, String arg1, IJavaObject arg2)
		{
			Instance.CallMethod("exiting", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)V")]
		public void exiting(String arg0, String arg1)
		{
			Instance.CallMethod("exiting", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void fine(String arg0)
		{
			Instance.CallMethod("fine", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)V")]
		public void fine(Supplier<String> arg0)
		{
			Instance.CallMethod("fine", "(Ljava/util/function/Supplier;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)V")]
		public void finer(Supplier<String> arg0)
		{
			Instance.CallMethod("finer", "(Ljava/util/function/Supplier;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void finer(String arg0)
		{
			Instance.CallMethod("finer", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void finest(String arg0)
		{
			Instance.CallMethod("finest", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)V")]
		public void finest(Supplier<String> arg0)
		{
			Instance.CallMethod("finest", "(Ljava/util/function/Supplier;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/logging/Logger;")]
		public static Logger getAnonymousLogger(String arg0)
		{
			return Static.CallMethod<Logger>(typeof(Logger), "getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", arg0);
		}
		
		[JavaSignature("()Ljava/util/logging/Logger;")]
		public static Logger getAnonymousLogger()
		{
			return Static.CallMethod<Logger>(typeof(Logger), "getAnonymousLogger", "()Ljava/util/logging/Logger;");
		}
		
		[JavaSignature("()Ljava/util/logging/Logger;")]
		public static Logger getGlobal()
		{
			return Static.CallMethod<Logger>(typeof(Logger), "getGlobal", "()Ljava/util/logging/Logger;");
		}
		
		[JavaSignature("()Z")]
		public bool getUseParentHandlers()
		{
			return Instance.CallMethod<bool>("getUseParentHandlers", "()Z");
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;)V")]
		public void logp(Level arg0, String arg1, String arg2, Supplier<String> arg3)
		{
			Instance.CallMethod("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/function/Supplier;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V")]
		public void logp(Level arg0, String arg1, String arg2, String arg3, IJavaObject arg4)
		{
			Instance.CallMethod("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V")]
		public void logp(Level arg0, String arg1, String arg2, String arg3)
		{
			Instance.CallMethod("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V")]
		public void logp(Level arg0, String arg1, String arg2, Throwable arg3, Supplier<String> arg4)
		{
			Instance.CallMethod("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/function/Supplier;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V")]
		public void logp(Level arg0, String arg1, String arg2, String arg3, Throwable arg4)
		{
			Instance.CallMethod("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V")]
		public void logp(Level arg0, String arg1, String arg2, String arg3, ObjectArray<IJavaObject> arg4)
		{
			Instance.CallMethod("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V")]
		public void logrb(Level arg0, String arg1, String arg2, String arg3, String arg4, Throwable arg5)
		{
			Instance.CallMethod("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V")]
		public void logrb(Level arg0, String arg1, String arg2, String arg3, String arg4, IJavaObject arg5)
		{
			Instance.CallMethod("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V")]
		public void logrb(Level arg0, String arg1, String arg2, ResourceBundle arg3, String arg4, Throwable arg5)
		{
			Instance.CallMethod("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V")]
		public void logrb(Level arg0, String arg1, String arg2, String arg3, String arg4)
		{
			Instance.CallMethod("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V")]
		public void logrb(Level arg0, String arg1, String arg2, String arg3, String arg4, ObjectArray<IJavaObject> arg5)
		{
			Instance.CallMethod("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V")]
		public void logrb(Level arg0, String arg1, String arg2, ResourceBundle arg3, String arg4, ObjectArray<IJavaObject> arg5)
		{
			Instance.CallMethod("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/util/ResourceBundle;Ljava/lang/String;[Ljava/lang/Object;)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void severe(String arg0)
		{
			Instance.CallMethod("severe", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)V")]
		public void severe(Supplier<String> arg0)
		{
			Instance.CallMethod("severe", "(Ljava/util/function/Supplier;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V")]
		public void throwing(String arg0, String arg1, Throwable arg2)
		{
			Instance.CallMethod("throwing", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1, arg2);
		}
	}
}
