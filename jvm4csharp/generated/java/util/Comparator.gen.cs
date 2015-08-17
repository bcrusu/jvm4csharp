//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Comparator")]
	public interface Comparator<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)I")]
		int compare(T arg0, T arg1);
		
		[JavaSignature("()Ljava/util/Comparator;")]
		Comparator<T> reversed();
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/Comparator;")]
		Comparator<T> thenComparing<U>(Function<IJavaObject, U> arg0)
			where U : Comparable<IJavaObject>;
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Comparator;")]
		Comparator<T> thenComparing(Comparator<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;")]
		Comparator<T> thenComparing<U>(Function<IJavaObject, U> arg0, Comparator<IJavaObject> arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;")]
		Comparator<T> thenComparingDouble(ToDoubleFunction<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;")]
		Comparator<T> thenComparingInt(ToIntFunction<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;")]
		Comparator<T> thenComparingLong(ToLongFunction<IJavaObject> arg0);
	}
	
	public static class Comparator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;")]
		public static Comparator<T1> comparing<T1, U>(Function<IJavaObject, U> arg0, Comparator<IJavaObject> arg1)
			where T1 : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "comparing", "(Ljava/util/function/Function;Ljava/util/Comparator;)Ljava/util/Comparator;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/Comparator;")]
		public static Comparator<T1> comparing<T1, U>(Function<IJavaObject, U> arg0)
			where T1 : IJavaObject
			where U : Comparable<IJavaObject>
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "comparing", "(Ljava/util/function/Function;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;")]
		public static Comparator<T1> comparingDouble<T1>(ToDoubleFunction<IJavaObject> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "comparingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;")]
		public static Comparator<T1> comparingInt<T1>(ToIntFunction<IJavaObject> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "comparingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;")]
		public static Comparator<T1> comparingLong<T1>(ToLongFunction<IJavaObject> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "comparingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Comparator;")]
		public static Comparator<T1> naturalOrder<T1>()
			where T1 : Comparable<IJavaObject>
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "naturalOrder", "()Ljava/util/Comparator;");
		}
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Comparator;")]
		public static Comparator<T1> nullsFirst<T1>(Comparator<IJavaObject> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "nullsFirst", "(Ljava/util/Comparator;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Comparator;")]
		public static Comparator<T1> nullsLast<T1>(Comparator<IJavaObject> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "nullsLast", "(Ljava/util/Comparator;)Ljava/util/Comparator;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Comparator;")]
		public static Comparator<T1> reverseOrder<T1>()
			where T1 : Comparable<IJavaObject>
		{
			return Static.CallMethod<Comparator<T1>>(typeof(Comparator<>), "reverseOrder", "()Ljava/util/Comparator;");
		}
	
	}
}
