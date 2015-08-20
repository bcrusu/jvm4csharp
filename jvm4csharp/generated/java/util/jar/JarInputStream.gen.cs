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
	[JavaProxy("java/util/jar/JarInputStream")]
	public partial class JarInputStream : ZipInputStream
	{
		protected JarInputStream(ProxyCtor p) : base(p) {}
		
		public JarInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public JarInputStream(InputStream arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Z)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/util/jar/Manifest;")]
		public Manifest getManifest()
		{
			return Instance.CallMethod<Manifest>("getManifest", "()Ljava/util/jar/Manifest;");
		}
		
		[JavaSignature("()Ljava/util/jar/JarEntry;")]
		public JarEntry getNextJarEntry()
		{
			return Instance.CallMethod<JarEntry>("getNextJarEntry", "()Ljava/util/jar/JarEntry;");
		}
	}
}
