//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util;
using jvm4csharp.java.util.spi;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text.spi
{
	[JavaProxy("java/text/spi/BreakIteratorProvider")]
	public abstract class BreakIteratorProvider : LocaleServiceProvider
	{
		protected BreakIteratorProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public BreakIterator getCharacterInstance(Locale arg0)
		{
			return Instance.CallMethod<BreakIterator>("getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public BreakIterator getLineInstance(Locale arg0)
		{
			return Instance.CallMethod<BreakIterator>("getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public BreakIterator getSentenceInstance(Locale arg0)
		{
			return Instance.CallMethod<BreakIterator>("getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/BreakIterator;")]
		public BreakIterator getWordInstance(Locale arg0)
		{
			return Instance.CallMethod<BreakIterator>("getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
		}
	}
}
