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
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/CountedCompleter")]
	public abstract class CountedCompleter<T> : ForkJoinTask<T>
		where T : IJavaObject
	{
		protected CountedCompleter(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()V")]
		public void compute()
		{
			Instance.CallMethod("compute", "()V");
		}
		
		[JavaSignature("()Ljava/util/concurrent/CountedCompleter;")]
		public CountedCompleter<IJavaObject> getRoot()
		{
			return Instance.CallMethod<CountedCompleter<IJavaObject>>("getRoot", "()Ljava/util/concurrent/CountedCompleter;");
		}
		
		[JavaSignature("(I)V")]
		public void addToPendingCount(int arg0)
		{
			Instance.CallMethod("addToPendingCount", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void tryComplete()
		{
			Instance.CallMethod("tryComplete", "()V");
		}
		
		[JavaSignature("(II)Z")]
		public bool compareAndSetPendingCount(int arg0, int arg1)
		{
			return Instance.CallMethod<bool>("compareAndSetPendingCount", "(II)Z", arg0, arg1);
		}
		
		[JavaSignature("()I")]
		public int decrementPendingCountUnlessZero()
		{
			return Instance.CallMethod<int>("decrementPendingCountUnlessZero", "()I");
		}
		
		[JavaSignature("()Ljava/util/concurrent/CountedCompleter;")]
		public CountedCompleter<IJavaObject> firstComplete()
		{
			return Instance.CallMethod<CountedCompleter<IJavaObject>>("firstComplete", "()Ljava/util/concurrent/CountedCompleter;");
		}
		
		[JavaSignature("()Ljava/util/concurrent/CountedCompleter;")]
		public CountedCompleter<IJavaObject> getCompleter()
		{
			return Instance.CallMethod<CountedCompleter<IJavaObject>>("getCompleter", "()Ljava/util/concurrent/CountedCompleter;");
		}
		
		[JavaSignature("()I")]
		public int getPendingCount()
		{
			return Instance.CallMethod<int>("getPendingCount", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void helpComplete(int arg0)
		{
			Instance.CallMethod("helpComplete", "(I)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/concurrent/CountedCompleter;")]
		public CountedCompleter<IJavaObject> nextComplete()
		{
			return Instance.CallMethod<CountedCompleter<IJavaObject>>("nextComplete", "()Ljava/util/concurrent/CountedCompleter;");
		}
		
		[JavaSignature("(Ljava/util/concurrent/CountedCompleter;)V")]
		public void onCompletion(CountedCompleter<IJavaObject> arg0)
		{
			Instance.CallMethod("onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Throwable;Ljava/util/concurrent/CountedCompleter;)Z")]
		public bool onExceptionalCompletion(Throwable arg0, CountedCompleter<IJavaObject> arg1)
		{
			return Instance.CallMethod<bool>("onExceptionalCompletion", "(Ljava/lang/Throwable;Ljava/util/concurrent/CountedCompleter;)Z", arg0, arg1);
		}
		
		[JavaSignature("()V")]
		public void propagateCompletion()
		{
			Instance.CallMethod("propagateCompletion", "()V");
		}
		
		[JavaSignature("()V")]
		public void quietlyCompleteRoot()
		{
			Instance.CallMethod("quietlyCompleteRoot", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void setPendingCount(int arg0)
		{
			Instance.CallMethod("setPendingCount", "(I)V", arg0);
		}
	}
}
