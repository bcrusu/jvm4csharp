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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.math
{
	[JavaProxy("java/math/BigInteger")]
	public class BigInteger : Number, Comparable<BigInteger>
	{
		protected BigInteger(ProxyCtor p) : base(p) {}
		
		public BigInteger(int arg0, int arg1, Random arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IILjava/util/Random;)V", arg0, arg1, arg2);
		}
		
		public BigInteger(ByteArray arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([B)V", arg0);
		}
		
		public BigInteger(int arg0, ByteArray arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I[B)V", arg0, arg1);
		}
		
		public BigInteger(int arg0, Random arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/util/Random;)V", arg0, arg1);
		}
		
		public BigInteger(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public BigInteger(String arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;I)V", arg0, arg1);
		}
	
		[JavaSignature("Ljava/math/BigInteger;")]
		public static BigInteger ZERO
		{
			get { return Static.GetField<BigInteger>(typeof(BigInteger), "ZERO", "Ljava/math/BigInteger;"); }
		}
		
		[JavaSignature("Ljava/math/BigInteger;")]
		public static BigInteger ONE
		{
			get { return Static.GetField<BigInteger>(typeof(BigInteger), "ONE", "Ljava/math/BigInteger;"); }
		}
		
		[JavaSignature("Ljava/math/BigInteger;")]
		public static BigInteger TEN
		{
			get { return Static.GetField<BigInteger>(typeof(BigInteger), "TEN", "Ljava/math/BigInteger;"); }
		}
	
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger and(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger andNot(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger or(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("()[B")]
		public ByteArray toByteArray()
		{
			return Instance.CallMethod<ByteArray>("toByteArray", "()[B");
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger xor(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger @add(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("()I")]
		public int bitCount()
		{
			return Instance.CallMethod<int>("bitCount", "()I");
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public String toString(int arg0)
		{
			return Instance.CallMethod<String>("toString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger abs()
		{
			return Instance.CallMethod<BigInteger>("abs", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("(I)Ljava/math/BigInteger;")]
		public BigInteger pow(int arg0)
		{
			return Instance.CallMethod<BigInteger>("pow", "(I)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger min(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger max(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)I")]
		public int compareTo(BigInteger arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/math/BigInteger;)I", arg0);
		}
		
		[JavaSignature("(J)Ljava/math/BigInteger;")]
		public static BigInteger valueOf(long arg0)
		{
			return Static.CallMethod<BigInteger>(typeof(BigInteger), "valueOf", "(J)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("()I")]
		public int signum()
		{
			return Instance.CallMethod<int>("signum", "()I");
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger divide(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger remainder(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(I)Ljava/math/BigInteger;")]
		public BigInteger shiftLeft(int arg0)
		{
			return Instance.CallMethod<BigInteger>("shiftLeft", "(I)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger mod(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger not()
		{
			return Instance.CallMethod<BigInteger>("not", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger negate()
		{
			return Instance.CallMethod<BigInteger>("negate", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("()I")]
		public int bitLength()
		{
			return Instance.CallMethod<int>("bitLength", "()I");
		}
		
		[JavaSignature("()B")]
		public byte byteValueExact()
		{
			return Instance.CallMethod<byte>("byteValueExact", "()B");
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)[Ljava/math/BigInteger;")]
		public ObjectArray<BigInteger> divideAndRemainder(BigInteger arg0)
		{
			return Instance.CallMethod<ObjectArray<BigInteger>>("divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;", arg0);
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
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger multiply(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("()S")]
		public short shortValueExact()
		{
			return Instance.CallMethod<short>("shortValueExact", "()S");
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger subtract(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public bool testBit(int arg0)
		{
			return Instance.CallMethod<bool>("testBit", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Ljava/math/BigInteger;")]
		public BigInteger clearBit(int arg0)
		{
			return Instance.CallMethod<BigInteger>("clearBit", "(I)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(I)Ljava/math/BigInteger;")]
		public BigInteger flipBit(int arg0)
		{
			return Instance.CallMethod<BigInteger>("flipBit", "(I)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger gcd(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("()I")]
		public int getLowestSetBit()
		{
			return Instance.CallMethod<int>("getLowestSetBit", "()I");
		}
		
		[JavaSignature("(I)Z")]
		public bool isProbablePrime(int arg0)
		{
			return Instance.CallMethod<bool>("isProbablePrime", "(I)Z", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger modInverse(BigInteger arg0)
		{
			return Instance.CallMethod<BigInteger>("modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;")]
		public BigInteger modPow(BigInteger arg0, BigInteger arg1)
		{
			return Instance.CallMethod<BigInteger>("modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger nextProbablePrime()
		{
			return Instance.CallMethod<BigInteger>("nextProbablePrime", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("(ILjava/util/Random;)Ljava/math/BigInteger;")]
		public static BigInteger probablePrime(int arg0, Random arg1)
		{
			return Static.CallMethod<BigInteger>(typeof(BigInteger), "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/math/BigInteger;")]
		public BigInteger setBit(int arg0)
		{
			return Instance.CallMethod<BigInteger>("setBit", "(I)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("(I)Ljava/math/BigInteger;")]
		public BigInteger shiftRight(int arg0)
		{
			return Instance.CallMethod<BigInteger>("shiftRight", "(I)Ljava/math/BigInteger;", arg0);
		}
	}
}
