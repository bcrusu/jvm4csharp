//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;
using jvm4csharp.java.net;
using jvm4csharp.java.nio.file;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/File")]
	public partial class File : Object, Serializable, Comparable<File>
	{
		protected File(ProxyCtor p) : base(p) {}
		
		public File(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public File(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public File(File arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public File(URI arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/net/URI;)V", arg0);
		}
	
		[JavaSignature("C")]
		public static char separatorChar
		{
			get { return Static.GetField<char>(typeof(File), "separatorChar", "C"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String separator
		{
			get { return Static.GetField<String>(typeof(File), "separator", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("C")]
		public static char pathSeparatorChar
		{
			get { return Static.GetField<char>(typeof(File), "pathSeparatorChar", "C"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String pathSeparator
		{
			get { return Static.GetField<String>(typeof(File), "pathSeparator", "Ljava/lang/String;"); }
		}
	
		[JavaSignature("(Ljava/io/File;)I")]
		public int compareTo(File arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/io/File;)I", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()J")]
		public long length()
		{
			return Instance.CallMethod<long>("length", "()J");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCanonicalPath()
		{
			return Instance.CallMethod<String>("getCanonicalPath", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getParent()
		{
			return Instance.CallMethod<String>("getParent", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isAbsolute()
		{
			return Instance.CallMethod<bool>("isAbsolute", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool delete()
		{
			return Instance.CallMethod<bool>("delete", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool setReadOnly()
		{
			return Instance.CallMethod<bool>("setReadOnly", "()Z");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> list()
		{
			return Instance.CallMethod<ObjectArray<String>>("list", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/io/FilenameFilter;)[Ljava/lang/String;")]
		public ObjectArray<String> list(FilenameFilter arg0)
		{
			return Instance.CallMethod<ObjectArray<String>>("list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool canExecute()
		{
			return Instance.CallMethod<bool>("canExecute", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool canRead()
		{
			return Instance.CallMethod<bool>("canRead", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool canWrite()
		{
			return Instance.CallMethod<bool>("canWrite", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool createNewFile()
		{
			return Instance.CallMethod<bool>("createNewFile", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;")]
		public static File createTempFile(String arg0, String arg1, File arg2)
		{
			return Static.CallMethod<File>(typeof(File), "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;")]
		public static File createTempFile(String arg0, String arg1)
		{
			return Static.CallMethod<File>(typeof(File), "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;", arg0, arg1);
		}
		
		[JavaSignature("()V")]
		public void deleteOnExit()
		{
			Instance.CallMethod("deleteOnExit", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool exists()
		{
			return Instance.CallMethod<bool>("exists", "()Z");
		}
		
		[JavaSignature("()Ljava/io/File;")]
		public File getAbsoluteFile()
		{
			return Instance.CallMethod<File>("getAbsoluteFile", "()Ljava/io/File;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getAbsolutePath()
		{
			return Instance.CallMethod<String>("getAbsolutePath", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/io/File;")]
		public File getCanonicalFile()
		{
			return Instance.CallMethod<File>("getCanonicalFile", "()Ljava/io/File;");
		}
		
		[JavaSignature("()J")]
		public long getFreeSpace()
		{
			return Instance.CallMethod<long>("getFreeSpace", "()J");
		}
		
		[JavaSignature("()Ljava/io/File;")]
		public File getParentFile()
		{
			return Instance.CallMethod<File>("getParentFile", "()Ljava/io/File;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPath()
		{
			return Instance.CallMethod<String>("getPath", "()Ljava/lang/String;");
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
		public bool isDirectory()
		{
			return Instance.CallMethod<bool>("isDirectory", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isFile()
		{
			return Instance.CallMethod<bool>("isFile", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isHidden()
		{
			return Instance.CallMethod<bool>("isHidden", "()Z");
		}
		
		[JavaSignature("()J")]
		public long lastModified()
		{
			return Instance.CallMethod<long>("lastModified", "()J");
		}
		
		[JavaSignature("()[Ljava/io/File;")]
		public ObjectArray<File> listFiles()
		{
			return Instance.CallMethod<ObjectArray<File>>("listFiles", "()[Ljava/io/File;");
		}
		
		[JavaSignature("(Ljava/io/FilenameFilter;)[Ljava/io/File;")]
		public ObjectArray<File> listFiles(FilenameFilter arg0)
		{
			return Instance.CallMethod<ObjectArray<File>>("listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;", arg0);
		}
		
		[JavaSignature("(Ljava/io/FileFilter;)[Ljava/io/File;")]
		public ObjectArray<File> listFiles(FileFilter arg0)
		{
			return Instance.CallMethod<ObjectArray<File>>("listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;", arg0);
		}
		
		[JavaSignature("()[Ljava/io/File;")]
		public static ObjectArray<File> listRoots()
		{
			return Static.CallMethod<ObjectArray<File>>(typeof(File), "listRoots", "()[Ljava/io/File;");
		}
		
		[JavaSignature("()Z")]
		public bool mkdir()
		{
			return Instance.CallMethod<bool>("mkdir", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool mkdirs()
		{
			return Instance.CallMethod<bool>("mkdirs", "()Z");
		}
		
		[JavaSignature("(Ljava/io/File;)Z")]
		public bool renameTo(File arg0)
		{
			return Instance.CallMethod<bool>("renameTo", "(Ljava/io/File;)Z", arg0);
		}
		
		[JavaSignature("(ZZ)Z")]
		public bool setExecutable(bool arg0, bool arg1)
		{
			return Instance.CallMethod<bool>("setExecutable", "(ZZ)Z", arg0, arg1);
		}
		
		[JavaSignature("(Z)Z")]
		public bool setExecutable(bool arg0)
		{
			return Instance.CallMethod<bool>("setExecutable", "(Z)Z", arg0);
		}
		
		[JavaSignature("(J)Z")]
		public bool setLastModified(long arg0)
		{
			return Instance.CallMethod<bool>("setLastModified", "(J)Z", arg0);
		}
		
		[JavaSignature("(ZZ)Z")]
		public bool setReadable(bool arg0, bool arg1)
		{
			return Instance.CallMethod<bool>("setReadable", "(ZZ)Z", arg0, arg1);
		}
		
		[JavaSignature("(Z)Z")]
		public bool setReadable(bool arg0)
		{
			return Instance.CallMethod<bool>("setReadable", "(Z)Z", arg0);
		}
		
		[JavaSignature("(ZZ)Z")]
		public bool setWritable(bool arg0, bool arg1)
		{
			return Instance.CallMethod<bool>("setWritable", "(ZZ)Z", arg0, arg1);
		}
		
		[JavaSignature("(Z)Z")]
		public bool setWritable(bool arg0)
		{
			return Instance.CallMethod<bool>("setWritable", "(Z)Z", arg0);
		}
		
		[JavaSignature("()Ljava/nio/file/Path;")]
		public Path toPath()
		{
			return Instance.CallMethod<Path>("toPath", "()Ljava/nio/file/Path;");
		}
		
		[JavaSignature("()Ljava/net/URI;")]
		public URI toURI()
		{
			return Instance.CallMethod<URI>("toURI", "()Ljava/net/URI;");
		}
		
		[JavaSignature("()Ljava/net/URL;")]
		public URL toURL()
		{
			return Instance.CallMethod<URL>("toURL", "()Ljava/net/URL;");
		}
	}
}
