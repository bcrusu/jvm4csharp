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
	[JavaProxy("java/text/spi/DateFormatSymbolsProvider")]
	public abstract class DateFormatSymbolsProvider : LocaleServiceProvider
	{
		protected DateFormatSymbolsProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;")]
		public DateFormatSymbols getInstance(Locale arg0)
		{
			return Instance.CallMethod<DateFormatSymbols>("getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;", arg0);
		}
	}
}
