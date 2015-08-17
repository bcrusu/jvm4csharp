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
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/CheckedOutputStream")]
	public class CheckedOutputStream : FilterOutputStream
	{
		protected CheckedOutputStream(ProxyCtor p) : base(p) {}
		
		public CheckedOutputStream(OutputStream arg0, Checksum arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/zip/Checksum;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/util/zip/Checksum;")]
		public Checksum getChecksum()
		{
			return Instance.CallMethod<Checksum>("getChecksum", "()Ljava/util/zip/Checksum;");
		}
	}
}
