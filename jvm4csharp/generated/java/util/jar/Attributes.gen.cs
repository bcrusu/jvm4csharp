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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.jar
{
	[JavaProxy("java/util/jar/Attributes")]
	public partial class Attributes : Object, Map<IJavaObject, IJavaObject>, Cloneable
	{
		protected Attributes(ProxyCtor p) : base(p) {}
		
		public Attributes(Attributes arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/jar/Attributes;)V", arg0);
		}
		
		public Attributes(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public Attributes() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject @remove(IJavaObject arg0)
		{
			return Instance.CallMethod<IJavaObject>("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject @get(IJavaObject arg0)
		{
			return Instance.CallMethod<IJavaObject>("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject put(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<IJavaObject>("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Collection;")]
		public Collection<IJavaObject> values()
		{
			return Instance.CallMethod<Collection<IJavaObject>>("values", "()Ljava/util/Collection;");
		}
		
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("(Ljava/util/jar/Attributes/Name;)Ljava/lang/String;")]
		public String getValue(Attributes.Name arg0)
		{
			return Instance.CallMethod<String>("getValue", "(Ljava/util/jar/Attributes/Name;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String getValue(String arg0)
		{
			return Instance.CallMethod<String>("getValue", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isEmpty()
		{
			return Instance.CallMethod<bool>("isEmpty", "()Z");
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<Map_.Entry<IJavaObject, IJavaObject>> entrySet()
		{
			return Instance.CallMethod<Set<Map_.Entry<IJavaObject, IJavaObject>>>("entrySet", "()Ljava/util/Set;");
		}
		
		[JavaSignature("(Ljava/util/Map;)V")]
		public void putAll(Map<IJavaObject, IJavaObject> arg0)
		{
			Instance.CallMethod("putAll", "(Ljava/util/Map;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<IJavaObject> keySet()
		{
			return Instance.CallMethod<Set<IJavaObject>>("keySet", "()Ljava/util/Set;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool containsKey(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("containsKey", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool containsValue(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("containsValue", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public String putValue(String arg0, String arg1)
		{
			return Instance.CallMethod<String>("putValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool @remove(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<bool>("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject replace(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<IJavaObject>("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z")]
		public bool replace(IJavaObject arg0, IJavaObject arg1, IJavaObject arg2)
		{
			return Instance.CallMethod<bool>("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;)V")]
		public void replaceAll(BiFunction<IJavaObject, IJavaObject, IJavaObject> arg0)
		{
			Instance.CallMethod("replaceAll", "(Ljava/util/function/BiFunction;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject putIfAbsent(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<IJavaObject>("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public IJavaObject compute(IJavaObject arg0, BiFunction<IJavaObject, IJavaObject, IJavaObject> arg1)
		{
			return Instance.CallMethod<IJavaObject>("compute", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;")]
		public IJavaObject computeIfAbsent(IJavaObject arg0, Function<IJavaObject, IJavaObject> arg1)
		{
			return Instance.CallMethod<IJavaObject>("computeIfAbsent", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public IJavaObject computeIfPresent(IJavaObject arg0, BiFunction<IJavaObject, IJavaObject, IJavaObject> arg1)
		{
			return Instance.CallMethod<IJavaObject>("computeIfPresent", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)V")]
		public void forEach(BiConsumer<IJavaObject, IJavaObject> arg0)
		{
			Instance.CallMethod("forEach", "(Ljava/util/function/BiConsumer;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject getOrDefault(IJavaObject arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<IJavaObject>("getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;")]
		public IJavaObject merge(IJavaObject arg0, IJavaObject arg1, BiFunction<IJavaObject, IJavaObject, IJavaObject> arg2)
		{
			return Instance.CallMethod<IJavaObject>("merge", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
		}
	
		[JavaProxy("java/util/jar/Attributes/Name")]
		public partial class Name : Object
		{
			protected Name(ProxyCtor p) : base(p) {}
			
			public Name(String arg0) : base(ProxyCtor.I)
			{
				Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
			}
		
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name MANIFEST_VERSION
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "MANIFEST_VERSION", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name SIGNATURE_VERSION
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "SIGNATURE_VERSION", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name CONTENT_TYPE
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "CONTENT_TYPE", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name CLASS_PATH
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "CLASS_PATH", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name MAIN_CLASS
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "MAIN_CLASS", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name SEALED
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "SEALED", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name EXTENSION_LIST
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "EXTENSION_LIST", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name EXTENSION_NAME
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "EXTENSION_NAME", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name EXTENSION_INSTALLATION
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "EXTENSION_INSTALLATION", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name IMPLEMENTATION_TITLE
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "IMPLEMENTATION_TITLE", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name IMPLEMENTATION_VERSION
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "IMPLEMENTATION_VERSION", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name IMPLEMENTATION_VENDOR
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "IMPLEMENTATION_VENDOR", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name IMPLEMENTATION_VENDOR_ID
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "IMPLEMENTATION_VENDOR_ID", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name IMPLEMENTATION_URL
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "IMPLEMENTATION_URL", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name SPECIFICATION_TITLE
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "SPECIFICATION_TITLE", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name SPECIFICATION_VERSION
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "SPECIFICATION_VERSION", "Ljava/util/jar/Attributes/Name;"); }
			}
			
			[JavaSignature("Ljava/util/jar/Attributes/Name;")]
			public static Attributes.Name SPECIFICATION_VENDOR
			{
				get { return Static.GetField<Attributes.Name>(typeof(Name), "SPECIFICATION_VENDOR", "Ljava/util/jar/Attributes/Name;"); }
			}
		}
	}
}
