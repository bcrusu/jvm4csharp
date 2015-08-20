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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/Enum")]
	public abstract partial class Enum<E> : Enum, Comparable<E>, Serializable
		where E : Enum<E>
	{
		protected Enum(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String name()
		{
			return Instance.CallMethod<String>("name", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/Enum;)I")]
		public int compareTo(E arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Enum;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;")]
		public static T valueOf<T>(Class<T> arg0, String arg1)
			where T : Enum<T>
		{
			return Static.CallMethod<T>(typeof(Enum<>), "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<E> getDeclaringClass()
		{
			return Instance.CallMethod<Class<E>>("getDeclaringClass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()I")]
		public int ordinal()
		{
			return Instance.CallMethod<int>("ordinal", "()I");
		}
	}
}
