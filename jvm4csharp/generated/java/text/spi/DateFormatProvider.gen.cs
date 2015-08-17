//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util;
using jvm4csharp.java.util.spi;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text.spi
{
	[JavaProxy("java/text/spi/DateFormatProvider")]
	public abstract class DateFormatProvider : LocaleServiceProvider
	{
		protected DateFormatProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(IILjava/util/Locale;)Ljava/text/DateFormat;")]
		public DateFormat getDateTimeInstance(int arg0, int arg1, Locale arg2)
		{
			return Instance.CallMethod<DateFormat>("getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(ILjava/util/Locale;)Ljava/text/DateFormat;")]
		public DateFormat getDateInstance(int arg0, Locale arg1)
		{
			return Instance.CallMethod<DateFormat>("getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/util/Locale;)Ljava/text/DateFormat;")]
		public DateFormat getTimeInstance(int arg0, Locale arg1)
		{
			return Instance.CallMethod<DateFormat>("getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", arg0, arg1);
		}
	}
}
