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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/ObjectStreamField")]
	public partial class ObjectStreamField : Object, Comparable<IJavaObject>
	{
		protected ObjectStreamField(ProxyCtor p) : base(p) {}
		
		public ObjectStreamField(String arg0, Class<IJavaObject> arg1, bool arg2) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/Class;Z)V", arg0, arg1, arg2);
		}
		
		public ObjectStreamField(String arg0, Class<IJavaObject> arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/lang/String;Ljava/lang/Class;)V", arg0, arg1);
		}
	
		[JavaSignature("()Z")]
		public bool isPrimitive()
		{
			return Instance.CallMethod<bool>("isPrimitive", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int compareTo(IJavaObject arg0)
		{
			return Instance.CallMethod<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getType()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getType", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()I")]
		public int getOffset()
		{
			return Instance.CallMethod<int>("getOffset", "()I");
		}
		
		[JavaSignature("()C")]
		public char getTypeCode()
		{
			return Instance.CallMethod<char>("getTypeCode", "()C");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getTypeString()
		{
			return Instance.CallMethod<String>("getTypeString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Z")]
		public bool isUnshared()
		{
			return Instance.CallMethod<bool>("isUnshared", "()Z");
		}
	}
}
