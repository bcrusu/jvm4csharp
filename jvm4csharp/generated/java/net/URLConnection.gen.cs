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
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/URLConnection")]
	public abstract class URLConnection : Object
	{
		protected URLConnection(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/net/URL;")]
		public URL getURL()
		{
			return Instance.CallMethod<URL>("getURL", "()Ljava/net/URL;");
		}
		
		[JavaSignature("()V")]
		public void connect()
		{
			Instance.CallMethod("connect", "()V");
		}
		
		[JavaSignature("()Ljava/io/InputStream;")]
		public InputStream getInputStream()
		{
			return Instance.CallMethod<InputStream>("getInputStream", "()Ljava/io/InputStream;");
		}
		
		[JavaSignature("([Ljava/lang/Class;)Ljava/lang/Object;")]
		public IJavaObject getContent(ObjectArray<Class<IJavaObject>> arg0)
		{
			return Instance.CallMethod<IJavaObject>("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject getContent()
		{
			return Instance.CallMethod<IJavaObject>("getContent", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()I")]
		public int getContentLength()
		{
			return Instance.CallMethod<int>("getContentLength", "()I");
		}
		
		[JavaSignature("()J")]
		public long getContentLengthLong()
		{
			return Instance.CallMethod<long>("getContentLengthLong", "()J");
		}
		
		[JavaSignature("()Ljava/net/FileNameMap;")]
		public static FileNameMap getFileNameMap()
		{
			return Static.CallMethod<FileNameMap>(typeof(URLConnection), "getFileNameMap", "()Ljava/net/FileNameMap;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String getHeaderField(String arg0)
		{
			return Instance.CallMethod<String>("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public String getHeaderField(int arg0)
		{
			return Instance.CallMethod<String>("getHeaderField", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public String getHeaderFieldKey(int arg0)
		{
			return Instance.CallMethod<String>("getHeaderFieldKey", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()J")]
		public long getLastModified()
		{
			return Instance.CallMethod<long>("getLastModified", "()J");
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)V")]
		public void addRequestProperty(String arg0, String arg1)
		{
			Instance.CallMethod("addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getContentType()
		{
			return Instance.CallMethod<String>("getContentType", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/Map;")]
		public Map<String, List<String>> getRequestProperties()
		{
			return Instance.CallMethod<Map<String, List<String>>>("getRequestProperties", "()Ljava/util/Map;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String getRequestProperty(String arg0)
		{
			return Instance.CallMethod<String>("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String guessContentTypeFromName(String arg0)
		{
			return Static.CallMethod<String>(typeof(URLConnection), "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)Ljava/lang/String;")]
		public static String guessContentTypeFromStream(InputStream arg0)
		{
			return Static.CallMethod<String>(typeof(URLConnection), "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool getAllowUserInteraction()
		{
			return Instance.CallMethod<bool>("getAllowUserInteraction", "()Z");
		}
		
		[JavaSignature("()I")]
		public int getConnectTimeout()
		{
			return Instance.CallMethod<int>("getConnectTimeout", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getContentEncoding()
		{
			return Instance.CallMethod<String>("getContentEncoding", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public static bool getDefaultAllowUserInteraction()
		{
			return Static.CallMethod<bool>(typeof(URLConnection), "getDefaultAllowUserInteraction", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String getDefaultRequestProperty(String arg0)
		{
			return Static.CallMethod<String>(typeof(URLConnection), "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool getDefaultUseCaches()
		{
			return Instance.CallMethod<bool>("getDefaultUseCaches", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool getDoInput()
		{
			return Instance.CallMethod<bool>("getDoInput", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool getDoOutput()
		{
			return Instance.CallMethod<bool>("getDoOutput", "()Z");
		}
		
		[JavaSignature("()J")]
		public long getExpiration()
		{
			return Instance.CallMethod<long>("getExpiration", "()J");
		}
		
		[JavaSignature("(Ljava/lang/String;J)J")]
		public long getHeaderFieldDate(String arg0, long arg1)
		{
			return Instance.CallMethod<long>("getHeaderFieldDate", "(Ljava/lang/String;J)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;I)I")]
		public int getHeaderFieldInt(String arg0, int arg1)
		{
			return Instance.CallMethod<int>("getHeaderFieldInt", "(Ljava/lang/String;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;J)J")]
		public long getHeaderFieldLong(String arg0, long arg1)
		{
			return Instance.CallMethod<long>("getHeaderFieldLong", "(Ljava/lang/String;J)J", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/Map;")]
		public Map<String, List<String>> getHeaderFields()
		{
			return Instance.CallMethod<Map<String, List<String>>>("getHeaderFields", "()Ljava/util/Map;");
		}
		
		[JavaSignature("()J")]
		public long getIfModifiedSince()
		{
			return Instance.CallMethod<long>("getIfModifiedSince", "()J");
		}
		
		[JavaSignature("()Ljava/io/OutputStream;")]
		public OutputStream getOutputStream()
		{
			return Instance.CallMethod<OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
		}
		
		[JavaSignature("()I")]
		public int getReadTimeout()
		{
			return Instance.CallMethod<int>("getReadTimeout", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool getUseCaches()
		{
			return Instance.CallMethod<bool>("getUseCaches", "()Z");
		}
		
		[JavaSignature("(Z)V")]
		public void setAllowUserInteraction(bool arg0)
		{
			Instance.CallMethod("setAllowUserInteraction", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setConnectTimeout(int arg0)
		{
			Instance.CallMethod("setConnectTimeout", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/ContentHandlerFactory;)V")]
		public static void setContentHandlerFactory(ContentHandlerFactory arg0)
		{
			Static.CallMethod(typeof(URLConnection), "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public static void setDefaultAllowUserInteraction(bool arg0)
		{
			Static.CallMethod(typeof(URLConnection), "setDefaultAllowUserInteraction", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)V")]
		public static void setDefaultRequestProperty(String arg0, String arg1)
		{
			Static.CallMethod(typeof(URLConnection), "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Z)V")]
		public void setDefaultUseCaches(bool arg0)
		{
			Instance.CallMethod("setDefaultUseCaches", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setDoInput(bool arg0)
		{
			Instance.CallMethod("setDoInput", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setDoOutput(bool arg0)
		{
			Instance.CallMethod("setDoOutput", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/net/FileNameMap;)V")]
		public static void setFileNameMap(FileNameMap arg0)
		{
			Static.CallMethod(typeof(URLConnection), "setFileNameMap", "(Ljava/net/FileNameMap;)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setIfModifiedSince(long arg0)
		{
			Instance.CallMethod("setIfModifiedSince", "(J)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setReadTimeout(int arg0)
		{
			Instance.CallMethod("setReadTimeout", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)V")]
		public void setRequestProperty(String arg0, String arg1)
		{
			Instance.CallMethod("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Z)V")]
		public void setUseCaches(bool arg0)
		{
			Instance.CallMethod("setUseCaches", "(Z)V", arg0);
		}
		
		[JavaSignature("()J")]
		public long getDate()
		{
			return Instance.CallMethod<long>("getDate", "()J");
		}
	}
}
