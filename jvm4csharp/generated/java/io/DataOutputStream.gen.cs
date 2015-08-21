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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/DataOutputStream")]
	public partial class DataOutputStream : FilterOutputStream, DataOutput
	{
		protected DataOutputStream(ProxyCtor p) : base(p) {}
		
		public DataOutputStream(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
	
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void writeInt(int arg0)
		{
			Instance.CallMethod("writeInt", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeChar(int arg0)
		{
			Instance.CallMethod("writeChar", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeBytes(String arg0)
		{
			Instance.CallMethod("writeBytes", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeUTF(String arg0)
		{
			Instance.CallMethod("writeUTF", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(F)V")]
		public void writeFloat(float arg0)
		{
			Instance.CallMethod("writeFloat", "(F)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void writeLong(long arg0)
		{
			Instance.CallMethod("writeLong", "(J)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeShort(int arg0)
		{
			Instance.CallMethod("writeShort", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeByte(int arg0)
		{
			Instance.CallMethod("writeByte", "(I)V", arg0);
		}
		
		[JavaSignature("(D)V")]
		public void writeDouble(double arg0)
		{
			Instance.CallMethod("writeDouble", "(D)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void writeBoolean(bool arg0)
		{
			Instance.CallMethod("writeBoolean", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeChars(String arg0)
		{
			Instance.CallMethod("writeChars", "(Ljava/lang/String;)V", arg0);
		}
	}
}
