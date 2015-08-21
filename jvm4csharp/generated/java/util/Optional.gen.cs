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
	[JavaProxy("java/util/Optional")]
	public partial class Optional<T> : Object
		where T : IJavaObject
	{
		protected Optional(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public T @get()
		{
			return Instance.CallMethod<T>("get", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Optional;")]
		public static Optional<T1> of<T1>(T1 arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Optional<T1>>(typeof(Optional<>), "of", "(Ljava/lang/Object;)Ljava/util/Optional;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Optional;")]
		public static Optional<T1> empty<T1>()
			where T1 : IJavaObject
		{
			return Static.CallMethod<Optional<T1>>(typeof(Optional<>), "empty", "()Ljava/util/Optional;");
		}
		
		[JavaSignature("(Ljava/util/function/Predicate;)Ljava/util/Optional;")]
		public Optional<T> filter(Predicate<IJavaObject> arg0)
		{
			return Instance.CallMethod<Optional<T>>("filter", "(Ljava/util/function/Predicate;)Ljava/util/Optional;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/Optional;")]
		public Optional<U> map<U>(Function<IJavaObject, U> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<Optional<U>>("map", "(Ljava/util/function/Function;)Ljava/util/Optional;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)V")]
		public void ifPresent(Consumer<IJavaObject> arg0)
		{
			Instance.CallMethod("ifPresent", "(Ljava/util/function/Consumer;)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isPresent()
		{
			return Instance.CallMethod<bool>("isPresent", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public T orElse(T arg0)
		{
			return Instance.CallMethod<T>("orElse", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)Ljava/lang/Object;")]
		public T orElseGet(Supplier<T> arg0)
		{
			return Instance.CallMethod<T>("orElseGet", "(Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)Ljava/lang/Object;")]
		public T orElseThrow<X>(Supplier<X> arg0)
			where X : Throwable
		{
			return Instance.CallMethod<T>("orElseThrow", "(Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/Optional;")]
		public Optional<U> flatMap<U>(Function<IJavaObject, Optional<U>> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<Optional<U>>("flatMap", "(Ljava/util/function/Function;)Ljava/util/Optional;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/Optional;")]
		public static Optional<T1> ofNullable<T1>(T1 arg0)
			where T1 : IJavaObject
		{
			return Static.CallMethod<Optional<T1>>(typeof(Optional<>), "ofNullable", "(Ljava/lang/Object;)Ljava/util/Optional;", arg0);
		}
	}
}
