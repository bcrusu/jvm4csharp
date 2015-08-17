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
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/HttpURLConnection")]
	public abstract class HttpURLConnection : URLConnection
	{
		protected HttpURLConnection(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int HTTP_OK
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_OK", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_CREATED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_CREATED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_ACCEPTED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_ACCEPTED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_NOT_AUTHORITATIVE
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_NOT_AUTHORITATIVE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_NO_CONTENT
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_NO_CONTENT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_RESET
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_RESET", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_PARTIAL
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_PARTIAL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_MULT_CHOICE
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_MULT_CHOICE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_MOVED_PERM
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_MOVED_PERM", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_MOVED_TEMP
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_MOVED_TEMP", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_SEE_OTHER
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_SEE_OTHER", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_NOT_MODIFIED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_NOT_MODIFIED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_USE_PROXY
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_USE_PROXY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_BAD_REQUEST
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_BAD_REQUEST", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_UNAUTHORIZED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_UNAUTHORIZED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_PAYMENT_REQUIRED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_PAYMENT_REQUIRED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_FORBIDDEN
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_FORBIDDEN", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_NOT_FOUND
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_NOT_FOUND", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_BAD_METHOD
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_BAD_METHOD", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_NOT_ACCEPTABLE
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_NOT_ACCEPTABLE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_PROXY_AUTH
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_PROXY_AUTH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_CLIENT_TIMEOUT
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_CLIENT_TIMEOUT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_CONFLICT
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_CONFLICT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_GONE
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_GONE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_LENGTH_REQUIRED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_LENGTH_REQUIRED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_PRECON_FAILED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_PRECON_FAILED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_ENTITY_TOO_LARGE
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_ENTITY_TOO_LARGE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_REQ_TOO_LONG
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_REQ_TOO_LONG", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_UNSUPPORTED_TYPE
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_UNSUPPORTED_TYPE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_SERVER_ERROR
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_SERVER_ERROR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_INTERNAL_ERROR
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_INTERNAL_ERROR", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_NOT_IMPLEMENTED
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_NOT_IMPLEMENTED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_BAD_GATEWAY
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_BAD_GATEWAY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_UNAVAILABLE
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_UNAVAILABLE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_GATEWAY_TIMEOUT
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_GATEWAY_TIMEOUT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HTTP_VERSION
		{
			get { return Static.GetField<int>(typeof(HttpURLConnection), "HTTP_VERSION", "I"); }
		}
	
		[JavaSignature("()I")]
		public int getResponseCode()
		{
			return Instance.CallMethod<int>("getResponseCode", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setRequestMethod(String arg0)
		{
			Instance.CallMethod("setRequestMethod", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void disconnect()
		{
			Instance.CallMethod("disconnect", "()V");
		}
		
		[JavaSignature("()Ljava/io/InputStream;")]
		public InputStream getErrorStream()
		{
			return Instance.CallMethod<InputStream>("getErrorStream", "()Ljava/io/InputStream;");
		}
		
		[JavaSignature("()Z")]
		public static bool getFollowRedirects()
		{
			return Static.CallMethod<bool>(typeof(HttpURLConnection), "getFollowRedirects", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool getInstanceFollowRedirects()
		{
			return Instance.CallMethod<bool>("getInstanceFollowRedirects", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getRequestMethod()
		{
			return Instance.CallMethod<String>("getRequestMethod", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getResponseMessage()
		{
			return Instance.CallMethod<String>("getResponseMessage", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(I)V")]
		public void setChunkedStreamingMode(int arg0)
		{
			Instance.CallMethod("setChunkedStreamingMode", "(I)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void setFixedLengthStreamingMode(long arg0)
		{
			Instance.CallMethod("setFixedLengthStreamingMode", "(J)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setFixedLengthStreamingMode(int arg0)
		{
			Instance.CallMethod("setFixedLengthStreamingMode", "(I)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public static void setFollowRedirects(bool arg0)
		{
			Static.CallMethod(typeof(HttpURLConnection), "setFollowRedirects", "(Z)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setInstanceFollowRedirects(bool arg0)
		{
			Instance.CallMethod("setInstanceFollowRedirects", "(Z)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool usingProxy()
		{
			return Instance.CallMethod<bool>("usingProxy", "()Z");
		}
	}
}
