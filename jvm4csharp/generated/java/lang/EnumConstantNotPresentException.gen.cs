//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/EnumConstantNotPresentException")]
	public class EnumConstantNotPresentException : RuntimeException
	{
		protected EnumConstantNotPresentException(ProxyCtor p) : base(p) {}
		
		public EnumConstantNotPresentException(Class<Enum> arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Class;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String constantName()
		{
			return Instance.CallMethod<String>("constantName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<Enum> enumType()
		{
			return Instance.CallMethod<Class<Enum>>("enumType", "()Ljava/lang/Class;");
		}
	}
}
