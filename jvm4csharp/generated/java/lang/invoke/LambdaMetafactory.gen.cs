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
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/LambdaMetafactory")]
	public class LambdaMetafactory : Object
	{
		protected LambdaMetafactory(ProxyCtor p) : base(p) {}
		
		public LambdaMetafactory() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("I")]
		public static int FLAG_SERIALIZABLE
		{
			get { return Static.GetField<int>(typeof(LambdaMetafactory), "FLAG_SERIALIZABLE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FLAG_MARKERS
		{
			get { return Static.GetField<int>(typeof(LambdaMetafactory), "FLAG_MARKERS", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FLAG_BRIDGES
		{
			get { return Static.GetField<int>(typeof(LambdaMetafactory), "FLAG_BRIDGES", "I"); }
		}
	
		[JavaSignature("(Ljava/lang/invoke/MethodHandles/Lookup;Ljava/lang/String;Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/CallSite;")]
		public static CallSite metafactory(MethodHandles.Lookup arg0, String arg1, MethodType arg2, MethodType arg3, MethodHandle arg4, MethodType arg5)
		{
			return Static.CallMethod<CallSite>(typeof(LambdaMetafactory), "metafactory", "(Ljava/lang/invoke/MethodHandles/Lookup;Ljava/lang/String;Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/CallSite;", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(Ljava/lang/invoke/MethodHandles/Lookup;Ljava/lang/String;Ljava/lang/invoke/MethodType;[Ljava/lang/Object;)Ljava/lang/invoke/CallSite;")]
		public static CallSite altMetafactory(MethodHandles.Lookup arg0, String arg1, MethodType arg2, ObjectArray<IJavaObject> arg3)
		{
			return Static.CallMethod<CallSite>(typeof(LambdaMetafactory), "altMetafactory", "(Ljava/lang/invoke/MethodHandles/Lookup;Ljava/lang/String;Ljava/lang/invoke/MethodType;[Ljava/lang/Object;)Ljava/lang/invoke/CallSite;", arg0, arg1, arg2, arg3);
		}
	}
}
