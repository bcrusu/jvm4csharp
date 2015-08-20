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
using jvm4csharp.java.util.jar;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/JarURLConnection")]
	public abstract partial class JarURLConnection : URLConnection
	{
		protected JarURLConnection(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/jar/Attributes;")]
		public Attributes getAttributes()
		{
			return Instance.CallMethod<Attributes>("getAttributes", "()Ljava/util/jar/Attributes;");
		}
		
		[JavaSignature("()Ljava/util/jar/JarFile;")]
		public JarFile getJarFile()
		{
			return Instance.CallMethod<JarFile>("getJarFile", "()Ljava/util/jar/JarFile;");
		}
		
		[JavaSignature("()Ljava/net/URL;")]
		public URL getJarFileURL()
		{
			return Instance.CallMethod<URL>("getJarFileURL", "()Ljava/net/URL;");
		}
		
		[JavaSignature("()Ljava/util/jar/Attributes;")]
		public Attributes getMainAttributes()
		{
			return Instance.CallMethod<Attributes>("getMainAttributes", "()Ljava/util/jar/Attributes;");
		}
		
		[JavaSignature("()Ljava/util/jar/Manifest;")]
		public Manifest getManifest()
		{
			return Instance.CallMethod<Manifest>("getManifest", "()Ljava/util/jar/Manifest;");
		}
		
		[JavaSignature("()Ljava/util/jar/JarEntry;")]
		public JarEntry getJarEntry()
		{
			return Instance.CallMethod<JarEntry>("getJarEntry", "()Ljava/util/jar/JarEntry;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getEntryName()
		{
			return Instance.CallMethod<String>("getEntryName", "()Ljava/lang/String;");
		}
	}
}
