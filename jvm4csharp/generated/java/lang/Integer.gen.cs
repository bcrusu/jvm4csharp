//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Integer")]
	public class Integer : Number, Comparable<Integer>
	{
		protected Integer(ProxyCtor p) : base(p) {}
		
		public Integer(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public Integer(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("I")]
		public static int MIN_VALUE
		{
			get { return Static.GetField<int>(typeof(Integer), "MIN_VALUE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_VALUE
		{
			get { return Static.GetField<int>(typeof(Integer), "MAX_VALUE", "I"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Integer> TYPE
		{
			get { return Static.GetField<Class<Integer>>(typeof(Integer), "TYPE", "Ljava/lang/Class;"); }
		}
		
		[JavaSignature("I")]
		public static int SIZE
		{
			get { return Static.GetField<int>(typeof(Integer), "SIZE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BYTES
		{
			get { return Static.GetField<int>(typeof(Integer), "BYTES", "I"); }
		}
	
		[JavaSignature("(I)I")]
		public static int numberOfLeadingZeros(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "numberOfLeadingZeros", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int numberOfTrailingZeros(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "numberOfTrailingZeros", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int bitCount(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "bitCount", "(I)I", arg0);
		}
		
		[JavaSignature("(II)Ljava/lang/String;")]
		public static String toString(int arg0, int arg1)
		{
			return Static.CallMethod<String>(typeof(Integer), "toString", "(II)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String toString(int arg0)
		{
			return Static.CallMethod<String>(typeof(Integer), "toString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int hashCode(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "hashCode", "(I)I", arg0);
		}
		
		[JavaSignature("(II)I")]
		public static int min(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "min", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int max(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "max", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public static int reverseBytes(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "reverseBytes", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Integer;)I")]
		public int compareTo(Integer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Integer;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/Integer;")]
		public static Integer valueOf(String arg0, int arg1)
		{
			return Static.CallMethod<Integer>(typeof(Integer), "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/lang/Integer;")]
		public static Integer valueOf(int arg0)
		{
			return Static.CallMethod<Integer>(typeof(Integer), "valueOf", "(I)Ljava/lang/Integer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Integer;")]
		public static Integer valueOf(String arg0)
		{
			return Static.CallMethod<Integer>(typeof(Integer), "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String toHexString(int arg0)
		{
			return Static.CallMethod<String>(typeof(Integer), "toHexString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(II)I")]
		public static int compare(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "compare", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Integer;")]
		public static Integer decode(String arg0)
		{
			return Static.CallMethod<Integer>(typeof(Integer), "decode", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int reverse(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "reverse", "(I)I", arg0);
		}
		
		[JavaSignature("(II)I")]
		public static int sum(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "sum", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)I")]
		public static int parseInt(String arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "parseInt", "(Ljava/lang/String;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)I")]
		public static int parseInt(String arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "parseInt", "(Ljava/lang/String;I)I", arg0, arg1);
		}
		
		[JavaSignature("(I)J")]
		public static long toUnsignedLong(int arg0)
		{
			return Static.CallMethod<long>(typeof(Integer), "toUnsignedLong", "(I)J", arg0);
		}
		
		[JavaSignature("(II)I")]
		public static int compareUnsigned(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "compareUnsigned", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int divideUnsigned(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "divideUnsigned", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;")]
		public static Integer getInteger(String arg0, Integer arg1)
		{
			return Static.CallMethod<Integer>(typeof(Integer), "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/Integer;")]
		public static Integer getInteger(String arg0, int arg1)
		{
			return Static.CallMethod<Integer>(typeof(Integer), "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Integer;")]
		public static Integer getInteger(String arg0)
		{
			return Static.CallMethod<Integer>(typeof(Integer), "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int highestOneBit(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "highestOneBit", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int lowestOneBit(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "lowestOneBit", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)I")]
		public static int parseUnsignedInt(String arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "parseUnsignedInt", "(Ljava/lang/String;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)I")]
		public static int parseUnsignedInt(String arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "parseUnsignedInt", "(Ljava/lang/String;I)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int remainderUnsigned(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "remainderUnsigned", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int rotateLeft(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "rotateLeft", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int rotateRight(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Integer), "rotateRight", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public static int signum(int arg0)
		{
			return Static.CallMethod<int>(typeof(Integer), "signum", "(I)I", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String toBinaryString(int arg0)
		{
			return Static.CallMethod<String>(typeof(Integer), "toBinaryString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String toOctalString(int arg0)
		{
			return Static.CallMethod<String>(typeof(Integer), "toOctalString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String toUnsignedString(int arg0)
		{
			return Static.CallMethod<String>(typeof(Integer), "toUnsignedString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(II)Ljava/lang/String;")]
		public static String toUnsignedString(int arg0, int arg1)
		{
			return Static.CallMethod<String>(typeof(Integer), "toUnsignedString", "(II)Ljava/lang/String;", arg0, arg1);
		}
	}
}
