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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Character")]
	public class Character : Object, Serializable, Comparable<Character>
	{
		protected Character(ProxyCtor p) : base(p) {}
		
		public Character(char arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(C)V", arg0);
		}
	
		[JavaSignature("I")]
		public static int MIN_RADIX
		{
			get { return Static.GetField<int>(typeof(Character), "MIN_RADIX", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_RADIX
		{
			get { return Static.GetField<int>(typeof(Character), "MAX_RADIX", "I"); }
		}
		
		[JavaSignature("C")]
		public static char MIN_VALUE
		{
			get { return Static.GetField<char>(typeof(Character), "MIN_VALUE", "C"); }
		}
		
		[JavaSignature("C")]
		public static char MAX_VALUE
		{
			get { return Static.GetField<char>(typeof(Character), "MAX_VALUE", "C"); }
		}
		
		[JavaSignature("Ljava/lang/Class;")]
		public static Class<Character> TYPE
		{
			get { return Static.GetField<Class<Character>>(typeof(Character), "TYPE", "Ljava/lang/Class;"); }
		}
		
		[JavaSignature("B")]
		public static byte UNASSIGNED
		{
			get { return Static.GetField<byte>(typeof(Character), "UNASSIGNED", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte UPPERCASE_LETTER
		{
			get { return Static.GetField<byte>(typeof(Character), "UPPERCASE_LETTER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte LOWERCASE_LETTER
		{
			get { return Static.GetField<byte>(typeof(Character), "LOWERCASE_LETTER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TITLECASE_LETTER
		{
			get { return Static.GetField<byte>(typeof(Character), "TITLECASE_LETTER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte MODIFIER_LETTER
		{
			get { return Static.GetField<byte>(typeof(Character), "MODIFIER_LETTER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte OTHER_LETTER
		{
			get { return Static.GetField<byte>(typeof(Character), "OTHER_LETTER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte NON_SPACING_MARK
		{
			get { return Static.GetField<byte>(typeof(Character), "NON_SPACING_MARK", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte ENCLOSING_MARK
		{
			get { return Static.GetField<byte>(typeof(Character), "ENCLOSING_MARK", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte COMBINING_SPACING_MARK
		{
			get { return Static.GetField<byte>(typeof(Character), "COMBINING_SPACING_MARK", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DECIMAL_DIGIT_NUMBER
		{
			get { return Static.GetField<byte>(typeof(Character), "DECIMAL_DIGIT_NUMBER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte LETTER_NUMBER
		{
			get { return Static.GetField<byte>(typeof(Character), "LETTER_NUMBER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte OTHER_NUMBER
		{
			get { return Static.GetField<byte>(typeof(Character), "OTHER_NUMBER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte SPACE_SEPARATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "SPACE_SEPARATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte LINE_SEPARATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "LINE_SEPARATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte PARAGRAPH_SEPARATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "PARAGRAPH_SEPARATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte CONTROL
		{
			get { return Static.GetField<byte>(typeof(Character), "CONTROL", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte FORMAT
		{
			get { return Static.GetField<byte>(typeof(Character), "FORMAT", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte PRIVATE_USE
		{
			get { return Static.GetField<byte>(typeof(Character), "PRIVATE_USE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte SURROGATE
		{
			get { return Static.GetField<byte>(typeof(Character), "SURROGATE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DASH_PUNCTUATION
		{
			get { return Static.GetField<byte>(typeof(Character), "DASH_PUNCTUATION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte START_PUNCTUATION
		{
			get { return Static.GetField<byte>(typeof(Character), "START_PUNCTUATION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte END_PUNCTUATION
		{
			get { return Static.GetField<byte>(typeof(Character), "END_PUNCTUATION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte CONNECTOR_PUNCTUATION
		{
			get { return Static.GetField<byte>(typeof(Character), "CONNECTOR_PUNCTUATION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte OTHER_PUNCTUATION
		{
			get { return Static.GetField<byte>(typeof(Character), "OTHER_PUNCTUATION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte MATH_SYMBOL
		{
			get { return Static.GetField<byte>(typeof(Character), "MATH_SYMBOL", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte CURRENCY_SYMBOL
		{
			get { return Static.GetField<byte>(typeof(Character), "CURRENCY_SYMBOL", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte MODIFIER_SYMBOL
		{
			get { return Static.GetField<byte>(typeof(Character), "MODIFIER_SYMBOL", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte OTHER_SYMBOL
		{
			get { return Static.GetField<byte>(typeof(Character), "OTHER_SYMBOL", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte INITIAL_QUOTE_PUNCTUATION
		{
			get { return Static.GetField<byte>(typeof(Character), "INITIAL_QUOTE_PUNCTUATION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte FINAL_QUOTE_PUNCTUATION
		{
			get { return Static.GetField<byte>(typeof(Character), "FINAL_QUOTE_PUNCTUATION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_UNDEFINED
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_UNDEFINED", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_LEFT_TO_RIGHT", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_RIGHT_TO_LEFT", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_EUROPEAN_NUMBER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_ARABIC_NUMBER
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_ARABIC_NUMBER", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_COMMON_NUMBER_SEPARATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_NONSPACING_MARK
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_NONSPACING_MARK", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_BOUNDARY_NEUTRAL
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_BOUNDARY_NEUTRAL", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_PARAGRAPH_SEPARATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_PARAGRAPH_SEPARATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_SEGMENT_SEPARATOR
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_SEGMENT_SEPARATOR", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_WHITESPACE
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_WHITESPACE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_OTHER_NEUTRALS
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_OTHER_NEUTRALS", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT
		{
			get { return Static.GetField<byte>(typeof(Character), "DIRECTIONALITY_POP_DIRECTIONAL_FORMAT", "B"); }
		}
		
		[JavaSignature("C")]
		public static char MIN_HIGH_SURROGATE
		{
			get { return Static.GetField<char>(typeof(Character), "MIN_HIGH_SURROGATE", "C"); }
		}
		
		[JavaSignature("C")]
		public static char MAX_HIGH_SURROGATE
		{
			get { return Static.GetField<char>(typeof(Character), "MAX_HIGH_SURROGATE", "C"); }
		}
		
		[JavaSignature("C")]
		public static char MIN_LOW_SURROGATE
		{
			get { return Static.GetField<char>(typeof(Character), "MIN_LOW_SURROGATE", "C"); }
		}
		
		[JavaSignature("C")]
		public static char MAX_LOW_SURROGATE
		{
			get { return Static.GetField<char>(typeof(Character), "MAX_LOW_SURROGATE", "C"); }
		}
		
		[JavaSignature("C")]
		public static char MIN_SURROGATE
		{
			get { return Static.GetField<char>(typeof(Character), "MIN_SURROGATE", "C"); }
		}
		
		[JavaSignature("C")]
		public static char MAX_SURROGATE
		{
			get { return Static.GetField<char>(typeof(Character), "MAX_SURROGATE", "C"); }
		}
		
		[JavaSignature("I")]
		public static int MIN_SUPPLEMENTARY_CODE_POINT
		{
			get { return Static.GetField<int>(typeof(Character), "MIN_SUPPLEMENTARY_CODE_POINT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MIN_CODE_POINT
		{
			get { return Static.GetField<int>(typeof(Character), "MIN_CODE_POINT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_CODE_POINT
		{
			get { return Static.GetField<int>(typeof(Character), "MAX_CODE_POINT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SIZE
		{
			get { return Static.GetField<int>(typeof(Character), "SIZE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BYTES
		{
			get { return Static.GetField<int>(typeof(Character), "BYTES", "I"); }
		}
	
		[JavaSignature("(C)Z")]
		public static bool isJavaIdentifierStart(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isJavaIdentifierStart", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isJavaIdentifierStart(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isJavaIdentifierStart", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isJavaIdentifierPart(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isJavaIdentifierPart", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isJavaIdentifierPart(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isJavaIdentifierPart", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Ljava/lang/String;")]
		public static String toString(char arg0)
		{
			return Static.CallMethod<String>(typeof(Character), "toString", "(C)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(C)I")]
		public static int hashCode(char arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "hashCode", "(C)I", arg0);
		}
		
		[JavaSignature("(C)C")]
		public static char reverseBytes(char arg0)
		{
			return Static.CallMethod<char>(typeof(Character), "reverseBytes", "(C)C", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Character;)I")]
		public int compareTo(Character arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Character;)I", arg0);
		}
		
		[JavaSignature("()C")]
		public char charValue()
		{
			return Instance.CallMethod<char>("charValue", "()C");
		}
		
		[JavaSignature("(C)Ljava/lang/Character;")]
		public static Character valueOf(char arg0)
		{
			return Static.CallMethod<Character>(typeof(Character), "valueOf", "(C)Ljava/lang/Character;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public static String getName(int arg0)
		{
			return Static.CallMethod<String>(typeof(Character), "getName", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int charCount(int arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "charCount", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;I)I")]
		public static int codePointAt(CharSequence arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointAt", "(Ljava/lang/CharSequence;I)I", arg0, arg1);
		}
		
		[JavaSignature("([CII)I")]
		public static int codePointAt(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointAt", "([CII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("([CI)I")]
		public static int codePointAt(CharArray arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointAt", "([CI)I", arg0, arg1);
		}
		
		[JavaSignature("([CII)I")]
		public static int codePointBefore(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointBefore", "([CII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("([CI)I")]
		public static int codePointBefore(CharArray arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointBefore", "([CI)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;I)I")]
		public static int codePointBefore(CharSequence arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointBefore", "(Ljava/lang/CharSequence;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)I")]
		public static int codePointCount(CharSequence arg0, int arg1, int arg2)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointCount", "(Ljava/lang/CharSequence;II)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("([CII)I")]
		public static int codePointCount(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<int>(typeof(Character), "codePointCount", "([CII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(CC)I")]
		public static int compare(char arg0, char arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "compare", "(CC)I", arg0, arg1);
		}
		
		[JavaSignature("(I)C")]
		public static char highSurrogate(int arg0)
		{
			return Static.CallMethod<char>(typeof(Character), "highSurrogate", "(I)C", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isBmpCodePoint(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isBmpCodePoint", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isValidCodePoint(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isValidCodePoint", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)C")]
		public static char lowSurrogate(int arg0)
		{
			return Static.CallMethod<char>(typeof(Character), "lowSurrogate", "(I)C", arg0);
		}
		
		[JavaSignature("([CIIII)I")]
		public static int offsetByCodePoints(CharArray arg0, int arg1, int arg2, int arg3, int arg4)
		{
			return Static.CallMethod<int>(typeof(Character), "offsetByCodePoints", "([CIIII)I", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)I")]
		public static int offsetByCodePoints(CharSequence arg0, int arg1, int arg2)
		{
			return Static.CallMethod<int>(typeof(Character), "offsetByCodePoints", "(Ljava/lang/CharSequence;II)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(I)[C")]
		public static CharArray toChars(int arg0)
		{
			return Static.CallMethod<CharArray>(typeof(Character), "toChars", "(I)[C", arg0);
		}
		
		[JavaSignature("(I[CI)I")]
		public static int toChars(int arg0, CharArray arg1, int arg2)
		{
			return Static.CallMethod<int>(typeof(Character), "toChars", "(I[CI)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("(I)I")]
		public static int toLowerCase(int arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "toLowerCase", "(I)I", arg0);
		}
		
		[JavaSignature("(C)C")]
		public static char toLowerCase(char arg0)
		{
			return Static.CallMethod<char>(typeof(Character), "toLowerCase", "(C)C", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int toUpperCase(int arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "toUpperCase", "(I)I", arg0);
		}
		
		[JavaSignature("(C)C")]
		public static char toUpperCase(char arg0)
		{
			return Static.CallMethod<char>(typeof(Character), "toUpperCase", "(C)C", arg0);
		}
		
		[JavaSignature("(C)I")]
		public static int getType(char arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "getType", "(C)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int getType(int arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "getType", "(I)I", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isDigit(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isDigit", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isDigit(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isDigit", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isHighSurrogate(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isHighSurrogate", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isLowSurrogate(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isLowSurrogate", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isSurrogate(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isSurrogate", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isLetter(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isLetter", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isLetter(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isLetter", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isLetterOrDigit(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isLetterOrDigit", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isLetterOrDigit(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isLetterOrDigit", "(I)Z", arg0);
		}
		
		[JavaSignature("(II)I")]
		public static int digit(int arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "digit", "(II)I", arg0, arg1);
		}
		
		[JavaSignature("(CI)I")]
		public static int digit(char arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "digit", "(CI)I", arg0, arg1);
		}
		
		[JavaSignature("(II)C")]
		public static char forDigit(int arg0, int arg1)
		{
			return Static.CallMethod<char>(typeof(Character), "forDigit", "(II)C", arg0, arg1);
		}
		
		[JavaSignature("(I)B")]
		public static byte getDirectionality(int arg0)
		{
			return Static.CallMethod<byte>(typeof(Character), "getDirectionality", "(I)B", arg0);
		}
		
		[JavaSignature("(C)B")]
		public static byte getDirectionality(char arg0)
		{
			return Static.CallMethod<byte>(typeof(Character), "getDirectionality", "(C)B", arg0);
		}
		
		[JavaSignature("(C)I")]
		public static int getNumericValue(char arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "getNumericValue", "(C)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int getNumericValue(int arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "getNumericValue", "(I)I", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isAlphabetic(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isAlphabetic", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isDefined(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isDefined", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isDefined(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isDefined", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isISOControl(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isISOControl", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isISOControl(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isISOControl", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isIdentifierIgnorable(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isIdentifierIgnorable", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isIdentifierIgnorable(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isIdentifierIgnorable", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isIdeographic(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isIdeographic", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isJavaLetter(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isJavaLetter", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isJavaLetterOrDigit(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isJavaLetterOrDigit", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isLowerCase(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isLowerCase", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isLowerCase(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isLowerCase", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isMirrored(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isMirrored", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isMirrored(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isMirrored", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isSpace(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isSpace", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isSpaceChar(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isSpaceChar", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isSpaceChar(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isSpaceChar", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isSupplementaryCodePoint(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isSupplementaryCodePoint", "(I)Z", arg0);
		}
		
		[JavaSignature("(CC)Z")]
		public static bool isSurrogatePair(char arg0, char arg1)
		{
			return Static.CallMethod<bool>(typeof(Character), "isSurrogatePair", "(CC)Z", arg0, arg1);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isTitleCase(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isTitleCase", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isTitleCase(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isTitleCase", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isUnicodeIdentifierPart(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isUnicodeIdentifierPart", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isUnicodeIdentifierPart(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isUnicodeIdentifierPart", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isUnicodeIdentifierStart(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isUnicodeIdentifierStart", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isUnicodeIdentifierStart(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isUnicodeIdentifierStart", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isUpperCase(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isUpperCase", "(I)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isUpperCase(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isUpperCase", "(C)Z", arg0);
		}
		
		[JavaSignature("(C)Z")]
		public static bool isWhitespace(char arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isWhitespace", "(C)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public static bool isWhitespace(int arg0)
		{
			return Static.CallMethod<bool>(typeof(Character), "isWhitespace", "(I)Z", arg0);
		}
		
		[JavaSignature("(CC)I")]
		public static int toCodePoint(char arg0, char arg1)
		{
			return Static.CallMethod<int>(typeof(Character), "toCodePoint", "(CC)I", arg0, arg1);
		}
		
		[JavaSignature("(C)C")]
		public static char toTitleCase(char arg0)
		{
			return Static.CallMethod<char>(typeof(Character), "toTitleCase", "(C)C", arg0);
		}
		
		[JavaSignature("(I)I")]
		public static int toTitleCase(int arg0)
		{
			return Static.CallMethod<int>(typeof(Character), "toTitleCase", "(I)I", arg0);
		}
	
		[JavaProxy("java/lang/Character/Subset")]
		public class Subset : Object
		{
			protected Subset(ProxyCtor p) : base(p) {}
		}
		
		[JavaProxy("java/lang/Character/UnicodeBlock")]
		public class UnicodeBlock : Character.Subset
		{
			protected UnicodeBlock(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BASIC_LATIN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BASIC_LATIN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LATIN_1_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LATIN_1_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LATIN_EXTENDED_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LATIN_EXTENDED_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LATIN_EXTENDED_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LATIN_EXTENDED_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock IPA_EXTENSIONS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "IPA_EXTENSIONS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SPACING_MODIFIER_LETTERS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SPACING_MODIFIER_LETTERS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GREEK
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GREEK", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CYRILLIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CYRILLIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARMENIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARMENIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HEBREW
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HEBREW", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARABIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARABIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock DEVANAGARI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "DEVANAGARI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BENGALI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BENGALI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GURMUKHI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GURMUKHI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GUJARATI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GUJARATI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ORIYA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ORIYA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAMIL
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAMIL", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TELUGU
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TELUGU", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KANNADA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KANNADA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MALAYALAM
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MALAYALAM", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock THAI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "THAI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LAO
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LAO", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TIBETAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TIBETAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GEORGIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GEORGIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HANGUL_JAMO
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HANGUL_JAMO", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GREEK_EXTENDED
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GREEK_EXTENDED", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GENERAL_PUNCTUATION
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GENERAL_PUNCTUATION", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CURRENCY_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CURRENCY_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LETTERLIKE_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LETTERLIKE_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock NUMBER_FORMS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "NUMBER_FORMS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARROWS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARROWS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MATHEMATICAL_OPERATORS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MATHEMATICAL_OPERATORS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MISCELLANEOUS_TECHNICAL
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CONTROL_PICTURES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CONTROL_PICTURES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ENCLOSED_ALPHANUMERICS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BOX_DRAWING
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BOX_DRAWING", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BLOCK_ELEMENTS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BLOCK_ELEMENTS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GEOMETRIC_SHAPES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GEOMETRIC_SHAPES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MISCELLANEOUS_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock DINGBATS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "DINGBATS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HIRAGANA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HIRAGANA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KATAKANA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KATAKANA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BOPOMOFO
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BOPOMOFO", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KANBUN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KANBUN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_COMPATIBILITY
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_COMPATIBILITY", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HANGUL_SYLLABLES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HANGUL_SYLLABLES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock PRIVATE_USE_AREA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "PRIVATE_USE_AREA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock COMBINING_HALF_MARKS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "COMBINING_HALF_MARKS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_COMPATIBILITY_FORMS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SMALL_FORM_VARIANTS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SMALL_FORM_VARIANTS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SPECIALS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SPECIALS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SURROGATES_AREA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SURROGATES_AREA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SYRIAC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SYRIAC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock THAANA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "THAANA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SINHALA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SINHALA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MYANMAR
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MYANMAR", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ETHIOPIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ETHIOPIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CHEROKEE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CHEROKEE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OGHAM
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OGHAM", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock RUNIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "RUNIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KHMER
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KHMER", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MONGOLIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MONGOLIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BRAILLE_PATTERNS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BRAILLE_PATTERNS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KANGXI_RADICALS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KANGXI_RADICALS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BOPOMOFO_EXTENDED
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BOPOMOFO_EXTENDED", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock YI_SYLLABLES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "YI_SYLLABLES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock YI_RADICALS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "YI_RADICALS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAGALOG
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAGALOG", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HANUNOO
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HANUNOO", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BUHID
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BUHID", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAGBANWA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAGBANWA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LIMBU
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LIMBU", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAI_LE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAI_LE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KHMER_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KHMER_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock PHONETIC_EXTENSIONS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "PHONETIC_EXTENSIONS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock VARIATION_SELECTORS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "VARIATION_SELECTORS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LINEAR_B_SYLLABARY
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LINEAR_B_SYLLABARY", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LINEAR_B_IDEOGRAMS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LINEAR_B_IDEOGRAMS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock AEGEAN_NUMBERS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "AEGEAN_NUMBERS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OLD_ITALIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OLD_ITALIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GOTHIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GOTHIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock UGARITIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "UGARITIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock DESERET
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "DESERET", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SHAVIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SHAVIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OSMANYA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OSMANYA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CYPRIOT_SYLLABARY
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CYPRIOT_SYLLABARY", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MUSICAL_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MUSICAL_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAGS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAGS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HIGH_SURROGATES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HIGH_SURROGATES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LOW_SURROGATES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LOW_SURROGATES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARABIC_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARABIC_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock NKO
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "NKO", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SAMARITAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SAMARITAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MANDAIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MANDAIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ETHIOPIC_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ETHIOPIC_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS_EXTENDED
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS_EXTENDED", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock NEW_TAI_LUE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "NEW_TAI_LUE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BUGINESE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BUGINESE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAI_THAM
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAI_THAM", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BALINESE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BALINESE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUNDANESE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUNDANESE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BATAK
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BATAK", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LEPCHA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LEPCHA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OL_CHIKI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OL_CHIKI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock VEDIC_EXTENSIONS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "VEDIC_EXTENSIONS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock PHONETIC_EXTENSIONS_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "PHONETIC_EXTENSIONS_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "COMBINING_DIACRITICAL_MARKS_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GLAGOLITIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GLAGOLITIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LATIN_EXTENDED_C
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LATIN_EXTENDED_C", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock COPTIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "COPTIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock GEORGIAN_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "GEORGIAN_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TIFINAGH
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TIFINAGH", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ETHIOPIC_EXTENDED
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ETHIOPIC_EXTENDED", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CYRILLIC_EXTENDED_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CYRILLIC_EXTENDED_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUPPLEMENTAL_PUNCTUATION
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUPPLEMENTAL_PUNCTUATION", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_STROKES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_STROKES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LISU
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LISU", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock VAI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "VAI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CYRILLIC_EXTENDED_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CYRILLIC_EXTENDED_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BAMUM
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BAMUM", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MODIFIER_TONE_LETTERS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MODIFIER_TONE_LETTERS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LATIN_EXTENDED_D
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LATIN_EXTENDED_D", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SYLOTI_NAGRI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SYLOTI_NAGRI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock COMMON_INDIC_NUMBER_FORMS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "COMMON_INDIC_NUMBER_FORMS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock PHAGS_PA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "PHAGS_PA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SAURASHTRA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SAURASHTRA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock DEVANAGARI_EXTENDED
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "DEVANAGARI_EXTENDED", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KAYAH_LI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KAYAH_LI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock REJANG
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "REJANG", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HANGUL_JAMO_EXTENDED_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HANGUL_JAMO_EXTENDED_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock JAVANESE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "JAVANESE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CHAM
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CHAM", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MYANMAR_EXTENDED_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MYANMAR_EXTENDED_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAI_VIET
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAI_VIET", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ETHIOPIC_EXTENDED_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ETHIOPIC_EXTENDED_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MEETEI_MAYEK
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MEETEI_MAYEK", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock HANGUL_JAMO_EXTENDED_B
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "HANGUL_JAMO_EXTENDED_B", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock VERTICAL_FORMS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "VERTICAL_FORMS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ANCIENT_GREEK_NUMBERS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ANCIENT_GREEK_NUMBERS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ANCIENT_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ANCIENT_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock PHAISTOS_DISC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "PHAISTOS_DISC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LYCIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LYCIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CARIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CARIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OLD_PERSIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OLD_PERSIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock IMPERIAL_ARAMAIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "IMPERIAL_ARAMAIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock PHOENICIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "PHOENICIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock LYDIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "LYDIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KHAROSHTHI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KHAROSHTHI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OLD_SOUTH_ARABIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OLD_SOUTH_ARABIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock AVESTAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "AVESTAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock INSCRIPTIONAL_PARTHIAN
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "INSCRIPTIONAL_PARTHIAN", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock INSCRIPTIONAL_PAHLAVI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "INSCRIPTIONAL_PAHLAVI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock OLD_TURKIC
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "OLD_TURKIC", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock RUMI_NUMERAL_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "RUMI_NUMERAL_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BRAHMI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BRAHMI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KAITHI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KAITHI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CUNEIFORM
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CUNEIFORM", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CUNEIFORM_NUMBERS_AND_PUNCTUATION
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CUNEIFORM_NUMBERS_AND_PUNCTUATION", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock EGYPTIAN_HIEROGLYPHS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "EGYPTIAN_HIEROGLYPHS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock BAMUM_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "BAMUM_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock KANA_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "KANA_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ANCIENT_GREEK_MUSICAL_NOTATION
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ANCIENT_GREEK_MUSICAL_NOTATION", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock COUNTING_ROD_NUMERALS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "COUNTING_ROD_NUMERALS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MAHJONG_TILES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MAHJONG_TILES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock DOMINO_TILES
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "DOMINO_TILES", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock PLAYING_CARDS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "PLAYING_CARDS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ENCLOSED_ALPHANUMERIC_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ENCLOSED_ALPHANUMERIC_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ENCLOSED_IDEOGRAPHIC_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ENCLOSED_IDEOGRAPHIC_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_PICTOGRAPHS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MISCELLANEOUS_SYMBOLS_AND_PICTOGRAPHS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock EMOTICONS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "EMOTICONS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TRANSPORT_AND_MAP_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TRANSPORT_AND_MAP_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ALCHEMICAL_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ALCHEMICAL_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_C
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_C", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_D
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_D", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARABIC_EXTENDED_A
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARABIC_EXTENDED_A", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SUNDANESE_SUPPLEMENT
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SUNDANESE_SUPPLEMENT", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MEETEI_MAYEK_EXTENSIONS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MEETEI_MAYEK_EXTENSIONS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MEROITIC_HIEROGLYPHS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MEROITIC_HIEROGLYPHS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MEROITIC_CURSIVE
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MEROITIC_CURSIVE", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SORA_SOMPENG
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SORA_SOMPENG", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock CHAKMA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "CHAKMA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock SHARADA
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "SHARADA", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock TAKRI
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "TAKRI", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock MIAO
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "MIAO", "Ljava/lang/Character/UnicodeBlock;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock ARABIC_MATHEMATICAL_ALPHABETIC_SYMBOLS
			{
				get { return Static.GetField<Character.UnicodeBlock>(typeof(UnicodeBlock), "ARABIC_MATHEMATICAL_ALPHABETIC_SYMBOLS", "Ljava/lang/Character/UnicodeBlock;"); }
			}
		
			[JavaSignature("(Ljava/lang/String;)Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock forName(String arg0)
			{
				return Static.CallMethod<Character.UnicodeBlock>(typeof(UnicodeBlock), "forName", "(Ljava/lang/String;)Ljava/lang/Character/UnicodeBlock;", arg0);
			}
			
			[JavaSignature("(I)Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock of(int arg0)
			{
				return Static.CallMethod<Character.UnicodeBlock>(typeof(UnicodeBlock), "of", "(I)Ljava/lang/Character/UnicodeBlock;", arg0);
			}
			
			[JavaSignature("(C)Ljava/lang/Character/UnicodeBlock;")]
			public static Character.UnicodeBlock of(char arg0)
			{
				return Static.CallMethod<Character.UnicodeBlock>(typeof(UnicodeBlock), "of", "(C)Ljava/lang/Character/UnicodeBlock;", arg0);
			}
		}
		
		[JavaProxy("java/lang/Character/UnicodeScript")]
		public class UnicodeScript : Enum<Character.UnicodeScript>
		{
			protected UnicodeScript(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript COMMON
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "COMMON", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LATIN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LATIN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript GREEK
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "GREEK", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CYRILLIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CYRILLIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript ARMENIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "ARMENIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript HEBREW
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "HEBREW", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript ARABIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "ARABIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SYRIAC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SYRIAC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript THAANA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "THAANA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript DEVANAGARI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "DEVANAGARI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BENGALI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BENGALI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript GURMUKHI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "GURMUKHI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript GUJARATI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "GUJARATI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript ORIYA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "ORIYA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TAMIL
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TAMIL", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TELUGU
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TELUGU", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript KANNADA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "KANNADA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MALAYALAM
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MALAYALAM", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SINHALA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SINHALA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript THAI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "THAI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LAO
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LAO", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TIBETAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TIBETAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MYANMAR
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MYANMAR", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript GEORGIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "GEORGIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript HANGUL
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "HANGUL", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript ETHIOPIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "ETHIOPIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CHEROKEE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CHEROKEE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CANADIAN_ABORIGINAL
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CANADIAN_ABORIGINAL", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript OGHAM
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "OGHAM", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript RUNIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "RUNIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript KHMER
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "KHMER", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MONGOLIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MONGOLIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript HIRAGANA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "HIRAGANA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript KATAKANA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "KATAKANA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BOPOMOFO
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BOPOMOFO", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript HAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "HAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript YI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "YI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript OLD_ITALIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "OLD_ITALIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript GOTHIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "GOTHIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript DESERET
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "DESERET", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript INHERITED
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "INHERITED", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TAGALOG
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TAGALOG", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript HANUNOO
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "HANUNOO", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BUHID
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BUHID", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TAGBANWA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TAGBANWA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LIMBU
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LIMBU", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TAI_LE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TAI_LE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LINEAR_B
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LINEAR_B", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript UGARITIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "UGARITIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SHAVIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SHAVIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript OSMANYA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "OSMANYA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CYPRIOT
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CYPRIOT", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BRAILLE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BRAILLE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BUGINESE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BUGINESE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript COPTIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "COPTIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript NEW_TAI_LUE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "NEW_TAI_LUE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript GLAGOLITIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "GLAGOLITIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TIFINAGH
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TIFINAGH", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SYLOTI_NAGRI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SYLOTI_NAGRI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript OLD_PERSIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "OLD_PERSIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript KHAROSHTHI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "KHAROSHTHI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BALINESE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BALINESE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CUNEIFORM
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CUNEIFORM", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript PHOENICIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "PHOENICIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript PHAGS_PA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "PHAGS_PA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript NKO
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "NKO", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SUNDANESE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SUNDANESE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BATAK
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BATAK", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LEPCHA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LEPCHA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript OL_CHIKI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "OL_CHIKI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript VAI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "VAI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SAURASHTRA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SAURASHTRA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript KAYAH_LI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "KAYAH_LI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript REJANG
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "REJANG", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LYCIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LYCIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CARIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CARIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LYDIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LYDIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CHAM
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CHAM", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TAI_THAM
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TAI_THAM", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TAI_VIET
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TAI_VIET", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript AVESTAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "AVESTAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript EGYPTIAN_HIEROGLYPHS
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "EGYPTIAN_HIEROGLYPHS", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SAMARITAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SAMARITAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MANDAIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MANDAIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript LISU
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "LISU", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BAMUM
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BAMUM", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript JAVANESE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "JAVANESE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MEETEI_MAYEK
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MEETEI_MAYEK", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript IMPERIAL_ARAMAIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "IMPERIAL_ARAMAIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript OLD_SOUTH_ARABIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "OLD_SOUTH_ARABIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript INSCRIPTIONAL_PARTHIAN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "INSCRIPTIONAL_PARTHIAN", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript INSCRIPTIONAL_PAHLAVI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "INSCRIPTIONAL_PAHLAVI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript OLD_TURKIC
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "OLD_TURKIC", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript BRAHMI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "BRAHMI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript KAITHI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "KAITHI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MEROITIC_HIEROGLYPHS
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MEROITIC_HIEROGLYPHS", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MEROITIC_CURSIVE
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MEROITIC_CURSIVE", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SORA_SOMPENG
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SORA_SOMPENG", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript CHAKMA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "CHAKMA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript SHARADA
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "SHARADA", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript TAKRI
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "TAKRI", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript MIAO
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "MIAO", "Ljava/lang/Character/UnicodeScript;"); }
			}
			
			[JavaSignature("Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript UNKNOWN
			{
				get { return Static.GetField<Character.UnicodeScript>(typeof(UnicodeScript), "UNKNOWN", "Ljava/lang/Character/UnicodeScript;"); }
			}
		
			[JavaSignature("(Ljava/lang/String;)Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript forName(String arg0)
			{
				return Static.CallMethod<Character.UnicodeScript>(typeof(UnicodeScript), "forName", "(Ljava/lang/String;)Ljava/lang/Character/UnicodeScript;", arg0);
			}
			
			[JavaSignature("()[Ljava/lang/Character/UnicodeScript;")]
			public static ObjectArray<Character.UnicodeScript> values()
			{
				return Static.CallMethod<ObjectArray<Character.UnicodeScript>>(typeof(UnicodeScript), "values", "()[Ljava/lang/Character/UnicodeScript;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript valueOf(String arg0)
			{
				return Static.CallMethod<Character.UnicodeScript>(typeof(UnicodeScript), "valueOf", "(Ljava/lang/String;)Ljava/lang/Character/UnicodeScript;", arg0);
			}
			
			[JavaSignature("(I)Ljava/lang/Character/UnicodeScript;")]
			public static Character.UnicodeScript of(int arg0)
			{
				return Static.CallMethod<Character.UnicodeScript>(typeof(UnicodeScript), "of", "(I)Ljava/lang/Character/UnicodeScript;", arg0);
			}
		}
	}
}
