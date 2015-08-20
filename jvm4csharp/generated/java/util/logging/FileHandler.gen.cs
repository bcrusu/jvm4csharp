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
	[JavaProxy("java/util/logging/FileHandler")]
	public partial class FileHandler : StreamHandler
	{
		protected FileHandler(ProxyCtor p) : base(p) {}
		
		public FileHandler(String arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;II)V", arg0, arg1, arg2);
		}
		
		public FileHandler(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public FileHandler() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public FileHandler(String arg0, int arg1, int arg2, bool arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;IIZ)V", arg0, arg1, arg2, arg3);
		}
		
		public FileHandler(String arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Z)V", arg0, arg1);
		}
	}
}
