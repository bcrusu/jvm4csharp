//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.lang;
using jvm4csharp.java.util.function;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/CompletableFuture")]
	public partial class CompletableFuture<T> : Object, Future<T>, CompletionStage<T>
		where T : IJavaObject
	{
		protected CompletableFuture(ProxyCtor p) : base(p) {}
		
		public CompletableFuture() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()Ljava/lang/Object;")]
		public T @get()
		{
			return Instance.CallMethod<T>("get", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;")]
		public T @get(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<T>("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public T @join()
		{
			return Instance.CallMethod<T>("join", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> handle<U>(BiFunction<IJavaObject, Throwable, U> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("handle", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;")]
		public static CompletableFuture<Void> allOf(ObjectArray<CompletableFuture<IJavaObject>> arg0)
		{
			return Static.CallMethod<CompletableFuture<Void>>(typeof(CompletableFuture<>), "allOf", "([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Z)Z")]
		public bool cancel(bool arg0)
		{
			return Instance.CallMethod<bool>("cancel", "(Z)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isDone()
		{
			return Instance.CallMethod<bool>("isDone", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool complete(T arg0)
		{
			return Instance.CallMethod<bool>("complete", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Throwable;)Z")]
		public bool completeExceptionally(Throwable arg0)
		{
			return Instance.CallMethod<bool>("completeExceptionally", "(Ljava/lang/Throwable;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isCancelled()
		{
			return Instance.CallMethod<bool>("isCancelled", "()Z");
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> acceptEither(CompletionStage<T> arg0, Consumer<IJavaObject> arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("acceptEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> acceptEitherAsync(CompletionStage<T> arg0, Consumer<IJavaObject> arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> acceptEitherAsync(CompletionStage<T> arg0, Consumer<IJavaObject> arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;")]
		public static CompletableFuture<IJavaObject> anyOf(ObjectArray<CompletableFuture<IJavaObject>> arg0)
		{
			return Static.CallMethod<CompletableFuture<IJavaObject>>(typeof(CompletableFuture<>), "anyOf", "([Ljava/util/concurrent/CompletableFuture;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> applyToEither<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("applyToEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> applyToEitherAsync<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> applyToEitherAsync<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1, Executor arg2)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/util/concurrent/CompletableFuture;")]
		public static CompletableFuture<U> completedFuture<U>(U arg0)
			where U : IJavaObject
		{
			return Static.CallMethod<CompletableFuture<U>>(typeof(CompletableFuture<>), "completedFuture", "(Ljava/lang/Object;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<T> exceptionally(Function<Throwable, T> arg0)
		{
			return Instance.CallMethod<CompletableFuture<T>>("exceptionally", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public T getNow(T arg0)
		{
			return Instance.CallMethod<T>("getNow", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()I")]
		public int getNumberOfDependents()
		{
			return Instance.CallMethod<int>("getNumberOfDependents", "()I");
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> handleAsync<U>(BiFunction<IJavaObject, Throwable, U> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("handleAsync", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> handleAsync<U>(BiFunction<IJavaObject, Throwable, U> arg0, Executor arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("handleAsync", "(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("()Z")]
		public bool isCompletedExceptionally()
		{
			return Instance.CallMethod<bool>("isCompletedExceptionally", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Throwable;)V")]
		public void obtrudeException(Throwable arg0)
		{
			Instance.CallMethod("obtrudeException", "(Ljava/lang/Throwable;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void obtrudeValue(T arg0)
		{
			Instance.CallMethod("obtrudeValue", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> runAfterBoth(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("runAfterBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> runAfterBothAsync(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> runAfterBothAsync(CompletionStage<IJavaObject> arg0, Runnable arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> runAfterEither(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("runAfterEither", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> runAfterEitherAsync(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> runAfterEitherAsync(CompletionStage<IJavaObject> arg0, Runnable arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;")]
		public static CompletableFuture<Void> runAsync(Runnable arg0)
		{
			return Static.CallMethod<CompletableFuture<Void>>(typeof(CompletableFuture<>), "runAsync", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public static CompletableFuture<Void> runAsync(Runnable arg0, Executor arg1)
		{
			return Static.CallMethod<CompletableFuture<Void>>(typeof(CompletableFuture<>), "runAsync", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;")]
		public static CompletableFuture<U> supplyAsync<U>(Supplier<U> arg0)
			where U : IJavaObject
		{
			return Static.CallMethod<CompletableFuture<U>>(typeof(CompletableFuture<>), "supplyAsync", "(Ljava/util/function/Supplier;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public static CompletableFuture<U> supplyAsync<U>(Supplier<U> arg0, Executor arg1)
			where U : IJavaObject
		{
			return Static.CallMethod<CompletableFuture<U>>(typeof(CompletableFuture<>), "supplyAsync", "(Ljava/util/function/Supplier;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenAccept(Consumer<IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenAccept", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenAcceptAsync(Consumer<IJavaObject> arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenAcceptAsync", "(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenAcceptAsync(Consumer<IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenAcceptAsync", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenAcceptBoth<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenAcceptBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenAcceptBothAsync<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1, Executor arg2)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenAcceptBothAsync<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> thenApply<U>(Function<IJavaObject, U> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("thenApply", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> thenApplyAsync<U>(Function<IJavaObject, U> arg0, Executor arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("thenApplyAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> thenApplyAsync<U>(Function<IJavaObject, U> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("thenApplyAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<V> thenCombine<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
			where U : IJavaObject
			where V : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<V>>("thenCombine", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<V> thenCombineAsync<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
			where U : IJavaObject
			where V : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<V>>("thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<V> thenCombineAsync<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1, Executor arg2)
			where U : IJavaObject
			where V : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<V>>("thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> thenCompose<U>(Function<IJavaObject, CompletionStage<U>> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("thenCompose", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> thenComposeAsync<U>(Function<IJavaObject, CompletionStage<U>> arg0)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("thenComposeAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<U> thenComposeAsync<U>(Function<IJavaObject, CompletionStage<U>> arg0, Executor arg1)
			where U : IJavaObject
		{
			return Instance.CallMethod<CompletableFuture<U>>("thenComposeAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenRun(Runnable arg0)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenRun", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenRunAsync(Runnable arg0)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenRunAsync", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<Void> thenRunAsync(Runnable arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletableFuture<Void>>("thenRunAsync", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<T> toCompletableFuture()
		{
			return Instance.CallMethod<CompletableFuture<T>>("toCompletableFuture", "()Ljava/util/concurrent/CompletableFuture;");
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<T> whenComplete(BiConsumer<IJavaObject, IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletableFuture<T>>("whenComplete", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<T> whenCompleteAsync(BiConsumer<IJavaObject, IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletableFuture<T>>("whenCompleteAsync", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;")]
		public CompletableFuture<T> whenCompleteAsync(BiConsumer<IJavaObject, IJavaObject> arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletableFuture<T>>("whenCompleteAsync", "(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.handle<U>(BiFunction<IJavaObject, Throwable, U> arg0)
		{
			return Instance.CallMethod<CompletionStage<U>>("handle", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.acceptEither(CompletionStage<T> arg0, Consumer<IJavaObject> arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("acceptEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.acceptEitherAsync(CompletionStage<T> arg0, Consumer<IJavaObject> arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.acceptEitherAsync(CompletionStage<T> arg0, Consumer<IJavaObject> arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletionStage<Void>>("acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.applyToEither<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1)
		{
			return Instance.CallMethod<CompletionStage<U>>("applyToEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.applyToEitherAsync<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1)
		{
			return Instance.CallMethod<CompletionStage<U>>("applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.applyToEitherAsync<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletionStage<U>>("applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> CompletionStage<T>.exceptionally(Function<Throwable, T> arg0)
		{
			return Instance.CallMethod<CompletionStage<T>>("exceptionally", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.handleAsync<U>(BiFunction<IJavaObject, Throwable, U> arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletionStage<U>>("handleAsync", "(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.handleAsync<U>(BiFunction<IJavaObject, Throwable, U> arg0)
		{
			return Instance.CallMethod<CompletionStage<U>>("handleAsync", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.runAfterBoth(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("runAfterBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.runAfterBothAsync(CompletionStage<IJavaObject> arg0, Runnable arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletionStage<Void>>("runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.runAfterBothAsync(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.runAfterEither(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("runAfterEither", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.runAfterEitherAsync(CompletionStage<IJavaObject> arg0, Runnable arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.runAfterEitherAsync(CompletionStage<IJavaObject> arg0, Runnable arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletionStage<Void>>("runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenAccept(Consumer<IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenAccept", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenAcceptAsync(Consumer<IJavaObject> arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenAcceptAsync", "(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenAcceptAsync(Consumer<IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenAcceptAsync", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenAcceptBoth<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenAcceptBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenAcceptBothAsync<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenAcceptBothAsync<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.thenApply<U>(Function<IJavaObject, U> arg0)
		{
			return Instance.CallMethod<CompletionStage<U>>("thenApply", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.thenApplyAsync<U>(Function<IJavaObject, U> arg0)
		{
			return Instance.CallMethod<CompletionStage<U>>("thenApplyAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.thenApplyAsync<U>(Function<IJavaObject, U> arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletionStage<U>>("thenApplyAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<V> CompletionStage<T>.thenCombine<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
		{
			return Instance.CallMethod<CompletionStage<V>>("thenCombine", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<V> CompletionStage<T>.thenCombineAsync<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1, Executor arg2)
		{
			return Instance.CallMethod<CompletionStage<V>>("thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<V> CompletionStage<T>.thenCombineAsync<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
		{
			return Instance.CallMethod<CompletionStage<V>>("thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.thenCompose<U>(Function<IJavaObject, CompletionStage<U>> arg0)
		{
			return Instance.CallMethod<CompletionStage<U>>("thenCompose", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.thenComposeAsync<U>(Function<IJavaObject, CompletionStage<U>> arg0)
		{
			return Instance.CallMethod<CompletionStage<U>>("thenComposeAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> CompletionStage<T>.thenComposeAsync<U>(Function<IJavaObject, CompletionStage<U>> arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletionStage<U>>("thenComposeAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenRun(Runnable arg0)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenRun", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenRunAsync(Runnable arg0)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenRunAsync", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> CompletionStage<T>.thenRunAsync(Runnable arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletionStage<Void>>("thenRunAsync", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> CompletionStage<T>.whenComplete(BiConsumer<IJavaObject, IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletionStage<T>>("whenComplete", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> CompletionStage<T>.whenCompleteAsync(BiConsumer<IJavaObject, IJavaObject> arg0, Executor arg1)
		{
			return Instance.CallMethod<CompletionStage<T>>("whenCompleteAsync", "(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> CompletionStage<T>.whenCompleteAsync(BiConsumer<IJavaObject, IJavaObject> arg0)
		{
			return Instance.CallMethod<CompletionStage<T>>("whenCompleteAsync", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;", arg0);
		}
	}
	
	public static partial class CompletableFuture_
	{
		[JavaProxy("java/util/concurrent/CompletableFuture/AsynchronousCompletionTask")]
		public partial interface AsynchronousCompletionTask : IJavaObject
		{
		}
	}
}
