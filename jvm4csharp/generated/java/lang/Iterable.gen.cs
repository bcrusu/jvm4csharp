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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Iterable")]
	public partial interface Iterable<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("()Ljava/util/Iterator;")]
		Iterator<T> iterator();
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		Spliterator<T> spliterator();
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		void forEach(Consumer<IJavaObject> arg0);
	}
}
