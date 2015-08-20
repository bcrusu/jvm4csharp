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
	[JavaProxy("java/util/OptionalInt")]
	public partial class OptionalInt : Object
	{
		protected OptionalInt(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(I)Ljava/util/OptionalInt;")]
		public static OptionalInt of(int arg0)
		{
			return Static.CallMethod<OptionalInt>(typeof(OptionalInt), "of", "(I)Ljava/util/OptionalInt;", arg0);
		}
		
		[JavaSignature("()Ljava/util/OptionalInt;")]
		public static OptionalInt empty()
		{
			return Static.CallMethod<OptionalInt>(typeof(OptionalInt), "empty", "()Ljava/util/OptionalInt;");
		}
		
		[JavaSignature("(Ljava/util/function/IntConsumer;)V")]
		public void ifPresent(IntConsumer arg0)
		{
			Instance.CallMethod("ifPresent", "(Ljava/util/function/IntConsumer;)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isPresent()
		{
			return Instance.CallMethod<bool>("isPresent", "()Z");
		}
		
		[JavaSignature("(I)I")]
		public int orElse(int arg0)
		{
			return Instance.CallMethod<int>("orElse", "(I)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/IntSupplier;)I")]
		public int orElseGet(IntSupplier arg0)
		{
			return Instance.CallMethod<int>("orElseGet", "(Ljava/util/function/IntSupplier;)I", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)I")]
		public int orElseThrow<X>(Supplier<X> arg0)
			where X : Throwable
		{
			return Instance.CallMethod<int>("orElseThrow", "(Ljava/util/function/Supplier;)I", arg0);
		}
		
		[JavaSignature("()I")]
		public int getAsInt()
		{
			return Instance.CallMethod<int>("getAsInt", "()I");
		}
	}
}
