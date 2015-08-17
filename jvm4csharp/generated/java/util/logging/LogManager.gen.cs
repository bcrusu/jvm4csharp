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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.logging
{
	[JavaProxy("java/util/logging/LogManager")]
	public class LogManager : Object
	{
		protected LogManager(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/lang/String;")]
		public static String LOGGING_MXBEAN_NAME
		{
			get { return Static.GetField<String>(typeof(LogManager), "LOGGING_MXBEAN_NAME", "Ljava/lang/String;"); }
		}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String getProperty(String arg0)
		{
			return Instance.CallMethod<String>("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()V")]
		public void checkAccess()
		{
			Instance.CallMethod("checkAccess", "()V");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/logging/Logger;")]
		public Logger getLogger(String arg0)
		{
			return Instance.CallMethod<Logger>("getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Logger;)Z")]
		public bool addLogger(Logger arg0)
		{
			return Instance.CallMethod<bool>("addLogger", "(Ljava/util/logging/Logger;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/logging/LogManager;")]
		public static LogManager getLogManager()
		{
			return Static.CallMethod<LogManager>(typeof(LogManager), "getLogManager", "()Ljava/util/logging/LogManager;");
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<String> getLoggerNames()
		{
			return Instance.CallMethod<Enumeration<String>>("getLoggerNames", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("()Ljava/util/logging/LoggingMXBean;")]
		public static LoggingMXBean getLoggingMXBean()
		{
			return Static.CallMethod<LoggingMXBean>(typeof(LogManager), "getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;");
		}
		
		[JavaSignature("()V")]
		public void readConfiguration()
		{
			Instance.CallMethod("readConfiguration", "()V");
		}
		
		[JavaSignature("(Ljava/io/InputStream;)V")]
		public void readConfiguration(InputStream arg0)
		{
			Instance.CallMethod("readConfiguration", "(Ljava/io/InputStream;)V", arg0);
		}
	}
}
