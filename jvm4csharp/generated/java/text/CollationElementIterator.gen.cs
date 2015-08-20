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
	[JavaProxy("java/text/CollationElementIterator")]
	public partial class CollationElementIterator : Object
	{
		protected CollationElementIterator(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int NULLORDER
		{
			get { return Static.GetField<int>(typeof(CollationElementIterator), "NULLORDER", "I"); }
		}
	
		[JavaSignature("()I")]
		public int next()
		{
			return Instance.CallMethod<int>("next", "()I");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("()I")]
		public int getOffset()
		{
			return Instance.CallMethod<int>("getOffset", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void setOffset(int arg0)
		{
			Instance.CallMethod("setOffset", "(I)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int previous()
		{
			return Instance.CallMethod<int>("previous", "()I");
		}
		
		[JavaSignature("(I)I")]
		public static int primaryOrder(int arg0)
		{
			return Static.CallMethod<int>(typeof(CollationElementIterator), "primaryOrder", "(I)I", arg0);
		}
		
		[JavaSignature("(I)S")]
		public static short secondaryOrder(int arg0)
		{
			return Static.CallMethod<short>(typeof(CollationElementIterator), "secondaryOrder", "(I)S", arg0);
		}
		
		[JavaSignature("(I)S")]
		public static short tertiaryOrder(int arg0)
		{
			return Static.CallMethod<short>(typeof(CollationElementIterator), "tertiaryOrder", "(I)S", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int getMaxExpansion(int arg0)
		{
			return Instance.CallMethod<int>("getMaxExpansion", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setText(String arg0)
		{
			Instance.CallMethod("setText", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/text/CharacterIterator;)V")]
		public void setText(CharacterIterator arg0)
		{
			Instance.CallMethod("setText", "(Ljava/text/CharacterIterator;)V", arg0);
		}
	}
}
