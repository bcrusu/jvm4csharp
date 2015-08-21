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
	[JavaProxy("java/text/DecimalFormat")]
	public partial class DecimalFormat : NumberFormat
	{
		protected DecimalFormat(ProxyCtor p) : base(p) {}
		
		public DecimalFormat(String arg0, DecimalFormatSymbols arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V", arg0, arg1);
		}
		
		public DecimalFormat(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public DecimalFormat() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()I")]
		public int getGroupingSize()
		{
			return Instance.CallMethod<int>("getGroupingSize", "()I");
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
		
		[JavaSignature("()I")]
		public int getMultiplier()
		{
			return Instance.CallMethod<int>("getMultiplier", "()I");
		}
		
		[JavaSignature("()Z")]
		public bool isDecimalSeparatorAlwaysShown()
		{
			return Instance.CallMethod<bool>("isDecimalSeparatorAlwaysShown", "()Z");
		}
		
		[JavaSignature("()Z")]
		public bool isParseBigDecimal()
		{
			return Instance.CallMethod<bool>("isParseBigDecimal", "()Z");
		}
		
		[JavaSignature("(Ljava/text/DecimalFormatSymbols;)V")]
		public void setDecimalFormatSymbols(DecimalFormatSymbols arg0)
		{
			Instance.CallMethod("setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setDecimalSeparatorAlwaysShown(bool arg0)
		{
			Instance.CallMethod("setDecimalSeparatorAlwaysShown", "(Z)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setGroupingSize(int arg0)
		{
			Instance.CallMethod("setGroupingSize", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMultiplier(int arg0)
		{
			Instance.CallMethod("setMultiplier", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setNegativePrefix(String arg0)
		{
			Instance.CallMethod("setNegativePrefix", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setNegativeSuffix(String arg0)
		{
			Instance.CallMethod("setNegativeSuffix", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void setParseBigDecimal(bool arg0)
		{
			Instance.CallMethod("setParseBigDecimal", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setPositivePrefix(String arg0)
		{
			Instance.CallMethod("setPositivePrefix", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setPositiveSuffix(String arg0)
		{
			Instance.CallMethod("setPositiveSuffix", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getNegativePrefix()
		{
			return Instance.CallMethod<String>("getNegativePrefix", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getNegativeSuffix()
		{
			return Instance.CallMethod<String>("getNegativeSuffix", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPositivePrefix()
		{
			return Instance.CallMethod<String>("getPositivePrefix", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getPositiveSuffix()
		{
			return Instance.CallMethod<String>("getPositiveSuffix", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void applyLocalizedPattern(String arg0)
		{
			Instance.CallMethod("applyLocalizedPattern", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/text/DecimalFormatSymbols;")]
		public DecimalFormatSymbols getDecimalFormatSymbols()
		{
			return Instance.CallMethod<DecimalFormatSymbols>("getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toLocalizedPattern()
		{
			return Instance.CallMethod<String>("toLocalizedPattern", "()Ljava/lang/String;");
		}
	}
}
