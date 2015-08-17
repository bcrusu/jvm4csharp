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
using jvm4csharp.java.util.zip;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.jar
{
	[JavaProxy("java/util/jar/JarOutputStream")]
	public class JarOutputStream : ZipOutputStream
	{
		protected JarOutputStream(ProxyCtor p) : base(p) {}
		
		public JarOutputStream(OutputStream arg0, Manifest arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/util/jar/Manifest;)V", arg0, arg1);
		}
		
		public JarOutputStream(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
	}
}
