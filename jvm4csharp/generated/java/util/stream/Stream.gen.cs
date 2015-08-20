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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.stream
{
	[JavaProxy("java/util/stream/Stream")]
	public partial interface Stream<T> : BaseStream<T, Stream<T>>
		where T : IJavaObject
	{
		[JavaSignature("(J)Ljava/util/stream/Stream;")]
		Stream<T> limit(long arg0);
		
		[JavaSignature("()J")]
		long count();
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Optional;")]
		Optional<T> min(Comparator<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/Optional;")]
		Optional<T> max(Comparator<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/IntFunction;)[Ljava/lang/Object;")]
		ObjectArray<A> toArray<A>(IntFunction<ObjectArray<A>> arg0)
			where A : IJavaObject;
		
		[JavaSignature("()[Ljava/lang/Object;")]
		ObjectArray<IJavaObject> toArray();
		
		[JavaSignature("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;")]
		R collect<R>(Supplier<R> arg0, BiConsumer<R, IJavaObject> arg1, BiConsumer<R, R> arg2)
			where R : IJavaObject;
		
		[JavaSignature("(Ljava/util/stream/Collector;)Ljava/lang/Object;")]
		R collect<R, A>(Collector<IJavaObject, A, R> arg0)
			where R : IJavaObject
			where A : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		void forEach(Consumer<IJavaObject> arg0);
		
		[JavaSignature("(J)Ljava/util/stream/Stream;")]
		Stream<T> skip(long arg0);
		
		[JavaSignature("(Ljava/util/function/Consumer;)Ljava/util/stream/Stream;")]
		Stream<T> peek(Consumer<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Predicate;)Ljava/util/stream/Stream;")]
		Stream<T> filter(Predicate<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/stream/Stream;")]
		Stream<R> map<R>(Function<IJavaObject, R> arg0)
			where R : IJavaObject;
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		U reduce<U>(U arg0, BiFunction<U, IJavaObject, U> arg1, BinaryOperator<U> arg2)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/BinaryOperator;)Ljava/util/Optional;")]
		Optional<T> reduce(BinaryOperator<T> arg0);
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BinaryOperator;)Ljava/lang/Object;")]
		T reduce(T arg0, BinaryOperator<T> arg1);
		
		[JavaSignature("(Ljava/util/Comparator;)Ljava/util/stream/Stream;")]
		Stream<T> sorted(Comparator<IJavaObject> arg0);
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		Stream<T> sorted();
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		bool allMatch(Predicate<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		bool anyMatch(Predicate<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		void forEachOrdered(Consumer<IJavaObject> arg0);
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		Stream<T> distinct();
		
		[JavaSignature("()Ljava/util/Optional;")]
		Optional<T> findAny();
		
		[JavaSignature("()Ljava/util/Optional;")]
		Optional<T> findFirst();
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/stream/Stream;")]
		Stream<R> flatMap<R>(Function<IJavaObject, Stream<R>> arg0)
			where R : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/stream/DoubleStream;")]
		DoubleStream flatMapToDouble(Function<IJavaObject, DoubleStream> arg0);
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/stream/IntStream;")]
		IntStream flatMapToInt(Function<IJavaObject, IntStream> arg0);
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/stream/LongStream;")]
		LongStream flatMapToLong(Function<IJavaObject, LongStream> arg0);
		
		[JavaSignature("(Ljava/util/function/ToDoubleFunction;)Ljava/util/stream/DoubleStream;")]
		DoubleStream mapToDouble(ToDoubleFunction<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/ToIntFunction;)Ljava/util/stream/IntStream;")]
		IntStream mapToInt(ToIntFunction<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/ToLongFunction;)Ljava/util/stream/LongStream;")]
		LongStream mapToLong(ToLongFunction<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		bool noneMatch(Predicate<IJavaObject> arg0);
	}
	
	public static class Stream_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/util/stream/Stream;Ljava/util/stream/Stream;)Ljava/util/stream/Stream;")]
		public static Stream<T1> concat<T1>(Stream<T1> arg0, Stream<T1> arg1)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Stream<T1>>(typeof(Stream<>), "concat", "(Ljava/util/stream/Stream;Ljava/util/stream/Stream;)Ljava/util/stream/Stream;", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/util/stream/Stream;")]
		public static Stream<T1> of<T1>(ObjectArray<T1> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Stream<T1>>(typeof(Stream<>), "of", "([Ljava/lang/Object;)Ljava/util/stream/Stream;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/stream/Stream;")]
		public static Stream<T1> of<T1>(T1 arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Stream<T1>>(typeof(Stream<>), "of", "(Ljava/lang/Object;)Ljava/util/stream/Stream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public static Stream<T1> empty<T1>()
			where T1 : IJavaObject
		{
			return Static.CallMethod<Stream<T1>>(typeof(Stream<>), "empty", "()Ljava/util/stream/Stream;");
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)Ljava/util/stream/Stream;")]
		public static Stream<T1> generate<T1>(Supplier<T1> arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Stream<T1>>(typeof(Stream<>), "generate", "(Ljava/util/function/Supplier;)Ljava/util/stream/Stream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream/Builder;")]
		public static Stream_.Builder<T1> builder<T1>()
			where T1 : IJavaObject
		{
			return Static.CallMethod<Stream_.Builder<T1>>(typeof(Stream<>), "builder", "()Ljava/util/stream/Stream/Builder;");
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/util/stream/Stream;")]
		public static Stream<T1> iterate<T1>(T1 arg0, UnaryOperator<T1> arg1)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Stream<T1>>(typeof(Stream<>), "iterate", "(Ljava/lang/Object;Ljava/util/function/UnaryOperator;)Ljava/util/stream/Stream;", arg0, arg1);
		}
	
		[JavaProxy("java/util/stream/Stream/Builder")]
		public partial interface Builder<T> : Consumer<T>
			where T : IJavaObject
		{
			[JavaSignature("(Ljava/lang/Object;)Ljava/util/stream/Stream/Builder;")]
			Stream_.Builder<T> @add(T arg0);
			
			[JavaSignature("(Ljava/lang/Object;)V")]
			new void accept(T arg0);
			
			[JavaSignature("()Ljava/util/stream/Stream;")]
			Stream<T> build();
		}
	}
}
