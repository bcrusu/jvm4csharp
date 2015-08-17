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
	[JavaProxy("java/util/spi/LocaleNameProvider")]
	public abstract class LocaleNameProvider : LocaleServiceProvider
	{
		protected LocaleNameProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayCountry(String arg0, Locale arg1)
		{
			return Instance.CallMethod<String>("getDisplayCountry", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayLanguage(String arg0, Locale arg1)
		{
			return Instance.CallMethod<String>("getDisplayLanguage", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayScript(String arg0, Locale arg1)
		{
			return Instance.CallMethod<String>("getDisplayScript", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayVariant(String arg0, Locale arg1)
		{
			return Instance.CallMethod<String>("getDisplayVariant", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
		}
	}
}
