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
using jvm4csharp.java.util.concurrent;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.stream
{
	[JavaProxy("java/util/stream/Collectors")]
	public class Collectors : Object
	{
		protected Collectors(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Map<K, U>> toMap<T, K, U>(Function<IJavaObject, K> arg0, Function<IJavaObject, U> arg1, BinaryOperator<U> arg2)
			where T : IJavaObject
			where K : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Map<K, U>>>(typeof(Collectors), "toMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, M> toMap<T, K, U, M>(Function<IJavaObject, K> arg0, Function<IJavaObject, U> arg1, BinaryOperator<U> arg2, Supplier<M> arg3)
			where T : IJavaObject
			where K : IJavaObject
			where U : IJavaObject
			where M : Map<K, U>
		{
			return Static.CallMethod<Collector<T, IJavaObject, M>>(typeof(Collectors), "toMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Map<K, U>> toMap<T, K, U>(Function<IJavaObject, K> arg0, Function<IJavaObject, U> arg1)
			where T : IJavaObject
			where K : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Map<K, U>>>(typeof(Collectors), "toMap", "(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, List<T>> toList<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, List<T>>>(typeof(Collectors), "toList", "()Ljava/util/stream/Collector;");
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, C> toCollection<T, C>(Supplier<C> arg0)
			where T : IJavaObject
			where C : Collection<T>
		{
			return Static.CallMethod<Collector<T, IJavaObject, C>>(typeof(Collectors), "toCollection", "(Ljava/util/function/Supplier;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Set<T>> toSet<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Set<T>>>(typeof(Collectors), "toSet", "()Ljava/util/stream/Collector;");
		}
		
		[JavaSignature("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Double> averagingDouble<T>(ToDoubleFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Double>>(typeof(Collectors), "averagingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Double> averagingInt<T>(ToIntFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Double>>(typeof(Collectors), "averagingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Double> averagingLong<T>(ToLongFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Double>>(typeof(Collectors), "averagingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/stream/Collector;Ljava/util/function/Function;)Ljava/util/stream/Collector;")]
		public static Collector<T, A, RR> collectingAndThen<T, A, R, RR>(Collector<T, A, R> arg0, Function<R, RR> arg1)
			where T : IJavaObject
			where A : IJavaObject
			where R : IJavaObject
			where RR : IJavaObject
		{
			return Static.CallMethod<Collector<T, A, RR>>(typeof(Collectors), "collectingAndThen", "(Ljava/util/stream/Collector;Ljava/util/function/Function;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Long> counting<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Long>>(typeof(Collectors), "counting", "()Ljava/util/stream/Collector;");
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Map<K, List<T>>> groupingBy<T, K>(Function<IJavaObject, K> arg0)
			where T : IJavaObject
			where K : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Map<K, List<T>>>>(typeof(Collectors), "groupingBy", "(Ljava/util/function/Function;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, M> groupingBy<T, K, D, A, M>(Function<IJavaObject, K> arg0, Supplier<M> arg1, Collector<IJavaObject, A, D> arg2)
			where T : IJavaObject
			where K : IJavaObject
			where D : IJavaObject
			where A : IJavaObject
			where M : Map<K, D>
		{
			return Static.CallMethod<Collector<T, IJavaObject, M>>(typeof(Collectors), "groupingBy", "(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Map<K, D>> groupingBy<T, K, A, D>(Function<IJavaObject, K> arg0, Collector<IJavaObject, A, D> arg1)
			where T : IJavaObject
			where K : IJavaObject
			where A : IJavaObject
			where D : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Map<K, D>>>(typeof(Collectors), "groupingBy", "(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, ConcurrentMap<K, List<T>>> groupingByConcurrent<T, K>(Function<IJavaObject, K> arg0)
			where T : IJavaObject
			where K : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, ConcurrentMap<K, List<T>>>>(typeof(Collectors), "groupingByConcurrent", "(Ljava/util/function/Function;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, M> groupingByConcurrent<T, K, A, D, M>(Function<IJavaObject, K> arg0, Supplier<M> arg1, Collector<IJavaObject, A, D> arg2)
			where T : IJavaObject
			where K : IJavaObject
			where A : IJavaObject
			where D : IJavaObject
			where M : ConcurrentMap<K, D>
		{
			return Static.CallMethod<Collector<T, IJavaObject, M>>(typeof(Collectors), "groupingByConcurrent", "(Ljava/util/function/Function;Ljava/util/function/Supplier;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, ConcurrentMap<K, D>> groupingByConcurrent<T, K, A, D>(Function<IJavaObject, K> arg0, Collector<IJavaObject, A, D> arg1)
			where T : IJavaObject
			where K : IJavaObject
			where A : IJavaObject
			where D : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, ConcurrentMap<K, D>>>(typeof(Collectors), "groupingByConcurrent", "(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;")]
		public static Collector<CharSequence, IJavaObject, String> joining(CharSequence arg0)
		{
			return Static.CallMethod<Collector<CharSequence, IJavaObject, String>>(typeof(Collectors), "joining", "(Ljava/lang/CharSequence;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/util/stream/Collector;")]
		public static Collector<CharSequence, IJavaObject, String> joining(CharSequence arg0, CharSequence arg1, CharSequence arg2)
		{
			return Static.CallMethod<Collector<CharSequence, IJavaObject, String>>(typeof(Collectors), "joining", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/util/stream/Collector;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/util/stream/Collector;")]
		public static Collector<CharSequence, IJavaObject, String> joining()
		{
			return Static.CallMethod<Collector<CharSequence, IJavaObject, String>>(typeof(Collectors), "joining", "()Ljava/util/stream/Collector;");
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, R> mapping<T, U, A, R>(Function<IJavaObject, U> arg0, Collector<IJavaObject, A, R> arg1)
			where T : IJavaObject
			where U : IJavaObject
			where A : IJavaObject
			where R : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, R>>(typeof(Collectors), "mapping", "(Ljava/util/function/Function;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Predicate;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Map<Boolean, List<T>>> partitioningBy<T>(Predicate<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Map<Boolean, List<T>>>>(typeof(Collectors), "partitioningBy", "(Ljava/util/function/Predicate;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Map<Boolean, D>> partitioningBy<T, D, A>(Predicate<IJavaObject> arg0, Collector<IJavaObject, A, D> arg1)
			where T : IJavaObject
			where D : IJavaObject
			where A : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Map<Boolean, D>>>(typeof(Collectors), "partitioningBy", "(Ljava/util/function/Predicate;Ljava/util/stream/Collector;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Optional<T>> reducing<T>(BinaryOperator<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Optional<T>>>(typeof(Collectors), "reducing", "(Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, T> reducing<T>(T arg0, BinaryOperator<T> arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, T>>(typeof(Collectors), "reducing", "(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, U> reducing<T, U>(U arg0, Function<IJavaObject, U> arg1, BinaryOperator<U> arg2)
			where T : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, U>>(typeof(Collectors), "reducing", "(Ljava/lang/Object;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, DoubleSummaryStatistics> summarizingDouble<T>(ToDoubleFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, DoubleSummaryStatistics>>(typeof(Collectors), "summarizingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, IntSummaryStatistics> summarizingInt<T>(ToIntFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, IntSummaryStatistics>>(typeof(Collectors), "summarizingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, LongSummaryStatistics> summarizingLong<T>(ToLongFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, LongSummaryStatistics>>(typeof(Collectors), "summarizingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Double> summingDouble<T>(ToDoubleFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Double>>(typeof(Collectors), "summingDouble", "(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Integer> summingInt<T>(ToIntFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Integer>>(typeof(Collectors), "summingInt", "(Ljava/util/function/ToIntFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Long> summingLong<T>(ToLongFunction<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Long>>(typeof(Collectors), "summingLong", "(Ljava/util/function/ToLongFunction;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, ConcurrentMap<K, U>> toConcurrentMap<T, K, U>(Function<IJavaObject, K> arg0, Function<IJavaObject, U> arg1, BinaryOperator<U> arg2)
			where T : IJavaObject
			where K : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, ConcurrentMap<K, U>>>(typeof(Collectors), "toConcurrentMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;)Ljava/util/stream/Collector;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, M> toConcurrentMap<T, K, U, M>(Function<IJavaObject, K> arg0, Function<IJavaObject, U> arg1, BinaryOperator<U> arg2, Supplier<M> arg3)
			where T : IJavaObject
			where K : IJavaObject
			where U : IJavaObject
			where M : ConcurrentMap<K, U>
		{
			return Static.CallMethod<Collector<T, IJavaObject, M>>(typeof(Collectors), "toConcurrentMap", "(Ljava/util/function/Function;Ljava/util/function/Function;Ljava/util/function/BinaryOperator;Ljava/util/function/Supplier;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, ConcurrentMap<K, U>> toConcurrentMap<T, K, U>(Function<IJavaObject, K> arg0, Function<IJavaObject, U> arg1)
			where T : IJavaObject
			where K : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, ConcurrentMap<K, U>>>(typeof(Collectors), "toConcurrentMap", "(Ljava/util/function/Function;Ljava/util/function/Function;)Ljava/util/stream/Collector;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Optional<T>> maxBy<T>(Comparator<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Optional<T>>>(typeof(Collectors), "maxBy", "(Ljava/util/Comparator;)Ljava/util/stream/Collector;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/stream/Collector;")]
		public static Collector<T, IJavaObject, Optional<T>> minBy<T>(Comparator<IJavaObject> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Collector<T, IJavaObject, Optional<T>>>(typeof(Collectors), "minBy", "(Ljava/util/Comparator;)Ljava/util/stream/Collector;", arg0);
		}
	}
}
