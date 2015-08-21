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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/MethodHandle")]
	public abstract partial class MethodHandle : Object
	{
		protected MethodHandle(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject invoke(ObjectArray<IJavaObject> arg0)
		{
			return Instance.CallMethod<IJavaObject>("invoke", "([Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodType;")]
		public MethodType type()
		{
			return Instance.CallMethod<MethodType>("type", "()Ljava/lang/invoke/MethodType;");
		}
		
		[JavaSignature("(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle asCollector(Class<IJavaObject> arg0, int arg1)
		{
			return Instance.CallMethod<MethodHandle>("asCollector", "(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle asFixedArity()
		{
			return Instance.CallMethod<MethodHandle>("asFixedArity", "()Ljava/lang/invoke/MethodHandle;");
		}
		
		[JavaSignature("(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle asSpreader(Class<IJavaObject> arg0, int arg1)
		{
			return Instance.CallMethod<MethodHandle>("asSpreader", "(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle asType(MethodType arg0)
		{
			return Instance.CallMethod<MethodHandle>("asType", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle asVarargsCollector(Class<IJavaObject> arg0)
		{
			return Instance.CallMethod<MethodHandle>("asVarargsCollector", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;")]
		public MethodHandle bindTo(IJavaObject arg0)
		{
			return Instance.CallMethod<MethodHandle>("bindTo", "(Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject invokeExact(ObjectArray<IJavaObject> arg0)
		{
			return Instance.CallMethod<IJavaObject>("invokeExact", "([Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/List;)Ljava/lang/Object;")]
		public IJavaObject invokeWithArguments(List<IJavaObject> arg0)
		{
			return Instance.CallMethod<IJavaObject>("invokeWithArguments", "(Ljava/util/List;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject invokeWithArguments(ObjectArray<IJavaObject> arg0)
		{
			return Instance.CallMethod<IJavaObject>("invokeWithArguments", "([Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isVarargsCollector()
		{
			return Instance.CallMethod<bool>("isVarargsCollector", "()Z");
		}
	}
}
