//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/DateFormat")]
	public abstract partial class DateFormat : Format
	{
		protected DateFormat(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int ERA_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "ERA_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int YEAR_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "YEAR_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MONTH_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "MONTH_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DATE_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "DATE_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HOUR_OF_DAY1_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "HOUR_OF_DAY1_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HOUR_OF_DAY0_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "HOUR_OF_DAY0_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MINUTE_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "MINUTE_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SECOND_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "SECOND_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MILLISECOND_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "MILLISECOND_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DAY_OF_WEEK_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "DAY_OF_WEEK_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DAY_OF_YEAR_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "DAY_OF_YEAR_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DAY_OF_WEEK_IN_MONTH_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "DAY_OF_WEEK_IN_MONTH_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int WEEK_OF_YEAR_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "WEEK_OF_YEAR_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int WEEK_OF_MONTH_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "WEEK_OF_MONTH_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int AM_PM_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "AM_PM_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HOUR1_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "HOUR1_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HOUR0_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "HOUR0_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int TIMEZONE_FIELD
		{
			get { return Static.GetField<int>(typeof(DateFormat), "TIMEZONE_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FULL
		{
			get { return Static.GetField<int>(typeof(DateFormat), "FULL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int LONG
		{
			get { return Static.GetField<int>(typeof(DateFormat), "LONG", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MEDIUM
		{
			get { return Static.GetField<int>(typeof(DateFormat), "MEDIUM", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SHORT
		{
			get { return Static.GetField<int>(typeof(DateFormat), "SHORT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DEFAULT
		{
			get { return Static.GetField<int>(typeof(DateFormat), "DEFAULT", "I"); }
		}
	
		[JavaSignature("(Ljava/util/Date;)Ljava/lang/String;")]
		public String format(Date arg0)
		{
			return Instance.CallMethod<String>("format", "(Ljava/util/Date;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;")]
		public StringBuffer format(Date arg0, StringBuffer arg1, FieldPosition arg2)
		{
			return Instance.CallMethod<StringBuffer>("format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/text/DateFormat;")]
		public static DateFormat getInstance()
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getInstance", "()Ljava/text/DateFormat;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Date;")]
		public Date parse(String arg0)
		{
			return Instance.CallMethod<Date>("parse", "(Ljava/lang/String;)Ljava/util/Date;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;")]
		public Date parse(String arg0, ParsePosition arg1)
		{
			return Instance.CallMethod<Date>("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", arg0, arg1);
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(DateFormat), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("(Ljava/util/TimeZone;)V")]
		public void setTimeZone(TimeZone arg0)
		{
			Instance.CallMethod("setTimeZone", "(Ljava/util/TimeZone;)V", arg0);
		}
		
		[JavaSignature("(II)Ljava/text/DateFormat;")]
		public static DateFormat getDateTimeInstance(int arg0, int arg1)
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getDateTimeInstance", "(II)Ljava/text/DateFormat;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/text/DateFormat;")]
		public static DateFormat getDateTimeInstance()
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getDateTimeInstance", "()Ljava/text/DateFormat;");
		}
		
		[JavaSignature("(IILjava/util/Locale;)Ljava/text/DateFormat;")]
		public static DateFormat getDateTimeInstance(int arg0, int arg1, Locale arg2)
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/util/TimeZone;")]
		public TimeZone getTimeZone()
		{
			return Instance.CallMethod<TimeZone>("getTimeZone", "()Ljava/util/TimeZone;");
		}
		
		[JavaSignature("(Z)V")]
		public void setLenient(bool arg0)
		{
			Instance.CallMethod("setLenient", "(Z)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isLenient()
		{
			return Instance.CallMethod<bool>("isLenient", "()Z");
		}
		
		[JavaSignature("(I)Ljava/text/DateFormat;")]
		public static DateFormat getDateInstance(int arg0)
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getDateInstance", "(I)Ljava/text/DateFormat;", arg0);
		}
		
		[JavaSignature("(ILjava/util/Locale;)Ljava/text/DateFormat;")]
		public static DateFormat getDateInstance(int arg0, Locale arg1)
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/text/DateFormat;")]
		public static DateFormat getDateInstance()
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getDateInstance", "()Ljava/text/DateFormat;");
		}
		
		[JavaSignature("(ILjava/util/Locale;)Ljava/text/DateFormat;")]
		public static DateFormat getTimeInstance(int arg0, Locale arg1)
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/text/DateFormat;")]
		public static DateFormat getTimeInstance(int arg0)
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getTimeInstance", "(I)Ljava/text/DateFormat;", arg0);
		}
		
		[JavaSignature("()Ljava/text/DateFormat;")]
		public static DateFormat getTimeInstance()
		{
			return Static.CallMethod<DateFormat>(typeof(DateFormat), "getTimeInstance", "()Ljava/text/DateFormat;");
		}
		
		[JavaSignature("()Ljava/util/Calendar;")]
		public Calendar getCalendar()
		{
			return Instance.CallMethod<Calendar>("getCalendar", "()Ljava/util/Calendar;");
		}
		
		[JavaSignature("()Ljava/text/NumberFormat;")]
		public NumberFormat getNumberFormat()
		{
			return Instance.CallMethod<NumberFormat>("getNumberFormat", "()Ljava/text/NumberFormat;");
		}
		
		[JavaSignature("(Ljava/util/Calendar;)V")]
		public void setCalendar(Calendar arg0)
		{
			Instance.CallMethod("setCalendar", "(Ljava/util/Calendar;)V", arg0);
		}
		
		[JavaSignature("(Ljava/text/NumberFormat;)V")]
		public void setNumberFormat(NumberFormat arg0)
		{
			Instance.CallMethod("setNumberFormat", "(Ljava/text/NumberFormat;)V", arg0);
		}
	}
	
	public static partial class DateFormat_
	{
		[JavaProxy("java/text/DateFormat/Field")]
		public partial class Field : Format_.Field
		{
			protected Field(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field ERA
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "ERA", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field YEAR
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "YEAR", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field MONTH
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "MONTH", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field DAY_OF_MONTH
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "DAY_OF_MONTH", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field HOUR_OF_DAY1
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "HOUR_OF_DAY1", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field HOUR_OF_DAY0
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "HOUR_OF_DAY0", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field MINUTE
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "MINUTE", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field SECOND
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "SECOND", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field MILLISECOND
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "MILLISECOND", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field DAY_OF_WEEK
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "DAY_OF_WEEK", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field DAY_OF_YEAR
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "DAY_OF_YEAR", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field DAY_OF_WEEK_IN_MONTH
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "DAY_OF_WEEK_IN_MONTH", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field WEEK_OF_YEAR
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "WEEK_OF_YEAR", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field WEEK_OF_MONTH
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "WEEK_OF_MONTH", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field AM_PM
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "AM_PM", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field HOUR1
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "HOUR1", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field HOUR0
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "HOUR0", "Ljava/text/DateFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field TIME_ZONE
			{
				get { return Static.GetField<DateFormat_.Field>(typeof(Field), "TIME_ZONE", "Ljava/text/DateFormat/Field;"); }
			}
		
			[JavaSignature("()I")]
			public int getCalendarField()
			{
				return Instance.CallMethod<int>("getCalendarField", "()I");
			}
			
			[JavaSignature("(I)Ljava/text/DateFormat/Field;")]
			public static DateFormat_.Field ofCalendarField(int arg0)
			{
				return Static.CallMethod<DateFormat_.Field>(typeof(Field), "ofCalendarField", "(I)Ljava/text/DateFormat/Field;", arg0);
			}
		}
	}
}
