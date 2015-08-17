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
	[JavaProxy("java/math/RoundingMode")]
	public class RoundingMode : Enum<RoundingMode>
	{
		protected RoundingMode(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode UP
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "UP", "Ljava/math/RoundingMode;"); }
		}
		
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode DOWN
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "DOWN", "Ljava/math/RoundingMode;"); }
		}
		
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode CEILING
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "CEILING", "Ljava/math/RoundingMode;"); }
		}
		
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode FLOOR
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "FLOOR", "Ljava/math/RoundingMode;"); }
		}
		
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode HALF_UP
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "HALF_UP", "Ljava/math/RoundingMode;"); }
		}
		
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode HALF_DOWN
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "HALF_DOWN", "Ljava/math/RoundingMode;"); }
		}
		
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode HALF_EVEN
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "HALF_EVEN", "Ljava/math/RoundingMode;"); }
		}
		
		[JavaSignature("Ljava/math/RoundingMode;")]
		public static RoundingMode UNNECESSARY
		{
			get { return Static.GetField<RoundingMode>(typeof(RoundingMode), "UNNECESSARY", "Ljava/math/RoundingMode;"); }
		}
	
		[JavaSignature("()[Ljava/math/RoundingMode;")]
		public static ObjectArray<RoundingMode> values()
		{
			return Static.CallMethod<ObjectArray<RoundingMode>>(typeof(RoundingMode), "values", "()[Ljava/math/RoundingMode;");
		}
		
		[JavaSignature("(I)Ljava/math/RoundingMode;")]
		public static RoundingMode valueOf(int arg0)
		{
			return Static.CallMethod<RoundingMode>(typeof(RoundingMode), "valueOf", "(I)Ljava/math/RoundingMode;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/math/RoundingMode;")]
		public static RoundingMode valueOf(String arg0)
		{
			return Static.CallMethod<RoundingMode>(typeof(RoundingMode), "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;", arg0);
		}
	}
}
