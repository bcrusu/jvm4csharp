//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/PropertyResourceBundle")]
	public partial class PropertyResourceBundle : ResourceBundle
	{
		protected PropertyResourceBundle(ProxyCtor p) : base(p) {}
		
		public PropertyResourceBundle(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public PropertyResourceBundle(Reader arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/Reader;)V", arg0);
		}
	}
}
