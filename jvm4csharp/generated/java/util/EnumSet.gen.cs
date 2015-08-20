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
	[JavaProxy("java/util/EnumSet")]
	public abstract partial class EnumSet<E> : AbstractSet<E>, Cloneable, Serializable
		where E : Enum<E>
	{
		protected EnumSet(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/EnumSet;")]
		public EnumSet<E> clone()
		{
			return Instance.CallMethod<EnumSet<E>>("clone", "()Ljava/util/EnumSet;");
		}
		
		[JavaSignature("(Ljava/util/EnumSet;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> copyOf<E1>(EnumSet<E1> arg0)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;", arg0);
		}
		
		[JavaSignature("(Ljava/util/Collection;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> copyOf<E1>(Collection<E1> arg0)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> of<E1>(E1 arg0, E1 arg1, E1 arg2, E1 arg3, E1 arg4)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", arg0, arg1, arg2, arg3, arg4);
		}
		
		[JavaSignature("(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> of<E1>(E1 arg0, ObjectArray<E1> arg1)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "of", "(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Enum;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> of<E1>(E1 arg0)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> of<E1>(E1 arg0, E1 arg1)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "of", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> of<E1>(E1 arg0, E1 arg1, E1 arg2)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", arg0, arg1, arg2);
		}
		
		[JavaSignature("(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> of<E1>(E1 arg0, E1 arg1, E1 arg2, E1 arg3)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", arg0, arg1, arg2, arg3);
		}
		
		[JavaSignature("(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> range<E1>(E1 arg0, E1 arg1)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> noneOf<E1>(Class<E1> arg0)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> allOf<E1>(Class<E1> arg0)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;", arg0);
		}
		
		[JavaSignature("(Ljava/util/EnumSet;)Ljava/util/EnumSet;")]
		public static EnumSet<E1> complementOf<E1>(EnumSet<E1> arg0)
			where E1 : Enum<E1>
		{
			return Static.CallMethod<EnumSet<E1>>(typeof(EnumSet<>), "complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;", arg0);
		}
	}
}
