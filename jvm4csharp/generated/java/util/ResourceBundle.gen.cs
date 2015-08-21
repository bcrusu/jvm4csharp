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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/ResourceBundle")]
	public abstract partial class ResourceBundle : Object
	{
		protected ResourceBundle(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Object;")]
		public IJavaObject getObject(String arg0)
		{
			return Instance.CallMethod<IJavaObject>("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<String> keySet()
		{
			return Instance.CallMethod<Set<String>>("keySet", "()Ljava/util/Set;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool containsKey(String arg0)
		{
			return Instance.CallMethod<bool>("containsKey", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<String> getKeys()
		{
			return Instance.CallMethod<Enumeration<String>>("getKeys", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String getString(String arg0)
		{
			return Instance.CallMethod<String>("getString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()V")]
		public static void clearCache()
		{
			Static.CallMethod(typeof(ResourceBundle), "clearCache", "()V");
		}
		
		[JavaSignature("(Ljava/lang/ClassLoader;)V")]
		public static void clearCache(ClassLoader arg0)
		{
			Static.CallMethod(typeof(ResourceBundle), "clearCache", "(Ljava/lang/ClassLoader;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getBaseBundleName()
		{
			return Instance.CallMethod<String>("getBaseBundleName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;")]
		public static ResourceBundle getBundle(String arg0, Locale arg1)
		{
			return Static.CallMethod<ResourceBundle>(typeof(ResourceBundle), "getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/ResourceBundle/Control;)Ljava/util/ResourceBundle;")]
		public static ResourceBundle getBundle(String arg0, ResourceBundle_.Control arg1)
		{
			return Static.CallMethod<ResourceBundle>(typeof(ResourceBundle), "getBundle", "(Ljava/lang/String;Ljava/util/ResourceBundle/Control;)Ljava/util/ResourceBundle;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;Ljava/util/ResourceBundle/Control;)Ljava/util/ResourceBundle;")]
		public static ResourceBundle getBundle(String arg0, Locale arg1, ResourceBundle_.Control arg2)
		{
			return Static.CallMethod<ResourceBundle>(typeof(ResourceBundle), "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/util/ResourceBundle/Control;)Ljava/util/ResourceBundle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;Ljava/util/ResourceBundle/Control;)Ljava/util/ResourceBundle;")]
		public static ResourceBundle getBundle(String arg0, Locale arg1, ClassLoader arg2, ResourceBundle_.Control arg3)
		{
			return Static.CallMethod<ResourceBundle>(typeof(ResourceBundle), "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;Ljava/util/ResourceBundle/Control;)Ljava/util/ResourceBundle;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;")]
		public static ResourceBundle getBundle(String arg0, Locale arg1, ClassLoader arg2)
		{
			return Static.CallMethod<ResourceBundle>(typeof(ResourceBundle), "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/ResourceBundle;")]
		public static ResourceBundle getBundle(String arg0)
		{
			return Static.CallMethod<ResourceBundle>(typeof(ResourceBundle), "getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Locale;")]
		public Locale getLocale()
		{
			return Instance.CallMethod<Locale>("getLocale", "()Ljava/util/Locale;");
		}
		
		[JavaSignature("(Ljava/lang/String;)[Ljava/lang/String;")]
		public ObjectArray<String> getStringArray(String arg0)
		{
			return Instance.CallMethod<ObjectArray<String>>("getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
		}
	}
	
	public static partial class ResourceBundle_
	{
		[JavaProxy("java/util/ResourceBundle/Control")]
		public partial class Control : Object
		{
			protected Control(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/util/List;")]
			public static List<String> FORMAT_DEFAULT
			{
				get { return Static.GetField<List<String>>(typeof(Control), "FORMAT_DEFAULT", "Ljava/util/List;"); }
			}
			
			[JavaSignature("Ljava/util/List;")]
			public static List<String> FORMAT_CLASS
			{
				get { return Static.GetField<List<String>>(typeof(Control), "FORMAT_CLASS", "Ljava/util/List;"); }
			}
			
			[JavaSignature("Ljava/util/List;")]
			public static List<String> FORMAT_PROPERTIES
			{
				get { return Static.GetField<List<String>>(typeof(Control), "FORMAT_PROPERTIES", "Ljava/util/List;"); }
			}
			
			[JavaSignature("J")]
			public static long TTL_DONT_CACHE
			{
				get { return Static.GetField<long>(typeof(Control), "TTL_DONT_CACHE", "J"); }
			}
			
			[JavaSignature("J")]
			public static long TTL_NO_EXPIRATION_CONTROL
			{
				get { return Static.GetField<long>(typeof(Control), "TTL_NO_EXPIRATION_CONTROL", "J"); }
			}
		
			[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;")]
			public List<Locale> getCandidateLocales(String arg0, Locale arg1)
			{
				return Instance.CallMethod<List<Locale>>("getCandidateLocales", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/util/List;)Ljava/util/ResourceBundle/Control;")]
			public static ResourceBundle_.Control getControl(List<String> arg0)
			{
				return Static.CallMethod<ResourceBundle_.Control>(typeof(Control), "getControl", "(Ljava/util/List;)Ljava/util/ResourceBundle/Control;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/Locale;")]
			public Locale getFallbackLocale(String arg0, Locale arg1)
			{
				return Instance.CallMethod<Locale>("getFallbackLocale", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/Locale;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/util/List;")]
			public List<String> getFormats(String arg0)
			{
				return Instance.CallMethod<List<String>>("getFormats", "(Ljava/lang/String;)Ljava/util/List;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)J")]
			public long getTimeToLive(String arg0, Locale arg1)
			{
				return Instance.CallMethod<long>("getTimeToLive", "(Ljava/lang/String;Ljava/util/Locale;)J", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/util/ResourceBundle;J)Z")]
			public bool needsReload(String arg0, Locale arg1, String arg2, ClassLoader arg3, ResourceBundle arg4, long arg5)
			{
				return Instance.CallMethod<bool>("needsReload", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/util/ResourceBundle;J)Z", arg0, arg1, arg2, arg3, arg4, arg5);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Z)Ljava/util/ResourceBundle;")]
			public ResourceBundle newBundle(String arg0, Locale arg1, String arg2, ClassLoader arg3, bool arg4)
			{
				return Instance.CallMethod<ResourceBundle>("newBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/String;Ljava/lang/ClassLoader;Z)Ljava/util/ResourceBundle;", arg0, arg1, arg2, arg3, arg4);
			}
			
			[JavaSignature("(Ljava/util/List;)Ljava/util/ResourceBundle/Control;")]
			public static ResourceBundle_.Control getNoFallbackControl(List<String> arg0)
			{
				return Static.CallMethod<ResourceBundle_.Control>(typeof(Control), "getNoFallbackControl", "(Ljava/util/List;)Ljava/util/ResourceBundle/Control;", arg0);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;")]
			public String toBundleName(String arg0, Locale arg1)
			{
				return Instance.CallMethod<String>("toBundleName", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
			public String toResourceName(String arg0, String arg1)
			{
				return Instance.CallMethod<String>("toResourceName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
			}
		}
	}
}
