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
	[JavaProxy("java/lang/Float")]
	public partial class Float : Number, Comparable<Float>
	{
		protected Float(ProxyCtor p) : base(p) {}
		
		public Float(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Float(double arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(D)V", arg0);
		}
		
		public Float(float arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(F)V", arg0);
		}
	
		[JavaSignature("F")]
		public static float POSITIVE_INFINITY
		{
			get { return Static.GetField<float>(typeof(Float), "POSITIVE_INFINITY", "F"); }
		}
		
		[JavaSignature("F")]
		public static float NEGATIVE_INFINITY
		{
			get { return Static.GetField<float>(typeof(Float), "NEGATIVE_INFINITY", "F"); }
		}
		
		[JavaSignature("F")]
		public static float NaN
		{
			get { return Static.GetField<float>(typeof(Float), "NaN", "F"); }
		}
		
		[JavaSignature("F")]
		public static float MAX_VALUE
		{
			get { return Static.GetField<float>(typeof(Float), "MAX_VALUE", "F"); }
		}
		
		[JavaSignature("F")]
		public static float MIN_NORMAL
		{
			get { return Static.GetField<float>(typeof(Float), "MIN_NORMAL", "F"); }
		}
		
		[JavaSignature("F")]
		public static float MIN_VALUE
		{
			get { return Static.GetField<float>(typeof(Float), "MIN_VALUE", "F"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_EXPONENT
		{
			get { return Static.GetField<int>(typeof(Float), "MAX_EXPONENT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MIN_EXPONENT
		{
			get { return Static.GetField<int>(typeof(Float), "MIN_EXPONENT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SIZE
		{
			get { return Static.GetField<int>(typeof(Float), "SIZE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BYTES
		{
			get { return Static.GetField<int>(typeof(Float), "BYTES", "I"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Float> TYPE
		{
			get { return Static.GetField<Class<Float>>(typeof(Float), "TYPE", "Ljava/lang/Class;"); }
		}
	
		[JavaSignature("(F)Ljava/lang/String;")]
		public static String toString(float arg0)
		{
			return Static.CallMethod<String>(typeof(Float), "toString", "(F)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(F)I")]
		public static int hashCode(float arg0)
		{
			return Static.CallMethod<int>(typeof(Float), "hashCode", "(F)I", arg0);
		}
		
		[JavaSignature("(FF)F")]
		public static float min(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(Float), "min", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(FF)F")]
		public static float max(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(Float), "max", "(FF)F", arg0, arg1);
		}
		
		[JavaSignature("(F)I")]
		public static int floatToRawIntBits(float arg0)
		{
			return Static.CallMethod<int>(typeof(Float), "floatToRawIntBits", "(F)I", arg0);
		}
		
		[JavaSignature("(F)I")]
		public static int floatToIntBits(float arg0)
		{
			return Static.CallMethod<int>(typeof(Float), "floatToIntBits", "(F)I", arg0);
		}
		
		[JavaSignature("(I)F")]
		public static float intBitsToFloat(int arg0)
		{
			return Static.CallMethod<float>(typeof(Float), "intBitsToFloat", "(I)F", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Float;)I")]
		public int compareTo(Float arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Float;)I", arg0);
		}
		
		[JavaSignature("(F)Ljava/lang/Float;")]
		public static Float valueOf(float arg0)
		{
			return Static.CallMethod<Float>(typeof(Float), "valueOf", "(F)Ljava/lang/Float;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Float;")]
		public static Float valueOf(String arg0)
		{
			return Static.CallMethod<Float>(typeof(Float), "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;", arg0);
		}
		
		[JavaSignature("(F)Ljava/lang/String;")]
		public static String toHexString(float arg0)
		{
			return Static.CallMethod<String>(typeof(Float), "toHexString", "(F)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(FF)I")]
		public static int compare(float arg0, float arg1)
		{
			return Static.CallMethod<int>(typeof(Float), "compare", "(FF)I", arg0, arg1);
		}
		
		[JavaSignature("(F)Z")]
		public static bool isNaN(float arg0)
		{
			return Static.CallMethod<bool>(typeof(Float), "isNaN", "(F)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isNaN()
		{
			return Instance.CallMethod<bool>("isNaN", "()Z");
		}
		
		[JavaSignature("(F)Z")]
		public static bool isFinite(float arg0)
		{
			return Static.CallMethod<bool>(typeof(Float), "isFinite", "(F)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isInfinite()
		{
			return Instance.CallMethod<bool>("isInfinite", "()Z");
		}
		
		[JavaSignature("(F)Z")]
		public static bool isInfinite(float arg0)
		{
			return Static.CallMethod<bool>(typeof(Float), "isInfinite", "(F)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)F")]
		public static float parseFloat(String arg0)
		{
			return Static.CallMethod<float>(typeof(Float), "parseFloat", "(Ljava/lang/String;)F", arg0);
		}
		
		[JavaSignature("(FF)F")]
		public static float sum(float arg0, float arg1)
		{
			return Static.CallMethod<float>(typeof(Float), "sum", "(FF)F", arg0, arg1);
		}
	}
}
