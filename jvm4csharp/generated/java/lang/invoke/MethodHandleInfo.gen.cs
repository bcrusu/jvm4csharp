//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang.reflect;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.invoke
{
	[JavaProxy("java/lang/invoke/MethodHandleInfo")]
	public partial interface MethodHandleInfo : IJavaObject
	{
		[JavaSignature("()I")]
		int getModifiers();
		
		[JavaSignature("()Ljava/lang/String;")]
		String getName();
		
		[JavaSignature("()Ljava/lang/Class;")]
		Class<IJavaObject> getDeclaringClass();
		
		[JavaSignature("()Z")]
		bool isVarArgs();
		
		[JavaSignature("()Ljava/lang/invoke/MethodType;")]
		MethodType getMethodType();
		
		[JavaSignature("()I")]
		int getReferenceKind();
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandles/Lookup;)Ljava/lang/reflect/Member;")]
		T reflectAs<T>(Class<T> arg0, MethodHandles_.Lookup arg1)
			where T : Member;
	}
	
	public static partial class MethodHandleInfo_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("I")]
		public static int REF_getField
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_getField", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_getStatic
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_getStatic", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_putField
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_putField", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_putStatic
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_putStatic", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_invokeVirtual
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_invokeVirtual", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_invokeStatic
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_invokeStatic", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_invokeSpecial
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_invokeSpecial", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_newInvokeSpecial
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_newInvokeSpecial", "I"); }
		}
		
		[JavaSignature("I")]
		public static int REF_invokeInterface
		{
			get { return Static.GetField<int>(typeof(MethodHandleInfo), "REF_invokeInterface", "I"); }
		}
		
		[JavaSignature("(ILjava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/String;")]
		public static String toString(int arg0, Class<IJavaObject> arg1, String arg2, MethodType arg3)
		{
			return Static.CallMethod<String>(typeof(MethodHandleInfo), "toString", "(ILjava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/String;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String referenceKindToString(int arg0)
		{
			return Static.CallMethod<String>(typeof(MethodHandleInfo), "referenceKindToString", "(I)Ljava/lang/String;", arg0);
		}
	
	}
}
