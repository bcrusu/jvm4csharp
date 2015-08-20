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
namespace jvm4csharp.java.nio.charset
{
	[JavaProxy("java/nio/charset/UnmappableCharacterException")]
	public partial class UnmappableCharacterException : CharacterCodingException
	{
		protected UnmappableCharacterException(ProxyCtor p) : base(p) {}
		
		public UnmappableCharacterException(int arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(I)V", arg0);
		}
	
		[JavaSignature("()I")]
		public int getInputLength()
		{
			return Instance.CallMethod<int>("getInputLength", "()I");
		}
	}
}
