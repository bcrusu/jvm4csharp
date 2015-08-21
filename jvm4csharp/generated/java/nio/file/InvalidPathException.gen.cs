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
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/InvalidPathException")]
	public partial class InvalidPathException : IllegalArgumentException
	{
		protected InvalidPathException(ProxyCtor p) : base(p) {}
		
		public InvalidPathException(String arg0, String arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;I)V", arg0, arg1, arg2);
		}
		
		public InvalidPathException(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getInput()
		{
			return Instance.CallMethod<String>("getInput", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getReason()
		{
			return Instance.CallMethod<String>("getReason", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getIndex()
		{
			return Instance.CallMethod<int>("getIndex", "()I");
		}
	}
}
