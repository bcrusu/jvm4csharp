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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text
{
	[JavaProxy("java/text/ChoiceFormat")]
	public partial class ChoiceFormat : NumberFormat
	{
		protected ChoiceFormat(ProxyCtor p) : base(p) {}
		
		public ChoiceFormat(DoubleArray arg0, ObjectArray<String> arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([D[Ljava/lang/String;)V", arg0, arg1);
		}
		
		public ChoiceFormat(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("(DZ)D")]
		public static double nextDouble(double arg0, bool arg1)
		{
			return Static.CallMethod<double>(typeof(ChoiceFormat), "nextDouble", "(DZ)D", arg0, arg1);
		}
		
		[JavaSignature("(D)D")]
		public static double nextDouble(double arg0)
		{
			return Static.CallMethod<double>(typeof(ChoiceFormat), "nextDouble", "(D)D", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/Object;")]
		public ObjectArray<IJavaObject> getFormats()
		{
			return Instance.CallMethod<ObjectArray<IJavaObject>>("getFormats", "()[Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void applyPattern(String arg0)
		{
			Instance.CallMethod("applyPattern", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toPattern()
		{
			return Instance.CallMethod<String>("toPattern", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()[D")]
		public DoubleArray getLimits()
		{
			return Instance.CallMethod<DoubleArray>("getLimits", "()[D");
		}
		
		[JavaSignature("(D)D")]
		public static double previousDouble(double arg0)
		{
			return Static.CallMethod<double>(typeof(ChoiceFormat), "previousDouble", "(D)D", arg0);
		}
		
		[JavaSignature("([D[Ljava/lang/String;)V")]
		public void setChoices(DoubleArray arg0, ObjectArray<String> arg1)
		{
			Instance.CallMethod("setChoices", "([D[Ljava/lang/String;)V", arg0, arg1);
		}
	}
}
