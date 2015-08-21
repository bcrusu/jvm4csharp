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
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Arrays")]
	public partial class Arrays : Object
	{
		protected Arrays(ProxyCtor p) : base(p) {}
	
		[JavaSignature("([B[B)Z")]
		public static bool equals(ByteArray arg0, ByteArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([B[B)Z", arg0, arg1);
		}
		
		[JavaSignature("([Z[Z)Z")]
		public static bool equals(BooleanArray arg0, BooleanArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([Z[Z)Z", arg0, arg1);
		}
		
		[JavaSignature("([D[D)Z")]
		public static bool equals(DoubleArray arg0, DoubleArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([D[D)Z", arg0, arg1);
		}
		
		[JavaSignature("([F[F)Z")]
		public static bool equals(FloatArray arg0, FloatArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([F[F)Z", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;[Ljava/lang/Object;)Z")]
		public static bool equals(ObjectArray<IJavaObject> arg0, ObjectArray<IJavaObject> arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("([S[S)Z")]
		public static bool equals(ShortArray arg0, ShortArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([S[S)Z", arg0, arg1);
		}
		
		[JavaSignature("([I[I)Z")]
		public static bool equals(IntArray arg0, IntArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([I[I)Z", arg0, arg1);
		}
		
		[JavaSignature("([J[J)Z")]
		public static bool equals(LongArray arg0, LongArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([J[J)Z", arg0, arg1);
		}
		
		[JavaSignature("([C[C)Z")]
		public static bool equals(CharArray arg0, CharArray arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "equals", "([C[C)Z", arg0, arg1);
		}
		
		[JavaSignature("([Z)Ljava/lang/String;")]
		public static String toString(BooleanArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([Z)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([B)Ljava/lang/String;")]
		public static String toString(ByteArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([B)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([F)Ljava/lang/String;")]
		public static String toString(FloatArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([F)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([D)Ljava/lang/String;")]
		public static String toString(DoubleArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([D)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([J)Ljava/lang/String;")]
		public static String toString(LongArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([I)Ljava/lang/String;")]
		public static String toString(IntArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([S)Ljava/lang/String;")]
		public static String toString(ShortArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([S)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([C)Ljava/lang/String;")]
		public static String toString(CharArray arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([C)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/lang/String;")]
		public static String toString(ObjectArray<IJavaObject> arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "toString", "([Ljava/lang/Object;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([B)I")]
		public static int hashCode(ByteArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([B)I", arg0);
		}
		
		[JavaSignature("([Z)I")]
		public static int hashCode(BooleanArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([Z)I", arg0);
		}
		
		[JavaSignature("([F)I")]
		public static int hashCode(FloatArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([F)I", arg0);
		}
		
		[JavaSignature("([D)I")]
		public static int hashCode(DoubleArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([D)I", arg0);
		}
		
		[JavaSignature("([J)I")]
		public static int hashCode(LongArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([J)I", arg0);
		}
		
		[JavaSignature("([I)I")]
		public static int hashCode(IntArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([I)I", arg0);
		}
		
		[JavaSignature("([S)I")]
		public static int hashCode(ShortArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([S)I", arg0);
		}
		
		[JavaSignature("([C)I")]
		public static int hashCode(CharArray arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([C)I", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;)I")]
		public static int hashCode(ObjectArray<IJavaObject> arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "hashCode", "([Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("([FI)[F")]
		public static FloatArray copyOf(FloatArray arg0, int arg1)
		{
			return Static.CallMethod<FloatArray>(typeof(Arrays), "copyOf", "([FI)[F", arg0, arg1);
		}
		
		[JavaSignature("([CI)[C")]
		public static CharArray copyOf(CharArray arg0, int arg1)
		{
			return Static.CallMethod<CharArray>(typeof(Arrays), "copyOf", "([CI)[C", arg0, arg1);
		}
		
		[JavaSignature("([JI)[J")]
		public static LongArray copyOf(LongArray arg0, int arg1)
		{
			return Static.CallMethod<LongArray>(typeof(Arrays), "copyOf", "([JI)[J", arg0, arg1);
		}
		
		[JavaSignature("([DI)[D")]
		public static DoubleArray copyOf(DoubleArray arg0, int arg1)
		{
			return Static.CallMethod<DoubleArray>(typeof(Arrays), "copyOf", "([DI)[D", arg0, arg1);
		}
		
		[JavaSignature("([ZI)[Z")]
		public static BooleanArray copyOf(BooleanArray arg0, int arg1)
		{
			return Static.CallMethod<BooleanArray>(typeof(Arrays), "copyOf", "([ZI)[Z", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;I)[Ljava/lang/Object;")]
		public static ObjectArray<T> copyOf<T>(ObjectArray<T> arg0, int arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<ObjectArray<T>>(typeof(Arrays), "copyOf", "([Ljava/lang/Object;I)[Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;")]
		public static ObjectArray<T> copyOf<T, U>(ObjectArray<U> arg0, int arg1, Class<ObjectArray<T>> arg2)
			where T : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<ObjectArray<T>>(typeof(Arrays), "copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([BI)[B")]
		public static ByteArray copyOf(ByteArray arg0, int arg1)
		{
			return Static.CallMethod<ByteArray>(typeof(Arrays), "copyOf", "([BI)[B", arg0, arg1);
		}
		
		[JavaSignature("([SI)[S")]
		public static ShortArray copyOf(ShortArray arg0, int arg1)
		{
			return Static.CallMethod<ShortArray>(typeof(Arrays), "copyOf", "([SI)[S", arg0, arg1);
		}
		
		[JavaSignature("([II)[I")]
		public static IntArray copyOf(IntArray arg0, int arg1)
		{
			return Static.CallMethod<IntArray>(typeof(Arrays), "copyOf", "([II)[I", arg0, arg1);
		}
		
		[JavaSignature("([BII)[B")]
		public static ByteArray copyOfRange(ByteArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<ByteArray>(typeof(Arrays), "copyOfRange", "([BII)[B", arg0, arg1, arg2);
		}
		
		[JavaSignature("([SII)[S")]
		public static ShortArray copyOfRange(ShortArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<ShortArray>(typeof(Arrays), "copyOfRange", "([SII)[S", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;")]
		public static ObjectArray<T> copyOfRange<T, U>(ObjectArray<U> arg0, int arg1, int arg2, Class<ObjectArray<T>> arg3)
			where T : IJavaObject
			where U : IJavaObject
		{
			return Static.CallMethod<ObjectArray<T>>(typeof(Arrays), "copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;II)[Ljava/lang/Object;")]
		public static ObjectArray<T> copyOfRange<T>(ObjectArray<T> arg0, int arg1, int arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<ObjectArray<T>>(typeof(Arrays), "copyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([ZII)[Z")]
		public static BooleanArray copyOfRange(BooleanArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<BooleanArray>(typeof(Arrays), "copyOfRange", "([ZII)[Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("([DII)[D")]
		public static DoubleArray copyOfRange(DoubleArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<DoubleArray>(typeof(Arrays), "copyOfRange", "([DII)[D", arg0, arg1, arg2);
		}
		
		[JavaSignature("([FII)[F")]
		public static FloatArray copyOfRange(FloatArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<FloatArray>(typeof(Arrays), "copyOfRange", "([FII)[F", arg0, arg1, arg2);
		}
		
		[JavaSignature("([III)[I")]
		public static IntArray copyOfRange(IntArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<IntArray>(typeof(Arrays), "copyOfRange", "([III)[I", arg0, arg1, arg2);
		}
		
		[JavaSignature("([JII)[J")]
		public static LongArray copyOfRange(LongArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<LongArray>(typeof(Arrays), "copyOfRange", "([JII)[J", arg0, arg1, arg2);
		}
		
		[JavaSignature("([CII)[C")]
		public static CharArray copyOfRange(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<CharArray>(typeof(Arrays), "copyOfRange", "([CII)[C", arg0, arg1, arg2);
		}
		
		[JavaSignature("([JII)Ljava/util/Spliterator/OfLong;")]
		public static Spliterator_.OfLong spliterator(LongArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<Spliterator_.OfLong>(typeof(Arrays), "spliterator", "([JII)Ljava/util/Spliterator/OfLong;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([J)Ljava/util/Spliterator/OfLong;")]
		public static Spliterator_.OfLong spliterator(LongArray arg0)
		{
			return Static.CallMethod<Spliterator_.OfLong>(typeof(Arrays), "spliterator", "([J)Ljava/util/Spliterator/OfLong;", arg0);
		}
		
		[JavaSignature("([III)Ljava/util/Spliterator/OfInt;")]
		public static Spliterator_.OfInt spliterator(IntArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<Spliterator_.OfInt>(typeof(Arrays), "spliterator", "([III)Ljava/util/Spliterator/OfInt;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([D)Ljava/util/Spliterator/OfDouble;")]
		public static Spliterator_.OfDouble spliterator(DoubleArray arg0)
		{
			return Static.CallMethod<Spliterator_.OfDouble>(typeof(Arrays), "spliterator", "([D)Ljava/util/Spliterator/OfDouble;", arg0);
		}
		
		[JavaSignature("([DII)Ljava/util/Spliterator/OfDouble;")]
		public static Spliterator_.OfDouble spliterator(DoubleArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<Spliterator_.OfDouble>(typeof(Arrays), "spliterator", "([DII)Ljava/util/Spliterator/OfDouble;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/util/Spliterator;")]
		public static Spliterator<T> spliterator<T>(ObjectArray<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Arrays), "spliterator", "([Ljava/lang/Object;)Ljava/util/Spliterator;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;II)Ljava/util/Spliterator;")]
		public static Spliterator<T> spliterator<T>(ObjectArray<T> arg0, int arg1, int arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Arrays), "spliterator", "([Ljava/lang/Object;II)Ljava/util/Spliterator;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([I)Ljava/util/Spliterator/OfInt;")]
		public static Spliterator_.OfInt spliterator(IntArray arg0)
		{
			return Static.CallMethod<Spliterator_.OfInt>(typeof(Arrays), "spliterator", "([I)Ljava/util/Spliterator/OfInt;", arg0);
		}
		
		[JavaSignature("([I)Ljava/util/stream/IntStream;")]
		public static IntStream stream(IntArray arg0)
		{
			return Static.CallMethod<IntStream>(typeof(Arrays), "stream", "([I)Ljava/util/stream/IntStream;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;II)Ljava/util/stream/Stream;")]
		public static Stream<T> stream<T>(ObjectArray<T> arg0, int arg1, int arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<Stream<T>>(typeof(Arrays), "stream", "([Ljava/lang/Object;II)Ljava/util/stream/Stream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/util/stream/Stream;")]
		public static Stream<T> stream<T>(ObjectArray<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Stream<T>>(typeof(Arrays), "stream", "([Ljava/lang/Object;)Ljava/util/stream/Stream;", arg0);
		}
		
		[JavaSignature("([D)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream stream(DoubleArray arg0)
		{
			return Static.CallMethod<DoubleStream>(typeof(Arrays), "stream", "([D)Ljava/util/stream/DoubleStream;", arg0);
		}
		
		[JavaSignature("([III)Ljava/util/stream/IntStream;")]
		public static IntStream stream(IntArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<IntStream>(typeof(Arrays), "stream", "([III)Ljava/util/stream/IntStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([J)Ljava/util/stream/LongStream;")]
		public static LongStream stream(LongArray arg0)
		{
			return Static.CallMethod<LongStream>(typeof(Arrays), "stream", "([J)Ljava/util/stream/LongStream;", arg0);
		}
		
		[JavaSignature("([JII)Ljava/util/stream/LongStream;")]
		public static LongStream stream(LongArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<LongStream>(typeof(Arrays), "stream", "([JII)Ljava/util/stream/LongStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([DII)Ljava/util/stream/DoubleStream;")]
		public static DoubleStream stream(DoubleArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<DoubleStream>(typeof(Arrays), "stream", "([DII)Ljava/util/stream/DoubleStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/util/List;")]
		public static List<T> asList<T>(ObjectArray<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<List<T>>(typeof(Arrays), "asList", "([Ljava/lang/Object;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("([DIID)V")]
		public static void fill(DoubleArray arg0, int arg1, int arg2, double arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([DIID)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([FF)V")]
		public static void fill(FloatArray arg0, float arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([FF)V", arg0, arg1);
		}
		
		[JavaSignature("([DD)V")]
		public static void fill(DoubleArray arg0, double arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([DD)V", arg0, arg1);
		}
		
		[JavaSignature("([JJ)V")]
		public static void fill(LongArray arg0, long arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([JJ)V", arg0, arg1);
		}
		
		[JavaSignature("([ZIIZ)V")]
		public static void fill(BooleanArray arg0, int arg1, int arg2, bool arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([ZIIZ)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;IILjava/lang/Object;)V")]
		public static void fill(ObjectArray<IJavaObject> arg0, int arg1, int arg2, IJavaObject arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([Ljava/lang/Object;IILjava/lang/Object;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/lang/Object;)V")]
		public static void fill(ObjectArray<IJavaObject> arg0, IJavaObject arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("([FIIF)V")]
		public static void fill(FloatArray arg0, int arg1, int arg2, float arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([FIIF)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([CC)V")]
		public static void fill(CharArray arg0, char arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([CC)V", arg0, arg1);
		}
		
		[JavaSignature("([CIIC)V")]
		public static void fill(CharArray arg0, int arg1, int arg2, char arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([CIIC)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([BB)V")]
		public static void fill(ByteArray arg0, byte arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([BB)V", arg0, arg1);
		}
		
		[JavaSignature("([BIIB)V")]
		public static void fill(ByteArray arg0, int arg1, int arg2, byte arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([BIIB)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([ZZ)V")]
		public static void fill(BooleanArray arg0, bool arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([ZZ)V", arg0, arg1);
		}
		
		[JavaSignature("([JIIJ)V")]
		public static void fill(LongArray arg0, int arg1, int arg2, long arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([JIIJ)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([IIII)V")]
		public static void fill(IntArray arg0, int arg1, int arg2, int arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([IIII)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([SS)V")]
		public static void fill(ShortArray arg0, short arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([SS)V", arg0, arg1);
		}
		
		[JavaSignature("([SIIS)V")]
		public static void fill(ShortArray arg0, int arg1, int arg2, short arg3)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([SIIS)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([II)V")]
		public static void fill(IntArray arg0, int arg1)
		{
			Static.CallMethod(typeof(Arrays), "fill", "([II)V", arg0, arg1);
		}
		
		[JavaSignature("([J)V")]
		public static void sort(LongArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([J)V", arg0);
		}
		
		[JavaSignature("([JII)V")]
		public static void sort(LongArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([JII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)V")]
		public static void sort(ByteArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([B)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public static void sort(ByteArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([F)V")]
		public static void sort(FloatArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([F)V", arg0);
		}
		
		[JavaSignature("([C)V")]
		public static void sort(CharArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([C)V", arg0);
		}
		
		[JavaSignature("([SII)V")]
		public static void sort(ShortArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([SII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([CII)V")]
		public static void sort(CharArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([CII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([S)V")]
		public static void sort(ShortArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([S)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;)V")]
		public static void sort(ObjectArray<IJavaObject> arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;IILjava/util/Comparator;)V")]
		public static void sort<T>(ObjectArray<T> arg0, int arg1, int arg2, Comparator<IJavaObject> arg3)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;II)V")]
		public static void sort(ObjectArray<IJavaObject> arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([Ljava/lang/Object;II)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/util/Comparator;)V")]
		public static void sort<T>(ObjectArray<T> arg0, Comparator<IJavaObject> arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V", arg0, arg1);
		}
		
		[JavaSignature("([I)V")]
		public static void sort(IntArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([I)V", arg0);
		}
		
		[JavaSignature("([FII)V")]
		public static void sort(FloatArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([FII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([DII)V")]
		public static void sort(DoubleArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([DII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([D)V")]
		public static void sort(DoubleArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([D)V", arg0);
		}
		
		[JavaSignature("([III)V")]
		public static void sort(IntArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "sort", "([III)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([IIII)I")]
		public static int binarySearch(IntArray arg0, int arg1, int arg2, int arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([IIII)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([JJ)I")]
		public static int binarySearch(LongArray arg0, long arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([JJ)I", arg0, arg1);
		}
		
		[JavaSignature("([II)I")]
		public static int binarySearch(IntArray arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([II)I", arg0, arg1);
		}
		
		[JavaSignature("([JIIJ)I")]
		public static int binarySearch(LongArray arg0, int arg1, int arg2, long arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([JIIJ)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/lang/Object;)I")]
		public static int binarySearch(ObjectArray<IJavaObject> arg0, IJavaObject arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;)I", arg0, arg1);
		}
		
		[JavaSignature("([FIIF)I")]
		public static int binarySearch(FloatArray arg0, int arg1, int arg2, float arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([FIIF)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([FF)I")]
		public static int binarySearch(FloatArray arg0, float arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([FF)I", arg0, arg1);
		}
		
		[JavaSignature("([DIID)I")]
		public static int binarySearch(DoubleArray arg0, int arg1, int arg2, double arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([DIID)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;IILjava/lang/Object;)I")]
		public static int binarySearch(ObjectArray<IJavaObject> arg0, int arg1, int arg2, IJavaObject arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I")]
		public static int binarySearch<T>(ObjectArray<T> arg0, T arg1, Comparator<IJavaObject> arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I")]
		public static int binarySearch<T>(ObjectArray<T> arg0, int arg1, int arg2, T arg3, Comparator<IJavaObject> arg4)
			where T : IJavaObject
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("([SS)I")]
		public static int binarySearch(ShortArray arg0, short arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([SS)I", arg0, arg1);
		}
		
		[JavaSignature("([SIIS)I")]
		public static int binarySearch(ShortArray arg0, int arg1, int arg2, short arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([SIIS)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([CC)I")]
		public static int binarySearch(CharArray arg0, char arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([CC)I", arg0, arg1);
		}
		
		[JavaSignature("([CIIC)I")]
		public static int binarySearch(CharArray arg0, int arg1, int arg2, char arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([CIIC)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([BB)I")]
		public static int binarySearch(ByteArray arg0, byte arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([BB)I", arg0, arg1);
		}
		
		[JavaSignature("([BIIB)I")]
		public static int binarySearch(ByteArray arg0, int arg1, int arg2, byte arg3)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([BIIB)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([DD)I")]
		public static int binarySearch(DoubleArray arg0, double arg1)
		{
			return Static.CallMethod<int>(typeof(Arrays), "binarySearch", "([DD)I", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;[Ljava/lang/Object;)Z")]
		public static bool deepEquals(ObjectArray<IJavaObject> arg0, ObjectArray<IJavaObject> arg1)
		{
			return Static.CallMethod<bool>(typeof(Arrays), "deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;)I")]
		public static int deepHashCode(ObjectArray<IJavaObject> arg0)
		{
			return Static.CallMethod<int>(typeof(Arrays), "deepHashCode", "([Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;)Ljava/lang/String;")]
		public static String deepToString(ObjectArray<IJavaObject> arg0)
		{
			return Static.CallMethod<String>(typeof(Arrays), "deepToString", "([Ljava/lang/Object;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;IILjava/util/function/BinaryOperator;)V")]
		public static void parallelPrefix<T>(ObjectArray<T> arg0, int arg1, int arg2, BinaryOperator<T> arg3)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([Ljava/lang/Object;IILjava/util/function/BinaryOperator;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([DLjava/util/function/DoubleBinaryOperator;)V")]
		public static void parallelPrefix(DoubleArray arg0, DoubleBinaryOperator arg1)
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([DLjava/util/function/DoubleBinaryOperator;)V", arg0, arg1);
		}
		
		[JavaSignature("([JIILjava/util/function/LongBinaryOperator;)V")]
		public static void parallelPrefix(LongArray arg0, int arg1, int arg2, LongBinaryOperator arg3)
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([JIILjava/util/function/LongBinaryOperator;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([JLjava/util/function/LongBinaryOperator;)V")]
		public static void parallelPrefix(LongArray arg0, LongBinaryOperator arg1)
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([JLjava/util/function/LongBinaryOperator;)V", arg0, arg1);
		}
		
		[JavaSignature("([IIILjava/util/function/IntBinaryOperator;)V")]
		public static void parallelPrefix(IntArray arg0, int arg1, int arg2, IntBinaryOperator arg3)
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([IIILjava/util/function/IntBinaryOperator;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([ILjava/util/function/IntBinaryOperator;)V")]
		public static void parallelPrefix(IntArray arg0, IntBinaryOperator arg1)
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([ILjava/util/function/IntBinaryOperator;)V", arg0, arg1);
		}
		
		[JavaSignature("([DIILjava/util/function/DoubleBinaryOperator;)V")]
		public static void parallelPrefix(DoubleArray arg0, int arg1, int arg2, DoubleBinaryOperator arg3)
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([DIILjava/util/function/DoubleBinaryOperator;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/util/function/BinaryOperator;)V")]
		public static void parallelPrefix<T>(ObjectArray<T> arg0, BinaryOperator<T> arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "parallelPrefix", "([Ljava/lang/Object;Ljava/util/function/BinaryOperator;)V", arg0, arg1);
		}
		
		[JavaSignature("([JLjava/util/function/IntToLongFunction;)V")]
		public static void parallelSetAll(LongArray arg0, IntToLongFunction arg1)
		{
			Static.CallMethod(typeof(Arrays), "parallelSetAll", "([JLjava/util/function/IntToLongFunction;)V", arg0, arg1);
		}
		
		[JavaSignature("([DLjava/util/function/IntToDoubleFunction;)V")]
		public static void parallelSetAll(DoubleArray arg0, IntToDoubleFunction arg1)
		{
			Static.CallMethod(typeof(Arrays), "parallelSetAll", "([DLjava/util/function/IntToDoubleFunction;)V", arg0, arg1);
		}
		
		[JavaSignature("([ILjava/util/function/IntUnaryOperator;)V")]
		public static void parallelSetAll(IntArray arg0, IntUnaryOperator arg1)
		{
			Static.CallMethod(typeof(Arrays), "parallelSetAll", "([ILjava/util/function/IntUnaryOperator;)V", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/util/function/IntFunction;)V")]
		public static void parallelSetAll<T>(ObjectArray<T> arg0, IntFunction<T> arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "parallelSetAll", "([Ljava/lang/Object;Ljava/util/function/IntFunction;)V", arg0, arg1);
		}
		
		[JavaSignature("([JII)V")]
		public static void parallelSort(LongArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([JII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([F)V")]
		public static void parallelSort(FloatArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([F)V", arg0);
		}
		
		[JavaSignature("([FII)V")]
		public static void parallelSort(FloatArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([FII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([J)V")]
		public static void parallelSort(LongArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([J)V", arg0);
		}
		
		[JavaSignature("([III)V")]
		public static void parallelSort(IntArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([III)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/util/Comparator;)V")]
		public static void parallelSort<T>(ObjectArray<T> arg0, Comparator<IJavaObject> arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([Ljava/lang/Object;Ljava/util/Comparator;)V", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Comparable;II)V")]
		public static void parallelSort<T>(ObjectArray<T> arg0, int arg1, int arg2)
			where T : Comparable<IJavaObject>
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([Ljava/lang/Comparable;II)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Comparable;)V")]
		public static void parallelSort<T>(ObjectArray<T> arg0)
			where T : Comparable<IJavaObject>
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([Ljava/lang/Comparable;)V", arg0);
		}
		
		[JavaSignature("([DII)V")]
		public static void parallelSort(DoubleArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([DII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([D)V")]
		public static void parallelSort(DoubleArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([D)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/Object;IILjava/util/Comparator;)V")]
		public static void parallelSort<T>(ObjectArray<T> arg0, int arg1, int arg2, Comparator<IJavaObject> arg3)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([Ljava/lang/Object;IILjava/util/Comparator;)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([C)V")]
		public static void parallelSort(CharArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([C)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public static void parallelSort(ByteArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([I)V")]
		public static void parallelSort(IntArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([I)V", arg0);
		}
		
		[JavaSignature("([B)V")]
		public static void parallelSort(ByteArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([B)V", arg0);
		}
		
		[JavaSignature("([SII)V")]
		public static void parallelSort(ShortArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([SII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([S)V")]
		public static void parallelSort(ShortArray arg0)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([S)V", arg0);
		}
		
		[JavaSignature("([CII)V")]
		public static void parallelSort(CharArray arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Arrays), "parallelSort", "([CII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([DLjava/util/function/IntToDoubleFunction;)V")]
		public static void setAll(DoubleArray arg0, IntToDoubleFunction arg1)
		{
			Static.CallMethod(typeof(Arrays), "setAll", "([DLjava/util/function/IntToDoubleFunction;)V", arg0, arg1);
		}
		
		[JavaSignature("([JLjava/util/function/IntToLongFunction;)V")]
		public static void setAll(LongArray arg0, IntToLongFunction arg1)
		{
			Static.CallMethod(typeof(Arrays), "setAll", "([JLjava/util/function/IntToLongFunction;)V", arg0, arg1);
		}
		
		[JavaSignature("([ILjava/util/function/IntUnaryOperator;)V")]
		public static void setAll(IntArray arg0, IntUnaryOperator arg1)
		{
			Static.CallMethod(typeof(Arrays), "setAll", "([ILjava/util/function/IntUnaryOperator;)V", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/lang/Object;Ljava/util/function/IntFunction;)V")]
		public static void setAll<T>(ObjectArray<T> arg0, IntFunction<T> arg1)
			where T : IJavaObject
		{
			Static.CallMethod(typeof(Arrays), "setAll", "([Ljava/lang/Object;Ljava/util/function/IntFunction;)V", arg0, arg1);
		}
	}
}
