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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/OptionalDataException")]
	public class OptionalDataException : ObjectStreamException
	{
		protected OptionalDataException(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public int length
		{
			get { return Instance.GetField<int>("length", "I"); }
			set { Instance.SetField("length", "I", value); }
		}
		
		[JavaSignature("Z")]
		public bool eof
		{
			get { return Instance.GetField<bool>("eof", "Z"); }
			set { Instance.SetField("eof", "Z", value); }
		}
	}
}
