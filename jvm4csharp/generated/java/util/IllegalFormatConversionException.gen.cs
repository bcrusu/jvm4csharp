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
	[JavaProxy("java/util/IllegalFormatConversionException")]
	public class IllegalFormatConversionException : IllegalFormatException
	{
		protected IllegalFormatConversionException(ProxyCtor p) : base(p) {}
		
		public IllegalFormatConversionException(char arg0, Class<IJavaObject> arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(CLjava/lang/Class;)V", arg0, arg1);
		}
	
		[JavaSignature("()C")]
		public char getConversion()
		{
			return Instance.CallMethod<char>("getConversion", "()C");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getArgumentClass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getArgumentClass", "()Ljava/lang/Class;");
		}
	}
}
