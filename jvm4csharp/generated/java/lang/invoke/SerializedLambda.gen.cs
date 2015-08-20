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
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/SerializedLambda")]
	public partial class SerializedLambda : Object, Serializable
	{
		protected SerializedLambda(ProxyCtor p) : base(p) {}
		
		public SerializedLambda(Class<IJavaObject> arg0, String arg1, String arg2, String arg3, int arg4, String arg5, String arg6, String arg7, String arg8, ObjectArray<IJavaObject> arg9) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
	
		[JavaSignature("(I)Ljava/lang/Object;")]
		public IJavaObject getCapturedArg(int arg0)
		{
			return Instance.CallMethod<IJavaObject>("getCapturedArg", "(I)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getFunctionalInterfaceClass()
		{
			return Instance.CallMethod<String>("getFunctionalInterfaceClass", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getFunctionalInterfaceMethodName()
		{
			return Instance.CallMethod<String>("getFunctionalInterfaceMethodName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getFunctionalInterfaceMethodSignature()
		{
			return Instance.CallMethod<String>("getFunctionalInterfaceMethodSignature", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getImplClass()
		{
			return Instance.CallMethod<String>("getImplClass", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getImplMethodKind()
		{
			return Instance.CallMethod<int>("getImplMethodKind", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getImplMethodName()
		{
			return Instance.CallMethod<String>("getImplMethodName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getImplMethodSignature()
		{
			return Instance.CallMethod<String>("getImplMethodSignature", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getCapturedArgCount()
		{
			return Instance.CallMethod<int>("getCapturedArgCount", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCapturingClass()
		{
			return Instance.CallMethod<String>("getCapturingClass", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getInstantiatedMethodType()
		{
			return Instance.CallMethod<String>("getInstantiatedMethodType", "()Ljava/lang/String;");
		}
	}
}
