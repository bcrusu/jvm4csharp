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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/StackTraceElement")]
	public class StackTraceElement : Object, Serializable
	{
		protected StackTraceElement(ProxyCtor p) : base(p) {}
		
		public StackTraceElement(String arg0, String arg1, String arg2, int arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", arg0, arg1, arg2, arg3);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getClassName()
		{
			return Instance.CallMethod<String>("getClassName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getFileName()
		{
			return Instance.CallMethod<String>("getFileName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getLineNumber()
		{
			return Instance.CallMethod<int>("getLineNumber", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getMethodName()
		{
			return Instance.CallMethod<String>("getMethodName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isNativeMethod()
		{
			return Instance.CallMethod<bool>("isNativeMethod", "()Z");
		}
	}
}
