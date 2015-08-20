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
	[JavaProxy("java/nio/file/AccessMode")]
	public partial class AccessMode : Enum<AccessMode>
	{
		protected AccessMode(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/file/AccessMode;")]
		public static AccessMode READ
		{
			get { return Static.GetField<AccessMode>(typeof(AccessMode), "READ", "Ljava/nio/file/AccessMode;"); }
		}
		
		[JavaSignature("Ljava/nio/file/AccessMode;")]
		public static AccessMode WRITE
		{
			get { return Static.GetField<AccessMode>(typeof(AccessMode), "WRITE", "Ljava/nio/file/AccessMode;"); }
		}
		
		[JavaSignature("Ljava/nio/file/AccessMode;")]
		public static AccessMode EXECUTE
		{
			get { return Static.GetField<AccessMode>(typeof(AccessMode), "EXECUTE", "Ljava/nio/file/AccessMode;"); }
		}
	
		[JavaSignature("()[Ljava/nio/file/AccessMode;")]
		public static ObjectArray<AccessMode> values()
		{
			return Static.CallMethod<ObjectArray<AccessMode>>(typeof(AccessMode), "values", "()[Ljava/nio/file/AccessMode;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/file/AccessMode;")]
		public static AccessMode valueOf(String arg0)
		{
			return Static.CallMethod<AccessMode>(typeof(AccessMode), "valueOf", "(Ljava/lang/String;)Ljava/nio/file/AccessMode;", arg0);
		}
	}
}
