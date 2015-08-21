//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/ByteArrayOutputStream")]
	public partial class ByteArrayOutputStream : OutputStream
	{
		protected ByteArrayOutputStream(ProxyCtor p) : base(p) {}
		
		public ByteArrayOutputStream() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public ByteArrayOutputStream(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/String;")]
		public String toString(String arg0)
		{
			return Instance.CallMethod<String>("toString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(I)Ljava/lang/String;")]
		public String toString(int arg0)
		{
			return Instance.CallMethod<String>("toString", "(I)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()I")]
		public int size()
		{
			return Instance.CallMethod<int>("size", "()I");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("()[B")]
		public ByteArray toByteArray()
		{
			return Instance.CallMethod<ByteArray>("toByteArray", "()[B");
		}
		
		[JavaSignature("(Ljava/io/OutputStream;)V")]
		public void writeTo(OutputStream arg0)
		{
			Instance.CallMethod("writeTo", "(Ljava/io/OutputStream;)V", arg0);
		}
	}
}
