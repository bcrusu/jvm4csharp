//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/IllegalFormatWidthException")]
	public partial class IllegalFormatWidthException : IllegalFormatException
	{
		protected IllegalFormatWidthException(ProxyCtor p) : base(p) {}
		
		public IllegalFormatWidthException(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()I")]
		public int getWidth()
		{
			return Instance.CallMethod<int>("getWidth", "()I");
		}
	}
}
