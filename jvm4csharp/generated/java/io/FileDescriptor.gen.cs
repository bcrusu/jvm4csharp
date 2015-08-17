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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/FileDescriptor")]
	public class FileDescriptor : Object
	{
		protected FileDescriptor(ProxyCtor p) : base(p) {}
		
		public FileDescriptor() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("Ljava/io/FileDescriptor;")]
		public static FileDescriptor @in
		{
			get { return Static.GetField<FileDescriptor>(typeof(FileDescriptor), "in", "Ljava/io/FileDescriptor;"); }
		}
		
		[JavaSignature("Ljava/io/FileDescriptor;")]
		public static FileDescriptor @out
		{
			get { return Static.GetField<FileDescriptor>(typeof(FileDescriptor), "out", "Ljava/io/FileDescriptor;"); }
		}
		
		[JavaSignature("Ljava/io/FileDescriptor;")]
		public static FileDescriptor err
		{
			get { return Static.GetField<FileDescriptor>(typeof(FileDescriptor), "err", "Ljava/io/FileDescriptor;"); }
		}
	
		[JavaSignature("()V")]
		public void sync()
		{
			Instance.CallMethod("sync", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool valid()
		{
			return Instance.CallMethod<bool>("valid", "()Z");
		}
	}
}
