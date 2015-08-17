//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.spi
{
	[JavaProxy("java/util/spi/LocaleServiceProvider")]
	public abstract class LocaleServiceProvider : Object
	{
		protected LocaleServiceProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()[Ljava/util/Locale;")]
		public ObjectArray<Locale> getAvailableLocales()
		{
			return Instance.CallMethod<ObjectArray<Locale>>("getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Z")]
		public bool isSupportedLocale(Locale arg0)
		{
			return Instance.CallMethod<bool>("isSupportedLocale", "(Ljava/util/Locale;)Z", arg0);
		}
	}
}
