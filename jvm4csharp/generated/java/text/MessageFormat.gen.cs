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
using jvm4csharp.java.lang;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/MessageFormat")]
	public class MessageFormat : Format
	{
		protected MessageFormat(ProxyCtor p) : base(p) {}
		
		public MessageFormat(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public MessageFormat(String arg0, Locale arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/util/Locale;)V", arg0, arg1);
		}
	
		[JavaSignature("([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;")]
		public StringBuffer format(ObjectArray<IJavaObject> arg0, StringBuffer arg1, FieldPosition arg2)
		{
			return Instance.CallMethod<StringBuffer>("format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;")]
		public static String format(String arg0, ObjectArray<IJavaObject> arg1)
		{
			return Static.CallMethod<String>(typeof(MessageFormat), "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;")]
		public ObjectArray<IJavaObject> parse(String arg0, ParsePosition arg1)
		{
			return Instance.CallMethod<ObjectArray<IJavaObject>>("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;)[Ljava/lang/Object;")]
		public ObjectArray<IJavaObject> parse(String arg0)
		{
			return Instance.CallMethod<ObjectArray<IJavaObject>>("parse", "(Ljava/lang/String;)[Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)V")]
		public void setLocale(Locale arg0)
		{
			Instance.CallMethod("setLocale", "(Ljava/util/Locale;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void applyPattern(String arg0)
		{
			Instance.CallMethod("applyPattern", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()[Ljava/text/Format;")]
		public ObjectArray<Format> getFormatsByArgumentIndex()
		{
			return Instance.CallMethod<ObjectArray<Format>>("getFormatsByArgumentIndex", "()[Ljava/text/Format;");
		}
		
		[JavaSignature("(ILjava/text/Format;)V")]
		public void setFormatByArgumentIndex(int arg0, Format arg1)
		{
			Instance.CallMethod("setFormatByArgumentIndex", "(ILjava/text/Format;)V", arg0, arg1);
		}
		
		[JavaSignature("([Ljava/text/Format;)V")]
		public void setFormats(ObjectArray<Format> arg0)
		{
			Instance.CallMethod("setFormats", "([Ljava/text/Format;)V", arg0);
		}
		
		[JavaSignature("([Ljava/text/Format;)V")]
		public void setFormatsByArgumentIndex(ObjectArray<Format> arg0)
		{
			Instance.CallMethod("setFormatsByArgumentIndex", "([Ljava/text/Format;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toPattern()
		{
			return Instance.CallMethod<String>("toPattern", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[Ljava/text/Format;")]
		public ObjectArray<Format> getFormats()
		{
			return Instance.CallMethod<ObjectArray<Format>>("getFormats", "()[Ljava/text/Format;");
		}
		
		[JavaSignature("()Ljava/util/Locale;")]
		public Locale getLocale()
		{
			return Instance.CallMethod<Locale>("getLocale", "()Ljava/util/Locale;");
		}
		
		[JavaSignature("(ILjava/text/Format;)V")]
		public void setFormat(int arg0, Format arg1)
		{
			Instance.CallMethod("setFormat", "(ILjava/text/Format;)V", arg0, arg1);
		}
	
		[JavaProxy("java/text/MessageFormat/Field")]
		public class Field : Format.Field
		{
			protected Field(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/text/MessageFormat/Field;")]
			public static MessageFormat.Field ARGUMENT
			{
				get { return Static.GetField<MessageFormat.Field>(typeof(Field), "ARGUMENT", "Ljava/text/MessageFormat/Field;"); }
			}
		}
	}
}
