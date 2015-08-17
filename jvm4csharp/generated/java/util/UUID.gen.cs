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
	[JavaProxy("java/util/UUID")]
	public class UUID : Object, Serializable, Comparable<UUID>
	{
		protected UUID(ProxyCtor p) : base(p) {}
		
		public UUID(long arg0, long arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(JJ)V", arg0, arg1);
		}
	
		[JavaSignature("(Ljava/util/UUID;)I")]
		public int compareTo(UUID arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/util/UUID;)I", arg0);
		}
		
		[JavaSignature("()J")]
		public long timestamp()
		{
			return Instance.CallMethod<long>("timestamp", "()J");
		}
		
		[JavaSignature("()I")]
		public int version()
		{
			return Instance.CallMethod<int>("version", "()I");
		}
		
		[JavaSignature("()I")]
		public int variant()
		{
			return Instance.CallMethod<int>("variant", "()I");
		}
		
		[JavaSignature("()J")]
		public long node()
		{
			return Instance.CallMethod<long>("node", "()J");
		}
		
		[JavaSignature("()I")]
		public int clockSequence()
		{
			return Instance.CallMethod<int>("clockSequence", "()I");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/UUID;")]
		public static UUID fromString(String arg0)
		{
			return Static.CallMethod<UUID>(typeof(UUID), "fromString", "(Ljava/lang/String;)Ljava/util/UUID;", arg0);
		}
		
		[JavaSignature("()J")]
		public long getLeastSignificantBits()
		{
			return Instance.CallMethod<long>("getLeastSignificantBits", "()J");
		}
		
		[JavaSignature("()J")]
		public long getMostSignificantBits()
		{
			return Instance.CallMethod<long>("getMostSignificantBits", "()J");
		}
		
		[JavaSignature("([B)Ljava/util/UUID;")]
		public static UUID nameUUIDFromBytes(ByteArray arg0)
		{
			return Static.CallMethod<UUID>(typeof(UUID), "nameUUIDFromBytes", "([B)Ljava/util/UUID;", arg0);
		}
		
		[JavaSignature("()Ljava/util/UUID;")]
		public static UUID randomUUID()
		{
			return Static.CallMethod<UUID>(typeof(UUID), "randomUUID", "()Ljava/util/UUID;");
		}
	}
}
