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
	[JavaProxy("java/lang/Long")]
	public class Long : Number, Comparable<Long>
	{
		protected Long(ProxyCtor p) : base(p) {}
		
		public Long(long arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(J)V", arg0);
		}
		
		public Long(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("J")]
		public static long MIN_VALUE
		{
			get { return Static.GetField<long>(typeof(Long), "MIN_VALUE", "J"); }
		}
		
		[JavaSignature("J")]
		public static long MAX_VALUE
		{
			get { return Static.GetField<long>(typeof(Long), "MAX_VALUE", "J"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Long> TYPE
		{
			get { return Static.GetField<Class<Long>>(typeof(Long), "TYPE", "Ljava/lang/Class;"); }
		}
		
		[JavaSignature("I")]
		public static int SIZE
		{
			get { return Static.GetField<int>(typeof(Long), "SIZE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BYTES
		{
			get { return Static.GetField<int>(typeof(Long), "BYTES", "I"); }
		}
	
		[JavaSignature("(J)I")]
		public static int numberOfLeadingZeros(long arg0)
		{
			return Static.CallMethod<int>(typeof(Long), "numberOfLeadingZeros", "(J)I", arg0);
		}
		
		[JavaSignature("(J)I")]
		public static int numberOfTrailingZeros(long arg0)
		{
			return Static.CallMethod<int>(typeof(Long), "numberOfTrailingZeros", "(J)I", arg0);
		}
		
		[JavaSignature("(J)I")]
		public static int bitCount(long arg0)
		{
			return Static.CallMethod<int>(typeof(Long), "bitCount", "(J)I", arg0);
		}
		
		[JavaSignature("(JI)Ljava/lang/String;")]
		public static String toString(long arg0, int arg1)
		{
			return Static.CallMethod<String>(typeof(Long), "toString", "(JI)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(J)Ljava/lang/String;")]
		public static String toString(long arg0)
		{
			return Static.CallMethod<String>(typeof(Long), "toString", "(J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(J)I")]
		public static int hashCode(long arg0)
		{
			return Static.CallMethod<int>(typeof(Long), "hashCode", "(J)I", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public static long min(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "min", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long max(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "max", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(J)J")]
		public static long reverseBytes(long arg0)
		{
			return Static.CallMethod<long>(typeof(Long), "reverseBytes", "(J)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Long;)I")]
		public int compareTo(Long arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Long;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;")]
		public static Long getLong(String arg0, Long arg1)
		{
			return Static.CallMethod<Long>(typeof(Long), "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;J)Ljava/lang/Long;")]
		public static Long getLong(String arg0, long arg1)
		{
			return Static.CallMethod<Long>(typeof(Long), "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Long;")]
		public static Long getLong(String arg0)
		{
			return Static.CallMethod<Long>(typeof(Long), "getLong", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/Long;")]
		public static Long valueOf(long arg0)
		{
			return Static.CallMethod<Long>(typeof(Long), "valueOf", "(J)Ljava/lang/Long;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/Long;")]
		public static Long valueOf(String arg0, int arg1)
		{
			return Static.CallMethod<Long>(typeof(Long), "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Long;")]
		public static Long valueOf(String arg0)
		{
			return Static.CallMethod<Long>(typeof(Long), "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/String;")]
		public static String toHexString(long arg0)
		{
			return Static.CallMethod<String>(typeof(Long), "toHexString", "(J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(JJ)I")]
		public static int compare(long arg0, long arg1)
		{
			return Static.CallMethod<int>(typeof(Long), "compare", "(JJ)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Long;")]
		public static Long decode(String arg0)
		{
			return Static.CallMethod<Long>(typeof(Long), "decode", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
		}
		
		[JavaSignature("(J)J")]
		public static long reverse(long arg0)
		{
			return Static.CallMethod<long>(typeof(Long), "reverse", "(J)J", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public static long sum(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "sum", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(JJ)I")]
		public static int compareUnsigned(long arg0, long arg1)
		{
			return Static.CallMethod<int>(typeof(Long), "compareUnsigned", "(JJ)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long divideUnsigned(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "divideUnsigned", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(J)J")]
		public static long highestOneBit(long arg0)
		{
			return Static.CallMethod<long>(typeof(Long), "highestOneBit", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public static long lowestOneBit(long arg0)
		{
			return Static.CallMethod<long>(typeof(Long), "lowestOneBit", "(J)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)J")]
		public static long parseLong(String arg0, int arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "parseLong", "(Ljava/lang/String;I)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)J")]
		public static long parseLong(String arg0)
		{
			return Static.CallMethod<long>(typeof(Long), "parseLong", "(Ljava/lang/String;)J", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public static long remainderUnsigned(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "remainderUnsigned", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(JI)J")]
		public static long rotateLeft(long arg0, int arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "rotateLeft", "(JI)J", arg0, arg1);
		}
		
		[JavaSignature("(JI)J")]
		public static long rotateRight(long arg0, int arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "rotateRight", "(JI)J", arg0, arg1);
		}
		
		[JavaSignature("(J)I")]
		public static int signum(long arg0)
		{
			return Static.CallMethod<int>(typeof(Long), "signum", "(J)I", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/String;")]
		public static String toBinaryString(long arg0)
		{
			return Static.CallMethod<String>(typeof(Long), "toBinaryString", "(J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/String;")]
		public static String toOctalString(long arg0)
		{
			return Static.CallMethod<String>(typeof(Long), "toOctalString", "(J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/String;")]
		public static String toUnsignedString(long arg0)
		{
			return Static.CallMethod<String>(typeof(Long), "toUnsignedString", "(J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(JI)Ljava/lang/String;")]
		public static String toUnsignedString(long arg0, int arg1)
		{
			return Static.CallMethod<String>(typeof(Long), "toUnsignedString", "(JI)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)J")]
		public static long parseUnsignedLong(String arg0)
		{
			return Static.CallMethod<long>(typeof(Long), "parseUnsignedLong", "(Ljava/lang/String;)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)J")]
		public static long parseUnsignedLong(String arg0, int arg1)
		{
			return Static.CallMethod<long>(typeof(Long), "parseUnsignedLong", "(Ljava/lang/String;I)J", arg0, arg1);
		}
	}
}
