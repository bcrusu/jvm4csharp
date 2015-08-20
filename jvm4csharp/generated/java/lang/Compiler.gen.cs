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
	[JavaProxy("java/lang/Compiler")]
	public partial class Compiler : Object
	{
		protected Compiler(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public static IJavaObject command(IJavaObject arg0)
		{
			return Static.CallMethod<IJavaObject>(typeof(Compiler), "command", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public static bool compileClass(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<bool>(typeof(Compiler), "compileClass", "(Ljava/lang/Class;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public static bool compileClasses(String arg0)
		{
			return Static.CallMethod<bool>(typeof(Compiler), "compileClasses", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("()V")]
		public static void disable()
		{
			Static.CallMethod(typeof(Compiler), "disable", "()V");
		}
		
		[JavaSignature("()V")]
		public static void enable()
		{
			Static.CallMethod(typeof(Compiler), "enable", "()V");
		}
	}
}
