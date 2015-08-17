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
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/RuleBasedCollator")]
	public class RuleBasedCollator : Collator
	{
		protected RuleBasedCollator(ProxyCtor p) : base(p) {}
		
		public RuleBasedCollator(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getRules()
		{
			return Instance.CallMethod<String>("getRules", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;")]
		public CollationElementIterator getCollationElementIterator(CharacterIterator arg0)
		{
			return Instance.CallMethod<CollationElementIterator>("getCollationElementIterator", "(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/text/CollationElementIterator;")]
		public CollationElementIterator getCollationElementIterator(String arg0)
		{
			return Instance.CallMethod<CollationElementIterator>("getCollationElementIterator", "(Ljava/lang/String;)Ljava/text/CollationElementIterator;", arg0);
		}
	}
}
