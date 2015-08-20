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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/Bidi")]
	public partial class Bidi : Object
	{
		protected Bidi(ProxyCtor p) : base(p) {}
		
		public Bidi(CharArray arg0, int arg1, ByteArray arg2, int arg3, int arg4, int arg5) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([CI[BIII)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		public Bidi(AttributedCharacterIterator arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/text/AttributedCharacterIterator;)V", arg0);
		}
		
		public Bidi(String arg0, int arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;I)V", arg0, arg1);
		}
	
		[JavaSignature("I")]
		public static int DIRECTION_LEFT_TO_RIGHT
		{
			get { return Static.GetField<int>(typeof(Bidi), "DIRECTION_LEFT_TO_RIGHT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DIRECTION_RIGHT_TO_LEFT
		{
			get { return Static.GetField<int>(typeof(Bidi), "DIRECTION_RIGHT_TO_LEFT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DIRECTION_DEFAULT_LEFT_TO_RIGHT
		{
			get { return Static.GetField<int>(typeof(Bidi), "DIRECTION_DEFAULT_LEFT_TO_RIGHT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DIRECTION_DEFAULT_RIGHT_TO_LEFT
		{
			get { return Static.GetField<int>(typeof(Bidi), "DIRECTION_DEFAULT_RIGHT_TO_LEFT", "I"); }
		}
	
		[JavaSignature("()I")]
		public int getLength()
		{
			return Instance.CallMethod<int>("getLength", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int getRunLimit(int arg0)
		{
			return Instance.CallMethod<int>("getRunLimit", "(I)I", arg0);
		}
		
		[JavaSignature("(I)I")]
		public int getRunStart(int arg0)
		{
			return Instance.CallMethod<int>("getRunStart", "(I)I", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool baseIsLeftToRight()
		{
			return Instance.CallMethod<bool>("baseIsLeftToRight", "()Z");
		}
		
		[JavaSignature("(II)Ljava/text/Bidi;")]
		public Bidi createLineBidi(int arg0, int arg1)
		{
			return Instance.CallMethod<Bidi>("createLineBidi", "(II)Ljava/text/Bidi;", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int getBaseLevel()
		{
			return Instance.CallMethod<int>("getBaseLevel", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int getLevelAt(int arg0)
		{
			return Instance.CallMethod<int>("getLevelAt", "(I)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int getRunCount()
		{
			return Instance.CallMethod<int>("getRunCount", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int getRunLevel(int arg0)
		{
			return Instance.CallMethod<int>("getRunLevel", "(I)I", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isLeftToRight()
		{
			return Instance.CallMethod<bool>("isLeftToRight", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isMixed()
		{
			return Instance.CallMethod<bool>("isMixed", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isRightToLeft()
		{
			return Instance.CallMethod<bool>("isRightToLeft", "()Z");
		}
		
		[JavaSignature("([BI[Ljava/lang/Object;II)V")]
		public static void reorderVisually(ByteArray arg0, int arg1, ObjectArray<IJavaObject> arg2, int arg3, int arg4)
		{
			Static.CallMethod(typeof(Bidi), "reorderVisually", "([BI[Ljava/lang/Object;II)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("([CII)Z")]
		public static bool requiresBidi(CharArray arg0, int arg1, int arg2)
		{
			return Static.CallMethod<bool>(typeof(Bidi), "requiresBidi", "([CII)Z", arg0, arg1, arg2);
		}
	}
}
