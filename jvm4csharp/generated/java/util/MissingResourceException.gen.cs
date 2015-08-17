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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/MissingResourceException")]
	public class MissingResourceException : RuntimeException
	{
		protected MissingResourceException(ProxyCtor p) : base(p) {}
		
		public MissingResourceException(String arg0, String arg1, String arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getKey()
		{
			return Instance.CallMethod<String>("getKey", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getClassName()
		{
			return Instance.CallMethod<String>("getClassName", "()Ljava/lang/String;");
		}
	}
}
