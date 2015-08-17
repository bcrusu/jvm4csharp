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
	[JavaProxy("java/util/logging/ErrorManager")]
	public class ErrorManager : Object
	{
		protected ErrorManager(ProxyCtor p) : base(p) {}
		
		public ErrorManager() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("I")]
		public static int GENERIC_FAILURE
		{
			get { return Static.GetField<int>(typeof(ErrorManager), "GENERIC_FAILURE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int WRITE_FAILURE
		{
			get { return Static.GetField<int>(typeof(ErrorManager), "WRITE_FAILURE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FLUSH_FAILURE
		{
			get { return Static.GetField<int>(typeof(ErrorManager), "FLUSH_FAILURE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int CLOSE_FAILURE
		{
			get { return Static.GetField<int>(typeof(ErrorManager), "CLOSE_FAILURE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int OPEN_FAILURE
		{
			get { return Static.GetField<int>(typeof(ErrorManager), "OPEN_FAILURE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FORMAT_FAILURE
		{
			get { return Static.GetField<int>(typeof(ErrorManager), "FORMAT_FAILURE", "I"); }
		}
	
		[JavaSignature("(Ljava/lang/String;Ljava/lang/Exception;I)V")]
		public void error(String arg0, Exception arg1, int arg2)
		{
			Instance.CallMethod("error", "(Ljava/lang/String;Ljava/lang/Exception;I)V", arg0, arg1, arg2);
		}
	}
}
