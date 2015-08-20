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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.math
{
	[JavaProxy("java/math/BigDecimal")]
	public partial class BigDecimal : Number, Comparable<BigDecimal>
	{
		protected BigDecimal(ProxyCtor p) : base(p) {}
		
		public BigDecimal(BigInteger arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/math/BigInteger;I)V", arg0, arg1);
		}
		
		public BigDecimal(BigInteger arg0, MathContext arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/math/BigInteger;Ljava/math/MathContext;)V", arg0, arg1);
		}
		
		public BigDecimal(BigInteger arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/math/BigInteger;)V", arg0);
		}
		
		public BigDecimal(double arg0, MathContext arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(DLjava/math/MathContext;)V", arg0, arg1);
		}
		
		public BigDecimal(double arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(D)V", arg0);
		}
		
		public BigDecimal(long arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(J)V", arg0);
		}
		
		public BigDecimal(int arg0, MathContext arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/math/MathContext;)V", arg0, arg1);
		}
		
		public BigDecimal(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public BigDecimal(BigInteger arg0, int arg1, MathContext arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/math/BigInteger;ILjava/math/MathContext;)V", arg0, arg1, arg2);
		}
		
		public BigDecimal(long arg0, MathContext arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(JLjava/math/MathContext;)V", arg0, arg1);
		}
		
		public BigDecimal(CharArray arg0, int arg1, int arg2, MathContext arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([CIILjava/math/MathContext;)V", arg0, arg1, arg2, arg3);
		}
		
		public BigDecimal(CharArray arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([CII)V", arg0, arg1, arg2);
		}
		
		public BigDecimal(String arg0, MathContext arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/math/MathContext;)V", arg0, arg1);
		}
		
		public BigDecimal(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public BigDecimal(CharArray arg0, MathContext arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([CLjava/math/MathContext;)V", arg0, arg1);
		}
		
		public BigDecimal(CharArray arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([C)V", arg0);
		}
	
		[JavaSignature("Ljava/math/BigDecimal;")]
		public static BigDecimal ZERO
		{
			get { return Static.GetField<BigDecimal>(typeof(BigDecimal), "ZERO", "Ljava/math/BigDecimal;"); }
		}
		
		[JavaSignature("Ljava/math/BigDecimal;")]
		public static BigDecimal ONE
		{
			get { return Static.GetField<BigDecimal>(typeof(BigDecimal), "ONE", "Ljava/math/BigDecimal;"); }
		}
		
		[JavaSignature("Ljava/math/BigDecimal;")]
		public static BigDecimal TEN
		{
			get { return Static.GetField<BigDecimal>(typeof(BigDecimal), "TEN", "Ljava/math/BigDecimal;"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_UP
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_UP", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_DOWN
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_DOWN", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_CEILING
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_CEILING", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_FLOOR
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_FLOOR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_HALF_UP
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_HALF_UP", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_HALF_DOWN
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_HALF_DOWN", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_HALF_EVEN
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_HALF_EVEN", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ROUND_UNNECESSARY
		{
			get { return Static.GetField<int>(typeof(BigDecimal), "ROUND_UNNECESSARY", "I"); }
		}
	
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal @add(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal @add(BigDecimal arg0, MathContext arg1)
		{
			return Instance.CallMethod<BigDecimal>("add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal abs(MathContext arg0)
		{
			return Instance.CallMethod<BigDecimal>("abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigDecimal;")]
		public BigDecimal abs()
		{
			return Instance.CallMethod<BigDecimal>("abs", "()Ljava/math/BigDecimal;");
		}
		
		[JavaSignature("(I)Ljava/math/BigDecimal;")]
		public BigDecimal pow(int arg0)
		{
			return Instance.CallMethod<BigDecimal>("pow", "(I)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(ILjava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal pow(int arg0, MathContext arg1)
		{
			return Instance.CallMethod<BigDecimal>("pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal min(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal max(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)I")]
		public int compareTo(BigDecimal arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/math/BigDecimal;)I", arg0);
		}
		
		[JavaSignature("(D)Ljava/math/BigDecimal;")]
		public static BigDecimal valueOf(double arg0)
		{
			return Static.CallMethod<BigDecimal>(typeof(BigDecimal), "valueOf", "(D)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(J)Ljava/math/BigDecimal;")]
		public static BigDecimal valueOf(long arg0)
		{
			return Static.CallMethod<BigDecimal>(typeof(BigDecimal), "valueOf", "(J)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(JI)Ljava/math/BigDecimal;")]
		public static BigDecimal valueOf(long arg0, int arg1)
		{
			return Static.CallMethod<BigDecimal>(typeof(BigDecimal), "valueOf", "(JI)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int signum()
		{
			return Instance.CallMethod<int>("signum", "()I");
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;")]
		public BigDecimal divide(BigDecimal arg0, int arg1)
		{
			return Instance.CallMethod<BigDecimal>("divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;")]
		public BigDecimal divide(BigDecimal arg0, RoundingMode arg1)
		{
			return Instance.CallMethod<BigDecimal>("divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal divide(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal divide(BigDecimal arg0, MathContext arg1)
		{
			return Instance.CallMethod<BigDecimal>("divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;")]
		public BigDecimal divide(BigDecimal arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<BigDecimal>("divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;")]
		public BigDecimal divide(BigDecimal arg0, int arg1, RoundingMode arg2)
		{
			return Instance.CallMethod<BigDecimal>("divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal remainder(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal remainder(BigDecimal arg0, MathContext arg1)
		{
			return Instance.CallMethod<BigDecimal>("remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal round(MathContext arg0)
		{
			return Instance.CallMethod<BigDecimal>("round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigDecimal;")]
		public BigDecimal ulp()
		{
			return Instance.CallMethod<BigDecimal>("ulp", "()Ljava/math/BigDecimal;");
		}
		
		[JavaSignature("()I")]
		public int scale()
		{
			return Instance.CallMethod<int>("scale", "()I");
		}
		
		[JavaSignature("()I")]
		public int precision()
		{
			return Instance.CallMethod<int>("precision", "()I");
		}
		
		[JavaSignature("(II)Ljava/math/BigDecimal;")]
		public BigDecimal setScale(int arg0, int arg1)
		{
			return Instance.CallMethod<BigDecimal>("setScale", "(II)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;")]
		public BigDecimal setScale(int arg0, RoundingMode arg1)
		{
			return Instance.CallMethod<BigDecimal>("setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/math/BigDecimal;")]
		public BigDecimal setScale(int arg0)
		{
			return Instance.CallMethod<BigDecimal>("setScale", "(I)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger unscaledValue()
		{
			return Instance.CallMethod<BigInteger>("unscaledValue", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("(Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal plus(MathContext arg0)
		{
			return Instance.CallMethod<BigDecimal>("plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigDecimal;")]
		public BigDecimal plus()
		{
			return Instance.CallMethod<BigDecimal>("plus", "()Ljava/math/BigDecimal;");
		}
		
		[JavaSignature("()B")]
		public byte byteValueExact()
		{
			return Instance.CallMethod<byte>("byteValueExact", "()B");
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;")]
		public ObjectArray<BigDecimal> divideAndRemainder(BigDecimal arg0, MathContext arg1)
		{
			return Instance.CallMethod<ObjectArray<BigDecimal>>("divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;")]
		public ObjectArray<BigDecimal> divideAndRemainder(BigDecimal arg0)
		{
			return Instance.CallMethod<ObjectArray<BigDecimal>>("divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal divideToIntegralValue(BigDecimal arg0, MathContext arg1)
		{
			return Instance.CallMethod<BigDecimal>("divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal divideToIntegralValue(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("()I")]
		public int intValueExact()
		{
			return Instance.CallMethod<int>("intValueExact", "()I");
		}
		
		[JavaSignature("()J")]
		public long longValueExact()
		{
			return Instance.CallMethod<long>("longValueExact", "()J");
		}
		
		[JavaSignature("(I)Ljava/math/BigDecimal;")]
		public BigDecimal movePointLeft(int arg0)
		{
			return Instance.CallMethod<BigDecimal>("movePointLeft", "(I)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(I)Ljava/math/BigDecimal;")]
		public BigDecimal movePointRight(int arg0)
		{
			return Instance.CallMethod<BigDecimal>("movePointRight", "(I)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal multiply(BigDecimal arg0, MathContext arg1)
		{
			return Instance.CallMethod<BigDecimal>("multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal multiply(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("(I)Ljava/math/BigDecimal;")]
		public BigDecimal scaleByPowerOfTen(int arg0)
		{
			return Instance.CallMethod<BigDecimal>("scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("()S")]
		public short shortValueExact()
		{
			return Instance.CallMethod<short>("shortValueExact", "()S");
		}
		
		[JavaSignature("()Ljava/math/BigDecimal;")]
		public BigDecimal stripTrailingZeros()
		{
			return Instance.CallMethod<BigDecimal>("stripTrailingZeros", "()Ljava/math/BigDecimal;");
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal subtract(BigDecimal arg0, MathContext arg1)
		{
			return Instance.CallMethod<BigDecimal>("subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;")]
		public BigDecimal subtract(BigDecimal arg0)
		{
			return Instance.CallMethod<BigDecimal>("subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger toBigInteger()
		{
			return Instance.CallMethod<BigInteger>("toBigInteger", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger toBigIntegerExact()
		{
			return Instance.CallMethod<BigInteger>("toBigIntegerExact", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toEngineeringString()
		{
			return Instance.CallMethod<String>("toEngineeringString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toPlainString()
		{
			return Instance.CallMethod<String>("toPlainString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/math/BigDecimal;")]
		public BigDecimal negate()
		{
			return Instance.CallMethod<BigDecimal>("negate", "()Ljava/math/BigDecimal;");
		}
		
		[JavaSignature("(Ljava/math/MathContext;)Ljava/math/BigDecimal;")]
		public BigDecimal negate(MathContext arg0)
		{
			return Instance.CallMethod<BigDecimal>("negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
		}
	}
}
