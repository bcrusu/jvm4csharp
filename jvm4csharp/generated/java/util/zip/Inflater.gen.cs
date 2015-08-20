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
	[JavaProxy("java/util/zip/Inflater")]
	public partial class Inflater : Object
	{
		protected Inflater(ProxyCtor p) : base(p) {}
		
		public Inflater(bool arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Z)V", arg0);
		}
		
		public Inflater() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
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
		public int getRemaining()
		{
			return Instance.CallMethod<int>("getRemaining", "()I");
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
		
		[JavaSignature("([B)I")]
		public int inflate(ByteArray arg0)
		{
			return Instance.CallMethod<int>("inflate", "([B)I", arg0);
		}
		
		[JavaSignature("([BII)I")]
		public int inflate(ByteArray arg0, int arg1, int arg2)
		{
			return Instance.CallMethod<int>("inflate", "([BII)I", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Z")]
		public bool needsDictionary()
		{
			return Instance.CallMethod<bool>("needsDictionary", "()Z");
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
	}
}
