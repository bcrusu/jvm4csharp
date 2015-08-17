//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.file
{
	[JavaProxy("java/nio/file/LinkOption")]
	public class LinkOption : Enum<LinkOption>, OpenOption, CopyOption
	{
		protected LinkOption(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/LinkOption;")]
		public static LinkOption NOFOLLOW_LINKS
		{
			get { return Static.GetField<LinkOption>(typeof(LinkOption), "NOFOLLOW_LINKS", "Ljava/nio/file/LinkOption;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/LinkOption;")]
		public static ObjectArray<LinkOption> values()
		{
			return Static.CallMethod<ObjectArray<LinkOption>>(typeof(LinkOption), "values", "()[Ljava/nio/file/LinkOption;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/LinkOption;")]
		public static LinkOption valueOf(String arg0)
		{
			return Static.CallMethod<LinkOption>(typeof(LinkOption), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/LinkOption;", arg0);
		}
	}
}
