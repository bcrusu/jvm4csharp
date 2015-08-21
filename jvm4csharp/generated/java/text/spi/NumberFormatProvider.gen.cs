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
	[JavaProxy("java/text/spi/NumberFormatProvider")]
	public abstract partial class NumberFormatProvider : LocaleServiceProvider
	{
		protected NumberFormatProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public NumberFormat getIntegerInstance(Locale arg0)
		{
			return Instance.CallMethod<NumberFormat>("getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public NumberFormat getCurrencyInstance(Locale arg0)
		{
			return Instance.CallMethod<NumberFormat>("getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public NumberFormat getPercentInstance(Locale arg0)
		{
			return Instance.CallMethod<NumberFormat>("getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public NumberFormat getNumberInstance(Locale arg0)
		{
			return Instance.CallMethod<NumberFormat>("getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
	}
}
