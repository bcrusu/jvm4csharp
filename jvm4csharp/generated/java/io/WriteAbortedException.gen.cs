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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/WriteAbortedException")]
	public class WriteAbortedException : ObjectStreamException
	{
		protected WriteAbortedException(ProxyCtor p) : base(p) {}
		
		public WriteAbortedException(String arg0, Exception arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/Exception;)V", arg0, arg1);
		}
	
		[JavaSignature("Ljava/lang/Exception;")]
		public Exception detail
		{
			get { return Instance.GetField<Exception>("detail", "Ljava/lang/Exception;"); }
			set { Instance.SetField("detail", "Ljava/lang/Exception;", value); }
		}
	}
}
