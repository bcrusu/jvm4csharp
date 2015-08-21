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
	[JavaProxy("java/text/AttributedString")]
	public partial class AttributedString : Object
	{
		protected AttributedString(ProxyCtor p) : base(p) {}
		
		public AttributedString(AttributedCharacterIterator arg0, int arg1, int arg2, ObjectArray<AttributedCharacterIterator_.Attribute> arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/text/AttributedCharacterIterator;II[Ljava/text/AttributedCharacterIterator/Attribute;)V", arg0, arg1, arg2, arg3);
		}
		
		public AttributedString(AttributedCharacterIterator arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/text/AttributedCharacterIterator;II)V", arg0, arg1, arg2);
		}
		
		public AttributedString(AttributedCharacterIterator arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/text/AttributedCharacterIterator;)V", arg0);
		}
		
		public AttributedString(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public AttributedString(String arg0, Map<AttributedCharacterIterator_.Attribute, IJavaObject> arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/util/Map;)V", arg0, arg1);
		}
	
		[JavaSignature("([Ljava/text/AttributedCharacterIterator/Attribute;)Ljava/text/AttributedCharacterIterator;")]
		public AttributedCharacterIterator getIterator(ObjectArray<AttributedCharacterIterator_.Attribute> arg0)
		{
			return Instance.CallMethod<AttributedCharacterIterator>("getIterator", "([Ljava/text/AttributedCharacterIterator/Attribute;)Ljava/text/AttributedCharacterIterator;", arg0);
		}
		
		[JavaSignature("()Ljava/text/AttributedCharacterIterator;")]
		public AttributedCharacterIterator getIterator()
		{
			return Instance.CallMethod<AttributedCharacterIterator>("getIterator", "()Ljava/text/AttributedCharacterIterator;");
		}
		
		[JavaSignature("([Ljava/text/AttributedCharacterIterator/Attribute;II)Ljava/text/AttributedCharacterIterator;")]
		public AttributedCharacterIterator getIterator(ObjectArray<AttributedCharacterIterator_.Attribute> arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<AttributedCharacterIterator>("getIterator", "([Ljava/text/AttributedCharacterIterator/Attribute;II)Ljava/text/AttributedCharacterIterator;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/text/AttributedCharacterIterator/Attribute;Ljava/lang/Object;II)V")]
		public void addAttribute(AttributedCharacterIterator_.Attribute arg0, IJavaObject arg1, int arg2, int arg3)
		{
			Instance.CallMethod("addAttribute", "(Ljava/text/AttributedCharacterIterator/Attribute;Ljava/lang/Object;II)V", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/text/AttributedCharacterIterator/Attribute;Ljava/lang/Object;)V")]
		public void addAttribute(AttributedCharacterIterator_.Attribute arg0, IJavaObject arg1)
		{
			Instance.CallMethod("addAttribute", "(Ljava/text/AttributedCharacterIterator/Attribute;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Map;II)V")]
		public void addAttributes(Map<AttributedCharacterIterator_.Attribute, IJavaObject> arg0, int arg1, int arg2)
		{
			Instance.CallMethod("addAttributes", "(Ljava/util/Map;II)V", arg0, arg1, arg2);
		}
	}
}
