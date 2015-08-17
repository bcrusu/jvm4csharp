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
	[JavaProxy("java/lang/Byte")]
	public class Byte : Number, Comparable<Byte>
	{
		protected Byte(ProxyCtor p) : base(p) {}
		
		public Byte(byte arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(B)V", arg0);
		}
		
		public Byte(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("B")]
		public static byte MIN_VALUE
		{
			get { return Static.GetField<byte>(typeof(Byte), "MIN_VALUE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte MAX_VALUE
		{
			get { return Static.GetField<byte>(typeof(Byte), "MAX_VALUE", "B"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Byte> TYPE
		{
			get { return Static.GetField<Class<Byte>>(typeof(Byte), "TYPE", "Ljava/lang/Class;"); }
		}
		
		[JavaSignature("I")]
		public static int SIZE
		{
			get { return Static.GetField<int>(typeof(Byte), "SIZE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BYTES
		{
			get { return Static.GetField<int>(typeof(Byte), "BYTES", "I"); }
		}
	
		[JavaSignature("(B)Ljava/lang/String;")]
		public static String toString(byte arg0)
		{
			return Static.CallMethod<String>(typeof(Byte), "toString", "(B)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(B)I")]
		public static int hashCode(byte arg0)
		{
			return Static.CallMethod<int>(typeof(Byte), "hashCode", "(B)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Byte;)I")]
		public int compareTo(Byte arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Byte;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Byte;")]
		public static Byte valueOf(String arg0)
		{
			return Static.CallMethod<Byte>(typeof(Byte), "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;", arg0);
		}
		
		[JavaSignature("(B)Ljava/lang/Byte;")]
		public static Byte valueOf(byte arg0)
		{
			return Static.CallMethod<Byte>(typeof(Byte), "valueOf", "(B)Ljava/lang/Byte;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/Byte;")]
		public static Byte valueOf(String arg0, int arg1)
		{
			return Static.CallMethod<Byte>(typeof(Byte), "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;", arg0, arg1);
		}
		
		[JavaSignature("(BB)I")]
		public static int compare(byte arg0, byte arg1)
		{
			return Static.CallMethod<int>(typeof(Byte), "compare", "(BB)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Byte;")]
		public static Byte decode(String arg0)
		{
			return Static.CallMethod<Byte>(typeof(Byte), "decode", "(Ljava/lang/String;)Ljava/lang/Byte;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)B")]
		public static byte parseByte(String arg0)
		{
			return Static.CallMethod<byte>(typeof(Byte), "parseByte", "(Ljava/lang/String;)B", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)B")]
		public static byte parseByte(String arg0, int arg1)
		{
			return Static.CallMethod<byte>(typeof(Byte), "parseByte", "(Ljava/lang/String;I)B", arg0, arg1);
		}
		
		[JavaSignature("(B)I")]
		public static int toUnsignedInt(byte arg0)
		{
			return Static.CallMethod<int>(typeof(Byte), "toUnsignedInt", "(B)I", arg0);
		}
		
		[JavaSignature("(B)J")]
		public static long toUnsignedLong(byte arg0)
		{
			return Static.CallMethod<long>(typeof(Byte), "toUnsignedLong", "(B)J", arg0);
		}
	}
}
