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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/Normalizer")]
	public partial class Normalizer : Object
	{
		protected Normalizer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/CharSequence;Ljava/text/Normalizer/Form;)Ljava/lang/String;")]
		public static String normalize(CharSequence arg0, Normalizer_.Form arg1)
		{
			return Static.CallMethod<String>(typeof(Normalizer), "normalize", "(Ljava/lang/CharSequence;Ljava/text/Normalizer/Form;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;Ljava/text/Normalizer/Form;)Z")]
		public static bool isNormalized(CharSequence arg0, Normalizer_.Form arg1)
		{
			return Static.CallMethod<bool>(typeof(Normalizer), "isNormalized", "(Ljava/lang/CharSequence;Ljava/text/Normalizer/Form;)Z", arg0, arg1);
		}
	}
	
	public static partial class Normalizer_
	{
		[JavaProxy("java/text/Normalizer/Form")]
		public partial class Form : Enum<Normalizer_.Form>
		{
			protected Form(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/text/Normalizer/Form;")]
			public static Normalizer_.Form NFD
			{
				get { return Static.GetField<Normalizer_.Form>(typeof(Form), "NFD", "Ljava/text/Normalizer/Form;"); }
			}
			
			[JavaSignature("Ljava/text/Normalizer/Form;")]
			public static Normalizer_.Form NFC
			{
				get { return Static.GetField<Normalizer_.Form>(typeof(Form), "NFC", "Ljava/text/Normalizer/Form;"); }
			}
			
			[JavaSignature("Ljava/text/Normalizer/Form;")]
			public static Normalizer_.Form NFKD
			{
				get { return Static.GetField<Normalizer_.Form>(typeof(Form), "NFKD", "Ljava/text/Normalizer/Form;"); }
			}
			
			[JavaSignature("Ljava/text/Normalizer/Form;")]
			public static Normalizer_.Form NFKC
			{
				get { return Static.GetField<Normalizer_.Form>(typeof(Form), "NFKC", "Ljava/text/Normalizer/Form;"); }
			}
		
			[JavaSignature("()[Ljava/text/Normalizer/Form;")]
			public static ObjectArray<Normalizer_.Form> values()
			{
				return Static.CallMethod<ObjectArray<Normalizer_.Form>>(typeof(Form), "values", "()[Ljava/text/Normalizer/Form;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/text/Normalizer/Form;")]
			public static Normalizer_.Form valueOf(String arg0)
			{
				return Static.CallMethod<Normalizer_.Form>(typeof(Form), "valueOf", "(Ljava/lang/String;)Ljava/text/Normalizer/Form;", arg0);
			}
		}
	}
}
