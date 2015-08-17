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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/Format")]
	public abstract class Format : Object, Serializable, Cloneable
	{
		protected Format(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;")]
		public StringBuffer format(IJavaObject arg0, StringBuffer arg1, FieldPosition arg2)
		{
			return Instance.CallMethod<StringBuffer>("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/String;")]
		public String format(IJavaObject arg0)
		{
			return Instance.CallMethod<String>("format", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;")]
		public AttributedCharacterIterator formatToCharacterIterator(IJavaObject arg0)
		{
			return Instance.CallMethod<AttributedCharacterIterator>("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;")]
		public IJavaObject parseObject(String arg0, ParsePosition arg1)
		{
			return Instance.CallMethod<IJavaObject>("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/Object;")]
		public IJavaObject parseObject(String arg0)
		{
			return Instance.CallMethod<IJavaObject>("parseObject", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
		}
	
		[JavaProxy("java/text/Format/Field")]
		public class Field : AttributedCharacterIterator_.Attribute
		{
			protected Field(ProxyCtor p) : base(p) {}
		}
	}
}
