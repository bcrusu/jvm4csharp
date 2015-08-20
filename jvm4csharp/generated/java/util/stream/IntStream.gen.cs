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
	[JavaProxy("java/util/stream/IntStream")]
	public partial interface IntStream : BaseStream<Integer, IntStream>
	{
		[JavaSignature("(J)Ljava/util/stream/IntStream;")]
		IntStream limit(long arg0);
		
		[JavaSignature("()J")]
		long count();
		
		[JavaSignature("()Ljava/util/OptionalInt;")]
		OptionalInt min();
		
		[JavaSignature("()Ljava/util/OptionalInt;")]
		OptionalInt max();
		
		[JavaSignature("()Ljava/util/PrimitiveIterator/OfInt;")]
		new PrimitiveIterator_.OfInt iterator();
		
		[JavaSignature("()[I")]
		IntArray toArray();
		
		[JavaSignature("()Ljava/util/Spliterator/OfInt;")]
		new Spliterator_.OfInt spliterator();
		
		[JavaSignature("(Ljava/util/function/Supplier;Ljava/util/function/ObjIntConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;")]
		R collect<R>(Supplier<R> arg0, ObjIntConsumer<R> arg1, BiConsumer<R, R> arg2)
			where R : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/IntConsumer;)V")]
		void forEach(IntConsumer arg0);
		
		[JavaSignature("(J)Ljava/util/stream/IntStream;")]
		IntStream skip(long arg0);
		
		[JavaSignature("(Ljava/util/function/IntConsumer;)Ljava/util/stream/IntStream;")]
		IntStream peek(IntConsumer arg0);
		
		[JavaSignature("()I")]
		int sum();
		
		[JavaSignature("(Ljava/util/function/IntPredicate;)Ljava/util/stream/IntStream;")]
		IntStream filter(IntPredicate arg0);
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		new IntStream parallel();
		
		[JavaSignature("(Ljava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;")]
		IntStream map(IntUnaryOperator arg0);
		
		[JavaSignature("(Ljava/util/function/IntBinaryOperator;)Ljava/util/OptionalInt;")]
		OptionalInt reduce(IntBinaryOperator arg0);
		
		[JavaSignature("(ILjava/util/function/IntBinaryOperator;)I")]
		int reduce(int arg0, IntBinaryOperator arg1);
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		IntStream sorted();
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		DoubleStream asDoubleStream();
		
		[JavaSignature("()Ljava/util/stream/LongStream;")]
		LongStream asLongStream();
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		OptionalDouble average();
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		Stream<Integer> boxed();
		
		[JavaSignature("(Ljava/util/function/IntFunction;)Ljava/util/stream/Stream;")]
		Stream<U> mapToObj<U>(IntFunction<U> arg0)
			where U : IJavaObject;
		
		[JavaSignature("()Ljava/util/IntSummaryStatistics;")]
		IntSummaryStatistics summaryStatistics();
		
		[JavaSignature("(Ljava/util/function/IntPredicate;)Z")]
		bool allMatch(IntPredicate arg0);
		
		[JavaSignature("(Ljava/util/function/IntPredicate;)Z")]
		bool anyMatch(IntPredicate arg0);
		
		[JavaSignature("(Ljava/util/function/IntConsumer;)V")]
		void forEachOrdered(IntConsumer arg0);
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		IntStream distinct();
		
		[JavaSignature("()Ljava/util/OptionalInt;")]
		OptionalInt findAny();
		
		[JavaSignature("()Ljava/util/OptionalInt;")]
		OptionalInt findFirst();
		
		[JavaSignature("(Ljava/util/function/IntFunction;)Ljava/util/stream/IntStream;")]
		IntStream flatMap(IntFunction<IntStream> arg0);
		
		[JavaSignature("(Ljava/util/function/IntToDoubleFunction;)Ljava/util/stream/DoubleStream;")]
		DoubleStream mapToDouble(IntToDoubleFunction arg0);
		
		[JavaSignature("(Ljava/util/function/IntToLongFunction;)Ljava/util/stream/LongStream;")]
		LongStream mapToLong(IntToLongFunction arg0);
		
		[JavaSignature("(Ljava/util/function/IntPredicate;)Z")]
		bool noneMatch(IntPredicate arg0);
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		new IntStream sequential();
	}
	
	public static class IntStream_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/util/stream/IntStream;Ljava/util/stream/IntStream;)Ljava/util/stream/IntStream;")]
		public static IntStream concat(IntStream arg0, IntStream arg1)
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "concat", "(Ljava/util/stream/IntStream;Ljava/util/stream/IntStream;)Ljava/util/stream/IntStream;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/util/stream/IntStream;")]
		public static IntStream of(int arg0)
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "of", "(I)Ljava/util/stream/IntStream;", arg0);
		}
		
		[JavaSignature("([I)Ljava/util/stream/IntStream;")]
		public static IntStream of(IntArray arg0)
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "of", "([I)Ljava/util/stream/IntStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public static IntStream empty()
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "empty", "()Ljava/util/stream/IntStream;");
		}
		
		[JavaSignature("(II)Ljava/util/stream/IntStream;")]
		public static IntStream range(int arg0, int arg1)
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "range", "(II)Ljava/util/stream/IntStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/IntSupplier;)Ljava/util/stream/IntStream;")]
		public static IntStream generate(IntSupplier arg0)
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "generate", "(Ljava/util/function/IntSupplier;)Ljava/util/stream/IntStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream/Builder;")]
		public static IntStream_.Builder builder()
		{
			return Static.CallMethod<IntStream_.Builder>(typeof(IntStream), "builder", "()Ljava/util/stream/IntStream/Builder;");
		}
		
		[JavaSignature("(II)Ljava/util/stream/IntStream;")]
		public static IntStream rangeClosed(int arg0, int arg1)
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "rangeClosed", "(II)Ljava/util/stream/IntStream;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;")]
		public static IntStream iterate(int arg0, IntUnaryOperator arg1)
		{
			return Static.CallMethod<IntStream>(typeof(IntStream), "iterate", "(ILjava/util/function/IntUnaryOperator;)Ljava/util/stream/IntStream;", arg0, arg1);
		}
	
		[JavaProxy("java/util/stream/IntStream/Builder")]
		public partial interface Builder : IntConsumer
		{
			[JavaSignature("(I)Ljava/util/stream/IntStream/Builder;")]
			IntStream_.Builder @add(int arg0);
			
			[JavaSignature("(I)V")]
			new void accept(int arg0);
			
			[JavaSignature("()Ljava/util/stream/IntStream;")]
			IntStream build();
		}
	}
}
