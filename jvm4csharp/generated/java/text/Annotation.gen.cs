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
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/Annotation")]
	public partial class Annotation : Object
	{
		protected Annotation(ProxyCtor p) : base(p) {}
		
		public Annotation(IJavaObject arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/Object;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject getValue()
		{
			return Instance.CallMethod<IJavaObject>("getValue", "()Ljava/lang/Object;");
		}
	}
}
