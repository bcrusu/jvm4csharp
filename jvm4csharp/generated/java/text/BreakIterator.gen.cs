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
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/BreakIterator")]
	public abstract partial class BreakIterator : Object, Cloneable
	{
		protected BreakIterator(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int DONE
		{
			get { return Static.GetField<int>(typeof(BreakIterator), "DONE", "I"); }
		}
	
		[JavaSignature("(I)I")]
		public int next(int arg0)
		{
			return Instance.CallMethod<int>("next", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int next()
		{
			return Instance.CallMethod<int>("next", "()I");
		}
		
		[JavaSignature("()I")]
		public int first()
		{
			return Instance.CallMethod<int>("first", "()I");
		}
		
		[JavaSignature("()I")]
		public int previous()
		{
			return Instance.CallMethod<int>("previous", "()I");
		}
		
		[JavaSignature("()[Ljava/util/Locale;")]
		public static ObjectArray<Locale> getAvailableLocales()
		{
			return Static.CallMethod<ObjectArray<Locale>>(typeof(BreakIterator), "getAvailableLocales", "()[Ljava/util/Locale;");
		}
		
		[JavaSignature("()I")]
		public int current()
		{
			return Instance.CallMethod<int>("current", "()I");
		}
		
		[JavaSignature("()I")]
		public int last()
		{
			return Instance.CallMethod<int>("last", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int following(int arg0)
		{
			return Instance.CallMethod<int>("following", "(I)I", arg0);
		}
		
		[JavaSignature("()Ljava/text/BreakIterator;")]
		public static BreakIterator getCharacterInstance()
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getCharacterInstance", "()Ljava/text/BreakIterator;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public static BreakIterator getCharacterInstance(Locale arg0)
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
		
		[JavaSignature("()Ljava/text/BreakIterator;")]
		public static BreakIterator getLineInstance()
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getLineInstance", "()Ljava/text/BreakIterator;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public static BreakIterator getLineInstance(Locale arg0)
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public static BreakIterator getSentenceInstance(Locale arg0)
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
		
		[JavaSignature("()Ljava/text/BreakIterator;")]
		public static BreakIterator getSentenceInstance()
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getSentenceInstance", "()Ljava/text/BreakIterator;");
		}
		
		[JavaSignature("()Ljava/text/CharacterIterator;")]
		public CharacterIterator getText()
		{
			return Instance.CallMethod<CharacterIterator>("getText", "()Ljava/text/CharacterIterator;");
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public static BreakIterator getWordInstance(Locale arg0)
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
		
		[JavaSignature("()Ljava/text/BreakIterator;")]
		public static BreakIterator getWordInstance()
		{
			return Static.CallMethod<BreakIterator>(typeof(BreakIterator), "getWordInstance", "()Ljava/text/BreakIterator;");
		}
		
		[JavaSignature("(I)Z")]
		public bool isBoundary(int arg0)
		{
			return Instance.CallMethod<bool>("isBoundary", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int preceding(int arg0)
		{
			return Instance.CallMethod<int>("preceding", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setText(String arg0)
		{
			Instance.CallMethod("setText", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/text/CharacterIterator;)V")]
		public void setText(CharacterIterator arg0)
		{
			Instance.CallMethod("setText", "(Ljava/text/CharacterIterator;)V", arg0);
		}
	}
}
