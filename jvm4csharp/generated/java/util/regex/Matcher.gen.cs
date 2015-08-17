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
namespace jvm4csharp.java.util.regex
{
	[JavaProxy("java/util/regex/Matcher")]
	public class Matcher : Object, MatchResult
	{
		protected Matcher(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String @group(String arg0)
		{
			return Instance.CallMethod<String>("group", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String @group()
		{
			return Instance.CallMethod<String>("group", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public String @group(int arg0)
		{
			return Instance.CallMethod<String>("group", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool matches()
		{
			return Instance.CallMethod<bool>("matches", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public static String quoteReplacement(String arg0)
		{
			return Static.CallMethod<String>(typeof(Matcher), "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String replaceAll(String arg0)
		{
			return Instance.CallMethod<String>("replaceAll", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String replaceFirst(String arg0)
		{
			return Instance.CallMethod<String>("replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool find()
		{
			return Instance.CallMethod<bool>("find", "()Z");
		}
		
		[JavaSignature("(I)Z")]
		public bool find(int arg0)
		{
			return Instance.CallMethod<bool>("find", "(I)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)I")]
		public int start(String arg0)
		{
			return Instance.CallMethod<int>("start", "(Ljava/lang/String;)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int start()
		{
			return Instance.CallMethod<int>("start", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int start(int arg0)
		{
			return Instance.CallMethod<int>("start", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;")]
		public Matcher reset(CharSequence arg0)
		{
			return Instance.CallMethod<Matcher>("reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", arg0);
		}
		
		[JavaSignature("()Ljava/util/regex/Matcher;")]
		public Matcher reset()
		{
			return Instance.CallMethod<Matcher>("reset", "()Ljava/util/regex/Matcher;");
		}
		
		[JavaSignature("(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;")]
		public Matcher appendReplacement(StringBuffer arg0, String arg1)
		{
			return Instance.CallMethod<Matcher>("appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;")]
		public StringBuffer appendTail(StringBuffer arg0)
		{
			return Instance.CallMethod<StringBuffer>("appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(II)Ljava/util/regex/Matcher;")]
		public Matcher region(int arg0, int arg1)
		{
			return Instance.CallMethod<Matcher>("region", "(II)Ljava/util/regex/Matcher;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/regex/Pattern;")]
		public Pattern pattern()
		{
			return Instance.CallMethod<Pattern>("pattern", "()Ljava/util/regex/Pattern;");
		}
		
		[JavaSignature("()Z")]
		public bool hitEnd()
		{
			return Instance.CallMethod<bool>("hitEnd", "()Z");
		}
		
		[JavaSignature("()I")]
		public int groupCount()
		{
			return Instance.CallMethod<int>("groupCount", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool hasAnchoringBounds()
		{
			return Instance.CallMethod<bool>("hasAnchoringBounds", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasTransparentBounds()
		{
			return Instance.CallMethod<bool>("hasTransparentBounds", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool lookingAt()
		{
			return Instance.CallMethod<bool>("lookingAt", "()Z");
		}
		
		[JavaSignature("()I")]
		public int regionEnd()
		{
			return Instance.CallMethod<int>("regionEnd", "()I");
		}
		
		[JavaSignature("()I")]
		public int regionStart()
		{
			return Instance.CallMethod<int>("regionStart", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool requireEnd()
		{
			return Instance.CallMethod<bool>("requireEnd", "()Z");
		}
		
		[JavaSignature("()Ljava/util/regex/MatchResult;")]
		public MatchResult toMatchResult()
		{
			return Instance.CallMethod<MatchResult>("toMatchResult", "()Ljava/util/regex/MatchResult;");
		}
		
		[JavaSignature("(Z)Ljava/util/regex/Matcher;")]
		public Matcher useAnchoringBounds(bool arg0)
		{
			return Instance.CallMethod<Matcher>("useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;", arg0);
		}
		
		[JavaSignature("(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;")]
		public Matcher usePattern(Pattern arg0)
		{
			return Instance.CallMethod<Matcher>("usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;", arg0);
		}
		
		[JavaSignature("(Z)Ljava/util/regex/Matcher;")]
		public Matcher useTransparentBounds(bool arg0)
		{
			return Instance.CallMethod<Matcher>("useTransparentBounds", "(Z)Ljava/util/regex/Matcher;", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int end(int arg0)
		{
			return Instance.CallMethod<int>("end", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int end()
		{
			return Instance.CallMethod<int>("end", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;)I")]
		public int end(String arg0)
		{
			return Instance.CallMethod<int>("end", "(Ljava/lang/String;)I", arg0);
		}
	}
}
