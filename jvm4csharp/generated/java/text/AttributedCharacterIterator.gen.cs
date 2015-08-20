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
using jvm4csharp.java.lang;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/AttributedCharacterIterator")]
	public partial interface AttributedCharacterIterator : CharacterIterator
	{
		[JavaSignature("()Ljava/util/Map;")]
		Map<AttributedCharacterIterator_.Attribute, IJavaObject> getAttributes();
		
		[JavaSignature("(Ljava/text/AttributedCharacterIterator/Attribute;)Ljava/lang/Object;")]
		IJavaObject getAttribute(AttributedCharacterIterator_.Attribute arg0);
		
		[JavaSignature("()Ljava/util/Set;")]
		Set<AttributedCharacterIterator_.Attribute> getAllAttributeKeys();
		
		[JavaSignature("(Ljava/util/Set;)I")]
		int getRunLimit(Set<AttributedCharacterIterator_.Attribute> arg0);
		
		[JavaSignature("(Ljava/text/AttributedCharacterIterator/Attribute;)I")]
		int getRunLimit(AttributedCharacterIterator_.Attribute arg0);
		
		[JavaSignature("()I")]
		int getRunLimit();
		
		[JavaSignature("()I")]
		int getRunStart();
		
		[JavaSignature("(Ljava/text/AttributedCharacterIterator/Attribute;)I")]
		int getRunStart(AttributedCharacterIterator_.Attribute arg0);
		
		[JavaSignature("(Ljava/util/Set;)I")]
		int getRunStart(Set<AttributedCharacterIterator_.Attribute> arg0);
	}
	
	public static class AttributedCharacterIterator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
	
		[JavaProxy("java/text/AttributedCharacterIterator/Attribute")]
		public partial class Attribute : Object, Serializable
		{
			protected Attribute(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/text/AttributedCharacterIterator/Attribute;")]
			public static AttributedCharacterIterator_.Attribute LANGUAGE
			{
				get { return Static.GetField<AttributedCharacterIterator_.Attribute>(typeof(Attribute), "LANGUAGE", "Ljava/text/AttributedCharacterIterator/Attribute;"); }
			}
			
			[JavaSignature("Ljava/text/AttributedCharacterIterator/Attribute;")]
			public static AttributedCharacterIterator_.Attribute READING
			{
				get { return Static.GetField<AttributedCharacterIterator_.Attribute>(typeof(Attribute), "READING", "Ljava/text/AttributedCharacterIterator/Attribute;"); }
			}
			
			[JavaSignature("Ljava/text/AttributedCharacterIterator/Attribute;")]
			public static AttributedCharacterIterator_.Attribute INPUT_METHOD_SEGMENT
			{
				get { return Static.GetField<AttributedCharacterIterator_.Attribute>(typeof(Attribute), "INPUT_METHOD_SEGMENT", "Ljava/text/AttributedCharacterIterator/Attribute;"); }
			}
		}
	}
}
