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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/CompletionStage")]
	public partial interface CompletionStage<T> : IJavaObject
		where T : IJavaObject
	{
		[JavaSignature("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> handle<U>(BiFunction<IJavaObject, Throwable, U> arg0)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> acceptEither(CompletionStage<T> arg0, Consumer<IJavaObject> arg1);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> acceptEitherAsync(CompletionStage<T> arg0, Consumer<IJavaObject> arg1);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> acceptEitherAsync(CompletionStage<T> arg0, Consumer<IJavaObject> arg1, Executor arg2);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> applyToEither<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> applyToEitherAsync<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> applyToEitherAsync<U>(CompletionStage<T> arg0, Function<IJavaObject, U> arg1, Executor arg2)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> exceptionally(Function<Throwable, T> arg0);
		
		[JavaSignature("(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> handleAsync<U>(BiFunction<IJavaObject, Throwable, U> arg0, Executor arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> handleAsync<U>(BiFunction<IJavaObject, Throwable, U> arg0)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> runAfterBoth(CompletionStage<IJavaObject> arg0, Runnable arg1);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> runAfterBothAsync(CompletionStage<IJavaObject> arg0, Runnable arg1, Executor arg2);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> runAfterBothAsync(CompletionStage<IJavaObject> arg0, Runnable arg1);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> runAfterEither(CompletionStage<IJavaObject> arg0, Runnable arg1);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> runAfterEitherAsync(CompletionStage<IJavaObject> arg0, Runnable arg1);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> runAfterEitherAsync(CompletionStage<IJavaObject> arg0, Runnable arg1, Executor arg2);
		
		[JavaSignature("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenAccept(Consumer<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenAcceptAsync(Consumer<IJavaObject> arg0, Executor arg1);
		
		[JavaSignature("(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenAcceptAsync(Consumer<IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenAcceptBoth<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenAcceptBothAsync<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenAcceptBothAsync<U>(CompletionStage<U> arg0, BiConsumer<IJavaObject, IJavaObject> arg1, Executor arg2)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> thenApply<U>(Function<IJavaObject, U> arg0)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> thenApplyAsync<U>(Function<IJavaObject, U> arg0)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> thenApplyAsync<U>(Function<IJavaObject, U> arg0, Executor arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<V> thenCombine<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
			where U : IJavaObject
			where V : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<V> thenCombineAsync<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1, Executor arg2)
			where U : IJavaObject
			where V : IJavaObject;
		
		[JavaSignature("(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<V> thenCombineAsync<U, V>(CompletionStage<U> arg0, BiFunction<IJavaObject, IJavaObject, V> arg1)
			where U : IJavaObject
			where V : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> thenCompose<U>(Function<IJavaObject, CompletionStage<U>> arg0)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> thenComposeAsync<U>(Function<IJavaObject, CompletionStage<U>> arg0)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<U> thenComposeAsync<U>(Function<IJavaObject, CompletionStage<U>> arg0, Executor arg1)
			where U : IJavaObject;
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenRun(Runnable arg0);
		
		[JavaSignature("(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenRunAsync(Runnable arg0);
		
		[JavaSignature("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<Void> thenRunAsync(Runnable arg0, Executor arg1);
		
		[JavaSignature("()Ljava/util/concurrent/CompletableFuture;")]
		CompletableFuture<T> toCompletableFuture();
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> whenComplete(BiConsumer<IJavaObject, IJavaObject> arg0);
		
		[JavaSignature("(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> whenCompleteAsync(BiConsumer<IJavaObject, IJavaObject> arg0, Executor arg1);
		
		[JavaSignature("(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;")]
		CompletionStage<T> whenCompleteAsync(BiConsumer<IJavaObject, IJavaObject> arg0);
	}
}
