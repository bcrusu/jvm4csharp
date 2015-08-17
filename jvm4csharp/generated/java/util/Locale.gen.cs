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
	[JavaProxy("java/util/Locale")]
	public class Locale : Object, Cloneable, Serializable
	{
		protected Locale(ProxyCtor p) : base(p) {}
		
		public Locale(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Locale(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Locale(String arg0, String arg1, String arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale ENGLISH
		{
			get { return Static.GetField<Locale>(typeof(Locale), "ENGLISH", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale FRENCH
		{
			get { return Static.GetField<Locale>(typeof(Locale), "FRENCH", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale GERMAN
		{
			get { return Static.GetField<Locale>(typeof(Locale), "GERMAN", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale ITALIAN
		{
			get { return Static.GetField<Locale>(typeof(Locale), "ITALIAN", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale JAPANESE
		{
			get { return Static.GetField<Locale>(typeof(Locale), "JAPANESE", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale KOREAN
		{
			get { return Static.GetField<Locale>(typeof(Locale), "KOREAN", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale CHINESE
		{
			get { return Static.GetField<Locale>(typeof(Locale), "CHINESE", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale SIMPLIFIED_CHINESE
		{
			get { return Static.GetField<Locale>(typeof(Locale), "SIMPLIFIED_CHINESE", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale TRADITIONAL_CHINESE
		{
			get { return Static.GetField<Locale>(typeof(Locale), "TRADITIONAL_CHINESE", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale FRANCE
		{
			get { return Static.GetField<Locale>(typeof(Locale), "FRANCE", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale GERMANY
		{
			get { return Static.GetField<Locale>(typeof(Locale), "GERMANY", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale ITALY
		{
			get { return Static.GetField<Locale>(typeof(Locale), "ITALY", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale JAPAN
		{
			get { return Static.GetField<Locale>(typeof(Locale), "JAPAN", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale KOREA
		{
			get { return Static.GetField<Locale>(typeof(Locale), "KOREA", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale CHINA
		{
			get { return Static.GetField<Locale>(typeof(Locale), "CHINA", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale PRC
		{
			get { return Static.GetField<Locale>(typeof(Locale), "PRC", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale TAIWAN
		{
			get { return Static.GetField<Locale>(typeof(Locale), "TAIWAN", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale UK
		{
			get { return Static.GetField<Locale>(typeof(Locale), "UK", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale US
		{
			get { return Static.GetField<Locale>(typeof(Locale), "US", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale CANADA
		{
			get { return Static.GetField<Locale>(typeof(Locale), "CANADA", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale CANADA_FRENCH
		{
			get { return Static.GetField<Locale>(typeof(Locale), "CANADA_FRENCH", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("Ljava/util/Locale;")]
		public static Locale ROOT
		{
			get { return Static.GetField<Locale>(typeof(Locale), "ROOT", "Ljava/util/Locale;"); }
		}
		
		[JavaSignature("C")]
		public static char PRIVATE_USE_EXTENSION
		{
			get { return Static.GetField<char>(typeof(Locale), "PRIVATE_USE_EXTENSION", "C"); }
		}
		
		[JavaSignature("C")]
		public static char UNICODE_LOCALE_EXTENSION
		{
			get { return Static.GetField<char>(typeof(Locale), "UNICODE_LOCALE_EXTENSION", "C"); }
		}
	
		[JavaSignature("(Ljava/util/Locale/Category;)Ljava/util/Locale;")]
		public static Locale getDefault(Locale.Category arg0)
		{
			return Static.CallMethod<Locale>(typeof(Locale), "getDefault", "(Ljava/util/Locale/Category;)Ljava/util/Locale;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Locale;")]
		public static Locale getDefault()
		{
			return Static.CallMethod<Locale>(typeof(Locale), "getDefault", "()Ljava/util/Locale;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getLanguage()
		{
			return Instance.CallMethod<String>("getLanguage", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Collection;)Ljava/util/List;")]
		public static List<Locale> filter(List<Locale.LanguageRange> arg0, Collection<Locale> arg1)
		{
			return Static.CallMethod<List<Locale>>(typeof(Locale), "filter", "(Ljava/util/List;Ljava/util/Collection;)Ljava/util/List;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Collection;Ljava/util/Locale/FilteringMode;)Ljava/util/List;")]
		public static List<Locale> filter(List<Locale.LanguageRange> arg0, Collection<Locale> arg1, Locale.FilteringMode arg2)
		{
			return Static.CallMethod<List<Locale>>(typeof(Locale), "filter", "(Ljava/util/List;Ljava/util/Collection;Ljava/util/Locale/FilteringMode;)Ljava/util/List;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Collection;)Ljava/util/Locale;")]
		public static Locale lookup(List<Locale.LanguageRange> arg0, Collection<Locale> arg1)
		{
			return Static.CallMethod<Locale>(typeof(Locale), "lookup", "(Ljava/util/List;Ljava/util/Collection;)Ljava/util/Locale;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Collection;)Ljava/util/List;")]
		public static List<String> filterTags(List<Locale.LanguageRange> arg0, Collection<String> arg1)
		{
			return Static.CallMethod<List<String>>(typeof(Locale), "filterTags", "(Ljava/util/List;Ljava/util/Collection;)Ljava/util/List;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Collection;Ljava/util/Locale/FilteringMode;)Ljava/util/List;")]
		public static List<String> filterTags(List<Locale.LanguageRange> arg0, Collection<String> arg1, Locale.FilteringMode arg2)
		{
			return Static.CallMethod<List<String>>(typeof(Locale), "filterTags", "(Ljava/util/List;Ljava/util/Collection;Ljava/util/Locale/FilteringMode;)Ljava/util/List;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale;")]
		public static Locale forLanguageTag(String arg0)
		{
			return Static.CallMethod<Locale>(typeof(Locale), "forLanguageTag", "(Ljava/lang/String;)Ljava/util/Locale;", arg0);
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(Locale), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCountry()
		{
			return Instance.CallMethod<String>("getCountry", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayCountry()
		{
			return Instance.CallMethod<String>("getDisplayCountry", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayCountry(Locale arg0)
		{
			return Instance.CallMethod<String>("getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayLanguage(Locale arg0)
		{
			return Instance.CallMethod<String>("getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayLanguage()
		{
			return Instance.CallMethod<String>("getDisplayLanguage", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayName()
		{
			return Instance.CallMethod<String>("getDisplayName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(Locale arg0)
		{
			return Instance.CallMethod<String>("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayScript()
		{
			return Instance.CallMethod<String>("getDisplayScript", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayScript(Locale arg0)
		{
			return Instance.CallMethod<String>("getDisplayScript", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayVariant()
		{
			return Instance.CallMethod<String>("getDisplayVariant", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayVariant(Locale arg0)
		{
			return Instance.CallMethod<String>("getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(C)Ljava/lang/String;")]
		public String getExtension(char arg0)
		{
			return Instance.CallMethod<String>("getExtension", "(C)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<Character> getExtensionKeys()
		{
			return Instance.CallMethod<Set<Character>>("getExtensionKeys", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getISO3Country()
		{
			return Instance.CallMethod<String>("getISO3Country", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getISO3Language()
		{
			return Instance.CallMethod<String>("getISO3Language", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public static ObjectArray<String> getISOCountries()
		{
			return Static.CallMethod<ObjectArray<String>>(typeof(Locale), "getISOCountries", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public static ObjectArray<String> getISOLanguages()
		{
			return Static.CallMethod<ObjectArray<String>>(typeof(Locale), "getISOLanguages", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getScript()
		{
			return Instance.CallMethod<String>("getScript", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<String> getUnicodeLocaleAttributes()
		{
			return Instance.CallMethod<Set<String>>("getUnicodeLocaleAttributes", "()Ljava/util/Set;");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<String> getUnicodeLocaleKeys()
		{
			return Instance.CallMethod<Set<String>>("getUnicodeLocaleKeys", "()Ljava/util/Set;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String getUnicodeLocaleType(String arg0)
		{
			return Instance.CallMethod<String>("getUnicodeLocaleType", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getVariant()
		{
			return Instance.CallMethod<String>("getVariant", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool hasExtensions()
		{
			return Instance.CallMethod<bool>("hasExtensions", "()Z");
		}
		
		[JavaSignature("(Ljava/util/List;Ljava/util/Collection;)Ljava/lang/String;")]
		public static String lookupTag(List<Locale.LanguageRange> arg0, Collection<String> arg1)
		{
			return Static.CallMethod<String>(typeof(Locale), "lookupTag", "(Ljava/util/List;Ljava/util/Collection;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Locale;)V")]
		public static void setDefault(Locale arg0)
		{
			Static.CallMethod(typeof(Locale), "setDefault", "(Ljava/util/Locale;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale/Category;Ljava/util/Locale;)V")]
		public static void setDefault(Locale.Category arg0, Locale arg1)
		{
			Static.CallMethod(typeof(Locale), "setDefault", "(Ljava/util/Locale/Category;Ljava/util/Locale;)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Locale;")]
		public Locale stripExtensions()
		{
			return Instance.CallMethod<Locale>("stripExtensions", "()Ljava/util/Locale;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toLanguageTag()
		{
			return Instance.CallMethod<String>("toLanguageTag", "()Ljava/lang/String;");
		}
	
		[JavaProxy("java/util/Locale/Builder")]
		public class Builder : Object
		{
			protected Builder(ProxyCtor p) : base(p) {}
			
			public Builder() : base(ProxyCtor.I)
			{
				Instance.CallConstructor("()V");
			}
		
			[JavaSignature("()Ljava/util/Locale/Builder;")]
			public Locale.Builder clear()
			{
				return Instance.CallMethod<Locale.Builder>("clear", "()Ljava/util/Locale/Builder;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setLanguageTag(String arg0)
			{
				return Instance.CallMethod<Locale.Builder>("setLanguageTag", "(Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/util/Locale;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setLocale(Locale arg0)
			{
				return Instance.CallMethod<Locale.Builder>("setLocale", "(Ljava/util/Locale;)Ljava/util/Locale/Builder;", arg0);
			}
			
			[JavaSignature("()Ljava/util/Locale;")]
			public Locale build()
			{
				return Instance.CallMethod<Locale>("build", "()Ljava/util/Locale;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder addUnicodeLocaleAttribute(String arg0)
			{
				return Instance.CallMethod<Locale.Builder>("addUnicodeLocaleAttribute", "(Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0);
			}
			
			[JavaSignature("()Ljava/util/Locale/Builder;")]
			public Locale.Builder clearExtensions()
			{
				return Instance.CallMethod<Locale.Builder>("clearExtensions", "()Ljava/util/Locale/Builder;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder removeUnicodeLocaleAttribute(String arg0)
			{
				return Instance.CallMethod<Locale.Builder>("removeUnicodeLocaleAttribute", "(Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0);
			}
			
			[JavaSignature("(CLjava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setExtension(char arg0, String arg1)
			{
				return Instance.CallMethod<Locale.Builder>("setExtension", "(CLjava/lang/String;)Ljava/util/Locale/Builder;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setLanguage(String arg0)
			{
				return Instance.CallMethod<Locale.Builder>("setLanguage", "(Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setRegion(String arg0)
			{
				return Instance.CallMethod<Locale.Builder>("setRegion", "(Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setScript(String arg0)
			{
				return Instance.CallMethod<Locale.Builder>("setScript", "(Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setUnicodeLocaleKeyword(String arg0, String arg1)
			{
				return Instance.CallMethod<Locale.Builder>("setUnicodeLocaleKeyword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Builder;")]
			public Locale.Builder setVariant(String arg0)
			{
				return Instance.CallMethod<Locale.Builder>("setVariant", "(Ljava/lang/String;)Ljava/util/Locale/Builder;", arg0);
			}
		}
		
		[JavaProxy("java/util/Locale/Category")]
		public class Category : Enum<Locale.Category>
		{
			protected Category(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/util/Locale/Category;")]
			public static Locale.Category DISPLAY
			{
				get { return Static.GetField<Locale.Category>(typeof(Category), "DISPLAY", "Ljava/util/Locale/Category;"); }
			}
			
			[JavaSignature("Ljava/util/Locale/Category;")]
			public static Locale.Category FORMAT
			{
				get { return Static.GetField<Locale.Category>(typeof(Category), "FORMAT", "Ljava/util/Locale/Category;"); }
			}
		
			[JavaSignature("()[Ljava/util/Locale/Category;")]
			public static ObjectArray<Locale.Category> values()
			{
				return Static.CallMethod<ObjectArray<Locale.Category>>(typeof(Category), "values", "()[Ljava/util/Locale/Category;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/Category;")]
			public static Locale.Category valueOf(String arg0)
			{
				return Static.CallMethod<Locale.Category>(typeof(Category), "valueOf", "(Ljava/lang/String;)Ljava/util/Locale/Category;", arg0);
			}
		}
		
		[JavaProxy("java/util/Locale/FilteringMode")]
		public class FilteringMode : Enum<Locale.FilteringMode>
		{
			protected FilteringMode(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/util/Locale/FilteringMode;")]
			public static Locale.FilteringMode AUTOSELECT_FILTERING
			{
				get { return Static.GetField<Locale.FilteringMode>(typeof(FilteringMode), "AUTOSELECT_FILTERING", "Ljava/util/Locale/FilteringMode;"); }
			}
			
			[JavaSignature("Ljava/util/Locale/FilteringMode;")]
			public static Locale.FilteringMode EXTENDED_FILTERING
			{
				get { return Static.GetField<Locale.FilteringMode>(typeof(FilteringMode), "EXTENDED_FILTERING", "Ljava/util/Locale/FilteringMode;"); }
			}
			
			[JavaSignature("Ljava/util/Locale/FilteringMode;")]
			public static Locale.FilteringMode IGNORE_EXTENDED_RANGES
			{
				get { return Static.GetField<Locale.FilteringMode>(typeof(FilteringMode), "IGNORE_EXTENDED_RANGES", "Ljava/util/Locale/FilteringMode;"); }
			}
			
			[JavaSignature("Ljava/util/Locale/FilteringMode;")]
			public static Locale.FilteringMode MAP_EXTENDED_RANGES
			{
				get { return Static.GetField<Locale.FilteringMode>(typeof(FilteringMode), "MAP_EXTENDED_RANGES", "Ljava/util/Locale/FilteringMode;"); }
			}
			
			[JavaSignature("Ljava/util/Locale/FilteringMode;")]
			public static Locale.FilteringMode REJECT_EXTENDED_RANGES
			{
				get { return Static.GetField<Locale.FilteringMode>(typeof(FilteringMode), "REJECT_EXTENDED_RANGES", "Ljava/util/Locale/FilteringMode;"); }
			}
		
			[JavaSignature("()[Ljava/util/Locale/FilteringMode;")]
			public static ObjectArray<Locale.FilteringMode> values()
			{
				return Static.CallMethod<ObjectArray<Locale.FilteringMode>>(typeof(FilteringMode), "values", "()[Ljava/util/Locale/FilteringMode;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/Locale/FilteringMode;")]
			public static Locale.FilteringMode valueOf(String arg0)
			{
				return Static.CallMethod<Locale.FilteringMode>(typeof(FilteringMode), "valueOf", "(Ljava/lang/String;)Ljava/util/Locale/FilteringMode;", arg0);
			}
		}
		
		[JavaProxy("java/util/Locale/LanguageRange")]
		public class LanguageRange : Object
		{
			protected LanguageRange(ProxyCtor p) : base(p) {}
			
			public LanguageRange(String arg0) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
			}
			
			public LanguageRange(String arg0, double arg1) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/lang/String;D)V", arg0, arg1);
			}
		
			[JavaSignature("D")]
			public static double MAX_WEIGHT
			{
				get { return Static.GetField<double>(typeof(LanguageRange), "MAX_WEIGHT", "D"); }
			}
			
			[JavaSignature("D")]
			public static double MIN_WEIGHT
			{
				get { return Static.GetField<double>(typeof(LanguageRange), "MIN_WEIGHT", "D"); }
			}
		
			[JavaSignature("(Ljava/lang/String;)Ljava/util/List;")]
			public static List<Locale.LanguageRange> parse(String arg0)
			{
				return Static.CallMethod<List<Locale.LanguageRange>>(typeof(LanguageRange), "parse", "(Ljava/lang/String;)Ljava/util/List;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/util/Map;)Ljava/util/List;")]
			public static List<Locale.LanguageRange> parse(String arg0, Map<String, List<String>> arg1)
			{
				return Static.CallMethod<List<Locale.LanguageRange>>(typeof(LanguageRange), "parse", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/List;", arg0, arg1);
			}
			
			[JavaSignature("()Ljava/lang/String;")]
			public String getRange()
			{
				return Instance.CallMethod<String>("getRange", "()Ljava/lang/String;");
			}
			
			[JavaSignature("()D")]
			public double getWeight()
			{
				return Instance.CallMethod<double>("getWeight", "()D");
			}
			
			[JavaSignature("(Ljava/util/List;Ljava/util/Map;)Ljava/util/List;")]
			public static List<Locale.LanguageRange> mapEquivalents(List<Locale.LanguageRange> arg0, Map<String, List<String>> arg1)
			{
				return Static.CallMethod<List<Locale.LanguageRange>>(typeof(LanguageRange), "mapEquivalents", "(Ljava/util/List;Ljava/util/Map;)Ljava/util/List;", arg0, arg1);
			}
		}
	}
}
