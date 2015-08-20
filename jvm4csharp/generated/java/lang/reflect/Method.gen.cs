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
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/Method")]
	public partial class Method : Executable
	{
		protected Method(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject invoke(IJavaObject arg0, ObjectArray<IJavaObject> arg1)
		{
			return Instance.CallMethod<IJavaObject>("invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getReturnType()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getReturnType", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Z")]
		public bool isDefault()
		{
			return Instance.CallMethod<bool>("isDefault", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject getDefaultValue()
		{
			return Instance.CallMethod<IJavaObject>("getDefaultValue", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/Type;")]
		public Type getGenericReturnType()
		{
			return Instance.CallMethod<Type>("getGenericReturnType", "()Ljava/lang/reflect/Type;");
		}
		
		[JavaSignature("()Z")]
		public bool isBridge()
		{
			return Instance.CallMethod<bool>("isBridge", "()Z");
		}
	}
}
