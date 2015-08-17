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
using jvm4csharp.java.math;
using jvm4csharp.java.nio.channels;
using jvm4csharp.java.nio.file;
using jvm4csharp.java.util.function;
using jvm4csharp.java.util.regex;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Scanner")]
	public class Scanner : Object, Iterator<String>, Closeable
	{
		protected Scanner(ProxyCtor p) : base(p) {}
		
		public Scanner(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public Scanner(Readable arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Readable;)V", arg0);
		}
		
		public Scanner(InputStream arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Scanner(File arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Scanner(File arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/File;)V", arg0);
		}
		
		public Scanner(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Scanner(ReadableByteChannel arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/nio/channels/ReadableByteChannel;)V", arg0);
		}
		
		public Scanner(ReadableByteChannel arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Scanner(Path arg0, String arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/nio/file/Path;Ljava/lang/String;)V", arg0, arg1);
		}
		
		public Scanner(Path arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/nio/file/Path;)V", arg0);
		}
	
		[JavaSignature("()V")]
		public void @remove()
		{
			Instance.CallMethod("remove", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool hasNext()
		{
			return Instance.CallMethod<bool>("hasNext", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool hasNext(String arg0)
		{
			return Instance.CallMethod<bool>("hasNext", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/regex/Pattern;)Z")]
		public bool hasNext(Pattern arg0)
		{
			return Instance.CallMethod<bool>("hasNext", "(Ljava/util/regex/Pattern;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String next(String arg0)
		{
			return Instance.CallMethod<String>("next", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/util/regex/Pattern;)Ljava/lang/String;")]
		public String next(Pattern arg0)
		{
			return Instance.CallMethod<String>("next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String next()
		{
			return Instance.CallMethod<String>("next", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()V")]
		public void close()
		{
			Instance.CallMethod("close", "()V");
		}
		
		[JavaSignature("()Ljava/util/Scanner;")]
		public Scanner reset()
		{
			return Instance.CallMethod<Scanner>("reset", "()Ljava/util/Scanner;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Scanner;")]
		public Scanner skip(String arg0)
		{
			return Instance.CallMethod<Scanner>("skip", "(Ljava/lang/String;)Ljava/util/Scanner;", arg0);
		}
		
		[JavaSignature("(Ljava/util/regex/Pattern;)Ljava/util/Scanner;")]
		public Scanner skip(Pattern arg0)
		{
			return Instance.CallMethod<Scanner>("skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", arg0);
		}
		
		[JavaSignature("()D")]
		public double nextDouble()
		{
			return Instance.CallMethod<double>("nextDouble", "()D");
		}
		
		[JavaSignature("()I")]
		public int nextInt()
		{
			return Instance.CallMethod<int>("nextInt", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int nextInt(int arg0)
		{
			return Instance.CallMethod<int>("nextInt", "(I)I", arg0);
		}
		
		[JavaSignature("()Ljava/util/regex/MatchResult;")]
		public MatchResult match()
		{
			return Instance.CallMethod<MatchResult>("match", "()Ljava/util/regex/MatchResult;");
		}
		
		[JavaSignature("()Ljava/util/Locale;")]
		public Locale locale()
		{
			return Instance.CallMethod<Locale>("locale", "()Ljava/util/Locale;");
		}
		
		[JavaSignature("()Ljava/io/IOException;")]
		public IOException ioException()
		{
			return Instance.CallMethod<IOException>("ioException", "()Ljava/io/IOException;");
		}
		
		[JavaSignature("()Z")]
		public bool nextBoolean()
		{
			return Instance.CallMethod<bool>("nextBoolean", "()Z");
		}
		
		[JavaSignature("()F")]
		public float nextFloat()
		{
			return Instance.CallMethod<float>("nextFloat", "()F");
		}
		
		[JavaSignature("()J")]
		public long nextLong()
		{
			return Instance.CallMethod<long>("nextLong", "()J");
		}
		
		[JavaSignature("(I)J")]
		public long nextLong(int arg0)
		{
			return Instance.CallMethod<long>("nextLong", "(I)J", arg0);
		}
		
		[JavaSignature("()Ljava/util/regex/Pattern;")]
		public Pattern delimiter()
		{
			return Instance.CallMethod<Pattern>("delimiter", "()Ljava/util/regex/Pattern;");
		}
		
		[JavaSignature("(Ljava/util/regex/Pattern;)Ljava/lang/String;")]
		public String findInLine(Pattern arg0)
		{
			return Instance.CallMethod<String>("findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String findInLine(String arg0)
		{
			return Instance.CallMethod<String>("findInLine", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(Ljava/util/regex/Pattern;I)Ljava/lang/String;")]
		public String findWithinHorizon(Pattern arg0, int arg1)
		{
			return Instance.CallMethod<String>("findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;I)Ljava/lang/String;")]
		public String findWithinHorizon(String arg0, int arg1)
		{
			return Instance.CallMethod<String>("findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool hasNextBigDecimal()
		{
			return Instance.CallMethod<bool>("hasNextBigDecimal", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasNextBigInteger()
		{
			return Instance.CallMethod<bool>("hasNextBigInteger", "()Z");
		}
		
		[JavaSignature("(I)Z")]
		public bool hasNextBigInteger(int arg0)
		{
			return Instance.CallMethod<bool>("hasNextBigInteger", "(I)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool hasNextBoolean()
		{
			return Instance.CallMethod<bool>("hasNextBoolean", "()Z");
		}
		
		[JavaSignature("(I)Z")]
		public bool hasNextByte(int arg0)
		{
			return Instance.CallMethod<bool>("hasNextByte", "(I)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool hasNextByte()
		{
			return Instance.CallMethod<bool>("hasNextByte", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasNextDouble()
		{
			return Instance.CallMethod<bool>("hasNextDouble", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasNextFloat()
		{
			return Instance.CallMethod<bool>("hasNextFloat", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasNextInt()
		{
			return Instance.CallMethod<bool>("hasNextInt", "()Z");
		}
		
		[JavaSignature("(I)Z")]
		public bool hasNextInt(int arg0)
		{
			return Instance.CallMethod<bool>("hasNextInt", "(I)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool hasNextLine()
		{
			return Instance.CallMethod<bool>("hasNextLine", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool hasNextLong()
		{
			return Instance.CallMethod<bool>("hasNextLong", "()Z");
		}
		
		[JavaSignature("(I)Z")]
		public bool hasNextLong(int arg0)
		{
			return Instance.CallMethod<bool>("hasNextLong", "(I)Z", arg0);
		}
		
		[JavaSignature("(I)Z")]
		public bool hasNextShort(int arg0)
		{
			return Instance.CallMethod<bool>("hasNextShort", "(I)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool hasNextShort()
		{
			return Instance.CallMethod<bool>("hasNextShort", "()Z");
		}
		
		[JavaSignature("()Ljava/math/BigDecimal;")]
		public BigDecimal nextBigDecimal()
		{
			return Instance.CallMethod<BigDecimal>("nextBigDecimal", "()Ljava/math/BigDecimal;");
		}
		
		[JavaSignature("(I)Ljava/math/BigInteger;")]
		public BigInteger nextBigInteger(int arg0)
		{
			return Instance.CallMethod<BigInteger>("nextBigInteger", "(I)Ljava/math/BigInteger;", arg0);
		}
		
		[JavaSignature("()Ljava/math/BigInteger;")]
		public BigInteger nextBigInteger()
		{
			return Instance.CallMethod<BigInteger>("nextBigInteger", "()Ljava/math/BigInteger;");
		}
		
		[JavaSignature("(I)B")]
		public byte nextByte(int arg0)
		{
			return Instance.CallMethod<byte>("nextByte", "(I)B", arg0);
		}
		
		[JavaSignature("()B")]
		public byte nextByte()
		{
			return Instance.CallMethod<byte>("nextByte", "()B");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String nextLine()
		{
			return Instance.CallMethod<String>("nextLine", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()S")]
		public short nextShort()
		{
			return Instance.CallMethod<short>("nextShort", "()S");
		}
		
		[JavaSignature("(I)S")]
		public short nextShort(int arg0)
		{
			return Instance.CallMethod<short>("nextShort", "(I)S", arg0);
		}
		
		[JavaSignature("()I")]
		public int radix()
		{
			return Instance.CallMethod<int>("radix", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/Scanner;")]
		public Scanner useDelimiter(String arg0)
		{
			return Instance.CallMethod<Scanner>("useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;", arg0);
		}
		
		[JavaSignature("(Ljava/util/regex/Pattern;)Ljava/util/Scanner;")]
		public Scanner useDelimiter(Pattern arg0)
		{
			return Instance.CallMethod<Scanner>("useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/util/Scanner;")]
		public Scanner useLocale(Locale arg0)
		{
			return Instance.CallMethod<Scanner>("useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;", arg0);
		}
		
		[JavaSignature("(I)Ljava/util/Scanner;")]
		public Scanner useRadix(int arg0)
		{
			return Instance.CallMethod<Scanner>("useRadix", "(I)Ljava/util/Scanner;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		public void forEachRemaining(Consumer<IJavaObject> arg0)
		{
			Instance.CallMethod("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
		}
	}
}
