//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/MemoryNotificationInfo")]
	public class MemoryNotificationInfo : Object
	{
		protected MemoryNotificationInfo(ProxyCtor p) : base(p) {}
		
		public MemoryNotificationInfo(String arg0, MemoryUsage arg1, long arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/management/MemoryUsage;J)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("Ljava/lang/String;")]
		public static String MEMORY_THRESHOLD_EXCEEDED
		{
			get { return Static.GetField<String>(typeof(MemoryNotificationInfo), "MEMORY_THRESHOLD_EXCEEDED", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String MEMORY_COLLECTION_THRESHOLD_EXCEEDED
		{
			get { return Static.GetField<String>(typeof(MemoryNotificationInfo), "MEMORY_COLLECTION_THRESHOLD_EXCEEDED", "Ljava/lang/String;"); }
		}
	
		[JavaSignature("()J")]
		public long getCount()
		{
			return Instance.CallMethod<long>("getCount", "()J");
		}
		
		[JavaSignature("()Ljava/lang/management/MemoryUsage;")]
		public MemoryUsage getUsage()
		{
			return Instance.CallMethod<MemoryUsage>("getUsage", "()Ljava/lang/management/MemoryUsage;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPoolName()
		{
			return Instance.CallMethod<String>("getPoolName", "()Ljava/lang/String;");
		}
	}
}
