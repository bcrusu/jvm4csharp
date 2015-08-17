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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/GregorianCalendar")]
	public class GregorianCalendar : Calendar
	{
		protected GregorianCalendar(ProxyCtor p) : base(p) {}
		
		public GregorianCalendar(int arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(III)V", arg0, arg1, arg2);
		}
		
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIIII)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIIIII)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		public GregorianCalendar() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public GregorianCalendar(TimeZone arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/TimeZone;)V", arg0);
		}
		
		public GregorianCalendar(Locale arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Locale;)V", arg0);
		}
		
		public GregorianCalendar(TimeZone arg0, Locale arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/TimeZone;Ljava/util/Locale;)V", arg0, arg1);
		}
	
		[JavaSignature("I")]
		public static int BC
		{
			get { return Static.GetField<int>(typeof(GregorianCalendar), "BC", "I"); }
		}
		
		[JavaSignature("I")]
		public static int AD
		{
			get { return Static.GetField<int>(typeof(GregorianCalendar), "AD", "I"); }
		}
	
		[JavaSignature("(I)Z")]
		public bool isLeapYear(int arg0)
		{
			return Instance.CallMethod<bool>("isLeapYear", "(I)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/Date;")]
		public Date getGregorianChange()
		{
			return Instance.CallMethod<Date>("getGregorianChange", "()Ljava/util/Date;");
		}
		
		[JavaSignature("(Ljava/util/Date;)V")]
		public void setGregorianChange(Date arg0)
		{
			Instance.CallMethod("setGregorianChange", "(Ljava/util/Date;)V", arg0);
		}
	}
}
