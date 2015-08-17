//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
	[JavaProxy("java/util/concurrent/TimeUnit")]
	public abstract class TimeUnit : Enum<TimeUnit>
	{
		protected TimeUnit(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit NANOSECONDS
		{
			get { return Static.GetField<TimeUnit>(typeof(TimeUnit), "NANOSECONDS", "Ljava/util/concurrent/TimeUnit;"); }
		}
		
		[JavaSignature("Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit MICROSECONDS
		{
			get { return Static.GetField<TimeUnit>(typeof(TimeUnit), "MICROSECONDS", "Ljava/util/concurrent/TimeUnit;"); }
		}
		
		[JavaSignature("Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit MILLISECONDS
		{
			get { return Static.GetField<TimeUnit>(typeof(TimeUnit), "MILLISECONDS", "Ljava/util/concurrent/TimeUnit;"); }
		}
		
		[JavaSignature("Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit SECONDS
		{
			get { return Static.GetField<TimeUnit>(typeof(TimeUnit), "SECONDS", "Ljava/util/concurrent/TimeUnit;"); }
		}
		
		[JavaSignature("Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit MINUTES
		{
			get { return Static.GetField<TimeUnit>(typeof(TimeUnit), "MINUTES", "Ljava/util/concurrent/TimeUnit;"); }
		}
		
		[JavaSignature("Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit HOURS
		{
			get { return Static.GetField<TimeUnit>(typeof(TimeUnit), "HOURS", "Ljava/util/concurrent/TimeUnit;"); }
		}
		
		[JavaSignature("Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit DAYS
		{
			get { return Static.GetField<TimeUnit>(typeof(TimeUnit), "DAYS", "Ljava/util/concurrent/TimeUnit;"); }
		}
	
		[JavaSignature("(JLjava/util/concurrent/TimeUnit;)J")]
		public long convert(long arg0, TimeUnit arg1)
		{
			return Instance.CallMethod<long>("convert", "(JLjava/util/concurrent/TimeUnit;)J", arg0, arg1);
		}
		
		[JavaSignature("()[Ljava/util/concurrent/TimeUnit;")]
		public static ObjectArray<TimeUnit> values()
		{
			return Static.CallMethod<ObjectArray<TimeUnit>>(typeof(TimeUnit), "values", "()[Ljava/util/concurrent/TimeUnit;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;")]
		public static TimeUnit valueOf(String arg0)
		{
			return Static.CallMethod<TimeUnit>(typeof(TimeUnit), "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void sleep(long arg0)
		{
			Instance.CallMethod("sleep", "(J)V", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long toNanos(long arg0)
		{
			return Instance.CallMethod<long>("toNanos", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long toDays(long arg0)
		{
			return Instance.CallMethod<long>("toDays", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long toMillis(long arg0)
		{
			return Instance.CallMethod<long>("toMillis", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long toSeconds(long arg0)
		{
			return Instance.CallMethod<long>("toSeconds", "(J)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Thread;J)V")]
		public void timedJoin(Thread arg0, long arg1)
		{
			Instance.CallMethod("timedJoin", "(Ljava/lang/Thread;J)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)V")]
		public void timedWait(IJavaObject arg0, long arg1)
		{
			Instance.CallMethod("timedWait", "(Ljava/lang/Object;J)V", arg0, arg1);
		}
		
		[JavaSignature("(J)J")]
		public long toHours(long arg0)
		{
			return Instance.CallMethod<long>("toHours", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long toMicros(long arg0)
		{
			return Instance.CallMethod<long>("toMicros", "(J)J", arg0);
		}
		
		[JavaSignature("(J)J")]
		public long toMinutes(long arg0)
		{
			return Instance.CallMethod<long>("toMinutes", "(J)J", arg0);
		}
	}
}
