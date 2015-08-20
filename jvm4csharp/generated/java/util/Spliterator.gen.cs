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
	[JavaProxy("java/util/Spliterator")]
	public partial interface Spliterator<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		void forEachRemaining(Consumer<IJavaObject> arg0);
		
		[JavaSignature("()I")]
		int characteristics();
		
		[JavaSignature("()J")]
		long estimateSize();
		
		[JavaSignature("(Ljava/util/function/Consumer;)Z")]
		bool tryAdvance(Consumer<IJavaObject> arg0);
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		Spliterator<T> trySplit();
		
		[JavaSignature("()Ljava/util/Comparator;")]
		Comparator<IJavaObject> getComparator();
		
		[JavaSignature("()J")]
		long getExactSizeIfKnown();
		
		[JavaSignature("(I)Z")]
		bool hasCharacteristics(int arg0);
	}
	
	public static class Spliterator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("I")]
		public static int ORDERED
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "ORDERED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DISTINCT
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "DISTINCT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SORTED
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "SORTED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SIZED
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "SIZED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NONNULL
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "NONNULL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int IMMUTABLE
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "IMMUTABLE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int CONCURRENT
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "CONCURRENT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SUBSIZED
		{
			get { return Static.GetField<int>(typeof(Spliterator<>), "SUBSIZED", "I"); }
		}
	
		[JavaProxy("java/util/Spliterator/OfDouble")]
		public partial interface OfDouble : Spliterator_.OfPrimitive<Double, DoubleConsumer, Spliterator_.OfDouble>
		{
			[JavaSignature("(Ljava/util/function/DoubleConsumer;)V")]
			new void forEachRemaining(DoubleConsumer arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			new void forEachRemaining(Consumer<IJavaObject> arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)Z")]
			new bool tryAdvance(Consumer<IJavaObject> arg0);
			
			[JavaSignature("(Ljava/util/function/DoubleConsumer;)Z")]
			new bool tryAdvance(DoubleConsumer arg0);
			
			[JavaSignature("()Ljava/util/Spliterator/OfDouble;")]
			new Spliterator_.OfDouble trySplit();
		}
		
		[JavaProxy("java/util/Spliterator/OfInt")]
		public partial interface OfInt : Spliterator_.OfPrimitive<Integer, IntConsumer, Spliterator_.OfInt>
		{
			[JavaSignature("(Ljava/util/function/IntConsumer;)V")]
			new void forEachRemaining(IntConsumer arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			new void forEachRemaining(Consumer<IJavaObject> arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)Z")]
			new bool tryAdvance(Consumer<IJavaObject> arg0);
			
			[JavaSignature("(Ljava/util/function/IntConsumer;)Z")]
			new bool tryAdvance(IntConsumer arg0);
			
			[JavaSignature("()Ljava/util/Spliterator/OfInt;")]
			new Spliterator_.OfInt trySplit();
		}
		
		[JavaProxy("java/util/Spliterator/OfLong")]
		public partial interface OfLong : Spliterator_.OfPrimitive<Long, LongConsumer, Spliterator_.OfLong>
		{
			[JavaSignature("(Ljava/util/function/LongConsumer;)V")]
			new void forEachRemaining(LongConsumer arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			new void forEachRemaining(Consumer<IJavaObject> arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)Z")]
			new bool tryAdvance(Consumer<IJavaObject> arg0);
			
			[JavaSignature("(Ljava/util/function/LongConsumer;)Z")]
			new bool tryAdvance(LongConsumer arg0);
			
			[JavaSignature("()Ljava/util/Spliterator/OfLong;")]
			new Spliterator_.OfLong trySplit();
		}
		
		[JavaProxy("java/util/Spliterator/OfPrimitive")]
		public partial interface OfPrimitive<T, T_CONS, T_SPLITR> : Spliterator<T>
			where T : IJavaObject
			where T_CONS : IJavaObject
			where T_SPLITR : Spliterator_.OfPrimitive<T, T_CONS, T_SPLITR>
		{
			[JavaSignature("(Ljava/lang/Object;)V")]
			void forEachRemaining(T_CONS arg0);
			
			[JavaSignature("(Ljava/lang/Object;)Z")]
			bool tryAdvance(T_CONS arg0);
			
			[JavaSignature("()Ljava/util/Spliterator/OfPrimitive;")]
			new T_SPLITR trySplit();
		}
	}
}
