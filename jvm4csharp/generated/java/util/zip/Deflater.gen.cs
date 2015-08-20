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
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/Deflater")]
	public partial class Deflater : Object
	{
		protected Deflater(ProxyCtor p) : base(p) {}
		
		public Deflater() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Deflater(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
		
		public Deflater(int arg0, bool arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IZ)V", arg0, arg1);
		}
	
		[JavaSignature("I")]
		public static int DEFLATED
		{
			get { return Static.GetField<int>(typeof(Deflater), "DEFLATED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NO_COMPRESSION
		{
			get { return Static.GetField<int>(typeof(Deflater), "NO_COMPRESSION", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BEST_SPEED
		{
			get { return Static.GetField<int>(typeof(Deflater), "BEST_SPEED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int BEST_COMPRESSION
		{
			get { return Static.GetField<int>(typeof(Deflater), "BEST_COMPRESSION", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DEFAULT_COMPRESSION
		{
			get { return Static.GetField<int>(typeof(Deflater), "DEFAULT_COMPRESSION", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FILTERED
		{
			get { return Static.GetField<int>(typeof(Deflater), "FILTERED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int HUFFMAN_ONLY
		{
			get { return Static.GetField<int>(typeof(Deflater), "HUFFMAN_ONLY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DEFAULT_STRATEGY
		{
			get { return Static.GetField<int>(typeof(Deflater), "DEFAULT_STRATEGY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int NO_FLUSH
		{
			get { return Static.GetField<int>(typeof(Deflater), "NO_FLUSH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int SYNC_FLUSH
		{
			get { return Static.GetField<int>(typeof(Deflater), "SYNC_FLUSH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int FULL_FLUSH
		{
			get { return Static.GetField<int>(typeof(Deflater), "FULL_FLUSH", "I"); }
		}
	
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("()Z")]
		public bool finished()
		{
			return Instance.CallMethod<bool>("finished", "()Z");
		}
		
		[JavaSignature("()I")]
		public int getAdler()
		{
			return Instance.CallMethod<int>("getAdler", "()I");
		}
		
		[JavaSignature("()J")]
		public long getBytesRead()
		{
			return Instance.CallMethod<long>("getBytesRead", "()J");
		}
		
		[JavaSignature("()J")]
		public long getBytesWritten()
		{
			return Instance.CallMethod<long>("getBytesWritten", "()J");
		}
		
		[JavaSignature("()I")]
		public int getTotalIn()
		{
			return Instance.CallMethod<int>("getTotalIn", "()I");
		}
		
		[JavaSignature("()I")]
		public int getTotalOut()
		{
			return Instance.CallMethod<int>("getTotalOut", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool needsInput()
		{
			return Instance.CallMethod<bool>("needsInput", "()Z");
		}
		
		[JavaSignature("([BII)V")]
		public void setDictionary(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("setDictionary", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)V")]
		public void setDictionary(ByteArray arg0)
		{
			Instance.CallMethod("setDictionary", "([B)V", arg0);
		}
		
		[JavaSignature("([B)V")]
		public void setInput(ByteArray arg0)
		{
			Instance.CallMethod("setInput", "([B)V", arg0);
		}
		
		[JavaSignature("([BII)V")]
		public void setInput(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("setInput", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("()V")]
		public void end()
		{
			Instance.CallMethod("end", "()V");
		}
		
		[JavaSignature("([B)I")]
		public int deflate(ByteArray arg0)
		{
			return Instance.CallMethod<int>("deflate", "([B)I", arg0);
		}
		
		[JavaSignature("([BIII)I")]
		public int deflate(ByteArray arg0, int arg1, int arg2, int arg3)
		{
			return Instance.CallMethod<int>("deflate", "([BIII)I", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("([BII)I")]
		public int deflate(ByteArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<int>("deflate", "([BII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("()V")]
		public void finish()
		{
			Instance.CallMethod("finish", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void setLevel(int arg0)
		{
			Instance.CallMethod("setLevel", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setStrategy(int arg0)
		{
			Instance.CallMethod("setStrategy", "(I)V", arg0);
		}
	}
}
