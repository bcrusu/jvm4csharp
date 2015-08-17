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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Spliterators")]
	public class Spliterators : Object
	{
		protected Spliterators(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/Spliterator;)Ljava/util/Iterator;")]
		public static Iterator<T> iterator<T>(Spliterator<T> arg0)
			where T : IJavaObject
		{
			return Static.CallMethod<Iterator<T>>(typeof(Spliterators), "iterator", "(Ljava/util/Spliterator;)Ljava/util/Iterator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Spliterator/OfInt;)Ljava/util/PrimitiveIterator/OfInt;")]
		public static PrimitiveIterator_.OfInt iterator(Spliterator_.OfInt arg0)
		{
			return Static.CallMethod<PrimitiveIterator_.OfInt>(typeof(Spliterators), "iterator", "(Ljava/util/Spliterator/OfInt;)Ljava/util/PrimitiveIterator/OfInt;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Spliterator/OfLong;)Ljava/util/PrimitiveIterator/OfLong;")]
		public static PrimitiveIterator_.OfLong iterator(Spliterator_.OfLong arg0)
		{
			return Static.CallMethod<PrimitiveIterator_.OfLong>(typeof(Spliterators), "iterator", "(Ljava/util/Spliterator/OfLong;)Ljava/util/PrimitiveIterator/OfLong;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Spliterator/OfDouble;)Ljava/util/PrimitiveIterator/OfDouble;")]
		public static PrimitiveIterator_.OfDouble iterator(Spliterator_.OfDouble arg0)
		{
			return Static.CallMethod<PrimitiveIterator_.OfDouble>(typeof(Spliterators), "iterator", "(Ljava/util/Spliterator/OfDouble;)Ljava/util/PrimitiveIterator/OfDouble;", arg0);
		}
		
		[JavaSignature("([DIII)Ljava/util/Spliterator/OfDouble;")]
		public static Spliterator_.OfDouble spliterator(DoubleArray arg0, int arg1, int arg2, int arg3)
		{
			return Static.CallMethod<Spliterator_.OfDouble>(typeof(Spliterators), "spliterator", "([DIII)Ljava/util/Spliterator/OfDouble;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/util/Collection;I)Ljava/util/Spliterator;")]
		public static Spliterator<T> spliterator<T>(Collection<T> arg0, int arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Spliterators), "spliterator", "(Ljava/util/Collection;I)Ljava/util/Spliterator;", arg0, arg1);
		}
		
		[JavaSignature("([DI)Ljava/util/Spliterator/OfDouble;")]
		public static Spliterator_.OfDouble spliterator(DoubleArray arg0, int arg1)
		{
			return Static.CallMethod<Spliterator_.OfDouble>(typeof(Spliterators), "spliterator", "([DI)Ljava/util/Spliterator/OfDouble;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/PrimitiveIterator/OfInt;JI)Ljava/util/Spliterator/OfInt;")]
		public static Spliterator_.OfInt spliterator(PrimitiveIterator_.OfInt arg0, long arg1, int arg2)
		{
			return Static.CallMethod<Spliterator_.OfInt>(typeof(Spliterators), "spliterator", "(Ljava/util/PrimitiveIterator/OfInt;JI)Ljava/util/Spliterator/OfInt;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/PrimitiveIterator/OfLong;JI)Ljava/util/Spliterator/OfLong;")]
		public static Spliterator_.OfLong spliterator(PrimitiveIterator_.OfLong arg0, long arg1, int arg2)
		{
			return Static.CallMethod<Spliterator_.OfLong>(typeof(Spliterators), "spliterator", "(Ljava/util/PrimitiveIterator/OfLong;JI)Ljava/util/Spliterator/OfLong;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/PrimitiveIterator/OfDouble;JI)Ljava/util/Spliterator/OfDouble;")]
		public static Spliterator_.OfDouble spliterator(PrimitiveIterator_.OfDouble arg0, long arg1, int arg2)
		{
			return Static.CallMethod<Spliterator_.OfDouble>(typeof(Spliterators), "spliterator", "(Ljava/util/PrimitiveIterator/OfDouble;JI)Ljava/util/Spliterator/OfDouble;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([JI)Ljava/util/Spliterator/OfLong;")]
		public static Spliterator_.OfLong spliterator(LongArray arg0, int arg1)
		{
			return Static.CallMethod<Spliterator_.OfLong>(typeof(Spliterators), "spliterator", "([JI)Ljava/util/Spliterator/OfLong;", arg0, arg1);
		}
		
		[JavaSignature("([II)Ljava/util/Spliterator/OfInt;")]
		public static Spliterator_.OfInt spliterator(IntArray arg0, int arg1)
		{
			return Static.CallMethod<Spliterator_.OfInt>(typeof(Spliterators), "spliterator", "([II)Ljava/util/Spliterator/OfInt;", arg0, arg1);
		}
		
		[JavaSignature("([IIII)Ljava/util/Spliterator/OfInt;")]
		public static Spliterator_.OfInt spliterator(IntArray arg0, int arg1, int arg2, int arg3)
		{
			return Static.CallMethod<Spliterator_.OfInt>(typeof(Spliterators), "spliterator", "([IIII)Ljava/util/Spliterator/OfInt;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([Ljava/lang/Object;III)Ljava/util/Spliterator;")]
		public static Spliterator<T> spliterator<T>(ObjectArray<IJavaObject> arg0, int arg1, int arg2, int arg3)
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Spliterators), "spliterator", "([Ljava/lang/Object;III)Ljava/util/Spliterator;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([JIII)Ljava/util/Spliterator/OfLong;")]
		public static Spliterator_.OfLong spliterator(LongArray arg0, int arg1, int arg2, int arg3)
		{
			return Static.CallMethod<Spliterator_.OfLong>(typeof(Spliterators), "spliterator", "([JIII)Ljava/util/Spliterator/OfLong;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/util/Iterator;JI)Ljava/util/Spliterator;")]
		public static Spliterator<T> spliterator<T>(Iterator<T> arg0, long arg1, int arg2)
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Spliterators), "spliterator", "(Ljava/util/Iterator;JI)Ljava/util/Spliterator;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/lang/Object;I)Ljava/util/Spliterator;")]
		public static Spliterator<T> spliterator<T>(ObjectArray<IJavaObject> arg0, int arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Spliterators), "spliterator", "([Ljava/lang/Object;I)Ljava/util/Spliterator;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/PrimitiveIterator/OfLong;I)Ljava/util/Spliterator/OfLong;")]
		public static Spliterator_.OfLong spliteratorUnknownSize(PrimitiveIterator_.OfLong arg0, int arg1)
		{
			return Static.CallMethod<Spliterator_.OfLong>(typeof(Spliterators), "spliteratorUnknownSize", "(Ljava/util/PrimitiveIterator/OfLong;I)Ljava/util/Spliterator/OfLong;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/PrimitiveIterator/OfDouble;I)Ljava/util/Spliterator/OfDouble;")]
		public static Spliterator_.OfDouble spliteratorUnknownSize(PrimitiveIterator_.OfDouble arg0, int arg1)
		{
			return Static.CallMethod<Spliterator_.OfDouble>(typeof(Spliterators), "spliteratorUnknownSize", "(Ljava/util/PrimitiveIterator/OfDouble;I)Ljava/util/Spliterator/OfDouble;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/PrimitiveIterator/OfInt;I)Ljava/util/Spliterator/OfInt;")]
		public static Spliterator_.OfInt spliteratorUnknownSize(PrimitiveIterator_.OfInt arg0, int arg1)
		{
			return Static.CallMethod<Spliterator_.OfInt>(typeof(Spliterators), "spliteratorUnknownSize", "(Ljava/util/PrimitiveIterator/OfInt;I)Ljava/util/Spliterator/OfInt;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Iterator;I)Ljava/util/Spliterator;")]
		public static Spliterator<T> spliteratorUnknownSize<T>(Iterator<T> arg0, int arg1)
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Spliterators), "spliteratorUnknownSize", "(Ljava/util/Iterator;I)Ljava/util/Spliterator;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		public static Spliterator<T> emptySpliterator<T>()
			where T : IJavaObject
		{
			return Static.CallMethod<Spliterator<T>>(typeof(Spliterators), "emptySpliterator", "()Ljava/util/Spliterator;");
		}
		
		[JavaSignature("()Ljava/util/Spliterator/OfDouble;")]
		public static Spliterator_.OfDouble emptyDoubleSpliterator()
		{
			return Static.CallMethod<Spliterator_.OfDouble>(typeof(Spliterators), "emptyDoubleSpliterator", "()Ljava/util/Spliterator/OfDouble;");
		}
		
		[JavaSignature("()Ljava/util/Spliterator/OfInt;")]
		public static Spliterator_.OfInt emptyIntSpliterator()
		{
			return Static.CallMethod<Spliterator_.OfInt>(typeof(Spliterators), "emptyIntSpliterator", "()Ljava/util/Spliterator/OfInt;");
		}
		
		[JavaSignature("()Ljava/util/Spliterator/OfLong;")]
		public static Spliterator_.OfLong emptyLongSpliterator()
		{
			return Static.CallMethod<Spliterator_.OfLong>(typeof(Spliterators), "emptyLongSpliterator", "()Ljava/util/Spliterator/OfLong;");
		}
	
		[JavaProxy("java/util/Spliterators/AbstractDoubleSpliterator")]
		public abstract class AbstractDoubleSpliterator : Object, Spliterator_.OfDouble
		{
			protected AbstractDoubleSpliterator(ProxyCtor p) : base(p) {}
		
			[JavaSignature("()I")]
			public int characteristics()
			{
				return Instance.CallMethod<int>("characteristics", "()I");
			}
			
			[JavaSignature("()J")]
			public long estimateSize()
			{
				return Instance.CallMethod<long>("estimateSize", "()J");
			}
			
			[JavaSignature("()Ljava/util/Spliterator/OfDouble;")]
			public Spliterator_.OfDouble trySplit()
			{
				return Instance.CallMethod<Spliterator_.OfDouble>("trySplit", "()Ljava/util/Spliterator/OfDouble;");
			}
			
			[JavaSignature("(Ljava/util/function/DoubleConsumer;)V")]
			public void forEachRemaining(DoubleConsumer arg0)
			{
				Instance.CallMethod("forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			public void forEachRemaining(Consumer<IJavaObject> arg0)
			{
				Instance.CallMethod("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)Z")]
			public bool tryAdvance(Consumer<IJavaObject> arg0)
			{
				return Instance.CallMethod<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/DoubleConsumer;)Z")]
			public bool tryAdvance(DoubleConsumer arg0)
			{
				return Instance.CallMethod<bool>("tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z", arg0);
			}
			
			[JavaSignature("()Ljava/util/Spliterator;")]
			Spliterator<Double> Spliterator<Double>.trySplit()
			{
				return Instance.CallMethod<Spliterator<Double>>("trySplit", "()Ljava/util/Spliterator;");
			}
			
			[JavaSignature("()Ljava/util/Comparator;")]
			public Comparator<IJavaObject> getComparator()
			{
				return Instance.CallMethod<Comparator<IJavaObject>>("getComparator", "()Ljava/util/Comparator;");
			}
			
			[JavaSignature("()J")]
			public long getExactSizeIfKnown()
			{
				return Instance.CallMethod<long>("getExactSizeIfKnown", "()J");
			}
			
			[JavaSignature("(I)Z")]
			public bool hasCharacteristics(int arg0)
			{
				return Instance.CallMethod<bool>("hasCharacteristics", "(I)Z", arg0);
			}
		}
		
		[JavaProxy("java/util/Spliterators/AbstractIntSpliterator")]
		public abstract class AbstractIntSpliterator : Object, Spliterator_.OfInt
		{
			protected AbstractIntSpliterator(ProxyCtor p) : base(p) {}
		
			[JavaSignature("()I")]
			public int characteristics()
			{
				return Instance.CallMethod<int>("characteristics", "()I");
			}
			
			[JavaSignature("()J")]
			public long estimateSize()
			{
				return Instance.CallMethod<long>("estimateSize", "()J");
			}
			
			[JavaSignature("()Ljava/util/Spliterator/OfInt;")]
			public Spliterator_.OfInt trySplit()
			{
				return Instance.CallMethod<Spliterator_.OfInt>("trySplit", "()Ljava/util/Spliterator/OfInt;");
			}
			
			[JavaSignature("(Ljava/util/function/IntConsumer;)V")]
			public void forEachRemaining(IntConsumer arg0)
			{
				Instance.CallMethod("forEachRemaining", "(Ljava/util/function/IntConsumer;)V", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			public void forEachRemaining(Consumer<IJavaObject> arg0)
			{
				Instance.CallMethod("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)Z")]
			public bool tryAdvance(Consumer<IJavaObject> arg0)
			{
				return Instance.CallMethod<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/IntConsumer;)Z")]
			public bool tryAdvance(IntConsumer arg0)
			{
				return Instance.CallMethod<bool>("tryAdvance", "(Ljava/util/function/IntConsumer;)Z", arg0);
			}
			
			[JavaSignature("()Ljava/util/Spliterator;")]
			Spliterator<Integer> Spliterator<Integer>.trySplit()
			{
				return Instance.CallMethod<Spliterator<Integer>>("trySplit", "()Ljava/util/Spliterator;");
			}
			
			[JavaSignature("()Ljava/util/Comparator;")]
			public Comparator<IJavaObject> getComparator()
			{
				return Instance.CallMethod<Comparator<IJavaObject>>("getComparator", "()Ljava/util/Comparator;");
			}
			
			[JavaSignature("()J")]
			public long getExactSizeIfKnown()
			{
				return Instance.CallMethod<long>("getExactSizeIfKnown", "()J");
			}
			
			[JavaSignature("(I)Z")]
			public bool hasCharacteristics(int arg0)
			{
				return Instance.CallMethod<bool>("hasCharacteristics", "(I)Z", arg0);
			}
		}
		
		[JavaProxy("java/util/Spliterators/AbstractLongSpliterator")]
		public abstract class AbstractLongSpliterator : Object, Spliterator_.OfLong
		{
			protected AbstractLongSpliterator(ProxyCtor p) : base(p) {}
		
			[JavaSignature("()I")]
			public int characteristics()
			{
				return Instance.CallMethod<int>("characteristics", "()I");
			}
			
			[JavaSignature("()J")]
			public long estimateSize()
			{
				return Instance.CallMethod<long>("estimateSize", "()J");
			}
			
			[JavaSignature("()Ljava/util/Spliterator/OfLong;")]
			public Spliterator_.OfLong trySplit()
			{
				return Instance.CallMethod<Spliterator_.OfLong>("trySplit", "()Ljava/util/Spliterator/OfLong;");
			}
			
			[JavaSignature("(Ljava/util/function/LongConsumer;)V")]
			public void forEachRemaining(LongConsumer arg0)
			{
				Instance.CallMethod("forEachRemaining", "(Ljava/util/function/LongConsumer;)V", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			public void forEachRemaining(Consumer<IJavaObject> arg0)
			{
				Instance.CallMethod("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)Z")]
			public bool tryAdvance(Consumer<IJavaObject> arg0)
			{
				return Instance.CallMethod<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/LongConsumer;)Z")]
			public bool tryAdvance(LongConsumer arg0)
			{
				return Instance.CallMethod<bool>("tryAdvance", "(Ljava/util/function/LongConsumer;)Z", arg0);
			}
			
			[JavaSignature("()Ljava/util/Spliterator;")]
			Spliterator<Long> Spliterator<Long>.trySplit()
			{
				return Instance.CallMethod<Spliterator<Long>>("trySplit", "()Ljava/util/Spliterator;");
			}
			
			[JavaSignature("()Ljava/util/Comparator;")]
			public Comparator<IJavaObject> getComparator()
			{
				return Instance.CallMethod<Comparator<IJavaObject>>("getComparator", "()Ljava/util/Comparator;");
			}
			
			[JavaSignature("()J")]
			public long getExactSizeIfKnown()
			{
				return Instance.CallMethod<long>("getExactSizeIfKnown", "()J");
			}
			
			[JavaSignature("(I)Z")]
			public bool hasCharacteristics(int arg0)
			{
				return Instance.CallMethod<bool>("hasCharacteristics", "(I)Z", arg0);
			}
		}
		
		[JavaProxy("java/util/Spliterators/AbstractSpliterator")]
		public abstract class AbstractSpliterator<T> : Object, Spliterator<T>
			where T : IJavaObject
		{
			protected AbstractSpliterator(ProxyCtor p) : base(p) {}
		
			[JavaSignature("()I")]
			public int characteristics()
			{
				return Instance.CallMethod<int>("characteristics", "()I");
			}
			
			[JavaSignature("()J")]
			public long estimateSize()
			{
				return Instance.CallMethod<long>("estimateSize", "()J");
			}
			
			[JavaSignature("()Ljava/util/Spliterator;")]
			public Spliterator<T> trySplit()
			{
				return Instance.CallMethod<Spliterator<T>>("trySplit", "()Ljava/util/Spliterator;");
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			public void forEachRemaining(Consumer<IJavaObject> arg0)
			{
				Instance.CallMethod("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
			}
			
			[JavaSignature("(Ljava/util/function/Consumer;)Z")]
			public bool tryAdvance(Consumer<IJavaObject> arg0)
			{
				return Instance.CallMethod<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
			}
			
			[JavaSignature("()Ljava/util/Comparator;")]
			public Comparator<IJavaObject> getComparator()
			{
				return Instance.CallMethod<Comparator<IJavaObject>>("getComparator", "()Ljava/util/Comparator;");
			}
			
			[JavaSignature("()J")]
			public long getExactSizeIfKnown()
			{
				return Instance.CallMethod<long>("getExactSizeIfKnown", "()J");
			}
			
			[JavaSignature("(I)Z")]
			public bool hasCharacteristics(int arg0)
			{
				return Instance.CallMethod<bool>("hasCharacteristics", "(I)Z", arg0);
			}
		}
	}
}
