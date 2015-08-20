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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Boolean")]
	public partial class Boolean : Object, Serializable, Comparable<Boolean>
	{
		protected Boolean(ProxyCtor p) : base(p) {}
		
		public Boolean(bool arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Z)V", arg0);
		}
		
		public Boolean(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("Ljava/lang/Boolean;")]
		public static Boolean TRUE
		{
			get { return Static.GetField<Boolean>(typeof(Boolean), "TRUE", "Ljava/lang/Boolean;"); }
		}
		
		[JavaSignature("Ljava/lang/Boolean;")]
		public static Boolean FALSE
		{
			get { return Static.GetField<Boolean>(typeof(Boolean), "FALSE", "Ljava/lang/Boolean;"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Boolean> TYPE
		{
			get { return Static.GetField<Class<Boolean>>(typeof(Boolean), "TYPE", "Ljava/lang/Class;"); }
		}
	
		[JavaSignature("(Z)Ljava/lang/String;")]
		public static String toString(bool arg0)
		{
			return Static.CallMethod<String>(typeof(Boolean), "toString", "(Z)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Z)I")]
		public static int hashCode(bool arg0)
		{
			return Static.CallMethod<int>(typeof(Boolean), "hashCode", "(Z)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Boolean;)I")]
		public int compareTo(Boolean arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Boolean;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public static bool getBoolean(String arg0)
		{
			return Static.CallMethod<bool>(typeof(Boolean), "getBoolean", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool booleanValue()
		{
			return Instance.CallMethod<bool>("booleanValue", "()Z");
		}
		
		[JavaSignature("(Z)Ljava/lang/Boolean;")]
		public static Boolean valueOf(bool arg0)
		{
			return Static.CallMethod<Boolean>(typeof(Boolean), "valueOf", "(Z)Ljava/lang/Boolean;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Boolean;")]
		public static Boolean valueOf(String arg0)
		{
			return Static.CallMethod<Boolean>(typeof(Boolean), "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;", arg0);
		}
		
		[JavaSignature("(ZZ)I")]
		public static int compare(bool arg0, bool arg1)
		{
			return Static.CallMethod<int>(typeof(Boolean), "compare", "(ZZ)I", arg0, arg1);
		}
		
		[JavaSignature("(ZZ)Z")]
		public static bool logicalAnd(bool arg0, bool arg1)
		{
			return Static.CallMethod<bool>(typeof(Boolean), "logicalAnd", "(ZZ)Z", arg0, arg1);
		}
		
		[JavaSignature("(ZZ)Z")]
		public static bool logicalOr(bool arg0, bool arg1)
		{
			return Static.CallMethod<bool>(typeof(Boolean), "logicalOr", "(ZZ)Z", arg0, arg1);
		}
		
		[JavaSignature("(ZZ)Z")]
		public static bool logicalXor(bool arg0, bool arg1)
		{
			return Static.CallMethod<bool>(typeof(Boolean), "logicalXor", "(ZZ)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public static bool parseBoolean(String arg0)
		{
			return Static.CallMethod<bool>(typeof(Boolean), "parseBoolean", "(Ljava/lang/String;)Z", arg0);
		}
	}
}
