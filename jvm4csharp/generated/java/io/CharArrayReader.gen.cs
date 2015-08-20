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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/CharArrayReader")]
	public partial class CharArrayReader : Reader
	{
		protected CharArrayReader(ProxyCtor p) : base(p) {}
		
		public CharArrayReader(CharArray arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([C)V", arg0);
		}
		
		public CharArrayReader(CharArray arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([CII)V", arg0, arg1, arg2);
		}
	}
}
