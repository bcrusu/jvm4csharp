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
	[JavaProxy("java/lang/Throwable")]
	public partial class Throwable : global::System.Exception, Serializable
	{
		public Throwable(Throwable arg0)
		{
			Instance.CallConstructor("(Ljava/lang/Throwable;)V", arg0);
		}
		
		public Throwable(String arg0, Throwable arg1)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/Throwable;)V", arg0, arg1);
		}
		
		public Throwable(String arg0)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Throwable()
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()V")]
		public void printStackTrace()
		{
			Instance.CallMethod("printStackTrace", "()V");
		}
		
		[JavaSignature("(Ljava/io/PrintWriter;)V")]
		public void printStackTrace(PrintWriter arg0)
		{
			Instance.CallMethod("printStackTrace", "(Ljava/io/PrintWriter;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/PrintStream;)V")]
		public void printStackTrace(PrintStream arg0)
		{
			Instance.CallMethod("printStackTrace", "(Ljava/io/PrintStream;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Throwable;")]
		public Throwable fillInStackTrace()
		{
			return Instance.CallMethod<Throwable>("fillInStackTrace", "()Ljava/lang/Throwable;");
		}
		
		[JavaSignature("()Ljava/lang/Throwable;")]
		public Throwable getCause()
		{
			return Instance.CallMethod<Throwable>("getCause", "()Ljava/lang/Throwable;");
		}
		
		[JavaSignature("(Ljava/lang/Throwable;)Ljava/lang/Throwable;")]
		public Throwable initCause(Throwable arg0)
		{
			return Instance.CallMethod<Throwable>("initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Throwable;)V")]
		public void addSuppressed(Throwable arg0)
		{
			Instance.CallMethod("addSuppressed", "(Ljava/lang/Throwable;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getLocalizedMessage()
		{
			return Instance.CallMethod<String>("getLocalizedMessage", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getMessage()
		{
			return Instance.CallMethod<String>("getMessage", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/StackTraceElement;")]
		public ObjectArray<StackTraceElement> getStackTrace()
		{
			return Instance.CallMethod<ObjectArray<StackTraceElement>>("getStackTrace", "()[Ljava/lang/StackTraceElement;");
		}
		
		[JavaSignature("()[Ljava/lang/Throwable;")]
		public ObjectArray<Throwable> getSuppressed()
		{
			return Instance.CallMethod<ObjectArray<Throwable>>("getSuppressed", "()[Ljava/lang/Throwable;");
		}
		
		[JavaSignature("([Ljava/lang/StackTraceElement;)V")]
		public void setStackTrace(ObjectArray<StackTraceElement> arg0)
		{
			Instance.CallMethod("setStackTrace", "([Ljava/lang/StackTraceElement;)V", arg0);
		}
	}
}
