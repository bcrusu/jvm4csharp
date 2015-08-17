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
	[JavaProxy("java/lang/Double")]
	public class Double : Number, Comparable<Double>
	{
		protected Double(ProxyCtor p) : base(p) {}
		
		public Double(double arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(D)V", arg0);
		}
		
		public Double(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("D")]
		public static double POSITIVE_INFINITY
		{
			get { return Static.GetField<double>(typeof(Double), "POSITIVE_INFINITY", "D"); }
		}
		
		[JavaSignature("D")]
		public static double NEGATIVE_INFINITY
		{
			get { return Static.GetField<double>(typeof(Double), "NEGATIVE_INFINITY", "D"); }
		}
		
		[JavaSignature("D")]
		public static double NaN
		{
			get { return Static.GetField<double>(typeof(Double), "NaN", "D"); }
		}
		
		[JavaSignature("D")]
		public static double MAX_VALUE
		{
			get { return Static.GetField<double>(typeof(Double), "MAX_VALUE", "D"); }
		}
		
		[JavaSignature("D")]
		public static double MIN_NORMAL
		{
			get { return Static.GetField<double>(typeof(Double), "MIN_NORMAL", "D"); }
		}
		
		[JavaSignature("D")]
		public static double MIN_VALUE
		{
			get { return Static.GetField<double>(typeof(Double), "MIN_VALUE", "D"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_EXPONENT
		{
			get { return Static.GetField<int>(typeof(Double), "MAX_EXPONENT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MIN_EXPONENT
		{
			get { return Static.GetField<int>(typeof(Double), "MIN_EXPONENT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SIZE
		{
			get { return Static.GetField<int>(typeof(Double), "SIZE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BYTES
		{
			get { return Static.GetField<int>(typeof(Double), "BYTES", "I"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Double> TYPE
		{
			get { return Static.GetField<Class<Double>>(typeof(Double), "TYPE", "Ljava/lang/Class;"); }
		}
	
		[JavaSignature("(D)Ljava/lang/String;")]
		public static String toString(double arg0)
		{
			return Static.CallMethod<String>(typeof(Double), "toString", "(D)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(D)I")]
		public static int hashCode(double arg0)
		{
			return Static.CallMethod<int>(typeof(Double), "hashCode", "(D)I", arg0);
		}
		
		[JavaSignature("(DD)D")]
		public static double min(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Double), "min", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double max(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Double), "max", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)J")]
		public static long doubleToRawLongBits(double arg0)
		{
			return Static.CallMethod<long>(typeof(Double), "doubleToRawLongBits", "(D)J", arg0);
		}
		
		[JavaSignature("(D)J")]
		public static long doubleToLongBits(double arg0)
		{
			return Static.CallMethod<long>(typeof(Double), "doubleToLongBits", "(D)J", arg0);
		}
		
		[JavaSignature("(J)D")]
		public static double longBitsToDouble(long arg0)
		{
			return Static.CallMethod<double>(typeof(Double), "longBitsToDouble", "(J)D", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Double;)I")]
		public int compareTo(Double arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Double;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Double;")]
		public static Double valueOf(String arg0)
		{
			return Static.CallMethod<Double>(typeof(Double), "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;", arg0);
		}
		
		[JavaSignature("(D)Ljava/lang/Double;")]
		public static Double valueOf(double arg0)
		{
			return Static.CallMethod<Double>(typeof(Double), "valueOf", "(D)Ljava/lang/Double;", arg0);
		}
		
		[JavaSignature("(D)Ljava/lang/String;")]
		public static String toHexString(double arg0)
		{
			return Static.CallMethod<String>(typeof(Double), "toHexString", "(D)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(DD)I")]
		public static int compare(double arg0, double arg1)
		{
			return Static.CallMethod<int>(typeof(Double), "compare", "(DD)I", arg0, arg1);
		}
		
		[JavaSignature("(D)Z")]
		public static bool isNaN(double arg0)
		{
			return Static.CallMethod<bool>(typeof(Double), "isNaN", "(D)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isNaN()
		{
			return Instance.CallMethod<bool>("isNaN", "()Z");
		}
		
		[JavaSignature("(D)Z")]
		public static bool isFinite(double arg0)
		{
			return Static.CallMethod<bool>(typeof(Double), "isFinite", "(D)Z", arg0);
		}
		
		[JavaSignature("(D)Z")]
		public static bool isInfinite(double arg0)
		{
			return Static.CallMethod<bool>(typeof(Double), "isInfinite", "(D)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isInfinite()
		{
			return Instance.CallMethod<bool>("isInfinite", "()Z");
		}
		
		[JavaSignature("(DD)D")]
		public static double sum(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Double), "sum", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)D")]
		public static double parseDouble(String arg0)
		{
			return Static.CallMethod<double>(typeof(Double), "parseDouble", "(Ljava/lang/String;)D", arg0);
		}
	}
}
