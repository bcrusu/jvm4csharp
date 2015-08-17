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
namespace jvm4csharp.java.util.concurrent.locks
{
	[JavaProxy("java/util/concurrent/locks/LockSupport")]
	public class LockSupport : Object
	{
		protected LockSupport(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()V")]
		public static void park()
		{
			Static.CallMethod(typeof(LockSupport), "park", "()V");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public static void park(IJavaObject arg0)
		{
			Static.CallMethod(typeof(LockSupport), "park", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread;)V")]
		public static void unpark(Thread arg0)
		{
			Static.CallMethod(typeof(LockSupport), "unpark", "(Ljava/lang/Thread;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread;)Ljava/lang/Object;")]
		public static IJavaObject getBlocker(Thread arg0)
		{
			return Static.CallMethod<IJavaObject>(typeof(LockSupport), "getBlocker", "(Ljava/lang/Thread;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)V")]
		public static void parkUntil(IJavaObject arg0, long arg1)
		{
			Static.CallMethod(typeof(LockSupport), "parkUntil", "(Ljava/lang/Object;J)V", arg0, arg1);
		}
		
		[JavaSignature("(J)V")]
		public static void parkUntil(long arg0)
		{
			Static.CallMethod(typeof(LockSupport), "parkUntil", "(J)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)V")]
		public static void parkNanos(IJavaObject arg0, long arg1)
		{
			Static.CallMethod(typeof(LockSupport), "parkNanos", "(Ljava/lang/Object;J)V", arg0, arg1);
		}
		
		[JavaSignature("(J)V")]
		public static void parkNanos(long arg0)
		{
			Static.CallMethod(typeof(LockSupport), "parkNanos", "(J)V", arg0);
		}
	}
}
