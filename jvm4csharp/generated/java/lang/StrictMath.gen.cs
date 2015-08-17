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
	[JavaProxy("java/lang/StrictMath")]
	public class StrictMath : Object
	{
		protected StrictMath(ProxyCtor p) : base(p) {}
	
		[JavaSignature("D")]
		public static double E
		{
			get { return Static.GetField<double>(typeof(StrictMath), "E", "D"); }
		}
		
		[JavaSignature("D")]
		public static double PI
		{
			get { return Static.GetField<double>(typeof(StrictMath), "PI", "D"); }
		}
	
		[JavaSignature("(D)D")]
		public static double abs(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "abs", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float abs(float arg0)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "abs", "(F)F", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int abs(int arg0)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "abs", "(I)I", arg0);
		}
		
		[JavaSignature("(J)J")]
		public static long abs(long arg0)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "abs", "(J)J", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double sin(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "sin", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double cos(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "cos", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double tan(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "tan", "(D)D", arg0);
		}
		
		[JavaSignature("(DD)D")]
		public static double atan2(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "atan2", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double sqrt(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "sqrt", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double log(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "log", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double log10(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "log10", "(D)D", arg0);
		}
		
		[JavaSignature("(DD)D")]
		public static double pow(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "pow", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double exp(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "exp", "(D)D", arg0);
		}
		
		[JavaSignature("(II)I")]
		public static int min(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "min", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double min(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "min", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(FF)F")]
		public static float min(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "min", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long min(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "min", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int max(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "max", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long max(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "max", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(FF)F")]
		public static float max(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "max", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double max(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "max", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int addExact(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "addExact", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long addExact(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "addExact", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long multiplyExact(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "multiplyExact", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int multiplyExact(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "multiplyExact", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int subtractExact(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "subtractExact", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long subtractExact(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "subtractExact", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(DI)D")]
		public static double scalb(double arg0, int arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "scalb", "(DI)D", arg0, arg1);
		}
		
		[JavaSignature("(FI)F")]
		public static float scalb(float arg0, int arg1)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "scalb", "(FI)F", arg0, arg1);
		}
		
		[JavaSignature("(FF)F")]
		public static float copySign(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "copySign", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double copySign(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "copySign", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(F)I")]
		public static int getExponent(float arg0)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "getExponent", "(F)I", arg0);
		}
		
		[JavaSignature("(D)I")]
		public static int getExponent(double arg0)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "getExponent", "(D)I", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double signum(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "signum", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float signum(float arg0)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "signum", "(F)F", arg0);
		}
		
		[JavaSignature("(DD)D")]
		public static double IEEEremainder(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "IEEEremainder", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double acos(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "acos", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double asin(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "asin", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double atan(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "atan", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double cbrt(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "cbrt", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double ceil(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "ceil", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double cosh(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "cosh", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double expm1(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "expm1", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double floor(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "floor", "(D)D", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public static long floorDiv(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "floorDiv", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int floorDiv(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "floorDiv", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long floorMod(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "floorMod", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int floorMod(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "floorMod", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double hypot(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "hypot", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double log1p(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "log1p", "(D)D", arg0);
		}
		
		[JavaSignature("(FD)F")]
		public static float nextAfter(float arg0, double arg1)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "nextAfter", "(FD)F", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double nextAfter(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "nextAfter", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(F)F")]
		public static float nextDown(float arg0)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "nextDown", "(F)F", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double nextDown(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "nextDown", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float nextUp(float arg0)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "nextUp", "(F)F", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double nextUp(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "nextUp", "(D)D", arg0);
		}
		
		[JavaSignature("()D")]
		public static double random()
		{
			return Static.CallMethod<double>(typeof(StrictMath), "random", "()D");
		}
		
		[JavaSignature("(D)D")]
		public static double rint(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "rint", "(D)D", arg0);
		}
		
		[JavaSignature("(D)J")]
		public static long round(double arg0)
		{
			return Static.CallMethod<long>(typeof(StrictMath), "round", "(D)J", arg0);
		}
		
		[JavaSignature("(F)I")]
		public static int round(float arg0)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "round", "(F)I", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double sinh(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "sinh", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double tanh(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "tanh", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double toDegrees(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "toDegrees", "(D)D", arg0);
		}
		
		[JavaSignature("(J)I")]
		public static int toIntExact(long arg0)
		{
			return Static.CallMethod<int>(typeof(StrictMath), "toIntExact", "(J)I", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double toRadians(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "toRadians", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double ulp(double arg0)
		{
			return Static.CallMethod<double>(typeof(StrictMath), "ulp", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float ulp(float arg0)
		{
			return Static.CallMethod<float>(typeof(StrictMath), "ulp", "(F)F", arg0);
		}
	}
}
