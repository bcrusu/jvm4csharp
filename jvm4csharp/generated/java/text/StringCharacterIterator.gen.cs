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
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/StringCharacterIterator")]
	public class StringCharacterIterator : Object, CharacterIterator
	{
		protected StringCharacterIterator(ProxyCtor p) : base(p) {}
		
		public StringCharacterIterator(String arg0, int arg1, int arg2, int arg3) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;III)V", arg0, arg1, arg2, arg3);
		}
		
		public StringCharacterIterator(String arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;I)V", arg0, arg1);
		}
		
		public StringCharacterIterator(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("()C")]
		public char next()
		{
			return Instance.CallMethod<char>("next", "()C");
		}
		
		[JavaSignature("()C")]
		public char first()
		{
			return Instance.CallMethod<char>("first", "()C");
		}
		
		[JavaSignature("()C")]
		public char previous()
		{
			return Instance.CallMethod<char>("previous", "()C");
		}
		
		[JavaSignature("()C")]
		public char last()
		{
			return Instance.CallMethod<char>("last", "()C");
		}
		
		[JavaSignature("()I")]
		public int getIndex()
		{
			return Instance.CallMethod<int>("getIndex", "()I");
		}
		
		[JavaSignature("()C")]
		public char current()
		{
			return Instance.CallMethod<char>("current", "()C");
		}
		
		[JavaSignature("()I")]
		public int getBeginIndex()
		{
			return Instance.CallMethod<int>("getBeginIndex", "()I");
		}
		
		[JavaSignature("()I")]
		public int getEndIndex()
		{
			return Instance.CallMethod<int>("getEndIndex", "()I");
		}
		
		[JavaSignature("(I)C")]
		public char setIndex(int arg0)
		{
			return Instance.CallMethod<char>("setIndex", "(I)C", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setText(String arg0)
		{
			Instance.CallMethod("setText", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject clone()
		{
			return Instance.CallMethod<IJavaObject>("clone", "()Ljava/lang/Object;");
		}
	}
}
