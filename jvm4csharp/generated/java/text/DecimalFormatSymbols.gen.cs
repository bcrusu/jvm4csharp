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
	[JavaProxy("java/text/DecimalFormatSymbols")]
	public class DecimalFormatSymbols : Object, Cloneable, Serializable
	{
		protected DecimalFormatSymbols(ProxyCtor p) : base(p) {}
		
		public DecimalFormatSymbols() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public DecimalFormatSymbols(Locale arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Locale;)V", arg0);
		}
	
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;")]
		public static DecimalFormatSymbols getInstance(Locale arg0)
		{
			return Static.CallMethod<DecimalFormatSymbols>(typeof(DecimalFormatSymbols), "getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;", arg0);
		}
		
		[JavaSignature("()Ljava/text/DecimalFormatSymbols;")]
		public static DecimalFormatSymbols getInstance()
		{
			return Static.CallMethod<DecimalFormatSymbols>(typeof(DecimalFormatSymbols), "getInstance", "()Ljava/text/DecimalFormatSymbols;");
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(DecimalFormatSymbols), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("()C")]
		public char getZeroDigit()
		{
			return Instance.CallMethod<char>("getZeroDigit", "()C");
		}
		
		[JavaSignature("()C")]
		public char getDecimalSeparator()
		{
			return Instance.CallMethod<char>("getDecimalSeparator", "()C");
		}
		
		[JavaSignature("()C")]
		public char getGroupingSeparator()
		{
			return Instance.CallMethod<char>("getGroupingSeparator", "()C");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getInfinity()
		{
			return Instance.CallMethod<String>("getInfinity", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getNaN()
		{
			return Instance.CallMethod<String>("getNaN", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/Currency;")]
		public Currency getCurrency()
		{
			return Instance.CallMethod<Currency>("getCurrency", "()Ljava/util/Currency;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCurrencySymbol()
		{
			return Instance.CallMethod<String>("getCurrencySymbol", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()C")]
		public char getDigit()
		{
			return Instance.CallMethod<char>("getDigit", "()C");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getExponentSeparator()
		{
			return Instance.CallMethod<String>("getExponentSeparator", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getInternationalCurrencySymbol()
		{
			return Instance.CallMethod<String>("getInternationalCurrencySymbol", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()C")]
		public char getMinusSign()
		{
			return Instance.CallMethod<char>("getMinusSign", "()C");
		}
		
		[JavaSignature("()C")]
		public char getMonetaryDecimalSeparator()
		{
			return Instance.CallMethod<char>("getMonetaryDecimalSeparator", "()C");
		}
		
		[JavaSignature("()C")]
		public char getPatternSeparator()
		{
			return Instance.CallMethod<char>("getPatternSeparator", "()C");
		}
		
		[JavaSignature("()C")]
		public char getPerMill()
		{
			return Instance.CallMethod<char>("getPerMill", "()C");
		}
		
		[JavaSignature("()C")]
		public char getPercent()
		{
			return Instance.CallMethod<char>("getPercent", "()C");
		}
		
		[JavaSignature("(Ljava/util/Currency;)V")]
		public void setCurrency(Currency arg0)
		{
			Instance.CallMethod("setCurrency", "(Ljava/util/Currency;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setCurrencySymbol(String arg0)
		{
			Instance.CallMethod("setCurrencySymbol", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setDecimalSeparator(char arg0)
		{
			Instance.CallMethod("setDecimalSeparator", "(C)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setDigit(char arg0)
		{
			Instance.CallMethod("setDigit", "(C)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setExponentSeparator(String arg0)
		{
			Instance.CallMethod("setExponentSeparator", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setGroupingSeparator(char arg0)
		{
			Instance.CallMethod("setGroupingSeparator", "(C)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setInfinity(String arg0)
		{
			Instance.CallMethod("setInfinity", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setInternationalCurrencySymbol(String arg0)
		{
			Instance.CallMethod("setInternationalCurrencySymbol", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setMinusSign(char arg0)
		{
			Instance.CallMethod("setMinusSign", "(C)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setMonetaryDecimalSeparator(char arg0)
		{
			Instance.CallMethod("setMonetaryDecimalSeparator", "(C)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setNaN(String arg0)
		{
			Instance.CallMethod("setNaN", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setPatternSeparator(char arg0)
		{
			Instance.CallMethod("setPatternSeparator", "(C)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setPerMill(char arg0)
		{
			Instance.CallMethod("setPerMill", "(C)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setPercent(char arg0)
		{
			Instance.CallMethod("setPercent", "(C)V", arg0);
		}
		
		[JavaSignature("(C)V")]
		public void setZeroDigit(char arg0)
		{
			Instance.CallMethod("setZeroDigit", "(C)V", arg0);
		}
	}
}
