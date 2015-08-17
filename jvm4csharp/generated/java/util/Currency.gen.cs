//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Currency")]
	public class Currency : Object, Serializable
	{
		protected Currency(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Currency;")]
		public static Currency getInstance(String arg0)
		{
			return Static.CallMethod<Currency>(typeof(Currency), "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/util/Currency;")]
		public static Currency getInstance(Locale arg0)
		{
			return Static.CallMethod<Currency>(typeof(Currency), "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(Locale arg0)
		{
			return Instance.CallMethod<String>("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayName()
		{
			return Instance.CallMethod<String>("getDisplayName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public static Set<Currency> getAvailableCurrencies()
		{
			return Static.CallMethod<Set<Currency>>(typeof(Currency), "getAvailableCurrencies", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCurrencyCode()
		{
			return Instance.CallMethod<String>("getCurrencyCode", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getDefaultFractionDigits()
		{
			return Instance.CallMethod<int>("getDefaultFractionDigits", "()I");
		}
		
		[JavaSignature("()I")]
		public int getNumericCode()
		{
			return Instance.CallMethod<int>("getNumericCode", "()I");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getSymbol(Locale arg0)
		{
			return Instance.CallMethod<String>("getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getSymbol()
		{
			return Instance.CallMethod<String>("getSymbol", "()Ljava/lang/String;");
		}
	}
}
