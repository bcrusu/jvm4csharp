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
	[JavaProxy("java/util/prefs/NodeChangeEvent")]
	public class NodeChangeEvent : EventObject
	{
		protected NodeChangeEvent(ProxyCtor p) : base(p) {}
		
		public NodeChangeEvent(Preferences arg0, Preferences arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/prefs/Preferences;Ljava/util/prefs/Preferences;)V", arg0, arg1);
		}
	
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		public Preferences getParent()
		{
			return Instance.CallMethod<Preferences>("getParent", "()Ljava/util/prefs/Preferences;");
		}
		
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		public Preferences getChild()
		{
			return Instance.CallMethod<Preferences>("getChild", "()Ljava/util/prefs/Preferences;");
		}
	}
}
