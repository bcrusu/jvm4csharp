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
	[JavaProxy("java/util/spi/TimeZoneNameProvider")]
	public abstract class TimeZoneNameProvider : LocaleServiceProvider
	{
		protected TimeZoneNameProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;ZILjava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(String arg0, bool arg1, int arg2, Locale arg3)
		{
			return Instance.CallMethod<String>("getDisplayName", "(Ljava/lang/String;ZILjava/util/Locale;)Ljava/lang/String;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/String;ILjava/util/Locale;)Ljava/lang/String;")]
		public String getGenericDisplayName(String arg0, int arg1, Locale arg2)
		{
			return Instance.CallMethod<String>("getGenericDisplayName", "(Ljava/lang/String;ILjava/util/Locale;)Ljava/lang/String;", arg0, arg1, arg2);
		}
	}
}
