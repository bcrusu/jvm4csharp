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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/StringTokenizer")]
	public class StringTokenizer : Object, Enumeration<IJavaObject>
	{
		protected StringTokenizer(ProxyCtor p) : base(p) {}
		
		public StringTokenizer(String arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public StringTokenizer(String arg0, String arg1, bool arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/String;Z)V", arg0, arg1, arg2);
		}
		
		public StringTokenizer(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("()I")]
		public int countTokens()
		{
			return Instance.CallMethod<int>("countTokens", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool hasMoreElements()
		{
			return Instance.CallMethod<bool>("hasMoreElements", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String nextToken(String arg0)
		{
			return Instance.CallMethod<String>("nextToken", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String nextToken()
		{
			return Instance.CallMethod<String>("nextToken", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject nextElement()
		{
			return Instance.CallMethod<IJavaObject>("nextElement", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Z")]
		public bool hasMoreTokens()
		{
			return Instance.CallMethod<bool>("hasMoreTokens", "()Z");
		}
	}
}
