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
using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/TimeZone")]
	public abstract partial class TimeZone : Object, Serializable, Cloneable
	{
		protected TimeZone(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int SHORT
		{
			get { return Static.GetField<int>(typeof(TimeZone), "SHORT", "I"); }
		}
		
		[JavaSignature("I")]
		public static int LONG
		{
			get { return Static.GetField<int>(typeof(TimeZone), "LONG", "I"); }
		}
	
		[JavaSignature("()Ljava/util/TimeZone;")]
		public static TimeZone getDefault()
		{
			return Static.CallMethod<TimeZone>(typeof(TimeZone), "getDefault", "()Ljava/util/TimeZone;");
		}
		
		[JavaSignature("(IIIIII)I")]
		public int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return Instance.CallMethod<int>("getOffset", "(IIIIII)I", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("(J)I")]
		public int getOffset(long arg0)
		{
			return Instance.CallMethod<int>("getOffset", "(J)I", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getDisplayName()
		{
			return Instance.CallMethod<String>("getDisplayName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(ZI)Ljava/lang/String;")]
		public String getDisplayName(bool arg0, int arg1)
		{
			return Instance.CallMethod<String>("getDisplayName", "(ZI)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(Locale arg0)
		{
			return Instance.CallMethod<String>("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("(ZILjava/util/Locale;)Ljava/lang/String;")]
		public String getDisplayName(bool arg0, int arg1, Locale arg2)
		{
			return Instance.CallMethod<String>("getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;", arg0, arg1, arg2);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getID()
		{
			return Instance.CallMethod<String>("getID", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/TimeZone;)V")]
		public static void setDefault(TimeZone arg0)
		{
			Static.CallMethod(typeof(TimeZone), "setDefault", "(Ljava/util/TimeZone;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/TimeZone;")]
		public static TimeZone getTimeZone(String arg0)
		{
			return Static.CallMethod<TimeZone>(typeof(TimeZone), "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;", arg0);
		}
		
		[JavaSignature("()I")]
		public int getRawOffset()
		{
			return Instance.CallMethod<int>("getRawOffset", "()I");
		}
		
		[JavaSignature("(I)[Ljava/lang/String;")]
		public static ObjectArray<String> getAvailableIDs(int arg0)
		{
			return Static.CallMethod<ObjectArray<String>>(typeof(TimeZone), "getAvailableIDs", "(I)[Ljava/lang/String;", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public static ObjectArray<String> getAvailableIDs()
		{
			return Static.CallMethod<ObjectArray<String>>(typeof(TimeZone), "getAvailableIDs", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int getDSTSavings()
		{
			return Instance.CallMethod<int>("getDSTSavings", "()I");
		}
		
		[JavaSignature("(Ljava/util/TimeZone;)Z")]
		public bool hasSameRules(TimeZone arg0)
		{
			return Instance.CallMethod<bool>("hasSameRules", "(Ljava/util/TimeZone;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Date;)Z")]
		public bool inDaylightTime(Date arg0)
		{
			return Instance.CallMethod<bool>("inDaylightTime", "(Ljava/util/Date;)Z", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool observesDaylightTime()
		{
			return Instance.CallMethod<bool>("observesDaylightTime", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setID(String arg0)
		{
			Instance.CallMethod("setID", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setRawOffset(int arg0)
		{
			Instance.CallMethod("setRawOffset", "(I)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool useDaylightTime()
		{
			return Instance.CallMethod<bool>("useDaylightTime", "()Z");
		}
	}
}
