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
	[JavaProxy("java/lang/Math")]
	public partial class Math : Object
	{
		protected Math(ProxyCtor p) : base(p) {}
	
		[JavaSignature("D")]
		public static double E
		{
			get { return Static.GetField<double>(typeof(Math), "E", "D"); }
		}
		
		[JavaSignature("D")]
		public static double PI
		{
			get { return Static.GetField<double>(typeof(Math), "PI", "D"); }
		}
	
		[JavaSignature("(I)I")]
		public static int abs(int arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "abs", "(I)I", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double abs(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "abs", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float abs(float arg0)
		{
			return Static.CallMethod<float>(typeof(Math), "abs", "(F)F", arg0);
		}
		
		[JavaSignature("(J)J")]
		public static long abs(long arg0)
		{
			return Static.CallMethod<long>(typeof(Math), "abs", "(J)J", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double sin(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "sin", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double cos(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "cos", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double tan(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "tan", "(D)D", arg0);
		}
		
		[JavaSignature("(DD)D")]
		public static double atan2(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "atan2", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double sqrt(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "sqrt", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double log(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "log", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double log10(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "log10", "(D)D", arg0);
		}
		
		[JavaSignature("(DD)D")]
		public static double pow(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "pow", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double exp(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "exp", "(D)D", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public static long min(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Math), "min", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double min(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "min", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(FF)F")]
		public static float min(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(Math), "min", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int min(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Math), "min", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double max(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "max", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(FF)F")]
		public static float max(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(Math), "max", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long max(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Math), "max", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int max(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Math), "max", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long addExact(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Math), "addExact", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int addExact(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Math), "addExact", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public static int decrementExact(int arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "decrementExact", "(I)I", arg0);
		}
		
		[JavaSignature("(J)J")]
		public static long decrementExact(long arg0)
		{
			return Static.CallMethod<long>(typeof(Math), "decrementExact", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public static long incrementExact(long arg0)
		{
			return Static.CallMethod<long>(typeof(Math), "incrementExact", "(J)J", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int incrementExact(int arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "incrementExact", "(I)I", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public static long multiplyExact(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Math), "multiplyExact", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int multiplyExact(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Math), "multiplyExact", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public static int negateExact(int arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "negateExact", "(I)I", arg0);
		}
		
		[JavaSignature("(J)J")]
		public static long negateExact(long arg0)
		{
			return Static.CallMethod<long>(typeof(Math), "negateExact", "(J)J", arg0);
		}
		
		[JavaSignature("(II)I")]
		public static int subtractExact(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Math), "subtractExact", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long subtractExact(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Math), "subtractExact", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(DI)D")]
		public static double scalb(double arg0, int arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "scalb", "(DI)D", arg0, arg1);
		}
		
		[JavaSignature("(FI)F")]
		public static float scalb(float arg0, int arg1)
		{
			return Static.CallMethod<float>(typeof(Math), "scalb", "(FI)F", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double copySign(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "copySign", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(FF)F")]
		public static float copySign(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(Math), "copySign", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(F)I")]
		public static int getExponent(float arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "getExponent", "(F)I", arg0);
		}
		
		[JavaSignature("(D)I")]
		public static int getExponent(double arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "getExponent", "(D)I", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double signum(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "signum", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float signum(float arg0)
		{
			return Static.CallMethod<float>(typeof(Math), "signum", "(F)F", arg0);
		}
		
		[JavaSignature("(DD)D")]
		public static double IEEEremainder(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "IEEEremainder", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double acos(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "acos", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double asin(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "asin", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double atan(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "atan", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double cbrt(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "cbrt", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double ceil(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "ceil", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double cosh(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "cosh", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double expm1(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "expm1", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double floor(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "floor", "(D)D", arg0);
		}
		
		[JavaSignature("(JJ)J")]
		public static long floorDiv(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Math), "floorDiv", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int floorDiv(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Math), "floorDiv", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public static int floorMod(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Math), "floorMod", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(JJ)J")]
		public static long floorMod(long arg0, long arg1)
		{
			return Static.CallMethod<long>(typeof(Math), "floorMod", "(JJ)J", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double hypot(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "hypot", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double log1p(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "log1p", "(D)D", arg0);
		}
		
		[JavaSignature("(FD)F")]
		public static float nextAfter(float arg0, double arg1)
		{
			return Static.CallMethod<float>(typeof(Math), "nextAfter", "(FD)F", arg0, arg1);
		}
		
		[JavaSignature("(DD)D")]
		public static double nextAfter(double arg0, double arg1)
		{
			return Static.CallMethod<double>(typeof(Math), "nextAfter", "(DD)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double nextDown(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "nextDown", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float nextDown(float arg0)
		{
			return Static.CallMethod<float>(typeof(Math), "nextDown", "(F)F", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double nextUp(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "nextUp", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float nextUp(float arg0)
		{
			return Static.CallMethod<float>(typeof(Math), "nextUp", "(F)F", arg0);
		}
		
		[JavaSignature("()D")]
		public static double random()
		{
			return Static.CallMethod<double>(typeof(Math), "random", "()D");
		}
		
		[JavaSignature("(D)D")]
		public static double rint(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "rint", "(D)D", arg0);
		}
		
		[JavaSignature("(F)I")]
		public static int round(float arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "round", "(F)I", arg0);
		}
		
		[JavaSignature("(D)J")]
		public static long round(double arg0)
		{
			return Static.CallMethod<long>(typeof(Math), "round", "(D)J", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double sinh(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "sinh", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double tanh(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "tanh", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double toDegrees(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "toDegrees", "(D)D", arg0);
		}
		
		[JavaSignature("(J)I")]
		public static int toIntExact(long arg0)
		{
			return Static.CallMethod<int>(typeof(Math), "toIntExact", "(J)I", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double toRadians(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "toRadians", "(D)D", arg0);
		}
		
		[JavaSignature("(D)D")]
		public static double ulp(double arg0)
		{
			return Static.CallMethod<double>(typeof(Math), "ulp", "(D)D", arg0);
		}
		
		[JavaSignature("(F)F")]
		public static float ulp(float arg0)
		{
			return Static.CallMethod<float>(typeof(Math), "ulp", "(F)F", arg0);
		}
	}
}
