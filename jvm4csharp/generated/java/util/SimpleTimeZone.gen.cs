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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/SimpleTimeZone")]
	public class SimpleTimeZone : TimeZone
	{
		protected SimpleTimeZone(ProxyCtor p) : base(p) {}
		
		public SimpleTimeZone(int arg0, String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/lang/String;IIIIIIIIIII)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
		}
		
		public SimpleTimeZone(int arg0, String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/lang/String;IIIIIIIII)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		}
		
		public SimpleTimeZone(int arg0, String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/lang/String;IIIIIIII)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		
		public SimpleTimeZone(int arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(ILjava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("I")]
		public static int WALL_TIME
		{
			get { return Static.GetField<int>(typeof(SimpleTimeZone), "WALL_TIME", "I"); }
		}
		
		[JavaSignature("I")]
		public static int STANDARD_TIME
		{
			get { return Static.GetField<int>(typeof(SimpleTimeZone), "STANDARD_TIME", "I"); }
		}
		
		[JavaSignature("I")]
		public static int UTC_TIME
		{
			get { return Static.GetField<int>(typeof(SimpleTimeZone), "UTC_TIME", "I"); }
		}
	
		[JavaSignature("(I)V")]
		public void setDSTSavings(int arg0)
		{
			Instance.CallMethod("setDSTSavings", "(I)V", arg0);
		}
		
		[JavaSignature("(IIIIZ)V")]
		public void setEndRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
		{
			Instance.CallMethod("setEndRule", "(IIIIZ)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(III)V")]
		public void setEndRule(int arg0, int arg1, int arg2)
		{
			Instance.CallMethod("setEndRule", "(III)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IIII)V")]
		public void setEndRule(int arg0, int arg1, int arg2, int arg3)
		{
			Instance.CallMethod("setEndRule", "(IIII)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(III)V")]
		public void setStartRule(int arg0, int arg1, int arg2)
		{
			Instance.CallMethod("setStartRule", "(III)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IIIIZ)V")]
		public void setStartRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
		{
			Instance.CallMethod("setStartRule", "(IIIIZ)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(IIII)V")]
		public void setStartRule(int arg0, int arg1, int arg2, int arg3)
		{
			Instance.CallMethod("setStartRule", "(IIII)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(I)V")]
		public void setStartYear(int arg0)
		{
			Instance.CallMethod("setStartYear", "(I)V", arg0);
		}
	}
}
