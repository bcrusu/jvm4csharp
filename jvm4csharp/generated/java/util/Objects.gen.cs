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
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Objects")]
	public partial class Objects : Object
	{
		protected Objects(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([Ljava/lang/Object;)I")]
		public static int hash(ObjectArray<IJavaObject> arg0)
		{
			return Static.CallMethod<int>(typeof(Objects), "hash", "([Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public static bool equals(IJavaObject arg0, IJavaObject arg1)
		{
			return Static.CallMethod<bool>(typeof(Objects), "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/String;")]
		public static String toString(IJavaObject arg0)
		{
			return Static.CallMethod<String>(typeof(Objects), "toString", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;")]
		public static String toString(IJavaObject arg0, String arg1)
		{
			return Static.CallMethod<String>(typeof(Objects), "toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public static int hashCode(IJavaObject arg0)
		{
			return Static.CallMethod<int>(typeof(Objects), "hashCode", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I")]
		public static int compare<T>(T arg0, T arg1, Comparator<IJavaObject> arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<int>(typeof(Objects), "compare", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;")]
		public static T requireNonNull<T>(T arg0, Supplier<String> arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<T>(typeof(Objects), "requireNonNull", "(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;")]
		public static T requireNonNull<T>(T arg0, String arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<T>(typeof(Objects), "requireNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public static T requireNonNull<T>(T arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<T>(typeof(Objects), "requireNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public static bool deepEquals(IJavaObject arg0, IJavaObject arg1)
		{
			return Static.CallMethod<bool>(typeof(Objects), "deepEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public static bool isNull(IJavaObject arg0)
		{
			return Static.CallMethod<bool>(typeof(Objects), "isNull", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public static bool nonNull(IJavaObject arg0)
		{
			return Static.CallMethod<bool>(typeof(Objects), "nonNull", "(Ljava/lang/Object;)Z", arg0);
		}
	}
}
