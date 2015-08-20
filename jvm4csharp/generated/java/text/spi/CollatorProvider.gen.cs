//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util;
using jvm4csharp.java.util.spi;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.text.spi
{
	[JavaProxy("java/text/spi/CollatorProvider")]
	public abstract partial class CollatorProvider : LocaleServiceProvider
	{
		protected CollatorProvider(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/util/Locale;)Ljava/text/Collator;")]
		public Collator getInstance(Locale arg0)
		{
			return Instance.CallMethod<Collator>("getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;", arg0);
		}
	}
}
