//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.logging
{
	[JavaProxy("java/util/logging/Handler")]
	public abstract partial class Handler : Object
	{
		protected Handler(ProxyCtor p) : base(p) {}
	
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
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getEncoding()
		{
			return Instance.CallMethod<String>("getEncoding", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/logging/LogRecord;)V")]
		public void publish(LogRecord arg0)
		{
			Instance.CallMethod("publish", "(Ljava/util/logging/LogRecord;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setEncoding(String arg0)
		{
			Instance.CallMethod("setEncoding", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Filter;)V")]
		public void setFilter(Filter arg0)
		{
			Instance.CallMethod("setFilter", "(Ljava/util/logging/Filter;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Formatter;)V")]
		public void setFormatter(Formatter arg0)
		{
			Instance.CallMethod("setFormatter", "(Ljava/util/logging/Formatter;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/logging/Formatter;")]
		public Formatter getFormatter()
		{
			return Instance.CallMethod<Formatter>("getFormatter", "()Ljava/util/logging/Formatter;");
		}
		
		[JavaSignature("()Ljava/util/logging/ErrorManager;")]
		public ErrorManager getErrorManager()
		{
			return Instance.CallMethod<ErrorManager>("getErrorManager", "()Ljava/util/logging/ErrorManager;");
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
		
		[JavaSignature("(Ljava/util/logging/ErrorManager;)V")]
		public void setErrorManager(ErrorManager arg0)
		{
			Instance.CallMethod("setErrorManager", "(Ljava/util/logging/ErrorManager;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;)V")]
		public void setLevel(Level arg0)
		{
			Instance.CallMethod("setLevel", "(Ljava/util/logging/Level;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/LogRecord;)Z")]
		public bool isLoggable(LogRecord arg0)
		{
			return Instance.CallMethod<bool>("isLoggable", "(Ljava/util/logging/LogRecord;)Z", arg0);
		}
	}
}
