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
using jvm4csharp.java.io;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/StringBuilder")]
	public partial class StringBuilder : Object, Serializable, CharSequence, Appendable
	{
		protected StringBuilder(ProxyCtor p) : base(p) {}
		
		public StringBuilder(CharSequence arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/CharSequence;)V", arg0);
		}
		
		public StringBuilder(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public StringBuilder(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public StringBuilder() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(F)Ljava/lang/StringBuilder;")]
		public StringBuilder append(float arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(F)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/StringBuilder;")]
		public StringBuilder append(long arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(J)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;")]
		public StringBuilder append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<StringBuilder>("append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([C)Ljava/lang/StringBuilder;")]
		public StringBuilder append(CharArray arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "([C)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(D)Ljava/lang/StringBuilder;")]
		public StringBuilder append(double arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(D)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;")]
		public StringBuilder append(StringBuffer arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;")]
		public StringBuilder append(CharSequence arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/StringBuilder;")]
		public StringBuilder append(int arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(I)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(C)Ljava/lang/StringBuilder;")]
		public StringBuilder append(char arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(C)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/StringBuilder;")]
		public StringBuilder append(IJavaObject arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("([CII)Ljava/lang/StringBuilder;")]
		public StringBuilder append(CharArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<StringBuilder>("append", "([CII)Ljava/lang/StringBuilder;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Z)Ljava/lang/StringBuilder;")]
		public StringBuilder append(bool arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(Z)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/StringBuilder;")]
		public StringBuilder append(String arg0)
		{
			return Instance.CallMethod<StringBuilder>("append", "(Ljava/lang/String;)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(IILjava/lang/String;)Ljava/lang/StringBuilder;")]
		public StringBuilder replace(int arg0, int arg1, String arg2)
		{
			return Instance.CallMethod<StringBuilder>("replace", "(IILjava/lang/String;)Ljava/lang/StringBuilder;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(II)Ljava/lang/StringBuilder;")]
		public StringBuilder delete(int arg0, int arg1)
		{
			return Instance.CallMethod<StringBuilder>("delete", "(II)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(I[CII)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, CharArray arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(I[CII)Ljava/lang/StringBuilder;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(ID)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, double arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(ID)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(IF)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, float arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(IF)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(IJ)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, long arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(IJ)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(II)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, int arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(II)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/Object;)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/String;)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, String arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(ILjava/lang/String;)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(I[C)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, CharArray arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(I[C)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, CharSequence arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, CharSequence arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(IZ)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, bool arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(IZ)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(IC)Ljava/lang/StringBuilder;")]
		public StringBuilder insert(int arg0, char arg1)
		{
			return Instance.CallMethod<StringBuilder>("insert", "(IC)Ljava/lang/StringBuilder;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/lang/StringBuilder;")]
		public StringBuilder appendCodePoint(int arg0)
		{
			return Instance.CallMethod<StringBuilder>("appendCodePoint", "(I)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/StringBuilder;")]
		public StringBuilder deleteCharAt(int arg0)
		{
			return Instance.CallMethod<StringBuilder>("deleteCharAt", "(I)Ljava/lang/StringBuilder;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/StringBuilder;")]
		public StringBuilder reverse()
		{
			return Instance.CallMethod<StringBuilder>("reverse", "()Ljava/lang/StringBuilder;");
		}
		
		[JavaSignature("(I)C")]
		public char charAt(int arg0)
		{
			return Instance.CallMethod<char>("charAt", "(I)C", arg0);
		}
		
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("(II)Ljava/lang/CharSequence;")]
		public CharSequence subSequence(int arg0, int arg1)
		{
			return Instance.CallMethod<CharSequence>("subSequence", "(II)Ljava/lang/CharSequence;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream chars()
		{
			return Instance.CallMethod<IntStream>("chars", "()Ljava/util/stream/IntStream;");
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream codePoints()
		{
			return Instance.CallMethod<IntStream>("codePoints", "()Ljava/util/stream/IntStream;");
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;")]
		Appendable Appendable.append(CharSequence arg0)
		{
			return Instance.CallMethod<Appendable>("append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;")]
		Appendable Appendable.append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<Appendable>("append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(C)Ljava/lang/Appendable;")]
		Appendable Appendable.append(char arg0)
		{
			return Instance.CallMethod<Appendable>("append", "(C)Ljava/lang/Appendable;", arg0);
		}
	}
}
