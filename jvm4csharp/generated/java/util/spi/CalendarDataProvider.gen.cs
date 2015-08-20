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
namespace jvm4csharp.java.util.spi
{
	[JavaProxy("java/util/spi/CalendarDataProvider")]
	public abstract partial class CalendarDataProvider : LocaleServiceProvider
	{
		protected CalendarDataProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/Locale;)I")]
		public int getFirstDayOfWeek(Locale arg0)
		{
			return Instance.CallMethod<int>("getFirstDayOfWeek", "(Ljava/util/Locale;)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)I")]
		public int getMinimalDaysInFirstWeek(Locale arg0)
		{
			return Instance.CallMethod<int>("getMinimalDaysInFirstWeek", "(Ljava/util/Locale;)I", arg0);
		}
	}
}
