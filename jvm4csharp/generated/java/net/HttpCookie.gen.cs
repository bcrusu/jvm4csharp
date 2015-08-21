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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/HttpCookie")]
	public partial class HttpCookie : Object, Cloneable
	{
		protected HttpCookie(ProxyCtor p) : base(p) {}
		
		public HttpCookie(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getValue()
		{
			return Instance.CallMethod<String>("getValue", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setValue(String arg0)
		{
			Instance.CallMethod("setValue", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPath()
		{
			return Instance.CallMethod<String>("getPath", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/List;")]
		public static List<HttpCookie> parse(String arg0)
		{
			return Static.CallMethod<List<HttpCookie>>(typeof(HttpCookie), "parse", "(Ljava/lang/String;)Ljava/util/List;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getComment()
		{
			return Instance.CallMethod<String>("getComment", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setComment(String arg0)
		{
			Instance.CallMethod("setComment", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int getVersion()
		{
			return Instance.CallMethod<int>("getVersion", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getCommentURL()
		{
			return Instance.CallMethod<String>("getCommentURL", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool getDiscard()
		{
			return Instance.CallMethod<bool>("getDiscard", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPortlist()
		{
			return Instance.CallMethod<String>("getPortlist", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isHttpOnly()
		{
			return Instance.CallMethod<bool>("isHttpOnly", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setCommentURL(String arg0)
		{
			Instance.CallMethod("setCommentURL", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setDiscard(bool arg0)
		{
			Instance.CallMethod("setDiscard", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setDomain(String arg0)
		{
			Instance.CallMethod("setDomain", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setHttpOnly(bool arg0)
		{
			Instance.CallMethod("setHttpOnly", "(Z)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setMaxAge(long arg0)
		{
			Instance.CallMethod("setMaxAge", "(J)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setPath(String arg0)
		{
			Instance.CallMethod("setPath", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setPortlist(String arg0)
		{
			Instance.CallMethod("setPortlist", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setSecure(bool arg0)
		{
			Instance.CallMethod("setSecure", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setVersion(int arg0)
		{
			Instance.CallMethod("setVersion", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Z")]
		public static bool domainMatches(String arg0, String arg1)
		{
			return Static.CallMethod<bool>(typeof(HttpCookie), "domainMatches", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDomain()
		{
			return Instance.CallMethod<String>("getDomain", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()J")]
		public long getMaxAge()
		{
			return Instance.CallMethod<long>("getMaxAge", "()J");
		}
		
		[JavaSignature("()Z")]
		public bool getSecure()
		{
			return Instance.CallMethod<bool>("getSecure", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasExpired()
		{
			return Instance.CallMethod<bool>("hasExpired", "()Z");
		}
	}
}
