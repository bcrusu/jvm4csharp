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
namespace jvm4csharp.java.nio.file.spi
{
	[JavaProxy("java/nio/file/spi/FileTypeDetector")]
	public abstract class FileTypeDetector : Object
	{
		protected FileTypeDetector(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/nio/file/Path;)Ljava/lang/String;")]
		public String probeContentType(Path arg0)
		{
			return Instance.CallMethod<String>("probeContentType", "(Ljava/nio/file/Path;)Ljava/lang/String;", arg0);
		}
	}
}
