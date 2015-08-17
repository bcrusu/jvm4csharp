//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.management
{
	[JavaProxy("java/lang/management/ManagementFactory")]
	public class ManagementFactory : Object
	{
		protected ManagementFactory(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/lang/String;")]
		public static String CLASS_LOADING_MXBEAN_NAME
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "CLASS_LOADING_MXBEAN_NAME", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String COMPILATION_MXBEAN_NAME
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "COMPILATION_MXBEAN_NAME", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String MEMORY_MXBEAN_NAME
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "MEMORY_MXBEAN_NAME", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String OPERATING_SYSTEM_MXBEAN_NAME
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "OPERATING_SYSTEM_MXBEAN_NAME", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String RUNTIME_MXBEAN_NAME
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "RUNTIME_MXBEAN_NAME", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String THREAD_MXBEAN_NAME
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "THREAD_MXBEAN_NAME", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String GARBAGE_COLLECTOR_MXBEAN_DOMAIN_TYPE
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "GARBAGE_COLLECTOR_MXBEAN_DOMAIN_TYPE", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String MEMORY_MANAGER_MXBEAN_DOMAIN_TYPE
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "MEMORY_MANAGER_MXBEAN_DOMAIN_TYPE", "Ljava/lang/String;"); }
		}
		
		[JavaSignature("Ljava/lang/String;")]
		public static String MEMORY_POOL_MXBEAN_DOMAIN_TYPE
		{
			get { return Static.GetField<String>(typeof(ManagementFactory), "MEMORY_POOL_MXBEAN_DOMAIN_TYPE", "Ljava/lang/String;"); }
		}
	
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/management/PlatformManagedObject;")]
		public static T getPlatformMXBean<T>(Class<T> arg0)
			where T : PlatformManagedObject
		{
			return Static.CallMethod<T>(typeof(ManagementFactory), "getPlatformMXBean", "(Ljava/lang/Class;)Ljava/lang/management/PlatformManagedObject;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/util/List;")]
		public static List<T> getPlatformMXBeans<T>(Class<T> arg0)
			where T : PlatformManagedObject
		{
			return Static.CallMethod<List<T>>(typeof(ManagementFactory), "getPlatformMXBeans", "(Ljava/lang/Class;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public static Set<Class<PlatformManagedObject>> getPlatformManagementInterfaces()
		{
			return Static.CallMethod<Set<Class<PlatformManagedObject>>>(typeof(ManagementFactory), "getPlatformManagementInterfaces", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public static List<MemoryManagerMXBean> getMemoryManagerMXBeans()
		{
			return Static.CallMethod<List<MemoryManagerMXBean>>(typeof(ManagementFactory), "getMemoryManagerMXBeans", "()Ljava/util/List;");
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public static List<MemoryPoolMXBean> getMemoryPoolMXBeans()
		{
			return Static.CallMethod<List<MemoryPoolMXBean>>(typeof(ManagementFactory), "getMemoryPoolMXBeans", "()Ljava/util/List;");
		}
		
		[JavaSignature("()Ljava/lang/management/OperatingSystemMXBean;")]
		public static OperatingSystemMXBean getOperatingSystemMXBean()
		{
			return Static.CallMethod<OperatingSystemMXBean>(typeof(ManagementFactory), "getOperatingSystemMXBean", "()Ljava/lang/management/OperatingSystemMXBean;");
		}
		
		[JavaSignature("()Ljava/lang/management/RuntimeMXBean;")]
		public static RuntimeMXBean getRuntimeMXBean()
		{
			return Static.CallMethod<RuntimeMXBean>(typeof(ManagementFactory), "getRuntimeMXBean", "()Ljava/lang/management/RuntimeMXBean;");
		}
		
		[JavaSignature("()Ljava/lang/management/ClassLoadingMXBean;")]
		public static ClassLoadingMXBean getClassLoadingMXBean()
		{
			return Static.CallMethod<ClassLoadingMXBean>(typeof(ManagementFactory), "getClassLoadingMXBean", "()Ljava/lang/management/ClassLoadingMXBean;");
		}
		
		[JavaSignature("()Ljava/lang/management/CompilationMXBean;")]
		public static CompilationMXBean getCompilationMXBean()
		{
			return Static.CallMethod<CompilationMXBean>(typeof(ManagementFactory), "getCompilationMXBean", "()Ljava/lang/management/CompilationMXBean;");
		}
		
		[JavaSignature("()Ljava/lang/management/MemoryMXBean;")]
		public static MemoryMXBean getMemoryMXBean()
		{
			return Static.CallMethod<MemoryMXBean>(typeof(ManagementFactory), "getMemoryMXBean", "()Ljava/lang/management/MemoryMXBean;");
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public static List<GarbageCollectorMXBean> getGarbageCollectorMXBeans()
		{
			return Static.CallMethod<List<GarbageCollectorMXBean>>(typeof(ManagementFactory), "getGarbageCollectorMXBeans", "()Ljava/util/List;");
		}
		
		[JavaSignature("()Ljava/lang/management/ThreadMXBean;")]
		public static ThreadMXBean getThreadMXBean()
		{
			return Static.CallMethod<ThreadMXBean>(typeof(ManagementFactory), "getThreadMXBean", "()Ljava/lang/management/ThreadMXBean;");
		}
	}
}
