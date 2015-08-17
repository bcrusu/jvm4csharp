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
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/FormattableFlags")]
	public class FormattableFlags : Object
	{
		protected FormattableFlags(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int LEFT_JUSTIFY
		{
			get { return Static.GetField<int>(typeof(FormattableFlags), "LEFT_JUSTIFY", "I"); }
		}
		
		[JavaSignature("I")]
		public static int UPPERCASE
		{
			get { return Static.GetField<int>(typeof(FormattableFlags), "UPPERCASE", "I"); }
		}
		
		[JavaSignature("I")]
		public static int ALTERNATE
		{
			get { return Static.GetField<int>(typeof(FormattableFlags), "ALTERNATE", "I"); }
		}
	}
}
