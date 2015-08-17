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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/MemoryType")]
	public class MemoryType : Enum<MemoryType>
	{
		protected MemoryType(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/lang/management/MemoryType;")]
		public static MemoryType HEAP
		{
			get { return Static.GetField<MemoryType>(typeof(MemoryType), "HEAP", "Ljava/lang/management/MemoryType;"); }
		}
		
		[JavaSignature("Ljava/lang/management/MemoryType;")]
		public static MemoryType NON_HEAP
		{
			get { return Static.GetField<MemoryType>(typeof(MemoryType), "NON_HEAP", "Ljava/lang/management/MemoryType;"); }
		}
	
		[JavaSignature("()[Ljava/lang/management/MemoryType;")]
		public static ObjectArray<MemoryType> values()
		{
			return Static.CallMethod<ObjectArray<MemoryType>>(typeof(MemoryType), "values", "()[Ljava/lang/management/MemoryType;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/management/MemoryType;")]
		public static MemoryType valueOf(String arg0)
		{
			return Static.CallMethod<MemoryType>(typeof(MemoryType), "valueOf", "(Ljava/lang/String;)Ljava/lang/management/MemoryType;", arg0);
		}
	}
}
