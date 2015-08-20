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
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/StringBuffer")]
	public partial class StringBuffer : Object, Serializable, CharSequence, Appendable
	{
		protected StringBuffer(ProxyCtor p) : base(p) {}
		
		public StringBuffer(CharSequence arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/CharSequence;)V", arg0);
		}
		
		public StringBuffer(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public StringBuffer(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public StringBuffer() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("(F)Ljava/lang/StringBuffer;")]
		public StringBuffer append(float arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(F)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(D)Ljava/lang/StringBuffer;")]
		public StringBuffer append(double arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(D)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(Z)Ljava/lang/StringBuffer;")]
		public StringBuffer append(bool arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(Z)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(C)Ljava/lang/StringBuffer;")]
		public StringBuffer append(char arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(C)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/StringBuffer;")]
		public StringBuffer append(int arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(I)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(J)Ljava/lang/StringBuffer;")]
		public StringBuffer append(long arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(J)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/StringBuffer;")]
		public StringBuffer append(IJavaObject arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/StringBuffer;")]
		public StringBuffer append(String arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;")]
		public StringBuffer append(CharSequence arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;")]
		public StringBuffer append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<StringBuffer>("append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([C)Ljava/lang/StringBuffer;")]
		public StringBuffer append(CharArray arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "([C)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("([CII)Ljava/lang/StringBuffer;")]
		public StringBuffer append(CharArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<StringBuffer>("append", "([CII)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;")]
		public StringBuffer append(StringBuffer arg0)
		{
			return Instance.CallMethod<StringBuffer>("append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(IILjava/lang/String;)Ljava/lang/StringBuffer;")]
		public StringBuffer replace(int arg0, int arg1, String arg2)
		{
			return Instance.CallMethod<StringBuffer>("replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(II)Ljava/lang/StringBuffer;")]
		public StringBuffer delete(int arg0, int arg1)
		{
			return Instance.CallMethod<StringBuffer>("delete", "(II)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, CharSequence arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, CharSequence arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(IZ)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, bool arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(IZ)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(IC)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, char arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(IC)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(II)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, int arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(II)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(IF)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, float arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(IF)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(ID)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, double arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(ID)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(I[CII)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, CharArray arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(I[CII)Ljava/lang/StringBuffer;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(ILjava/lang/Object;)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, IJavaObject arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(ILjava/lang/String;)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, String arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(I[C)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, CharArray arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(I[C)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(IJ)Ljava/lang/StringBuffer;")]
		public StringBuffer insert(int arg0, long arg1)
		{
			return Instance.CallMethod<StringBuffer>("insert", "(IJ)Ljava/lang/StringBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(I)Ljava/lang/StringBuffer;")]
		public StringBuffer appendCodePoint(int arg0)
		{
			return Instance.CallMethod<StringBuffer>("appendCodePoint", "(I)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/StringBuffer;")]
		public StringBuffer deleteCharAt(int arg0)
		{
			return Instance.CallMethod<StringBuffer>("deleteCharAt", "(I)Ljava/lang/StringBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/StringBuffer;")]
		public StringBuffer reverse()
		{
			return Instance.CallMethod<StringBuffer>("reverse", "()Ljava/lang/StringBuffer;");
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
