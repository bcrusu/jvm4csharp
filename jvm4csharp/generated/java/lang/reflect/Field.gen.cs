//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.reflect
{
	[JavaProxy("java/lang/reflect/Field")]
	public class Field : AccessibleObject, Member
	{
		protected Field(ProxyCtor p) : base(p) {}
	
		[JavaSignature("(Ljava/lang/Object;)Ljava/lang/Object;")]
		public IJavaObject @get(IJavaObject arg0)
		{
			return Instance.CallMethod<IJavaObject>("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
		}
		
		[JavaSignature("()I")]
		public int getModifiers()
		{
			return Instance.CallMethod<int>("getModifiers", "()I");
		}
		
		[JavaSignature("(Ljava/lang/Object;)Z")]
		public bool getBoolean(IJavaObject arg0)
		{
			return Instance.CallMethod<bool>("getBoolean", "(Ljava/lang/Object;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)B")]
		public byte getByte(IJavaObject arg0)
		{
			return Instance.CallMethod<byte>("getByte", "(Ljava/lang/Object;)B", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)S")]
		public short getShort(IJavaObject arg0)
		{
			return Instance.CallMethod<short>("getShort", "(Ljava/lang/Object;)S", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)C")]
		public char getChar(IJavaObject arg0)
		{
			return Instance.CallMethod<char>("getChar", "(Ljava/lang/Object;)C", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)I")]
		public int getInt(IJavaObject arg0)
		{
			return Instance.CallMethod<int>("getInt", "(Ljava/lang/Object;)I", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)J")]
		public long getLong(IJavaObject arg0)
		{
			return Instance.CallMethod<long>("getLong", "(Ljava/lang/Object;)J", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)F")]
		public float getFloat(IJavaObject arg0)
		{
			return Instance.CallMethod<float>("getFloat", "(Ljava/lang/Object;)F", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)D")]
		public double getDouble(IJavaObject arg0)
		{
			return Instance.CallMethod<double>("getDouble", "(Ljava/lang/Object;)D", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getDeclaringClass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getDeclaringClass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Z")]
		public bool isSynthetic()
		{
			return Instance.CallMethod<bool>("isSynthetic", "()Z");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String toGenericString()
		{
			return Instance.CallMethod<String>("toGenericString", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/AnnotatedType;")]
		public AnnotatedType getAnnotatedType()
		{
			return Instance.CallMethod<AnnotatedType>("getAnnotatedType", "()Ljava/lang/reflect/AnnotatedType;");
		}
		
		[JavaSignature("()Ljava/lang/reflect/Type;")]
		public Type getGenericType()
		{
			return Instance.CallMethod<Type>("getGenericType", "()Ljava/lang/reflect/Type;");
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> getType()
		{
			return Instance.CallMethod<Class<IJavaObject>>("getType", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()Z")]
		public bool isEnumConstant()
		{
			return Instance.CallMethod<bool>("isEnumConstant", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/Object;Ljava/lang/Object;)V")]
		public void @set(IJavaObject arg0, IJavaObject arg1)
		{
			Instance.CallMethod("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;Z)V")]
		public void setBoolean(IJavaObject arg0, bool arg1)
		{
			Instance.CallMethod("setBoolean", "(Ljava/lang/Object;Z)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;B)V")]
		public void setByte(IJavaObject arg0, byte arg1)
		{
			Instance.CallMethod("setByte", "(Ljava/lang/Object;B)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;C)V")]
		public void setChar(IJavaObject arg0, char arg1)
		{
			Instance.CallMethod("setChar", "(Ljava/lang/Object;C)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;D)V")]
		public void setDouble(IJavaObject arg0, double arg1)
		{
			Instance.CallMethod("setDouble", "(Ljava/lang/Object;D)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;F)V")]
		public void setFloat(IJavaObject arg0, float arg1)
		{
			Instance.CallMethod("setFloat", "(Ljava/lang/Object;F)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;I)V")]
		public void setInt(IJavaObject arg0, int arg1)
		{
			Instance.CallMethod("setInt", "(Ljava/lang/Object;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;J)V")]
		public void setLong(IJavaObject arg0, long arg1)
		{
			Instance.CallMethod("setLong", "(Ljava/lang/Object;J)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/Object;S)V")]
		public void setShort(IJavaObject arg0, short arg1)
		{
			Instance.CallMethod("setShort", "(Ljava/lang/Object;S)V", arg0, arg1);
		}
	}
}
