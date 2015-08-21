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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.logging
{
	[JavaProxy("java/util/logging/LogRecord")]
	public partial class LogRecord : Object, Serializable
	{
		protected LogRecord(ProxyCtor p) : base(p) {}
		
		public LogRecord(Level arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/logging/Level;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getMessage()
		{
			return Instance.CallMethod<String>("getMessage", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/Object;")]
		public ObjectArray<IJavaObject> getParameters()
		{
			return Instance.CallMethod<ObjectArray<IJavaObject>>("getParameters", "()[Ljava/lang/Object;");
		}
		
		[JavaSignature("()J")]
		public long getMillis()
		{
			return Instance.CallMethod<long>("getMillis", "()J");
		}
		
		[JavaSignature("(J)V")]
		public void setMillis(long arg0)
		{
			Instance.CallMethod("setMillis", "(J)V", arg0);
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
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getLoggerName()
		{
			return Instance.CallMethod<String>("getLoggerName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/ResourceBundle;")]
		public ResourceBundle getResourceBundle()
		{
			return Instance.CallMethod<ResourceBundle>("getResourceBundle", "()Ljava/util/ResourceBundle;");
		}
		
		[JavaSignature("()J")]
		public long getSequenceNumber()
		{
			return Instance.CallMethod<long>("getSequenceNumber", "()J");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSourceClassName()
		{
			return Instance.CallMethod<String>("getSourceClassName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSourceMethodName()
		{
			return Instance.CallMethod<String>("getSourceMethodName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getThreadID()
		{
			return Instance.CallMethod<int>("getThreadID", "()I");
		}
		
		[JavaSignature("()Ljava/lang/Throwable;")]
		public Throwable getThrown()
		{
			return Instance.CallMethod<Throwable>("getThrown", "()Ljava/lang/Throwable;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setLoggerName(String arg0)
		{
			Instance.CallMethod("setLoggerName", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setMessage(String arg0)
		{
			Instance.CallMethod("setMessage", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;)V")]
		public void setParameters(ObjectArray<IJavaObject> arg0)
		{
			Instance.CallMethod("setParameters", "([Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/ResourceBundle;)V")]
		public void setResourceBundle(ResourceBundle arg0)
		{
			Instance.CallMethod("setResourceBundle", "(Ljava/util/ResourceBundle;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setResourceBundleName(String arg0)
		{
			Instance.CallMethod("setResourceBundleName", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setSequenceNumber(long arg0)
		{
			Instance.CallMethod("setSequenceNumber", "(J)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setSourceClassName(String arg0)
		{
			Instance.CallMethod("setSourceClassName", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setSourceMethodName(String arg0)
		{
			Instance.CallMethod("setSourceMethodName", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setThreadID(int arg0)
		{
			Instance.CallMethod("setThreadID", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Throwable;)V")]
		public void setThrown(Throwable arg0)
		{
			Instance.CallMethod("setThrown", "(Ljava/lang/Throwable;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Level;)V")]
		public void setLevel(Level arg0)
		{
			Instance.CallMethod("setLevel", "(Ljava/util/logging/Level;)V", arg0);
		}
	}
}
