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
using jvm4csharp.java.nio.file.attribute;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/FileStore")]
	public abstract class FileStore : Object
	{
		protected FileStore(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String name()
		{
			return Instance.CallMethod<String>("name", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String type()
		{
			return Instance.CallMethod<String>("type", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()J")]
		public long getTotalSpace()
		{
			return Instance.CallMethod<long>("getTotalSpace", "()J");
		}
		
		[JavaSignature("()J")]
		public long getUsableSpace()
		{
			return Instance.CallMethod<long>("getUsableSpace", "()J");
		}
		
		[JavaSignature("()Z")]
		public bool isReadOnly()
		{
			return Instance.CallMethod<bool>("isReadOnly", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Object;")]
		public IJavaObject getAttribute(String arg0)
		{
			return Instance.CallMethod<IJavaObject>("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/nio/file/attribute/FileStoreAttributeView;")]
		public V getFileStoreAttributeView<V>(Class<V> arg0)
			where V : FileStoreAttributeView
		{
			return Instance.CallMethod<V>("getFileStoreAttributeView", "(Ljava/lang/Class;)Ljava/nio/file/attribute/FileStoreAttributeView;", arg0);
		}
		
		[JavaSignature("()J")]
		public long getUnallocatedSpace()
		{
			return Instance.CallMethod<long>("getUnallocatedSpace", "()J");
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool supportsFileAttributeView(String arg0)
		{
			return Instance.CallMethod<bool>("supportsFileAttributeView", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public bool supportsFileAttributeView(Class<FileAttributeView> arg0)
		{
			return Instance.CallMethod<bool>("supportsFileAttributeView", "(Ljava/lang/Class;)Z", arg0);
		}
	}
}
