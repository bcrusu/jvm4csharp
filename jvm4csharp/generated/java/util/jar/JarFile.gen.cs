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
using jvm4csharp.java.lang;
using jvm4csharp.java.util.zip;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.jar
{
	[JavaProxy("java/util/jar/JarFile")]
	public partial class JarFile : ZipFile
	{
		protected JarFile(ProxyCtor p) : base(p) {}
		
		public JarFile(File arg0, bool arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;ZI)V", arg0, arg1, arg2);
		}
		
		public JarFile(File arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Z)V", arg0, arg1);
		}
		
		public JarFile(File arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;)V", arg0);
		}
		
		public JarFile(String arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Z)V", arg0, arg1);
		}
		
		public JarFile(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("Ljava/lang/String;")]
		public static String MANIFEST_NAME
		{
			get { return Static.GetField<String>(typeof(JarFile), "MANIFEST_NAME", "Ljava/lang/String;"); }
		}
	
		[JavaSignature("()Ljava/util/jar/Manifest;")]
		public Manifest getManifest()
		{
			return Instance.CallMethod<Manifest>("getManifest", "()Ljava/util/jar/Manifest;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/jar/JarEntry;")]
		public JarEntry getJarEntry(String arg0)
		{
			return Instance.CallMethod<JarEntry>("getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;", arg0);
		}
	}
}
