//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Short")]
	public partial class Short : Number, Comparable<Short>
	{
		protected Short(ProxyCtor p) : base(p) {}
		
		public Short(short arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(S)V", arg0);
		}
		
		public Short(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("S")]
		public static short MIN_VALUE
		{
			get { return Static.GetField<short>(typeof(Short), "MIN_VALUE", "S"); }
		}
		
		[JavaSignature("S")]
		public static short MAX_VALUE
		{
			get { return Static.GetField<short>(typeof(Short), "MAX_VALUE", "S"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Short> TYPE
		{
			get { return Static.GetField<Class<Short>>(typeof(Short), "TYPE", "Ljava/lang/Class;"); }
		}
		
		[JavaSignature("I")]
		public static int SIZE
		{
			get { return Static.GetField<int>(typeof(Short), "SIZE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BYTES
		{
			get { return Static.GetField<int>(typeof(Short), "BYTES", "I"); }
		}
	
		[JavaSignature("(S)Ljava/lang/String;")]
		public static String toString(short arg0)
		{
			return Static.CallMethod<String>(typeof(Short), "toString", "(S)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(S)I")]
		public static int hashCode(short arg0)
		{
			return Static.CallMethod<int>(typeof(Short), "hashCode", "(S)I", arg0);
		}
		
		[JavaSignature("(S)S")]
		public static short reverseBytes(short arg0)
		{
			return Static.CallMethod<short>(typeof(Short), "reverseBytes", "(S)S", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Short;)I")]
		public int compareTo(Short arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Short;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/Short;")]
		public static Short valueOf(String arg0, int arg1)
		{
			return Static.CallMethod<Short>(typeof(Short), "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;", arg0, arg1);
		}
		
		[JavaSignature("(S)Ljava/lang/Short;")]
		public static Short valueOf(short arg0)
		{
			return Static.CallMethod<Short>(typeof(Short), "valueOf", "(S)Ljava/lang/Short;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Short;")]
		public static Short valueOf(String arg0)
		{
			return Static.CallMethod<Short>(typeof(Short), "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;", arg0);
		}
		
		[JavaSignature("(SS)I")]
		public static int compare(short arg0, short arg1)
		{
			return Static.CallMethod<int>(typeof(Short), "compare", "(SS)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Short;")]
		public static Short decode(String arg0)
		{
			return Static.CallMethod<Short>(typeof(Short), "decode", "(Ljava/lang/String;)Ljava/lang/Short;", arg0);
		}
		
		[JavaSignature("(S)I")]
		public static int toUnsignedInt(short arg0)
		{
			return Static.CallMethod<int>(typeof(Short), "toUnsignedInt", "(S)I", arg0);
		}
		
		[JavaSignature("(S)J")]
		public static long toUnsignedLong(short arg0)
		{
			return Static.CallMethod<long>(typeof(Short), "toUnsignedLong", "(S)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)S")]
		public static short parseShort(String arg0)
		{
			return Static.CallMethod<short>(typeof(Short), "parseShort", "(Ljava/lang/String;)S", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)S")]
		public static short parseShort(String arg0, int arg1)
		{
			return Static.CallMethod<short>(typeof(Short), "parseShort", "(Ljava/lang/String;I)S", arg0, arg1);
		}
	}
}
