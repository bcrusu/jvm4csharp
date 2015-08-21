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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/Paths")]
	public partial class Paths : Object
	{
		protected Paths(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;")]
		public static Path @get(String arg0, ObjectArray<String> arg1)
		{
			return Static.CallMethod<Path>(typeof(Paths), "get", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/net/URI;)Ljava/nio/file/Path;")]
		public static Path @get(URI arg0)
		{
			return Static.CallMethod<Path>(typeof(Paths), "get", "(Ljava/net/URI;)Ljava/nio/file/Path;", arg0);
		}
	}
}
