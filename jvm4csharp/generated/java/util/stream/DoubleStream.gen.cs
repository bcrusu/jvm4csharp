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
	[JavaProxy("java/util/stream/DoubleStream")]
	public interface DoubleStream : BaseStream<Double, DoubleStream>
	{
		[JavaSignature("(J)Ljava/util/stream/DoubleStream;")]
		DoubleStream limit(long arg0);
		
		[JavaSignature("()J")]
		long count();
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		OptionalDouble min();
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		OptionalDouble max();
		
		[JavaSignature("()Ljava/util/PrimitiveIterator/OfDouble;")]
		new PrimitiveIterator_.OfDouble iterator();
		
		[JavaSignature("()[D")]
		DoubleArray toArray();
		
		[JavaSignature("()Ljava/util/Spliterator/OfDouble;")]
		new Spliterator_.OfDouble spliterator();
		
		[JavaSignature("(Ljava/util/function/Supplier;Ljava/util/function/ObjDoubleConsumer;Ljava/util/function/BiConsumer;)Ljava/lang/Object;")]
		R collect<R>(Supplier<R> arg0, ObjDoubleConsumer<R> arg1, BiConsumer<R, R> arg2)
			where R : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/DoubleConsumer;)V")]
		void forEach(DoubleConsumer arg0);
		
		[JavaSignature("(J)Ljava/util/stream/DoubleStream;")]
		DoubleStream skip(long arg0);
		
		[JavaSignature("(Ljava/util/function/DoubleConsumer;)Ljava/util/stream/DoubleStream;")]
		DoubleStream peek(DoubleConsumer arg0);
		
		[JavaSignature("()D")]
		double sum();
		
		[JavaSignature("(Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;")]
		DoubleStream filter(DoublePredicate arg0);
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		new DoubleStream parallel();
		
		[JavaSignature("(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/stream/DoubleStream;")]
		DoubleStream map(DoubleUnaryOperator arg0);
		
		[JavaSignature("(Ljava/util/function/DoubleBinaryOperator;)Ljava/util/OptionalDouble;")]
		OptionalDouble reduce(DoubleBinaryOperator arg0);
		
		[JavaSignature("(DLjava/util/function/DoubleBinaryOperator;)D")]
		double reduce(double arg0, DoubleBinaryOperator arg1);
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		DoubleStream sorted();
		
		[JavaSignature("(Ljava/util/function/DoublePredicate;)Z")]
		bool anyMatch(DoublePredicate arg0);
		
		[JavaSignature("(Ljava/util/function/DoublePredicate;)Z")]
		bool allMatch(DoublePredicate arg0);
		
		[JavaSignature("(Ljava/util/function/DoubleConsumer;)V")]
		void forEachOrdered(DoubleConsumer arg0);
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		DoubleStream distinct();
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		OptionalDouble findAny();
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		OptionalDouble findFirst();
		
		[JavaSignature("(Ljava/util/function/DoubleFunction;)Ljava/util/stream/DoubleStream;")]
		DoubleStream flatMap(DoubleFunction<DoubleStream> arg0);
		
		[JavaSignature("(Ljava/util/function/DoubleToIntFunction;)Ljava/util/stream/IntStream;")]
		IntStream mapToInt(DoubleToIntFunction arg0);
		
		[JavaSignature("(Ljava/util/function/DoubleToLongFunction;)Ljava/util/stream/LongStream;")]
		LongStream mapToLong(DoubleToLongFunction arg0);
		
		[JavaSignature("(Ljava/util/function/DoublePredicate;)Z")]
		bool noneMatch(DoublePredicate arg0);
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		new DoubleStream sequential();
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		OptionalDouble average();
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		Stream<Double> boxed();
		
		[JavaSignature("(Ljava/util/function/DoubleFunction;)Ljava/util/stream/Stream;")]
		Stream<U> mapToObj<U>(DoubleFunction<U> arg0)
			where U : IJavaObject;
		
		[JavaSignature("()Ljava/util/DoubleSummaryStatistics;")]
		DoubleSummaryStatistics summaryStatistics();
	}
	
	public static class DoubleStream_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("(Ljava/util/stream/DoubleStream;Ljava/util/stream/DoubleStream;)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream concat(DoubleStream arg0, DoubleStream arg1)
		{
			return Static.CallMethod<DoubleStream>(typeof(DoubleStream), "concat", "(Ljava/util/stream/DoubleStream;Ljava/util/stream/DoubleStream;)Ljava/util/stream/DoubleStream;", arg0, arg1);
		}
		
		[JavaSignature("(D)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream of(double arg0)
		{
			return Static.CallMethod<DoubleStream>(typeof(DoubleStream), "of", "(D)Ljava/util/stream/DoubleStream;", arg0);
		}
		
		[JavaSignature("([D)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream of(DoubleArray arg0)
		{
			return Static.CallMethod<DoubleStream>(typeof(DoubleStream), "of", "([D)Ljava/util/stream/DoubleStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		public static DoubleStream empty()
		{
			return Static.CallMethod<DoubleStream>(typeof(DoubleStream), "empty", "()Ljava/util/stream/DoubleStream;");
		}
		
		[JavaSignature("(Ljava/util/function/DoubleSupplier;)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream generate(DoubleSupplier arg0)
		{
			return Static.CallMethod<DoubleStream>(typeof(DoubleStream), "generate", "(Ljava/util/function/DoubleSupplier;)Ljava/util/stream/DoubleStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/DoubleStream/Builder;")]
		public static DoubleStream_.Builder builder()
		{
			return Static.CallMethod<DoubleStream_.Builder>(typeof(DoubleStream), "builder", "()Ljava/util/stream/DoubleStream/Builder;");
		}
		
		[JavaSignature("(DLjava/util/function/DoubleUnaryOperator;)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream iterate(double arg0, DoubleUnaryOperator arg1)
		{
			return Static.CallMethod<DoubleStream>(typeof(DoubleStream), "iterate", "(DLjava/util/function/DoubleUnaryOperator;)Ljava/util/stream/DoubleStream;", arg0, arg1);
		}
	
		[JavaProxy("java/util/stream/DoubleStream/Builder")]
		public interface Builder : DoubleConsumer
		{
			[JavaSignature("(D)Ljava/util/stream/DoubleStream/Builder;")]
			DoubleStream_.Builder @add(double arg0);
			
			[JavaSignature("(D)V")]
			new void accept(double arg0);
			
			[JavaSignature("()Ljava/util/stream/DoubleStream;")]
			DoubleStream build();
		}
	}
}
