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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Calendar")]
	public abstract class Calendar : Object, Serializable, Cloneable, Comparable<Calendar>
	{
		protected Calendar(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int ERA
		{
			get { return Static.GetField<int>(typeof(Calendar), "ERA", "I"); }
		}
		
		[JavaSignature("I")]
		public static int YEAR
		{
			get { return Static.GetField<int>(typeof(Calendar), "YEAR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MONTH
		{
			get { return Static.GetField<int>(typeof(Calendar), "MONTH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int WEEK_OF_YEAR
		{
			get { return Static.GetField<int>(typeof(Calendar), "WEEK_OF_YEAR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int WEEK_OF_MONTH
		{
			get { return Static.GetField<int>(typeof(Calendar), "WEEK_OF_MONTH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DATE
		{
			get { return Static.GetField<int>(typeof(Calendar), "DATE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DAY_OF_MONTH
		{
			get { return Static.GetField<int>(typeof(Calendar), "DAY_OF_MONTH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DAY_OF_YEAR
		{
			get { return Static.GetField<int>(typeof(Calendar), "DAY_OF_YEAR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DAY_OF_WEEK
		{
			get { return Static.GetField<int>(typeof(Calendar), "DAY_OF_WEEK", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DAY_OF_WEEK_IN_MONTH
		{
			get { return Static.GetField<int>(typeof(Calendar), "DAY_OF_WEEK_IN_MONTH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int AM_PM
		{
			get { return Static.GetField<int>(typeof(Calendar), "AM_PM", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HOUR
		{
			get { return Static.GetField<int>(typeof(Calendar), "HOUR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HOUR_OF_DAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "HOUR_OF_DAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MINUTE
		{
			get { return Static.GetField<int>(typeof(Calendar), "MINUTE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SECOND
		{
			get { return Static.GetField<int>(typeof(Calendar), "SECOND", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MILLISECOND
		{
			get { return Static.GetField<int>(typeof(Calendar), "MILLISECOND", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ZONE_OFFSET
		{
			get { return Static.GetField<int>(typeof(Calendar), "ZONE_OFFSET", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DST_OFFSET
		{
			get { return Static.GetField<int>(typeof(Calendar), "DST_OFFSET", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FIELD_COUNT
		{
			get { return Static.GetField<int>(typeof(Calendar), "FIELD_COUNT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SUNDAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "SUNDAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MONDAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "MONDAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int TUESDAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "TUESDAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int WEDNESDAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "WEDNESDAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int THURSDAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "THURSDAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FRIDAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "FRIDAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SATURDAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "SATURDAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int JANUARY
		{
			get { return Static.GetField<int>(typeof(Calendar), "JANUARY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FEBRUARY
		{
			get { return Static.GetField<int>(typeof(Calendar), "FEBRUARY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MARCH
		{
			get { return Static.GetField<int>(typeof(Calendar), "MARCH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int APRIL
		{
			get { return Static.GetField<int>(typeof(Calendar), "APRIL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MAY
		{
			get { return Static.GetField<int>(typeof(Calendar), "MAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int JUNE
		{
			get { return Static.GetField<int>(typeof(Calendar), "JUNE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int JULY
		{
			get { return Static.GetField<int>(typeof(Calendar), "JULY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int AUGUST
		{
			get { return Static.GetField<int>(typeof(Calendar), "AUGUST", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SEPTEMBER
		{
			get { return Static.GetField<int>(typeof(Calendar), "SEPTEMBER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int OCTOBER
		{
			get { return Static.GetField<int>(typeof(Calendar), "OCTOBER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NOVEMBER
		{
			get { return Static.GetField<int>(typeof(Calendar), "NOVEMBER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DECEMBER
		{
			get { return Static.GetField<int>(typeof(Calendar), "DECEMBER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int UNDECIMBER
		{
			get { return Static.GetField<int>(typeof(Calendar), "UNDECIMBER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int AM
		{
			get { return Static.GetField<int>(typeof(Calendar), "AM", "I"); }
		}
		
		[JavaSignature("I")]
		public static int PM
		{
			get { return Static.GetField<int>(typeof(Calendar), "PM", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ALL_STYLES
		{
			get { return Static.GetField<int>(typeof(Calendar), "ALL_STYLES", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SHORT
		{
			get { return Static.GetField<int>(typeof(Calendar), "SHORT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int LONG
		{
			get { return Static.GetField<int>(typeof(Calendar), "LONG", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NARROW_FORMAT
		{
			get { return Static.GetField<int>(typeof(Calendar), "NARROW_FORMAT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NARROW_STANDALONE
		{
			get { return Static.GetField<int>(typeof(Calendar), "NARROW_STANDALONE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SHORT_FORMAT
		{
			get { return Static.GetField<int>(typeof(Calendar), "SHORT_FORMAT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int LONG_FORMAT
		{
			get { return Static.GetField<int>(typeof(Calendar), "LONG_FORMAT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SHORT_STANDALONE
		{
			get { return Static.GetField<int>(typeof(Calendar), "SHORT_STANDALONE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int LONG_STANDALONE
		{
			get { return Static.GetField<int>(typeof(Calendar), "LONG_STANDALONE", "I"); }
		}
	
		[JavaSignature("(II)V")]
		public void @add(int arg0, int arg1)
		{
			Instance.CallMethod("add", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public int @get(int arg0)
		{
			return Instance.CallMethod<int>("get", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/Calendar;)I")]
		public int compareTo(Calendar arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/util/Calendar;)I", arg0);
		}
		
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void clear(int arg0)
		{
			Instance.CallMethod("clear", "(I)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Calendar;")]
		public static Calendar getInstance()
		{
			return Static.CallMethod<Calendar>(typeof(Calendar), "getInstance", "()Ljava/util/Calendar;");
		}
		
		[JavaSignature("(Ljava/util/TimeZone;)Ljava/util/Calendar;")]
		public static Calendar getInstance(TimeZone arg0)
		{
			return Static.CallMethod<Calendar>(typeof(Calendar), "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/util/Calendar;")]
		public static Calendar getInstance(Locale arg0)
		{
			return Static.CallMethod<Calendar>(typeof(Calendar), "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;", arg0);
		}
		
		[JavaSignature("(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;")]
		public static Calendar getInstance(TimeZone arg0, Locale arg1)
		{
			return Static.CallMethod<Calendar>(typeof(Calendar), "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;", arg0, arg1);
		}
		
		[JavaSignature("(I)Z")]
		public bool isSet(int arg0)
		{
			return Instance.CallMethod<bool>("isSet", "(I)Z", arg0);
		}
		
		[JavaSignature("(IIIII)V")]
		public void @set(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			Instance.CallMethod("set", "(IIIII)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(II)V")]
		public void @set(int arg0, int arg1)
		{
			Instance.CallMethod("set", "(II)V", arg0, arg1);
		}
		
		[JavaSignature("(IIIIII)V")]
		public void @set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			Instance.CallMethod("set", "(IIIIII)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(III)V")]
		public void @set(int arg0, int arg1, int arg2)
		{
			Instance.CallMethod("set", "(III)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool after(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("after", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool before(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("before", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(Calendar), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("(IILjava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(int arg0, int arg1, Locale arg2)
		{
			return Instance.CallMethod<String>("getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()J")]
		public long getTimeInMillis()
		{
			return Instance.CallMethod<long>("getTimeInMillis", "()J");
		}
		
		[JavaSignature("()Ljava/util/TimeZone;")]
		public TimeZone getTimeZone()
		{
			return Instance.CallMethod<TimeZone>("getTimeZone", "()Ljava/util/TimeZone;");
		}
		
		[JavaSignature("(IILjava/util/Locale;)Ljava/util/Map;")]
		public Map<String, Integer> getDisplayNames(int arg0, int arg1, Locale arg2)
		{
			return Instance.CallMethod<Map<String, Integer>>("getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Z)V")]
		public void setLenient(bool arg0)
		{
			Instance.CallMethod("setLenient", "(Z)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setTimeInMillis(long arg0)
		{
			Instance.CallMethod("setTimeInMillis", "(J)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/TimeZone;)V")]
		public void setTimeZone(TimeZone arg0)
		{
			Instance.CallMethod("setTimeZone", "(Ljava/util/TimeZone;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Date;")]
		public Date getTime()
		{
			return Instance.CallMethod<Date>("getTime", "()Ljava/util/Date;");
		}
		
		[JavaSignature("(Ljava/util/Date;)V")]
		public void setTime(Date arg0)
		{
			Instance.CallMethod("setTime", "(Ljava/util/Date;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public static Set<String> getAvailableCalendarTypes()
		{
			return Static.CallMethod<Set<String>>(typeof(Calendar), "getAvailableCalendarTypes", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()I")]
		public int getFirstDayOfWeek()
		{
			return Instance.CallMethod<int>("getFirstDayOfWeek", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isWeekDateSupported()
		{
			return Instance.CallMethod<bool>("isWeekDateSupported", "()Z");
		}
		
		[JavaSignature("(I)V")]
		public void setFirstDayOfWeek(int arg0)
		{
			Instance.CallMethod("setFirstDayOfWeek", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMinimalDaysInFirstWeek(int arg0)
		{
			Instance.CallMethod("setMinimalDaysInFirstWeek", "(I)V", arg0);
		}
		
		[JavaSignature("(III)V")]
		public void setWeekDate(int arg0, int arg1, int arg2)
		{
			Instance.CallMethod("setWeekDate", "(III)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(I)I")]
		public int getActualMaximum(int arg0)
		{
			return Instance.CallMethod<int>("getActualMaximum", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int getActualMinimum(int arg0)
		{
			return Instance.CallMethod<int>("getActualMinimum", "(I)I", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCalendarType()
		{
			return Instance.CallMethod<String>("getCalendarType", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(I)I")]
		public int getGreatestMinimum(int arg0)
		{
			return Instance.CallMethod<int>("getGreatestMinimum", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int getLeastMaximum(int arg0)
		{
			return Instance.CallMethod<int>("getLeastMaximum", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int getMaximum(int arg0)
		{
			return Instance.CallMethod<int>("getMaximum", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int getMinimalDaysInFirstWeek()
		{
			return Instance.CallMethod<int>("getMinimalDaysInFirstWeek", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int getMinimum(int arg0)
		{
			return Instance.CallMethod<int>("getMinimum", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int getWeekYear()
		{
			return Instance.CallMethod<int>("getWeekYear", "()I");
		}
		
		[JavaSignature("()I")]
		public int getWeeksInWeekYear()
		{
			return Instance.CallMethod<int>("getWeeksInWeekYear", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isLenient()
		{
			return Instance.CallMethod<bool>("isLenient", "()Z");
		}
		
		[JavaSignature("(IZ)V")]
		public void roll(int arg0, bool arg1)
		{
			Instance.CallMethod("roll", "(IZ)V", arg0, arg1);
		}
		
		[JavaSignature("(II)V")]
		public void roll(int arg0, int arg1)
		{
			Instance.CallMethod("roll", "(II)V", arg0, arg1);
		}
	
		[JavaProxy("java/util/Calendar/Builder")]
		public class Builder : Object
		{
			protected Builder(ProxyCtor p) : base(p) {}
			
			public Builder() : base(ProxyCtor.I)
			{
				Instance.CallConstructor("()V");
			}
		
			[JavaSignature("(II)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder @set(int arg0, int arg1)
			{
				return Instance.CallMethod<Calendar.Builder>("set", "(II)Ljava/util/Calendar/Builder;", arg0, arg1);
			}
			
			[JavaSignature("(III)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setDate(int arg0, int arg1, int arg2)
			{
				return Instance.CallMethod<Calendar.Builder>("setDate", "(III)Ljava/util/Calendar/Builder;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(III)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setTimeOfDay(int arg0, int arg1, int arg2)
			{
				return Instance.CallMethod<Calendar.Builder>("setTimeOfDay", "(III)Ljava/util/Calendar/Builder;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(IIII)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setTimeOfDay(int arg0, int arg1, int arg2, int arg3)
			{
				return Instance.CallMethod<Calendar.Builder>("setTimeOfDay", "(IIII)Ljava/util/Calendar/Builder;", arg0, arg1, arg2, arg3);
			}
			
			[JavaSignature("(Ljava/util/Locale;)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setLocale(Locale arg0)
			{
				return Instance.CallMethod<Calendar.Builder>("setLocale", "(Ljava/util/Locale;)Ljava/util/Calendar/Builder;", arg0);
			}
			
			[JavaSignature("(Z)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setLenient(bool arg0)
			{
				return Instance.CallMethod<Calendar.Builder>("setLenient", "(Z)Ljava/util/Calendar/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/util/TimeZone;)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setTimeZone(TimeZone arg0)
			{
				return Instance.CallMethod<Calendar.Builder>("setTimeZone", "(Ljava/util/TimeZone;)Ljava/util/Calendar/Builder;", arg0);
			}
			
			[JavaSignature("()Ljava/util/Calendar;")]
			public Calendar build()
			{
				return Instance.CallMethod<Calendar>("build", "()Ljava/util/Calendar;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setCalendarType(String arg0)
			{
				return Instance.CallMethod<Calendar.Builder>("setCalendarType", "(Ljava/lang/String;)Ljava/util/Calendar/Builder;", arg0);
			}
			
			[JavaSignature("([I)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setFields(IntArray arg0)
			{
				return Instance.CallMethod<Calendar.Builder>("setFields", "([I)Ljava/util/Calendar/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/util/Date;)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setInstant(Date arg0)
			{
				return Instance.CallMethod<Calendar.Builder>("setInstant", "(Ljava/util/Date;)Ljava/util/Calendar/Builder;", arg0);
			}
			
			[JavaSignature("(J)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setInstant(long arg0)
			{
				return Instance.CallMethod<Calendar.Builder>("setInstant", "(J)Ljava/util/Calendar/Builder;", arg0);
			}
			
			[JavaSignature("(III)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setWeekDate(int arg0, int arg1, int arg2)
			{
				return Instance.CallMethod<Calendar.Builder>("setWeekDate", "(III)Ljava/util/Calendar/Builder;", arg0, arg1, arg2);
			}
			
			[JavaSignature("(II)Ljava/util/Calendar/Builder;")]
			public Calendar.Builder setWeekDefinition(int arg0, int arg1)
			{
				return Instance.CallMethod<Calendar.Builder>("setWeekDefinition", "(II)Ljava/util/Calendar/Builder;", arg0, arg1);
			}
		}
	}
}
