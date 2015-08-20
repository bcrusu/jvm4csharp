//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.math
{
	[JavaProxy("java/math/MathContext")]
	public partial class MathContext : Object, Serializable
	{
		protected MathContext(ProxyCtor p) : base(p) {}
		
		public MathContext(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public MathContext(int arg0, RoundingMode arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/math/RoundingMode;)V", arg0, arg1);
		}
		
		public MathContext(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("Ljava/math/MathContext;")]
		public static MathContext UNLIMITED
		{
			get { return Static.GetField<MathContext>(typeof(MathContext), "UNLIMITED", "Ljava/math/MathContext;"); }
		}
		
		[JavaSignature("Ljava/math/MathContext;")]
		public static MathContext DECIMAL32
		{
			get { return Static.GetField<MathContext>(typeof(MathContext), "DECIMAL32", "Ljava/math/MathContext;"); }
		}
		
		[JavaSignature("Ljava/math/MathContext;")]
		public static MathContext DECIMAL64
		{
			get { return Static.GetField<MathContext>(typeof(MathContext), "DECIMAL64", "Ljava/math/MathContext;"); }
		}
		
		[JavaSignature("Ljava/math/MathContext;")]
		public static MathContext DECIMAL128
		{
			get { return Static.GetField<MathContext>(typeof(MathContext), "DECIMAL128", "Ljava/math/MathContext;"); }
		}
	
		[JavaSignature("()Ljava/math/RoundingMode;")]
		public RoundingMode getRoundingMode()
		{
			return Instance.CallMethod<RoundingMode>("getRoundingMode", "()Ljava/math/RoundingMode;");
		}
		
		[JavaSignature("()I")]
		public int getPrecision()
		{
			return Instance.CallMethod<int>("getPrecision", "()I");
		}
	}
}
