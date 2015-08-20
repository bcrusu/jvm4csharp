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
namespace jvm4csharp.java.util.stream
{
	[JavaProxy("java/util/stream/StreamSupport")]
	public partial class StreamSupport : Object
	{
		protected StreamSupport(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/IntStream;")]
		public static IntStream intStream(Supplier<Spliterator_.OfInt> arg0, int arg1, bool arg2)
		{
			return Static.CallMethod<IntStream>(typeof(StreamSupport), "intStream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/IntStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/Spliterator/OfInt;Z)Ljava/util/stream/IntStream;")]
		public static IntStream intStream(Spliterator_.OfInt arg0, bool arg1)
		{
			return Static.CallMethod<IntStream>(typeof(StreamSupport), "intStream", "(Ljava/util/Spliterator/OfInt;Z)Ljava/util/stream/IntStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/Stream;")]
		public static Stream<T> stream<T>(Supplier<Spliterator<T>> arg0, int arg1, bool arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<Stream<T>>(typeof(StreamSupport), "stream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/Stream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;")]
		public static Stream<T> stream<T>(Spliterator<T> arg0, bool arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<Stream<T>>(typeof(StreamSupport), "stream", "(Ljava/util/Spliterator;Z)Ljava/util/stream/Stream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream doubleStream(Supplier<Spliterator_.OfDouble> arg0, int arg1, bool arg2)
		{
			return Static.CallMethod<DoubleStream>(typeof(StreamSupport), "doubleStream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/DoubleStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/Spliterator/OfDouble;Z)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream doubleStream(Spliterator_.OfDouble arg0, bool arg1)
		{
			return Static.CallMethod<DoubleStream>(typeof(StreamSupport), "doubleStream", "(Ljava/util/Spliterator/OfDouble;Z)Ljava/util/stream/DoubleStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Spliterator/OfLong;Z)Ljava/util/stream/LongStream;")]
		public static LongStream longStream(Spliterator_.OfLong arg0, bool arg1)
		{
			return Static.CallMethod<LongStream>(typeof(StreamSupport), "longStream", "(Ljava/util/Spliterator/OfLong;Z)Ljava/util/stream/LongStream;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;IZ)Ljava/util/stream/LongStream;")]
		public static LongStream longStream(Supplier<Spliterator_.OfLong> arg0, int arg1, bool arg2)
		{
			return Static.CallMethod<LongStream>(typeof(StreamSupport), "longStream", "(Ljava/util/function/Supplier;IZ)Ljava/util/stream/LongStream;", arg0, arg1, arg2);
		}
	}
}
