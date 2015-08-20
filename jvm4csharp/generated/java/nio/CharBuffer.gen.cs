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
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.nio
{
	[JavaProxy("java/nio/CharBuffer")]
	public abstract partial class CharBuffer : Buffer, Comparable<CharBuffer>, Appendable, CharSequence, Readable
	{
		protected CharBuffer(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(I)C")]
		public char @get(int arg0)
		{
			return Instance.CallMethod<char>("get", "(I)C", arg0);
		}
		
		[JavaSignature("()C")]
		public char @get()
		{
			return Instance.CallMethod<char>("get", "()C");
		}
		
		[JavaSignature("([CII)Ljava/nio/CharBuffer;")]
		public CharBuffer @get(CharArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<CharBuffer>("get", "([CII)Ljava/nio/CharBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([C)Ljava/nio/CharBuffer;")]
		public CharBuffer @get(CharArray arg0)
		{
			return Instance.CallMethod<CharBuffer>("get", "([C)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;II)Ljava/nio/CharBuffer;")]
		public CharBuffer put(String arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<CharBuffer>("put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(C)Ljava/nio/CharBuffer;")]
		public CharBuffer put(char arg0)
		{
			return Instance.CallMethod<CharBuffer>("put", "(C)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("([CII)Ljava/nio/CharBuffer;")]
		public CharBuffer put(CharArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<CharBuffer>("put", "([CII)Ljava/nio/CharBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(IC)Ljava/nio/CharBuffer;")]
		public CharBuffer put(int arg0, char arg1)
		{
			return Instance.CallMethod<CharBuffer>("put", "(IC)Ljava/nio/CharBuffer;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;")]
		public CharBuffer put(CharBuffer arg0)
		{
			return Instance.CallMethod<CharBuffer>("put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("([C)Ljava/nio/CharBuffer;")]
		public CharBuffer put(CharArray arg0)
		{
			return Instance.CallMethod<CharBuffer>("put", "([C)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/nio/CharBuffer;")]
		public CharBuffer put(String arg0)
		{
			return Instance.CallMethod<CharBuffer>("put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;")]
		public CharBuffer append(CharSequence arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<CharBuffer>("append", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(C)Ljava/nio/CharBuffer;")]
		public CharBuffer append(char arg0)
		{
			return Instance.CallMethod<CharBuffer>("append", "(C)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;")]
		public CharBuffer append(CharSequence arg0)
		{
			return Instance.CallMethod<CharBuffer>("append", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;)I")]
		public int compareTo(CharBuffer arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/nio/CharBuffer;)I", arg0);
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
		
		[JavaSignature("(II)Ljava/nio/CharBuffer;")]
		public CharBuffer subSequence(int arg0, int arg1)
		{
			return Instance.CallMethod<CharBuffer>("subSequence", "(II)Ljava/nio/CharBuffer;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream chars()
		{
			return Instance.CallMethod<IntStream>("chars", "()Ljava/util/stream/IntStream;");
		}
		
		[JavaSignature("()[C")]
		public new CharArray array()
		{
			return Instance.CallMethod<CharArray>("array", "()[C");
		}
		
		[JavaSignature("(Ljava/nio/CharBuffer;)I")]
		public int read(CharBuffer arg0)
		{
			return Instance.CallMethod<int>("read", "(Ljava/nio/CharBuffer;)I", arg0);
		}
		
		[JavaSignature("([CII)Ljava/nio/CharBuffer;")]
		public static CharBuffer wrap(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<CharBuffer>(typeof(CharBuffer), "wrap", "([CII)Ljava/nio/CharBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;")]
		public static CharBuffer wrap(CharSequence arg0)
		{
			return Static.CallMethod<CharBuffer>(typeof(CharBuffer), "wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;")]
		public static CharBuffer wrap(CharSequence arg0, int arg1, int arg2)
		{
			return Static.CallMethod<CharBuffer>(typeof(CharBuffer), "wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([C)Ljava/nio/CharBuffer;")]
		public static CharBuffer wrap(CharArray arg0)
		{
			return Static.CallMethod<CharBuffer>(typeof(CharBuffer), "wrap", "([C)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("(I)Ljava/nio/CharBuffer;")]
		public static CharBuffer allocate(int arg0)
		{
			return Static.CallMethod<CharBuffer>(typeof(CharBuffer), "allocate", "(I)Ljava/nio/CharBuffer;", arg0);
		}
		
		[JavaSignature("()Ljava/nio/CharBuffer;")]
		public CharBuffer duplicate()
		{
			return Instance.CallMethod<CharBuffer>("duplicate", "()Ljava/nio/CharBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/CharBuffer;")]
		public CharBuffer asReadOnlyBuffer()
		{
			return Instance.CallMethod<CharBuffer>("asReadOnlyBuffer", "()Ljava/nio/CharBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/CharBuffer;")]
		public CharBuffer compact()
		{
			return Instance.CallMethod<CharBuffer>("compact", "()Ljava/nio/CharBuffer;");
		}
		
		[JavaSignature("()Ljava/nio/ByteOrder;")]
		public ByteOrder order()
		{
			return Instance.CallMethod<ByteOrder>("order", "()Ljava/nio/ByteOrder;");
		}
		
		[JavaSignature("()Ljava/nio/CharBuffer;")]
		public CharBuffer slice()
		{
			return Instance.CallMethod<CharBuffer>("slice", "()Ljava/nio/CharBuffer;");
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
		
		[JavaSignature("(II)Ljava/lang/CharSequence;")]
		CharSequence CharSequence.subSequence(int arg0, int arg1)
		{
			return Instance.CallMethod<CharSequence>("subSequence", "(II)Ljava/lang/CharSequence;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/stream/IntStream;")]
		public IntStream codePoints()
		{
			return Instance.CallMethod<IntStream>("codePoints", "()Ljava/util/stream/IntStream;");
		}
	}
}
