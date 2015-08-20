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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/DateFormatSymbols")]
	public partial class DateFormatSymbols : Object, Serializable, Cloneable
	{
		protected DateFormatSymbols(ProxyCtor p) : base(p) {}
		
		public DateFormatSymbols() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public DateFormatSymbols(Locale arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Locale;)V", arg0);
		}
	
		[JavaSignature("()Ljava/text/DateFormatSymbols;")]
		public static DateFormatSymbols getInstance()
		{
			return Static.CallMethod<DateFormatSymbols>(typeof(DateFormatSymbols), "getInstance", "()Ljava/text/DateFormatSymbols;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;")]
		public static DateFormatSymbols getInstance(Locale arg0)
		{
			return Static.CallMethod<DateFormatSymbols>(typeof(DateFormatSymbols), "getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;", arg0);
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(DateFormatSymbols), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getLocalPatternChars()
		{
			return Instance.CallMethod<String>("getLocalPatternChars", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/String[];")]
		public ObjectArray<ObjectArray<String>> getZoneStrings()
		{
			return Instance.CallMethod<ObjectArray<ObjectArray<String>>>("getZoneStrings", "()[Ljava/lang/String[];");
		}
		
		[JavaSignature("([Ljava/lang/String;)V")]
		public void setAmPmStrings(ObjectArray<String> arg0)
		{
			Instance.CallMethod("setAmPmStrings", "([Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setLocalPatternChars(String arg0)
		{
			Instance.CallMethod("setLocalPatternChars", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/String;)V")]
		public void setMonths(ObjectArray<String> arg0)
		{
			Instance.CallMethod("setMonths", "([Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/String;)V")]
		public void setShortMonths(ObjectArray<String> arg0)
		{
			Instance.CallMethod("setShortMonths", "([Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/String;)V")]
		public void setShortWeekdays(ObjectArray<String> arg0)
		{
			Instance.CallMethod("setShortWeekdays", "([Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/String;)V")]
		public void setWeekdays(ObjectArray<String> arg0)
		{
			Instance.CallMethod("setWeekdays", "([Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("([Ljava/lang/String[];)V")]
		public void setZoneStrings(ObjectArray<ObjectArray<String>> arg0)
		{
			Instance.CallMethod("setZoneStrings", "([Ljava/lang/String[];)V", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> getEras()
		{
			return Instance.CallMethod<ObjectArray<String>>("getEras", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("([Ljava/lang/String;)V")]
		public void setEras(ObjectArray<String> arg0)
		{
			Instance.CallMethod("setEras", "([Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> getAmPmStrings()
		{
			return Instance.CallMethod<ObjectArray<String>>("getAmPmStrings", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> getMonths()
		{
			return Instance.CallMethod<ObjectArray<String>>("getMonths", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> getShortMonths()
		{
			return Instance.CallMethod<ObjectArray<String>>("getShortMonths", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> getShortWeekdays()
		{
			return Instance.CallMethod<ObjectArray<String>>("getShortWeekdays", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> getWeekdays()
		{
			return Instance.CallMethod<ObjectArray<String>>("getWeekdays", "()[Ljava/lang/String;");
		}
	}
}
