//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.util.function;
using jvm4csharp.java.util.stream;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/AbstractSet")]
	public abstract class AbstractSet<E> : AbstractCollection<E>, Set<E>
		where E : IJavaObject
	{
		protected AbstractSet(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<E> stream()
		{
			return Instance.CallMethod<Stream<E>>("stream", "()Ljava/util/stream/Stream;");
		}
		
		[JavaSignature("(Ljava/util/function/Predicate;)Z")]
		public bool removeIf(Predicate<IJavaObject> arg0)
		{
			return Instance.CallMethod<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
		}
		
		[JavaSignature("()Ljava/util/stream/Stream;")]
		public Stream<E> parallelStream()
		{
			return Instance.CallMethod<Stream<E>>("parallelStream", "()Ljava/util/stream/Stream;");
		}
	}
}
