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
namespace jvm4csharp.java.nio.channels
{
	[JavaProxy("java/nio/channels/UnsupportedAddressTypeException")]
	public partial class UnsupportedAddressTypeException : IllegalArgumentException
	{
		protected UnsupportedAddressTypeException(ProxyCtor p) : base(p) {}
		
		public UnsupportedAddressTypeException() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	}
}
