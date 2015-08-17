//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.java.io;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util
{
	[JavaProxy("java/util/Date")]
	public class Date : Object, Serializable, Cloneable, Comparable<Date>
	{
		protected Date(ProxyCtor p) : base(p) {}
		
		public Date(String arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;)V", arg0);
		}
		
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIIIII)V", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(IIIII)V", arg0, arg1, arg2, arg3, arg4);
		}
		
		public Date() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
		
		public Date(long arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(J)V", arg0);
		}
		
		public Date(int arg0, int arg1, int arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(III)V", arg0, arg1, arg2);
		}
	
		[JavaSignature("(Ljava/util/Date;)I")]
		public int compareTo(Date arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/util/Date;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)J")]
		public static long parse(String arg0)
		{
			return Static.CallMethod<long>(typeof(Date), "parse", "(Ljava/lang/String;)J", arg0);
		}
		
		[JavaSignature("(Ljava/util/Date;)Z")]
		public bool after(Date arg0)
		{
			return Instance.CallMethod<bool>("after", "(Ljava/util/Date;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/Date;)Z")]
		public bool before(Date arg0)
		{
			return Instance.CallMethod<bool>("before", "(Ljava/util/Date;)Z", arg0);
		}
		
		[JavaSignature("()I")]
		public int getMinutes()
		{
			return Instance.CallMethod<int>("getMinutes", "()I");
		}
		
		[JavaSignature("()I")]
		public int getMonth()
		{
			return Instance.CallMethod<int>("getMonth", "()I");
		}
		
		[JavaSignature("()I")]
		public int getSeconds()
		{
			return Instance.CallMethod<int>("getSeconds", "()I");
		}
		
		[JavaSignature("()I")]
		public int getYear()
		{
			return Instance.CallMethod<int>("getYear", "()I");
		}
		
		[JavaSignature("(IIIIII)J")]
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return Static.CallMethod<long>(typeof(Date), "UTC", "(IIIIII)J", arg0, arg1, arg2, arg3, arg4, arg5);
		}
		
		[JavaSignature("()I")]
		public int getDay()
		{
			return Instance.CallMethod<int>("getDay", "()I");
		}
		
		[JavaSignature("()I")]
		public int getTimezoneOffset()
		{
			return Instance.CallMethod<int>("getTimezoneOffset", "()I");
		}
		
		[JavaSignature("(I)V")]
		public void setDate(int arg0)
		{
			Instance.CallMethod("setDate", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setHours(int arg0)
		{
			Instance.CallMethod("setHours", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMinutes(int arg0)
		{
			Instance.CallMethod("setMinutes", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMonth(int arg0)
		{
			Instance.CallMethod("setMonth", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setSeconds(int arg0)
		{
			Instance.CallMethod("setSeconds", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setYear(int arg0)
		{
			Instance.CallMethod("setYear", "(I)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toGMTString()
		{
			return Instance.CallMethod<String>("toGMTString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toLocaleString()
		{
			return Instance.CallMethod<String>("toLocaleString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()J")]
		public long getTime()
		{
			return Instance.CallMethod<long>("getTime", "()J");
		}
		
		[JavaSignature("(J)V")]
		public void setTime(long arg0)
		{
			Instance.CallMethod("setTime", "(J)V", arg0);
		}
		
		[JavaSignature("()I")]
		public int getDate()
		{
			return Instance.CallMethod<int>("getDate", "()I");
		}
		
		[JavaSignature("()I")]
		public int getHours()
		{
			return Instance.CallMethod<int>("getHours", "()I");
		}
	}
}
