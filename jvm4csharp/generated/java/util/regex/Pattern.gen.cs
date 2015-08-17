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
using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.regex
{
	[JavaProxy("java/util/regex/Pattern")]
	public class Pattern : Object, Serializable
	{
		protected Pattern(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int UNIX_LINES
		{
			get { return Static.GetField<int>(typeof(Pattern), "UNIX_LINES", "I"); }
		}
		
		[JavaSignature("I")]
		public static int CASE_INSENSITIVE
		{
			get { return Static.GetField<int>(typeof(Pattern), "CASE_INSENSITIVE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int COMMENTS
		{
			get { return Static.GetField<int>(typeof(Pattern), "COMMENTS", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MULTILINE
		{
			get { return Static.GetField<int>(typeof(Pattern), "MULTILINE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int LITERAL
		{
			get { return Static.GetField<int>(typeof(Pattern), "LITERAL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DOTALL
		{
			get { return Static.GetField<int>(typeof(Pattern), "DOTALL", "I"); }
		}
		
		[JavaSignature("I")]
		public static int UNICODE_CASE
		{
			get { return Static.GetField<int>(typeof(Pattern), "UNICODE_CASE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int CANON_EQ
		{
			get { return Static.GetField<int>(typeof(Pattern), "CANON_EQ", "I"); }
		}
		
		[JavaSignature("I")]
		public static int UNICODE_CHARACTER_CLASS
		{
			get { return Static.GetField<int>(typeof(Pattern), "UNICODE_CHARACTER_CLASS", "I"); }
		}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String quote(String arg0)
		{
			return Static.CallMethod<String>(typeof(Pattern), "quote", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()I")]
		public int flags()
		{
			return Instance.CallMethod<int>("flags", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/regex/Pattern;")]
		public static Pattern compile(String arg0)
		{
			return Static.CallMethod<Pattern>(typeof(Pattern), "compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/util/regex/Pattern;")]
		public static Pattern compile(String arg0, int arg1)
		{
			return Static.CallMethod<Pattern>(typeof(Pattern), "compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;")]
		public Matcher matcher(CharSequence arg0)
		{
			return Instance.CallMethod<Matcher>("matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/CharSequence;)Z")]
		public static bool matches(String arg0, CharSequence arg1)
		{
			return Static.CallMethod<bool>(typeof(Pattern), "matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)[Ljava/lang/String;")]
		public ObjectArray<String> split(CharSequence arg0)
		{
			return Instance.CallMethod<ObjectArray<String>>("split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;I)[Ljava/lang/String;")]
		public ObjectArray<String> split(CharSequence arg0, int arg1)
		{
			return Instance.CallMethod<ObjectArray<String>>("split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/function/Predicate;")]
		public Predicate<String> asPredicate()
		{
			return Instance.CallMethod<Predicate<String>>("asPredicate", "()Ljava/util/function/Predicate;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String pattern()
		{
			return Instance.CallMethod<String>("pattern", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/util/stream/Stream;")]
		public Stream<String> splitAsStream(CharSequence arg0)
		{
			return Instance.CallMethod<Stream<String>>("splitAsStream", "(Ljava/lang/CharSequence;)Ljava/util/stream/Stream;", arg0);
		}
	}
}
