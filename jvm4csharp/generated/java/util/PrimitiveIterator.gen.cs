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
	[JavaProxy("java/util/PrimitiveIterator")]
	public partial interface PrimitiveIterator<T, T_CONS> : Iterator<T>
		where T : IJavaObject
		where T_CONS : IJavaObject
	{
		[JavaSignature("(Ljava/lang/Object;)V")]
		void forEachRemaining(T_CONS arg0);
	}
	
	public static partial class PrimitiveIterator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
	
		[JavaProxy("java/util/PrimitiveIterator/OfDouble")]
		public partial interface OfDouble : PrimitiveIterator<Double, DoubleConsumer>
		{
			[JavaSignature("()Ljava/lang/Double;")]
			new Double next();
			
			[JavaSignature("()D")]
			double nextDouble();
			
			[JavaSignature("(Ljava/util/function/DoubleConsumer;)V")]
			new void forEachRemaining(DoubleConsumer arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			new void forEachRemaining(Consumer<IJavaObject> arg0);
		}
		
		[JavaProxy("java/util/PrimitiveIterator/OfInt")]
		public partial interface OfInt : PrimitiveIterator<Integer, IntConsumer>
		{
			[JavaSignature("()Ljava/lang/Integer;")]
			new Integer next();
			
			[JavaSignature("()I")]
			int nextInt();
			
			[JavaSignature("(Ljava/util/function/IntConsumer;)V")]
			new void forEachRemaining(IntConsumer arg0);
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			new void forEachRemaining(Consumer<IJavaObject> arg0);
		}
		
		[JavaProxy("java/util/PrimitiveIterator/OfLong")]
		public partial interface OfLong : PrimitiveIterator<Long, LongConsumer>
		{
			[JavaSignature("()Ljava/lang/Long;")]
			new Long next();
			
			[JavaSignature("(Ljava/util/function/Consumer;)V")]
			new void forEachRemaining(Consumer<IJavaObject> arg0);
			
			[JavaSignature("(Ljava/util/function/LongConsumer;)V")]
			new void forEachRemaining(LongConsumer arg0);
			
			[JavaSignature("()J")]
			long nextLong();
		}
	}
}
