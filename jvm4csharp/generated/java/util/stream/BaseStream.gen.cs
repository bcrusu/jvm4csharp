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
namespace jvm4csharp.java.util.stream
{
	[JavaProxy("java/util/stream/BaseStream")]
	public partial interface BaseStream<T, S> : AutoCloseable
		where T : IJavaObject
		where S : BaseStream<T, S>
	{
		[JavaSignature("()Ljava/util/Iterator;")]
		Iterator<T> iterator();
		
		[JavaSignature("()Ljava/util/Spliterator;")]
		Spliterator<T> spliterator();
		
		[JavaSignature("()V")]
		new void close();
		
		[JavaSignature("()Ljava/util/stream/BaseStream;")]
		S parallel();
		
		[JavaSignature("()Z")]
		bool isParallel();
		
		[JavaSignature("()Ljava/util/stream/BaseStream;")]
		S unordered();
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/stream/BaseStream;")]
		S onClose(Runnable arg0);
		
		[JavaSignature("()Ljava/util/stream/BaseStream;")]
		S sequential();
	}
}
