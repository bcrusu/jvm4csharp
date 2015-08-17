//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/StringJoiner")]
	public class StringJoiner : Object
	{
		protected StringJoiner(ProxyCtor p) : base(p) {}
		
		public StringJoiner(CharSequence arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/CharSequence;)V", arg0);
		}
		
		public StringJoiner(CharSequence arg0, CharSequence arg1, CharSequence arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/util/StringJoiner;")]
		public StringJoiner @add(CharSequence arg0)
		{
			return Instance.CallMethod<StringJoiner>("add", "(Ljava/lang/CharSequence;)Ljava/util/StringJoiner;", arg0);
		}
		
		[JavaSignature("()I")]
		public int length()
		{
			return Instance.CallMethod<int>("length", "()I");
		}
		
		[JavaSignature("(Ljava/util/StringJoiner;)Ljava/util/StringJoiner;")]
		public StringJoiner merge(StringJoiner arg0)
		{
			return Instance.CallMethod<StringJoiner>("merge", "(Ljava/util/StringJoiner;)Ljava/util/StringJoiner;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/CharSequence;)Ljava/util/StringJoiner;")]
		public StringJoiner setEmptyValue(CharSequence arg0)
		{
			return Instance.CallMethod<StringJoiner>("setEmptyValue", "(Ljava/lang/CharSequence;)Ljava/util/StringJoiner;", arg0);
		}
	}
}
