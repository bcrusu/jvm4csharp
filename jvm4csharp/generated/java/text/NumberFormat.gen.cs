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
using jvm4csharp.java.math;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/NumberFormat")]
	public abstract class NumberFormat : Format
	{
		protected NumberFormat(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int INTEGER_FIELD
		{
			get { return Static.GetField<int>(typeof(NumberFormat), "INTEGER_FIELD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FRACTION_FIELD
		{
			get { return Static.GetField<int>(typeof(NumberFormat), "FRACTION_FIELD", "I"); }
		}
	
		[JavaSignature("(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;")]
		public StringBuffer format(long arg0, StringBuffer arg1, FieldPosition arg2)
		{
			return Instance.CallMethod<StringBuffer>("format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;")]
		public StringBuffer format(double arg0, StringBuffer arg1, FieldPosition arg2)
		{
			return Instance.CallMethod<StringBuffer>("format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(D)Ljava/lang/String;")]
		public String format(double arg0)
		{
			return Instance.CallMethod<String>("format", "(D)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/String;")]
		public String format(long arg0)
		{
			return Instance.CallMethod<String>("format", "(J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/text/NumberFormat;")]
		public static NumberFormat getInstance()
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getInstance", "()Ljava/text/NumberFormat;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public static NumberFormat getInstance(Locale arg0)
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;")]
		public Number parse(String arg0, ParsePosition arg1)
		{
			return Instance.CallMethod<Number>("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Number;")]
		public Number parse(String arg0)
		{
			return Instance.CallMethod<Number>("parse", "(Ljava/lang/String;)Ljava/lang/Number;", arg0);
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(NumberFormat), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public static NumberFormat getIntegerInstance(Locale arg0)
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("()Ljava/text/NumberFormat;")]
		public static NumberFormat getIntegerInstance()
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getIntegerInstance", "()Ljava/text/NumberFormat;");
		}
		
		[JavaSignature("()I")]
		public int getMaximumFractionDigits()
		{
			return Instance.CallMethod<int>("getMaximumFractionDigits", "()I");
		}
		
		[JavaSignature("()I")]
		public int getMaximumIntegerDigits()
		{
			return Instance.CallMethod<int>("getMaximumIntegerDigits", "()I");
		}
		
		[JavaSignature("()I")]
		public int getMinimumFractionDigits()
		{
			return Instance.CallMethod<int>("getMinimumFractionDigits", "()I");
		}
		
		[JavaSignature("()I")]
		public int getMinimumIntegerDigits()
		{
			return Instance.CallMethod<int>("getMinimumIntegerDigits", "()I");
		}
		
		[JavaSignature("()Ljava/math/RoundingMode;")]
		public RoundingMode getRoundingMode()
		{
			return Instance.CallMethod<RoundingMode>("getRoundingMode", "()Ljava/math/RoundingMode;");
		}
		
		[JavaSignature("()Z")]
		public bool isGroupingUsed()
		{
			return Instance.CallMethod<bool>("isGroupingUsed", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isParseIntegerOnly()
		{
			return Instance.CallMethod<bool>("isParseIntegerOnly", "()Z");
		}
		
		[JavaSignature("(Z)V")]
		public void setGroupingUsed(bool arg0)
		{
			Instance.CallMethod("setGroupingUsed", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMaximumFractionDigits(int arg0)
		{
			Instance.CallMethod("setMaximumFractionDigits", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMaximumIntegerDigits(int arg0)
		{
			Instance.CallMethod("setMaximumIntegerDigits", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMinimumFractionDigits(int arg0)
		{
			Instance.CallMethod("setMinimumFractionDigits", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMinimumIntegerDigits(int arg0)
		{
			Instance.CallMethod("setMinimumIntegerDigits", "(I)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setParseIntegerOnly(bool arg0)
		{
			Instance.CallMethod("setParseIntegerOnly", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/math/RoundingMode;)V")]
		public void setRoundingMode(RoundingMode arg0)
		{
			Instance.CallMethod("setRoundingMode", "(Ljava/math/RoundingMode;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public static NumberFormat getCurrencyInstance(Locale arg0)
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("()Ljava/text/NumberFormat;")]
		public static NumberFormat getCurrencyInstance()
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getCurrencyInstance", "()Ljava/text/NumberFormat;");
		}
		
		[JavaSignature("()Ljava/text/NumberFormat;")]
		public static NumberFormat getPercentInstance()
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getPercentInstance", "()Ljava/text/NumberFormat;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public static NumberFormat getPercentInstance(Locale arg0)
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/NumberFormat;")]
		public static NumberFormat getNumberInstance(Locale arg0)
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
		}
		
		[JavaSignature("()Ljava/text/NumberFormat;")]
		public static NumberFormat getNumberInstance()
		{
			return Static.CallMethod<NumberFormat>(typeof(NumberFormat), "getNumberInstance", "()Ljava/text/NumberFormat;");
		}
		
		[JavaSignature("()Ljava/util/Currency;")]
		public Currency getCurrency()
		{
			return Instance.CallMethod<Currency>("getCurrency", "()Ljava/util/Currency;");
		}
		
		[JavaSignature("(Ljava/util/Currency;)V")]
		public void setCurrency(Currency arg0)
		{
			Instance.CallMethod("setCurrency", "(Ljava/util/Currency;)V", arg0);
		}
	
		[JavaProxy("java/text/NumberFormat/Field")]
		public class Field : Format.Field
		{
			protected Field(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field INTEGER
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "INTEGER", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field FRACTION
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "FRACTION", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field EXPONENT
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "EXPONENT", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field DECIMAL_SEPARATOR
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "DECIMAL_SEPARATOR", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field SIGN
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "SIGN", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field GROUPING_SEPARATOR
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "GROUPING_SEPARATOR", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field EXPONENT_SYMBOL
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "EXPONENT_SYMBOL", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field PERCENT
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "PERCENT", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field PERMILLE
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "PERMILLE", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field CURRENCY
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "CURRENCY", "Ljava/text/NumberFormat/Field;"); }
			}
			
			[JavaSignature("Ljava/text/NumberFormat/Field;")]
			public static NumberFormat.Field EXPONENT_SIGN
			{
				get { return Static.GetField<NumberFormat.Field>(typeof(Field), "EXPONENT_SIGN", "Ljava/text/NumberFormat/Field;"); }
			}
		}
	}
}
