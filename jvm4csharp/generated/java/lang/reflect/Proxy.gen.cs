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
using jvm4csharp.java.io;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/Proxy")]
	public partial class Proxy : Object, Serializable
	{
		protected Proxy(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Class;)Z")]
		public static bool isProxyClass(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<bool>(typeof(Proxy), "isProxyClass", "(Ljava/lang/Class;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/reflect/InvocationHandler;")]
		public static InvocationHandler getInvocationHandler(IJavaObject arg0)
		{
			return Static.CallMethod<InvocationHandler>(typeof(Proxy), "getInvocationHandler", "(Ljava/lang/Object;)Ljava/lang/reflect/InvocationHandler;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/ClassLoader;[Ljava/lang/Class;)Ljava/lang/Class;")]
		public static Class<IJavaObject> getProxyClass(ClassLoader arg0, ObjectArray<Class<IJavaObject>> arg1)
		{
			return Static.CallMethod<Class<IJavaObject>>(typeof(Proxy), "getProxyClass", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;)Ljava/lang/Class;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/ClassLoader;[Ljava/lang/Class;Ljava/lang/reflect/InvocationHandler;)Ljava/lang/Object;")]
		public static IJavaObject newProxyInstance(ClassLoader arg0, ObjectArray<Class<IJavaObject>> arg1, InvocationHandler arg2)
		{
			return Static.CallMethod<IJavaObject>(typeof(Proxy), "newProxyInstance", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;Ljava/lang/reflect/InvocationHandler;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
	}
}
