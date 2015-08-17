//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio.charset
{
	[JavaProxy("java/nio/charset/CoderResult")]
	public class CoderResult : Object
	{
		protected CoderResult(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/nio/charset/CoderResult;")]
		public static CoderResult UNDERFLOW
		{
			get { return Static.GetField<CoderResult>(typeof(CoderResult), "UNDERFLOW", "Ljava/nio/charset/CoderResult;"); }
		}
		
		[JavaSignature("Ljava/nio/charset/CoderResult;")]
		public static CoderResult OVERFLOW
		{
			get { return Static.GetField<CoderResult>(typeof(CoderResult), "OVERFLOW", "Ljava/nio/charset/CoderResult;"); }
		}
	
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("()V")]
		public void throwException()
		{
			Instance.CallMethod("throwException", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool isOverflow()
		{
			return Instance.CallMethod<bool>("isOverflow", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isUnderflow()
		{
			return Instance.CallMethod<bool>("isUnderflow", "()Z");
		}
		
		[JavaSignature("(I)Ljava/nio/charset/CoderResult;")]
		public static CoderResult unmappableForLength(int arg0)
		{
			return Static.CallMethod<CoderResult>(typeof(CoderResult), "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isError()
		{
			return Instance.CallMethod<bool>("isError", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMalformed()
		{
			return Instance.CallMethod<bool>("isMalformed", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isUnmappable()
		{
			return Instance.CallMethod<bool>("isUnmappable", "()Z");
		}
		
		[JavaSignature("(I)Ljava/nio/charset/CoderResult;")]
		public static CoderResult malformedForLength(int arg0)
		{
			return Static.CallMethod<CoderResult>(typeof(CoderResult), "malformedForLength", "(I)Ljava/nio/charset/CoderResult;", arg0);
		}
	}
}
