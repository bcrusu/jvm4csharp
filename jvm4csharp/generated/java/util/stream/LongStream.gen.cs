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
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.stream
{
	[JavaProxy("java/util/stream/LongStream")]
	public interface LongStream : BaseStream<Long, LongStream>
	{
		[JavaSignature("(J)Ljava/util/stream/LongStream;")]
		LongStream limit(long arg0);
		
		[JavaSignature("()J")]
		long count();
		
		[JavaSignature("()Ljava/util/OptionalLong;")]
		OptionalLong min();
		
		[JavaSignature("()Ljava/util/OptionalLong;")]
		OptionalLong max();
		
		[JavaSignature("()Ljava/util/PrimitiveIterator/OfLong;")]
		new PrimitiveIterator_.OfLong iterator();
		
		[JavaSignature("()[J")]
		LongArray toArray();
		
		[JavaSignature("()Ljava/util/Spliterator/OfLong;")]
		new Spliterator_.OfLong spliterator();
		
		[JavaSignature("(Ljava/util/function/Supplier;Ljava/util/function/ObjLongConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;")]
		R collect<R>(Supplier<R> arg0, ObjLongConsumer<R> arg1, BiConsumer<R, R> arg2)
			where R : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/LongConsumer;)V")]
		void forEach(LongConsumer arg0);
		
		[JavaSignature("(J)Ljava/util/stream/LongStream;")]
		LongStream skip(long arg0);
		
		[JavaSignature("(Ljava/util/function/LongConsumer;)Ljava/util/stream/LongStream;")]
		LongStream peek(LongConsumer arg0);
		
		[JavaSignature("()J")]
		long sum();
		
		[JavaSignature("(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;")]
		LongStream filter(LongPredicate arg0);
		
		[JavaSignature("()Ljava/util/stream/LongStream;")]
		new LongStream parallel();
		
		[JavaSignature("(Ljava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;")]
		LongStream map(LongUnaryOperator arg0);
		
		[JavaSignature("(Ljava/util/function/LongBinaryOperator;)Ljava/util/OptionalLong;")]
		OptionalLong reduce(LongBinaryOperator arg0);
		
		[JavaSignature("(JLjava/util/function/LongBinaryOperator;)J")]
		long reduce(long arg0, LongBinaryOperator arg1);
		
		[JavaSignature("()Ljava/util/stream/LongStream;")]
		LongStream sorted();
		
		[JavaSignature("(Ljava/util/function/LongPredicate;)Z")]
		bool anyMatch(LongPredicate arg0);
		
		[JavaSignature("(Ljava/util/function/LongPredicate;)Z")]
		bool allMatch(LongPredicate arg0);
		
		[JavaSignature("(Ljava/util/function/LongConsumer;)V")]
		void forEachOrdered(LongConsumer arg0);
		
		[JavaSignature("()Ljava/util/stream/LongStream;")]
		LongStream distinct();
		
		[JavaSignature("()Ljava/util/OptionalLong;")]
		OptionalLong findAny();
		
		[JavaSignature("()Ljava/util/OptionalLong;")]
		OptionalLong findFirst();
		
		[JavaSignature("(Ljava/util/function/LongFunction;)Ljava/util/stream/LongStream;")]
		LongStream flatMap(LongFunction<LongStream> arg0);
		
		[JavaSignature("(Ljava/util/function/LongToDoubleFunction;)Ljava/util/stream/DoubleStream;")]
		DoubleStream mapToDouble(LongToDoubleFunction arg0);
		
		[JavaSignature("(Ljava/util/function/LongToIntFunction;)Ljava/util/stream/IntStream;")]
		IntStream mapToInt(LongToIntFunction arg0);
		
		[JavaSignature("(Ljava/util/function/LongPredicate;)Z")]
		bool noneMatch(LongPredicate arg0);
		
		[JavaSignature("()Ljava/util/stream/LongStream;")]
		new LongStream sequential();
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		DoubleStream asDoubleStream();
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		OptionalDouble average();
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		Stream<Long> boxed();
		
		[JavaSignature("(Ljava/util/function/LongFunction;)Ljava/util/stream/Stream;")]
		Stream<U> mapToObj<U>(LongFunction<U> arg0)
			where U : IJavaObject;
		
		[JavaSignature("()Ljava/util/LongSummaryStatistics;")]
		LongSummaryStatistics summaryStatistics();
	}
	
	public static class LongStream_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/util/stream/LongStream;Ljava/util/stream/LongStream;)Ljava/util/stream/LongStream;")]
		public static LongStream concat(LongStream arg0, LongStream arg1)
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "concat", "(Ljava/util/stream/LongStream;Ljava/util/stream/LongStream;)Ljava/util/stream/LongStream;", arg0, arg1);
		}
		
		[JavaSignature("(J)Ljava/util/stream/LongStream;")]
		public static LongStream of(long arg0)
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "of", "(J)Ljava/util/stream/LongStream;", arg0);
		}
		
		[JavaSignature("([J)Ljava/util/stream/LongStream;")]
		public static LongStream of(LongArray arg0)
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "of", "([J)Ljava/util/stream/LongStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/LongStream;")]
		public static LongStream empty()
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "empty", "()Ljava/util/stream/LongStream;");
		}
		
		[JavaSignature("(JJ)Ljava/util/stream/LongStream;")]
		public static LongStream range(long arg0, long arg1)
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "range", "(JJ)Ljava/util/stream/LongStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/LongSupplier;)Ljava/util/stream/LongStream;")]
		public static LongStream generate(LongSupplier arg0)
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "generate", "(Ljava/util/function/LongSupplier;)Ljava/util/stream/LongStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/LongStream/Builder;")]
		public static LongStream_.Builder builder()
		{
			return Static.CallMethod<LongStream_.Builder>(typeof(LongStream), "builder", "()Ljava/util/stream/LongStream/Builder;");
		}
		
		[JavaSignature("(JLjava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;")]
		public static LongStream iterate(long arg0, LongUnaryOperator arg1)
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "iterate", "(JLjava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;", arg0, arg1);
		}
		
		[JavaSignature("(JJ)Ljava/util/stream/LongStream;")]
		public static LongStream rangeClosed(long arg0, long arg1)
		{
			return Static.CallMethod<LongStream>(typeof(LongStream), "rangeClosed", "(JJ)Ljava/util/stream/LongStream;", arg0, arg1);
		}
	
		[JavaProxy("java/util/stream/LongStream/Builder")]
		public interface Builder : LongConsumer
		{
			[JavaSignature("(J)Ljava/util/stream/LongStream/Builder;")]
			LongStream_.Builder @add(long arg0);
			
			[JavaSignature("(J)V")]
			new void accept(long arg0);
			
			[JavaSignature("()Ljava/util/stream/LongStream;")]
			LongStream build();
		}
	}
}
