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
namespace jvm4csharp.java.util.prefs
{
	[JavaProxy("java/util/prefs/PreferencesFactory")]
	public partial interface PreferencesFactory : IJavaObject
	{
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		Preferences systemRoot();
		
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		Preferences userRoot();
	}
}
