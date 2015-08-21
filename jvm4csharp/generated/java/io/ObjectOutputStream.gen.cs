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
	[JavaProxy("java/io/ObjectOutputStream")]
	public partial class ObjectOutputStream : OutputStream, ObjectOutput, ObjectStreamConstants
	{
		protected ObjectOutputStream(ProxyCtor p) : base(p) {}
		
		public ObjectOutputStream(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
	
		[JavaSignature("()V")]
		public void defaultWriteObject()
		{
			Instance.CallMethod("defaultWriteObject", "()V");
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void writeObject(IJavaObject arg0)
		{
			Instance.CallMethod("writeObject", "(Ljava/lang/Object;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeInt(int arg0)
		{
			Instance.CallMethod("writeInt", "(I)V", arg0);
		}
		
		[JavaSignature("()Ljava/io/ObjectOutputStream/PutField;")]
		public ObjectOutputStream_.PutField putFields()
		{
			return Instance.CallMethod<ObjectOutputStream_.PutField>("putFields", "()Ljava/io/ObjectOutputStream/PutField;");
		}
		
		[JavaSignature("()V")]
		public void writeFields()
		{
			Instance.CallMethod("writeFields", "()V");
		}
		
		[JavaSignature("()V")]
		public void reset()
		{
			Instance.CallMethod("reset", "()V");
		}
		
		[JavaSignature("(I)V")]
		public void writeChar(int arg0)
		{
			Instance.CallMethod("writeChar", "(I)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeBytes(String arg0)
		{
			Instance.CallMethod("writeBytes", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeUTF(String arg0)
		{
			Instance.CallMethod("writeUTF", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(F)V")]
		public void writeFloat(float arg0)
		{
			Instance.CallMethod("writeFloat", "(F)V", arg0);
		}
		
		[JavaSignature("(J)V")]
		public void writeLong(long arg0)
		{
			Instance.CallMethod("writeLong", "(J)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeShort(int arg0)
		{
			Instance.CallMethod("writeShort", "(I)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void writeByte(int arg0)
		{
			Instance.CallMethod("writeByte", "(I)V", arg0);
		}
		
		[JavaSignature("(D)V")]
		public void writeDouble(double arg0)
		{
			Instance.CallMethod("writeDouble", "(D)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void useProtocolVersion(int arg0)
		{
			Instance.CallMethod("useProtocolVersion", "(I)V", arg0);
		}
		
		[JavaSignature("(Z)V")]
		public void writeBoolean(bool arg0)
		{
			Instance.CallMethod("writeBoolean", "(Z)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void writeChars(String arg0)
		{
			Instance.CallMethod("writeChars", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Object;)V")]
		public void writeUnshared(IJavaObject arg0)
		{
			Instance.CallMethod("writeUnshared", "(Ljava/lang/Object;)V", arg0);
		}
	}
	
	public static partial class ObjectOutputStream_
	{
		[JavaProxy("java/io/ObjectOutputStream/PutField")]
		public abstract partial class PutField : Object
		{
			protected PutField(ProxyCtor p) : base(p) {}
		
			[JavaSignature("(Ljava/lang/String;F)V")]
			public void put(String arg0, float arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;F)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;J)V")]
			public void put(String arg0, long arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;J)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;I)V")]
			public void put(String arg0, int arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;I)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;D)V")]
			public void put(String arg0, double arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;D)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/lang/Object;)V")]
			public void put(String arg0, IJavaObject arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;Z)V")]
			public void put(String arg0, bool arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;Z)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;B)V")]
			public void put(String arg0, byte arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;B)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;C)V")]
			public void put(String arg0, char arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;C)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;S)V")]
			public void put(String arg0, short arg1)
			{
				Instance.CallMethod("put", "(Ljava/lang/String;S)V", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/io/ObjectOutput;)V")]
			public void write(ObjectOutput arg0)
			{
				Instance.CallMethod("write", "(Ljava/io/ObjectOutput;)V", arg0);
			}
		}
	}
}
