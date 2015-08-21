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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Random")]
	public partial class Random : Object, Serializable
	{
		protected Random(ProxyCtor p) : base(p) {}
		
		public Random() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Random(long arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(J)V", arg0);
		}
	
		[JavaSignature("()D")]
		public double nextDouble()
		{
			return Instance.CallMethod<double>("nextDouble", "()D");
		}
		
		[JavaSignature("()I")]
		public int nextInt()
		{
			return Instance.CallMethod<int>("nextInt", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int nextInt(int arg0)
		{
			return Instance.CallMethod<int>("nextInt", "(I)I", arg0);
		}
		
		[JavaSignature("(DD)Ljava/util/stream/DoubleStream;")]
		public DoubleStream doubles(double arg0, double arg1)
		{
			return Instance.CallMethod<DoubleStream>("doubles", "(DD)Ljava/util/stream/DoubleStream;", arg0, arg1);
		}
		
		[JavaSignature("(JDD)Ljava/util/stream/DoubleStream;")]
		public DoubleStream doubles(long arg0, double arg1, double arg2)
		{
			return Instance.CallMethod<DoubleStream>("doubles", "(JDD)Ljava/util/stream/DoubleStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(J)Ljava/util/stream/DoubleStream;")]
		public DoubleStream doubles(long arg0)
		{
			return Instance.CallMethod<DoubleStream>("doubles", "(J)Ljava/util/stream/DoubleStream;", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/DoubleStream;")]
		public DoubleStream doubles()
		{
			return Instance.CallMethod<DoubleStream>("doubles", "()Ljava/util/stream/DoubleStream;");
		}
		
		[JavaSignature("(II)Ljava/util/stream/IntStream;")]
		public IntStream ints(int arg0, int arg1)
		{
			return Instance.CallMethod<IntStream>("ints", "(II)Ljava/util/stream/IntStream;", arg0, arg1);
		}
		
		[JavaSignature("(JII)Ljava/util/stream/IntStream;")]
		public IntStream ints(long arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<IntStream>("ints", "(JII)Ljava/util/stream/IntStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream ints()
		{
			return Instance.CallMethod<IntStream>("ints", "()Ljava/util/stream/IntStream;");
		}
		
		[JavaSignature("(J)Ljava/util/stream/IntStream;")]
		public IntStream ints(long arg0)
		{
			return Instance.CallMethod<IntStream>("ints", "(J)Ljava/util/stream/IntStream;", arg0);
		}
		
		[JavaSignature("(JJJ)Ljava/util/stream/LongStream;")]
		public LongStream longs(long arg0, long arg1, long arg2)
		{
			return Instance.CallMethod<LongStream>("longs", "(JJJ)Ljava/util/stream/LongStream;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(JJ)Ljava/util/stream/LongStream;")]
		public LongStream longs(long arg0, long arg1)
		{
			return Instance.CallMethod<LongStream>("longs", "(JJ)Ljava/util/stream/LongStream;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/stream/LongStream;")]
		public LongStream longs()
		{
			return Instance.CallMethod<LongStream>("longs", "()Ljava/util/stream/LongStream;");
		}
		
		[JavaSignature("(J)Ljava/util/stream/LongStream;")]
		public LongStream longs(long arg0)
		{
			return Instance.CallMethod<LongStream>("longs", "(J)Ljava/util/stream/LongStream;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool nextBoolean()
		{
			return Instance.CallMethod<bool>("nextBoolean", "()Z");
		}
		
		[JavaSignature("([B)V")]
		public void nextBytes(ByteArray arg0)
		{
			Instance.CallMethod("nextBytes", "([B)V", arg0);
		}
		
		[JavaSignature("()F")]
		public float nextFloat()
		{
			return Instance.CallMethod<float>("nextFloat", "()F");
		}
		
		[JavaSignature("()D")]
		public double nextGaussian()
		{
			return Instance.CallMethod<double>("nextGaussian", "()D");
		}
		
		[JavaSignature("()J")]
		public long nextLong()
		{
			return Instance.CallMethod<long>("nextLong", "()J");
		}
		
		[JavaSignature("(J)V")]
		public void setSeed(long arg0)
		{
			Instance.CallMethod("setSeed", "(J)V", arg0);
		}
	}
}
