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
namespace jvm4csharp.java.util.spi
{
	[JavaProxy("java/util/spi/ResourceBundleControlProvider")]
	public partial interface ResourceBundleControlProvider : IJavaObject
	{
		[JavaSignature("(Ljava/lang/String;)Ljava/util/ResourceBundle/Control;")]
		ResourceBundle_.Control getControl(String arg0);
	}
}
