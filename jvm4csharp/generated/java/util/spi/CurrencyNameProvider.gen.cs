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
namespace jvm4csharp.java.util.spi
{
	[JavaProxy("java/util/spi/CurrencyNameProvider")]
	public abstract class CurrencyNameProvider : LocaleServiceProvider
	{
		protected CurrencyNameProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(String arg0, Locale arg1)
		{
			return Instance.CallMethod<String>("getDisplayName", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;")]
		public String getSymbol(String arg0, Locale arg1)
		{
			return Instance.CallMethod<String>("getSymbol", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
		}
	}
}
