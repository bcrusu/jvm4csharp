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
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/MethodHandleProxies")]
	public class MethodHandleProxies : Object
	{
		protected MethodHandleProxies(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/Object;")]
		public static T asInterfaceInstance<T>(Class<T> arg0, MethodHandle arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<T>(typeof(MethodHandleProxies), "asInterfaceInstance", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public static bool isWrapperInstance(IJavaObject arg0)
		{
			return Static.CallMethod<bool>(typeof(MethodHandleProxies), "isWrapperInstance", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;")]
		public static MethodHandle wrapperInstanceTarget(IJavaObject arg0)
		{
			return Static.CallMethod<MethodHandle>(typeof(MethodHandleProxies), "wrapperInstanceTarget", "(Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Class;")]
		public static Class<IJavaObject> wrapperInstanceType(IJavaObject arg0)
		{
			return Static.CallMethod<Class<IJavaObject>>(typeof(MethodHandleProxies), "wrapperInstanceType", "(Ljava/lang/Object;)Ljava/lang/Class;", arg0);
		}
	}
}
