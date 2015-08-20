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
using jvm4csharp.java.util.zip;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.jar
{
	[JavaProxy("java/util/jar/JarEntry")]
	public partial class JarEntry : ZipEntry
	{
		protected JarEntry(ProxyCtor p) : base(p) {}
		
		public JarEntry(JarEntry arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/jar/JarEntry;)V", arg0);
		}
		
		public JarEntry(ZipEntry arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/zip/ZipEntry;)V", arg0);
		}
		
		public JarEntry(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("()Ljava/util/jar/Attributes;")]
		public Attributes getAttributes()
		{
			return Instance.CallMethod<Attributes>("getAttributes", "()Ljava/util/jar/Attributes;");
		}
	}
}
