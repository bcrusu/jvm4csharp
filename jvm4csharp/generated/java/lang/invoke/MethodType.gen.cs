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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/MethodType")]
	public partial class MethodType : Object, Serializable
	{
		protected MethodType(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> returnType()
		{
			return Instance.CallMethod<Class<IJavaObject>>("returnType", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodType;")]
		public MethodType wrap()
		{
			return Instance.CallMethod<MethodType>("wrap", "()Ljava/lang/invoke/MethodType;");
		}
		
		[JavaSignature("(Ljava/util/List;)Ljava/lang/invoke/MethodType;")]
		public MethodType appendParameterTypes(List<Class<IJavaObject>> arg0)
		{
			return Instance.CallMethod<MethodType>("appendParameterTypes", "(Ljava/util/List;)Ljava/lang/invoke/MethodType;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public MethodType appendParameterTypes(ObjectArray<Class<IJavaObject>> arg0)
		{
			return Instance.CallMethod<MethodType>("appendParameterTypes", "([Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public MethodType changeReturnType(Class<IJavaObject> arg0)
		{
			return Instance.CallMethod<MethodType>("changeReturnType", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0);
		}
		
		[JavaSignature("(II)Ljava/lang/invoke/MethodType;")]
		public MethodType dropParameterTypes(int arg0, int arg1)
		{
			return Instance.CallMethod<MethodType>("dropParameterTypes", "(II)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/List;)Ljava/lang/invoke/MethodType;")]
		public MethodType insertParameterTypes(int arg0, List<Class<IJavaObject>> arg1)
		{
			return Instance.CallMethod<MethodType>("insertParameterTypes", "(ILjava/util/List;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(I[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public MethodType insertParameterTypes(int arg0, ObjectArray<Class<IJavaObject>> arg1)
		{
			return Instance.CallMethod<MethodType>("insertParameterTypes", "(I[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodType;")]
		public static MethodType methodType(Class<IJavaObject> arg0, MethodType arg1)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "methodType", "(Ljava/lang/Class;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public static MethodType methodType(Class<IJavaObject> arg0, Class<IJavaObject> arg1)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "methodType", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodType;")]
		public static MethodType methodType(Class<IJavaObject> arg0, List<Class<IJavaObject>> arg1)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "methodType", "(Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public static MethodType methodType(Class<IJavaObject> arg0, Class<IJavaObject> arg1, ObjectArray<Class<IJavaObject>> arg2)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "methodType", "(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public static MethodType methodType(Class<IJavaObject> arg0, ObjectArray<Class<IJavaObject>> arg1)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "methodType", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public static MethodType methodType(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "methodType", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0);
		}
		
		[JavaSignature("()I")]
		public int parameterCount()
		{
			return Instance.CallMethod<int>("parameterCount", "()I");
		}
		
		[JavaSignature("(I)Ljava/lang/invoke/MethodType;")]
		public static MethodType genericMethodType(int arg0)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "genericMethodType", "(I)Ljava/lang/invoke/MethodType;", arg0);
		}
		
		[JavaSignature("(IZ)Ljava/lang/invoke/MethodType;")]
		public static MethodType genericMethodType(int arg0, bool arg1)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "genericMethodType", "(IZ)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/lang/Class;")]
		public Class<IJavaObject> parameterType(int arg0)
		{
			return Instance.CallMethod<Class<IJavaObject>>("parameterType", "(I)Ljava/lang/Class;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodType;")]
		public MethodType erase()
		{
			return Instance.CallMethod<MethodType>("erase", "()Ljava/lang/invoke/MethodType;");
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/invoke/MethodType;")]
		public static MethodType fromMethodDescriptorString(String arg0, ClassLoader arg1)
		{
			return Static.CallMethod<MethodType>(typeof(MethodType), "fromMethodDescriptorString", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("()[Ljava/lang/Class;")]
		public ObjectArray<Class<IJavaObject>> parameterArray()
		{
			return Instance.CallMethod<ObjectArray<Class<IJavaObject>>>("parameterArray", "()[Ljava/lang/Class;");
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public List<Class<IJavaObject>> parameterList()
		{
			return Instance.CallMethod<List<Class<IJavaObject>>>("parameterList", "()Ljava/util/List;");
		}
		
		[JavaSignature("(ILjava/lang/Class;)Ljava/lang/invoke/MethodType;")]
		public MethodType changeParameterType(int arg0, Class<IJavaObject> arg1)
		{
			return Instance.CallMethod<MethodType>("changeParameterType", "(ILjava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodType;")]
		public MethodType generic()
		{
			return Instance.CallMethod<MethodType>("generic", "()Ljava/lang/invoke/MethodType;");
		}
		
		[JavaSignature("()Z")]
		public bool hasPrimitives()
		{
			return Instance.CallMethod<bool>("hasPrimitives", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasWrappers()
		{
			return Instance.CallMethod<bool>("hasWrappers", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toMethodDescriptorString()
		{
			return Instance.CallMethod<String>("toMethodDescriptorString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/invoke/MethodType;")]
		public MethodType unwrap()
		{
			return Instance.CallMethod<MethodType>("unwrap", "()Ljava/lang/invoke/MethodType;");
		}
	}
}
