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
	[JavaProxy("java/text/CharacterIterator")]
	public partial interface CharacterIterator : Cloneable
	{
		[JavaSignature("()Ljava/lang/Object;")]
		IJavaObject clone();
		
		[JavaSignature("()C")]
		char next();
		
		[JavaSignature("()C")]
		char first();
		
		[JavaSignature("()C")]
		char previous();
		
		[JavaSignature("()C")]
		char current();
		
		[JavaSignature("()I")]
		int getIndex();
		
		[JavaSignature("()C")]
		char last();
		
		[JavaSignature("()I")]
		int getBeginIndex();
		
		[JavaSignature("()I")]
		int getEndIndex();
		
		[JavaSignature("(I)C")]
		char setIndex(int arg0);
	}
	
	public static partial class CharacterIterator_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("C")]
		public static char DONE
		{
			get { return Static.GetField<char>(typeof(CharacterIterator), "DONE", "C"); }
		}
	
	}
}
