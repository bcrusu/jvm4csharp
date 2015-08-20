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
namespace jvm4csharp.java.util.logging
{
	[JavaProxy("java/util/logging/StreamHandler")]
	public partial class StreamHandler : Handler
	{
		protected StreamHandler(ProxyCtor p) : base(p) {}
		
		public StreamHandler(OutputStream arg0, Formatter arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V", arg0, arg1);
		}
		
		public StreamHandler() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	}
}
