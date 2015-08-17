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
	[JavaProxy("java/util/spi/CalendarNameProvider")]
	public abstract class CalendarNameProvider : LocaleServiceProvider
	{
		protected CalendarNameProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;IIILjava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(String arg0, int arg1, int arg2, int arg3, Locale arg4)
		{
			return Instance.CallMethod<String>("getDisplayName", "(Ljava/lang/String;IIILjava/util/Locale;)Ljava/lang/String;", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/lang/String;IILjava/util/Locale;)Ljava/util/Map;")]
		public Map<String, Integer> getDisplayNames(String arg0, int arg1, int arg2, Locale arg3)
		{
			return Instance.CallMethod<Map<String, Integer>>("getDisplayNames", "(Ljava/lang/String;IILjava/util/Locale;)Ljava/util/Map;", arg0, arg1, arg2, arg3);
		}
	}
}
