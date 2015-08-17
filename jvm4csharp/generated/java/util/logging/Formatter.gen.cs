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
	[JavaProxy("java/util/logging/Formatter")]
	public abstract class Formatter : Object
	{
		protected Formatter(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/logging/LogRecord;)Ljava/lang/String;")]
		public String format(LogRecord arg0)
		{
			return Instance.CallMethod<String>("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Handler;)Ljava/lang/String;")]
		public String getHead(Handler arg0)
		{
			return Instance.CallMethod<String>("getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/Handler;)Ljava/lang/String;")]
		public String getTail(Handler arg0)
		{
			return Instance.CallMethod<String>("getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/util/logging/LogRecord;)Ljava/lang/String;")]
		public String formatMessage(LogRecord arg0)
		{
			return Instance.CallMethod<String>("formatMessage", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", arg0);
		}
	}
}
