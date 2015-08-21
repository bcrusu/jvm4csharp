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
namespace jvm4csharp.java.net
{
	[JavaProxy("java/net/Authenticator")]
	public abstract partial class Authenticator : Object
	{
		protected Authenticator(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/net/Authenticator;)V")]
		public static void setDefault(Authenticator arg0)
		{
			Static.CallMethod(typeof(Authenticator), "setDefault", "(Ljava/net/Authenticator;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;")]
		public static PasswordAuthentication requestPasswordAuthentication(String arg0, InetAddress arg1, int arg2, String arg3, String arg4, String arg5)
		{
			return Static.CallMethod<PasswordAuthentication>(typeof(Authenticator), "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/net/Authenticator/RequestorType;)Ljava/net/PasswordAuthentication;")]
		public static PasswordAuthentication requestPasswordAuthentication(String arg0, InetAddress arg1, int arg2, String arg3, String arg4, String arg5, URL arg6, Authenticator_.RequestorType arg7)
		{
			return Static.CallMethod<PasswordAuthentication>(typeof(Authenticator), "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/net/Authenticator/RequestorType;)Ljava/net/PasswordAuthentication;", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}
		
		[JavaSignature("(Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;")]
		public static PasswordAuthentication requestPasswordAuthentication(InetAddress arg0, int arg1, String arg2, String arg3, String arg4)
		{
			return Static.CallMethod<PasswordAuthentication>(typeof(Authenticator), "requestPasswordAuthentication", "(Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;", arg0, arg1, arg2, arg3, arg4);
		}
	}
	
	public static partial class Authenticator_
	{
		[JavaProxy("java/net/Authenticator/RequestorType")]
		public partial class RequestorType : Enum<Authenticator_.RequestorType>
		{
			protected RequestorType(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/net/Authenticator/RequestorType;")]
			public static Authenticator_.RequestorType PROXY
			{
				get { return Static.GetField<Authenticator_.RequestorType>(typeof(RequestorType), "PROXY", "Ljava/net/Authenticator/RequestorType;"); }
			}
			
			[JavaSignature("Ljava/net/Authenticator/RequestorType;")]
			public static Authenticator_.RequestorType SERVER
			{
				get { return Static.GetField<Authenticator_.RequestorType>(typeof(RequestorType), "SERVER", "Ljava/net/Authenticator/RequestorType;"); }
			}
		
			[JavaSignature("()[Ljava/net/Authenticator/RequestorType;")]
			public static ObjectArray<Authenticator_.RequestorType> values()
			{
				return Static.CallMethod<ObjectArray<Authenticator_.RequestorType>>(typeof(RequestorType), "values", "()[Ljava/net/Authenticator/RequestorType;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/net/Authenticator/RequestorType;")]
			public static Authenticator_.RequestorType valueOf(String arg0)
			{
				return Static.CallMethod<Authenticator_.RequestorType>(typeof(RequestorType), "valueOf", "(Ljava/lang/String;)Ljava/net/Authenticator/RequestorType;", arg0);
			}
		}
	}
}
