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
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/OptionalLong")]
	public partial class OptionalLong : Object
	{
		protected OptionalLong(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(J)Ljava/util/OptionalLong;")]
		public static OptionalLong of(long arg0)
		{
			return Static.CallMethod<OptionalLong>(typeof(OptionalLong), "of", "(J)Ljava/util/OptionalLong;", arg0);
		}
		
		[JavaSignature("()Ljava/util/OptionalLong;")]
		public static OptionalLong empty()
		{
			return Static.CallMethod<OptionalLong>(typeof(OptionalLong), "empty", "()Ljava/util/OptionalLong;");
		}
		
		[JavaSignature("()J")]
		public long getAsLong()
		{
			return Instance.CallMethod<long>("getAsLong", "()J");
		}
		
		[JavaSignature("(Ljava/util/function/LongConsumer;)V")]
		public void ifPresent(LongConsumer arg0)
		{
			Instance.CallMethod("ifPresent", "(Ljava/util/function/LongConsumer;)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isPresent()
		{
			return Instance.CallMethod<bool>("isPresent", "()Z");
		}
		
		[JavaSignature("(J)J")]
		public long orElse(long arg0)
		{
			return Instance.CallMethod<long>("orElse", "(J)J", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/LongSupplier;)J")]
		public long orElseGet(LongSupplier arg0)
		{
			return Instance.CallMethod<long>("orElseGet", "(Ljava/util/function/LongSupplier;)J", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)J")]
		public long orElseThrow<X>(Supplier<X> arg0)
			where X : Throwable
		{
			return Instance.CallMethod<long>("orElseThrow", "(Ljava/util/function/Supplier;)J", arg0);
		}
	}
}
