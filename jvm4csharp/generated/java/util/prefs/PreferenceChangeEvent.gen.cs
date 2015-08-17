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
namespace jvm4csharp.java.util.prefs
{
	[JavaProxy("java/util/prefs/PreferenceChangeEvent")]
	public class PreferenceChangeEvent : EventObject
	{
		protected PreferenceChangeEvent(ProxyCtor p) : base(p) {}
		
		public PreferenceChangeEvent(Preferences arg0, String arg1, String arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/prefs/Preferences;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getKey()
		{
			return Instance.CallMethod<String>("getKey", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		public Preferences getNode()
		{
			return Instance.CallMethod<Preferences>("getNode", "()Ljava/util/prefs/Preferences;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getNewValue()
		{
			return Instance.CallMethod<String>("getNewValue", "()Ljava/lang/String;");
		}
	}
}
