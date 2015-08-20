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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/EventObject")]
	public partial class EventObject : Object, Serializable
	{
		protected EventObject(ProxyCtor p) : base(p) {}
		
		public EventObject(IJavaObject arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Object;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject getSource()
		{
			return Instance.CallMethod<IJavaObject>("getSource", "()Ljava/lang/Object;");
		}
	}
}
