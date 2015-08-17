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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/Array")]
	public class Array : Object
	{
		protected Array(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;I)Ljava/lang/Object;")]
		public static IJavaObject @get(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<IJavaObject>(typeof(Array), "get", "(Ljava/lang/Object;I)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public static int getLength(IJavaObject arg0)
		{
			return Static.CallMethod<int>(typeof(Array), "getLength", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)Z")]
		public static bool getBoolean(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<bool>(typeof(Array), "getBoolean", "(Ljava/lang/Object;I)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)B")]
		public static byte getByte(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<byte>(typeof(Array), "getByte", "(Ljava/lang/Object;I)B", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)S")]
		public static short getShort(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<short>(typeof(Array), "getShort", "(Ljava/lang/Object;I)S", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)C")]
		public static char getChar(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<char>(typeof(Array), "getChar", "(Ljava/lang/Object;I)C", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)I")]
		public static int getInt(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<int>(typeof(Array), "getInt", "(Ljava/lang/Object;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)J")]
		public static long getLong(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<long>(typeof(Array), "getLong", "(Ljava/lang/Object;I)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)F")]
		public static float getFloat(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<float>(typeof(Array), "getFloat", "(Ljava/lang/Object;I)F", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)D")]
		public static double getDouble(IJavaObject arg0, int arg1)
		{
			return Static.CallMethod<double>(typeof(Array), "getDouble", "(Ljava/lang/Object;I)D", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;I)Ljava/lang/Object;")]
		public static IJavaObject newInstance(Class<IJavaObject> arg0, int arg1)
		{
			return Static.CallMethod<IJavaObject>(typeof(Array), "newInstance", "(Ljava/lang/Class;I)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;[I)Ljava/lang/Object;")]
		public static IJavaObject newInstance(Class<IJavaObject> arg0, IntArray arg1)
		{
			return Static.CallMethod<IJavaObject>(typeof(Array), "newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;ILjava/lang/Object;)V")]
		public static void @set(IJavaObject arg0, int arg1, IJavaObject arg2)
		{
			Static.CallMethod(typeof(Array), "set", "(Ljava/lang/Object;ILjava/lang/Object;)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;IZ)V")]
		public static void setBoolean(IJavaObject arg0, int arg1, bool arg2)
		{
			Static.CallMethod(typeof(Array), "setBoolean", "(Ljava/lang/Object;IZ)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;IB)V")]
		public static void setByte(IJavaObject arg0, int arg1, byte arg2)
		{
			Static.CallMethod(typeof(Array), "setByte", "(Ljava/lang/Object;IB)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;IC)V")]
		public static void setChar(IJavaObject arg0, int arg1, char arg2)
		{
			Static.CallMethod(typeof(Array), "setChar", "(Ljava/lang/Object;IC)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;ID)V")]
		public static void setDouble(IJavaObject arg0, int arg1, double arg2)
		{
			Static.CallMethod(typeof(Array), "setDouble", "(Ljava/lang/Object;ID)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;IF)V")]
		public static void setFloat(IJavaObject arg0, int arg1, float arg2)
		{
			Static.CallMethod(typeof(Array), "setFloat", "(Ljava/lang/Object;IF)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;II)V")]
		public static void setInt(IJavaObject arg0, int arg1, int arg2)
		{
			Static.CallMethod(typeof(Array), "setInt", "(Ljava/lang/Object;II)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;IJ)V")]
		public static void setLong(IJavaObject arg0, int arg1, long arg2)
		{
			Static.CallMethod(typeof(Array), "setLong", "(Ljava/lang/Object;IJ)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Object;IS)V")]
		public static void setShort(IJavaObject arg0, int arg1, short arg2)
		{
			Static.CallMethod(typeof(Array), "setShort", "(Ljava/lang/Object;IS)V", arg0, arg1, arg2);
		}
	}
}
