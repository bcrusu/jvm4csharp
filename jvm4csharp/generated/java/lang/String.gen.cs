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
using jvm4csharp.java.io;
using jvm4csharp.java.nio.charset;
using jvm4csharp.java.util;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/String")]
	public partial class String : Object, Serializable, Comparable<String>, CharSequence
	{
		public String(ByteArray arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BII)V", arg0, arg1, arg2);
		}
		
		public String(ByteArray arg0, Charset arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BLjava/nio/charset/Charset;)V", arg0, arg1);
		}
		
		public String(ByteArray arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BLjava/lang/String;)V", arg0, arg1);
		}
		
		public String(ByteArray arg0, int arg1, int arg2, Charset arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BIILjava/nio/charset/Charset;)V", arg0, arg1, arg2, arg3);
		}
		
		public String(ByteArray arg0, int arg1, int arg2, String arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BIILjava/lang/String;)V", arg0, arg1, arg2, arg3);
		}
		
		public String(StringBuilder arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/StringBuilder;)V", arg0);
		}
		
		public String(StringBuffer arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/StringBuffer;)V", arg0);
		}
		
		public String(ByteArray arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([B)V", arg0);
		}
		
		public String(IntArray arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([III)V", arg0, arg1, arg2);
		}
		
		public String() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public String(CharArray arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([C)V", arg0);
		}
		
		public String(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public String(CharArray arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([CII)V", arg0, arg1, arg2);
		}
		
		public String(ByteArray arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BI)V", arg0, arg1);
		}
		
		public String(ByteArray arg0, int arg1, int arg2, int arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([BIII)V", arg0, arg1, arg2, arg3);
		}
	
		[JavaSignature("Ljava/util/Comparator;")]
		public static Comparator<String> CASE_INSENSITIVE_ORDER
		{
			get { return Static.GetField<Comparator<String>>(typeof(String), "CASE_INSENSITIVE_ORDER", "Ljava/util/Comparator;"); }
		}
	
		[JavaSignature("(Ljava/lang/String;)I")]
		public int compareTo(String arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/String;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)I")]
		public int indexOf(String arg0, int arg1)
		{
			return Instance.CallMethod<int>("indexOf", "(Ljava/lang/String;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)I")]
		public int indexOf(String arg0)
		{
			return Instance.CallMethod<int>("indexOf", "(Ljava/lang/String;)I", arg0);
		}
		
		[JavaSignature("(II)I")]
		public int indexOf(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("indexOf", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public int indexOf(int arg0)
		{
			return Instance.CallMethod<int>("indexOf", "(I)I", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String valueOf(int arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/String;")]
		public static String valueOf(long arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "(J)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(F)Ljava/lang/String;")]
		public static String valueOf(float arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "(F)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Z)Ljava/lang/String;")]
		public static String valueOf(bool arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "(Z)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([C)Ljava/lang/String;")]
		public static String valueOf(CharArray arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "([C)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([CII)Ljava/lang/String;")]
		public static String valueOf(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "([CII)Ljava/lang/String;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/String;")]
		public static String valueOf(IJavaObject arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(C)Ljava/lang/String;")]
		public static String valueOf(char arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "(C)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(D)Ljava/lang/String;")]
		public static String valueOf(double arg0)
		{
			return Static.CallMethod<String>(typeof(String), "valueOf", "(D)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)C")]
		public char charAt(int arg0)
		{
			return Instance.CallMethod<char>("charAt", "(I)C", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int codePointAt(int arg0)
		{
			return Instance.CallMethod<int>("codePointAt", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int codePointBefore(int arg0)
		{
			return Instance.CallMethod<int>("codePointBefore", "(I)I", arg0);
		}
		
		[JavaSignature("(II)I")]
		public int codePointCount(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("codePointCount", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)I")]
		public int compareToIgnoreCase(String arg0)
		{
			return Instance.CallMethod<int>("compareToIgnoreCase", "(Ljava/lang/String;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String concat(String arg0)
		{
			return Instance.CallMethod<String>("concat", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Z")]
		public bool contains(CharSequence arg0)
		{
			return Instance.CallMethod<bool>("contains", "(Ljava/lang/CharSequence;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Z")]
		public bool contentEquals(CharSequence arg0)
		{
			return Instance.CallMethod<bool>("contentEquals", "(Ljava/lang/CharSequence;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/StringBuffer;)Z")]
		public bool contentEquals(StringBuffer arg0)
		{
			return Instance.CallMethod<bool>("contentEquals", "(Ljava/lang/StringBuffer;)Z", arg0);
		}
		
		[JavaSignature("([C)Ljava/lang/String;")]
		public static String copyValueOf(CharArray arg0)
		{
			return Static.CallMethod<String>(typeof(String), "copyValueOf", "([C)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("([CII)Ljava/lang/String;")]
		public static String copyValueOf(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<String>(typeof(String), "copyValueOf", "([CII)Ljava/lang/String;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool endsWith(String arg0)
		{
			return Instance.CallMethod<bool>("endsWith", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool equalsIgnoreCase(String arg0)
		{
			return Instance.CallMethod<bool>("equalsIgnoreCase", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;")]
		public static String format(Locale arg0, String arg1, ObjectArray<IJavaObject> arg2)
		{
			return Static.CallMethod<String>(typeof(String), "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;")]
		public static String format(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Static.CallMethod<String>(typeof(String), "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(II[BI)V")]
		public void getBytes(int arg0, int arg1, ByteArray arg2, int arg3)
		{
			Instance.CallMethod("getBytes", "(II[BI)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/nio/charset/Charset;)[B")]
		public ByteArray getBytes(Charset arg0)
		{
			return Instance.CallMethod<ByteArray>("getBytes", "(Ljava/nio/charset/Charset;)[B", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)[B")]
		public ByteArray getBytes(String arg0)
		{
			return Instance.CallMethod<ByteArray>("getBytes", "(Ljava/lang/String;)[B", arg0);
		}
		
		[JavaSignature("()[B")]
		public ByteArray getBytes()
		{
			return Instance.CallMethod<ByteArray>("getBytes", "()[B");
		}
		
		[JavaSignature("(II[CI)V")]
		public void getChars(int arg0, int arg1, CharArray arg2, int arg3)
		{
			Instance.CallMethod("getChars", "(II[CI)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String intern()
		{
			return Instance.CallMethod<String>("intern", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isEmpty()
		{
			return Instance.CallMethod<bool>("isEmpty", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;")]
		public static String @join(CharSequence arg0, ObjectArray<CharSequence> arg1)
		{
			return Static.CallMethod<String>(typeof(String), "join", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;")]
		public static String @join(CharSequence arg0, Iterable<CharSequence> arg1)
		{
			return Static.CallMethod<String>(typeof(String), "join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(I)I")]
		public int lastIndexOf(int arg0)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)I")]
		public int lastIndexOf(String arg0)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(Ljava/lang/String;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)I")]
		public int lastIndexOf(String arg0, int arg1)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(Ljava/lang/String;I)I", arg0, arg1);
		}
		
		[JavaSignature("(II)I")]
		public int lastIndexOf(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("lastIndexOf", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool matches(String arg0)
		{
			return Instance.CallMethod<bool>("matches", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("(II)I")]
		public int offsetByCodePoints(int arg0, int arg1)
		{
			return Instance.CallMethod<int>("offsetByCodePoints", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/String;II)Z")]
		public bool regionMatches(int arg0, String arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<bool>("regionMatches", "(ILjava/lang/String;II)Z", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(ZILjava/lang/String;II)Z")]
		public bool regionMatches(bool arg0, int arg1, String arg2, int arg3, int arg4)
		{
			return Instance.CallMethod<bool>("regionMatches", "(ZILjava/lang/String;II)Z", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(CC)Ljava/lang/String;")]
		public String replace(char arg0, char arg1)
		{
			return Instance.CallMethod<String>("replace", "(CC)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;")]
		public String replace(CharSequence arg0, CharSequence arg1)
		{
			return Instance.CallMethod<String>("replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public String replaceAll(String arg0, String arg1)
		{
			return Instance.CallMethod<String>("replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public String replaceFirst(String arg0, String arg1)
		{
			return Instance.CallMethod<String>("replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)[Ljava/lang/String;")]
		public ObjectArray<String> split(String arg0)
		{
			return Instance.CallMethod<ObjectArray<String>>("split", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)[Ljava/lang/String;")]
		public ObjectArray<String> split(String arg0, int arg1)
		{
			return Instance.CallMethod<ObjectArray<String>>("split", "(Ljava/lang/String;I)[Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Z")]
		public bool startsWith(String arg0, int arg1)
		{
			return Instance.CallMethod<bool>("startsWith", "(Ljava/lang/String;I)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool startsWith(String arg0)
		{
			return Instance.CallMethod<bool>("startsWith", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("(II)Ljava/lang/CharSequence;")]
		public CharSequence subSequence(int arg0, int arg1)
		{
			return Instance.CallMethod<CharSequence>("subSequence", "(II)Ljava/lang/CharSequence;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public String substring(int arg0)
		{
			return Instance.CallMethod<String>("substring", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(II)Ljava/lang/String;")]
		public String substring(int arg0, int arg1)
		{
			return Instance.CallMethod<String>("substring", "(II)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("()[C")]
		public CharArray toCharArray()
		{
			return Instance.CallMethod<CharArray>("toCharArray", "()[C");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String toLowerCase(Locale arg0)
		{
			return Instance.CallMethod<String>("toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toLowerCase()
		{
			return Instance.CallMethod<String>("toLowerCase", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toUpperCase()
		{
			return Instance.CallMethod<String>("toUpperCase", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String toUpperCase(Locale arg0)
		{
			return Instance.CallMethod<String>("toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String trim()
		{
			return Instance.CallMethod<String>("trim", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream chars()
		{
			return Instance.CallMethod<IntStream>("chars", "()Ljava/util/stream/IntStream;");
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream codePoints()
		{
			return Instance.CallMethod<IntStream>("codePoints", "()Ljava/util/stream/IntStream;");
		}
	}
}
