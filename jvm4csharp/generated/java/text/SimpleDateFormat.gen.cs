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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/SimpleDateFormat")]
	public partial class SimpleDateFormat : DateFormat
	{
		protected SimpleDateFormat(ProxyCtor p) : base(p) {}
		
		public SimpleDateFormat(String arg0, DateFormatSymbols arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/text/DateFormatSymbols;)V", arg0, arg1);
		}
		
		public SimpleDateFormat(String arg0, Locale arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/util/Locale;)V", arg0, arg1);
		}
		
		public SimpleDateFormat(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public SimpleDateFormat() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/lang/String;)V")]
		public void applyPattern(String arg0)
		{
			Instance.CallMethod("applyPattern", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toPattern()
		{
			return Instance.CallMethod<String>("toPattern", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/Date;)V")]
		public void set2DigitYearStart(Date arg0)
		{
			Instance.CallMethod("set2DigitYearStart", "(Ljava/util/Date;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void applyLocalizedPattern(String arg0)
		{
			Instance.CallMethod("applyLocalizedPattern", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Date;")]
		public Date get2DigitYearStart()
		{
			return Instance.CallMethod<Date>("get2DigitYearStart", "()Ljava/util/Date;");
		}
		
		[JavaSignature("()Ljava/text/DateFormatSymbols;")]
		public DateFormatSymbols getDateFormatSymbols()
		{
			return Instance.CallMethod<DateFormatSymbols>("getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;");
		}
		
		[JavaSignature("(Ljava/text/DateFormatSymbols;)V")]
		public void setDateFormatSymbols(DateFormatSymbols arg0)
		{
			Instance.CallMethod("setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toLocalizedPattern()
		{
			return Instance.CallMethod<String>("toLocalizedPattern", "()Ljava/lang/String;");
		}
	}
}
