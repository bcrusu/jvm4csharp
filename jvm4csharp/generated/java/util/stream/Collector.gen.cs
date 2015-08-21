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
namespace jvm4csharp.java.util.stream
{
	[JavaProxy("java/util/stream/Collector")]
	public partial interface Collector<T, A, R> : IJavaObject
		where T : IJavaObject
		where A : IJavaObject
		where R : IJavaObject
	{
		[JavaSignature("()Ljava/util/function/BinaryOperator;")]
		BinaryOperator<A> combiner();
		
		[JavaSignature("()Ljava/util/Set;")]
		Set<Collector_.Characteristics> characteristics();
		
		[JavaSignature("()Ljava/util/function/BiConsumer;")]
		BiConsumer<A, T> accumulator();
		
		[JavaSignature("()Ljava/util/function/Function;")]
		Function<A, R> finisher();
		
		[JavaSignature("()Ljava/util/function/Supplier;")]
		Supplier<A> supplier();
	}
	
	public static partial class Collector_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector/Characteristics;)Ljava/util/stream/Collector;")]
		public static Collector<T1, R1, R1> of<T1, R1>(Supplier<R1> arg0, BiConsumer<R1, T1> arg1, BinaryOperator<R1> arg2, ObjectArray<Collector_.Characteristics> arg3)
			where T1 : IJavaObject
			where R1 : IJavaObject
		{
			return Static.CallMethod<Collector<T1, R1, R1>>(typeof(Collector<,,>), "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector/Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector/Characteristics;)Ljava/util/stream/Collector;")]
		public static Collector<T1, A1, R1> of<T1, A1, R1>(Supplier<A1> arg0, BiConsumer<A1, T1> arg1, BinaryOperator<A1> arg2, Function<A1, R1> arg3, ObjectArray<Collector_.Characteristics> arg4)
			where T1 : IJavaObject
			where A1 : IJavaObject
			where R1 : IJavaObject
		{
			return Static.CallMethod<Collector<T1, A1, R1>>(typeof(Collector<,,>), "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector/Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3, arg4);
		}
	
		[JavaProxy("java/util/stream/Collector/Characteristics")]
		public partial class Characteristics : Enum<Collector_.Characteristics>
		{
			protected Characteristics(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/util/stream/Collector/Characteristics;")]
			public static Collector_.Characteristics CONCURRENT
			{
				get { return Static.GetField<Collector_.Characteristics>(typeof(Characteristics), "CONCURRENT", "Ljava/util/stream/Collector/Characteristics;"); }
			}
			
			[JavaSignature("Ljava/util/stream/Collector/Characteristics;")]
			public static Collector_.Characteristics UNORDERED
			{
				get { return Static.GetField<Collector_.Characteristics>(typeof(Characteristics), "UNORDERED", "Ljava/util/stream/Collector/Characteristics;"); }
			}
			
			[JavaSignature("Ljava/util/stream/Collector/Characteristics;")]
			public static Collector_.Characteristics IDENTITY_FINISH
			{
				get { return Static.GetField<Collector_.Characteristics>(typeof(Characteristics), "IDENTITY_FINISH", "Ljava/util/stream/Collector/Characteristics;"); }
			}
		
			[JavaSignature("()[Ljava/util/stream/Collector/Characteristics;")]
			public static ObjectArray<Collector_.Characteristics> values()
			{
				return Static.CallMethod<ObjectArray<Collector_.Characteristics>>(typeof(Characteristics), "values", "()[Ljava/util/stream/Collector/Characteristics;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/stream/Collector/Characteristics;")]
			public static Collector_.Characteristics valueOf(String arg0)
			{
				return Static.CallMethod<Collector_.Characteristics>(typeof(Characteristics), "valueOf", "(Ljava/lang/String;)Ljava/util/stream/Collector/Characteristics;", arg0);
			}
		}
	}
}
