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
using jvm4csharp.java.nio.channels;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/FileInputStream")]
	public partial class FileInputStream : InputStream
	{
		protected FileInputStream(ProxyCtor p) : base(p) {}
		
		public FileInputStream(FileDescriptor arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/FileDescriptor;)V", arg0);
		}
		
		public FileInputStream(File arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;)V", arg0);
		}
		
		public FileInputStream(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("()Ljava/nio/channels/FileChannel;")]
		public FileChannel getChannel()
		{
			return Instance.CallMethod<FileChannel>("getChannel", "()Ljava/nio/channels/FileChannel;");
		}
		
		[JavaSignature("()Ljava/io/FileDescriptor;")]
		public FileDescriptor getFD()
		{
			return Instance.CallMethod<FileDescriptor>("getFD", "()Ljava/io/FileDescriptor;");
		}
	}
}
