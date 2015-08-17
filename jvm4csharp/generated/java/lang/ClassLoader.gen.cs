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
using jvm4csharp.java.net;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/ClassLoader")]
	public abstract class ClassLoader : Object
	{
		protected ClassLoader(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Class;")]
		public Class<IJavaObject> loadClass(String arg0)
		{
			return Instance.CallMethod<Class<IJavaObject>>("loadClass", "(Ljava/lang/String;)Ljava/lang/Class;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/ClassLoader;")]
		public static ClassLoader getSystemClassLoader()
		{
			return Static.CallMethod<ClassLoader>(typeof(ClassLoader), "getSystemClassLoader", "()Ljava/lang/ClassLoader;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/net/URL;")]
		public URL getResource(String arg0)
		{
			return Instance.CallMethod<URL>("getResource", "(Ljava/lang/String;)Ljava/net/URL;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/io/InputStream;")]
		public InputStream getResourceAsStream(String arg0)
		{
			return Instance.CallMethod<InputStream>("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/net/URL;")]
		public static URL getSystemResource(String arg0)
		{
			return Static.CallMethod<URL>(typeof(ClassLoader), "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/io/InputStream;")]
		public static InputStream getSystemResourceAsStream(String arg0)
		{
			return Static.CallMethod<InputStream>(typeof(ClassLoader), "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", arg0);
		}
		
		[JavaSignature("()V")]
		public void clearAssertionStatus()
		{
			Instance.CallMethod("clearAssertionStatus", "()V");
		}
		
		[JavaSignature("()Ljava/lang/ClassLoader;")]
		public ClassLoader getParent()
		{
			return Instance.CallMethod<ClassLoader>("getParent", "()Ljava/lang/ClassLoader;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Enumeration;")]
		public Enumeration<URL> getResources(String arg0)
		{
			return Instance.CallMethod<Enumeration<URL>>("getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Enumeration;")]
		public static Enumeration<URL> getSystemResources(String arg0)
		{
			return Static.CallMethod<Enumeration<URL>>(typeof(ClassLoader), "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Z)V")]
		public void setClassAssertionStatus(String arg0, bool arg1)
		{
			Instance.CallMethod("setClassAssertionStatus", "(Ljava/lang/String;Z)V", arg0, arg1);
		}
		
		[JavaSignature("(Z)V")]
		public void setDefaultAssertionStatus(bool arg0)
		{
			Instance.CallMethod("setDefaultAssertionStatus", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Z)V")]
		public void setPackageAssertionStatus(String arg0, bool arg1)
		{
			Instance.CallMethod("setPackageAssertionStatus", "(Ljava/lang/String;Z)V", arg0, arg1);
		}
	}
}
