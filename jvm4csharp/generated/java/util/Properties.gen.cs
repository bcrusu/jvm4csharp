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
	[JavaProxy("java/util/Properties")]
	public class Properties : Hashtable<IJavaObject, IJavaObject>
	{
		protected Properties(ProxyCtor p) : base(p) {}
		
		public Properties() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Properties(Properties arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/Properties;)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;")]
		public IJavaObject setProperty(String arg0, String arg1)
		{
			return Instance.CallMethod<IJavaObject>("setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String getProperty(String arg0)
		{
			return Instance.CallMethod<String>("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public String getProperty(String arg0, String arg1)
		{
			return Instance.CallMethod<String>("getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/io/Reader;)V")]
		public void load(Reader arg0)
		{
			Instance.CallMethod("load", "(Ljava/io/Reader;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)V")]
		public void load(InputStream arg0)
		{
			Instance.CallMethod("load", "(Ljava/io/InputStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/PrintStream;)V")]
		public void list(PrintStream arg0)
		{
			Instance.CallMethod("list", "(Ljava/io/PrintStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/PrintWriter;)V")]
		public void list(PrintWriter arg0)
		{
			Instance.CallMethod("list", "(Ljava/io/PrintWriter;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)V")]
		public void loadFromXML(InputStream arg0)
		{
			Instance.CallMethod("loadFromXML", "(Ljava/io/InputStream;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/Enumeration;")]
		public Enumeration<IJavaObject> propertyNames()
		{
			return Instance.CallMethod<Enumeration<IJavaObject>>("propertyNames", "()Ljava/util/Enumeration;");
		}
		
		[JavaSignature("(Ljava/io/OutputStream;Ljava/lang/String;)V")]
		public void save(OutputStream arg0, String arg1)
		{
			Instance.CallMethod("save", "(Ljava/io/OutputStream;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/io/Writer;Ljava/lang/String;)V")]
		public void store(Writer arg0, String arg1)
		{
			Instance.CallMethod("store", "(Ljava/io/Writer;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/io/OutputStream;Ljava/lang/String;)V")]
		public void store(OutputStream arg0, String arg1)
		{
			Instance.CallMethod("store", "(Ljava/io/OutputStream;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/io/OutputStream;Ljava/lang/String;)V")]
		public void storeToXML(OutputStream arg0, String arg1)
		{
			Instance.CallMethod("storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V")]
		public void storeToXML(OutputStream arg0, String arg1, String arg2)
		{
			Instance.CallMethod("storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/util/Set;")]
		public Set<String> stringPropertyNames()
		{
			return Instance.CallMethod<Set<String>>("stringPropertyNames", "()Ljava/util/Set;");
		}
	}
}
