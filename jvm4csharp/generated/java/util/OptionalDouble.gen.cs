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
	[JavaProxy("java/util/OptionalDouble")]
	public class OptionalDouble : Object
	{
		protected OptionalDouble(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(D)Ljava/util/OptionalDouble;")]
		public static OptionalDouble of(double arg0)
		{
			return Static.CallMethod<OptionalDouble>(typeof(OptionalDouble), "of", "(D)Ljava/util/OptionalDouble;", arg0);
		}
		
		[JavaSignature("()Ljava/util/OptionalDouble;")]
		public static OptionalDouble empty()
		{
			return Static.CallMethod<OptionalDouble>(typeof(OptionalDouble), "empty", "()Ljava/util/OptionalDouble;");
		}
		
		[JavaSignature("(Ljava/util/function/DoubleConsumer;)V")]
		public void ifPresent(DoubleConsumer arg0)
		{
			Instance.CallMethod("ifPresent", "(Ljava/util/function/DoubleConsumer;)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isPresent()
		{
			return Instance.CallMethod<bool>("isPresent", "()Z");
		}
		
		[JavaSignature("(D)D")]
		public double orElse(double arg0)
		{
			return Instance.CallMethod<double>("orElse", "(D)D", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/DoubleSupplier;)D")]
		public double orElseGet(DoubleSupplier arg0)
		{
			return Instance.CallMethod<double>("orElseGet", "(Ljava/util/function/DoubleSupplier;)D", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)D")]
		public double orElseThrow<X>(Supplier<X> arg0)
			where X : Throwable
		{
			return Instance.CallMethod<double>("orElseThrow", "(Ljava/util/function/Supplier;)D", arg0);
		}
		
		[JavaSignature("()D")]
		public double getAsDouble()
		{
			return Instance.CallMethod<double>("getAsDouble", "()D");
		}
	}
}
