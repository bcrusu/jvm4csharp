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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/ObjectInputStream")]
	public class ObjectInputStream : InputStream, ObjectInput, ObjectStreamConstants
	{
		protected ObjectInputStream(ProxyCtor p) : base(p) {}
		
		public ObjectInputStream(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
	
		[JavaSignature("()F")]
		public float readFloat()
		{
			return Instance.CallMethod<float>("readFloat", "()F");
		}
		
		[JavaSignature("()V")]
		public void defaultReadObject()
		{
			Instance.CallMethod("defaultReadObject", "()V");
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject readObject()
		{
			return Instance.CallMethod<IJavaObject>("readObject", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String readLine()
		{
			return Instance.CallMethod<String>("readLine", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()I")]
		public int readInt()
		{
			return Instance.CallMethod<int>("readInt", "()I");
		}
		
		[JavaSignature("()Ljava/io/ObjectInputStream/GetField;")]
		public ObjectInputStream.GetField readFields()
		{
			return Instance.CallMethod<ObjectInputStream.GetField>("readFields", "()Ljava/io/ObjectInputStream/GetField;");
		}
		
		[JavaSignature("()C")]
		public char readChar()
		{
			return Instance.CallMethod<char>("readChar", "()C");
		}
		
		[JavaSignature("([BII)V")]
		public void readFully(ByteArray arg0, int arg1, int arg2)
		{
			Instance.CallMethod("readFully", "([BII)V", arg0, arg1, arg2);
		}
		
		[JavaSignature("([B)V")]
		public void readFully(ByteArray arg0)
		{
			Instance.CallMethod("readFully", "([B)V", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String readUTF()
		{
			return Instance.CallMethod<String>("readUTF", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()J")]
		public long readLong()
		{
			return Instance.CallMethod<long>("readLong", "()J");
		}
		
		[JavaSignature("()B")]
		public byte readByte()
		{
			return Instance.CallMethod<byte>("readByte", "()B");
		}
		
		[JavaSignature("()S")]
		public short readShort()
		{
			return Instance.CallMethod<short>("readShort", "()S");
		}
		
		[JavaSignature("()Z")]
		public bool readBoolean()
		{
			return Instance.CallMethod<bool>("readBoolean", "()Z");
		}
		
		[JavaSignature("()D")]
		public double readDouble()
		{
			return Instance.CallMethod<double>("readDouble", "()D");
		}
		
		[JavaSignature("()I")]
		public int readUnsignedByte()
		{
			return Instance.CallMethod<int>("readUnsignedByte", "()I");
		}
		
		[JavaSignature("()I")]
		public int readUnsignedShort()
		{
			return Instance.CallMethod<int>("readUnsignedShort", "()I");
		}
		
		[JavaSignature("(I)I")]
		public int skipBytes(int arg0)
		{
			return Instance.CallMethod<int>("skipBytes", "(I)I", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Object;")]
		public IJavaObject readUnshared()
		{
			return Instance.CallMethod<IJavaObject>("readUnshared", "()Ljava/lang/Object;");
		}
		
		[JavaSignature("(Ljava/io/ObjectInputValidation;I)V")]
		public void registerValidation(ObjectInputValidation arg0, int arg1)
		{
			Instance.CallMethod("registerValidation", "(Ljava/io/ObjectInputValidation;I)V", arg0, arg1);
		}
	
		[JavaProxy("java/io/ObjectInputStream/GetField")]
		public abstract class GetField : Object
		{
			protected GetField(ProxyCtor p) : base(p) {}
		
			[JavaSignature("(Ljava/lang/String;J)J")]
			public long @get(String arg0, long arg1)
			{
				return Instance.CallMethod<long>("get", "(Ljava/lang/String;J)J", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;I)I")]
			public int @get(String arg0, int arg1)
			{
				return Instance.CallMethod<int>("get", "(Ljava/lang/String;I)I", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;S)S")]
			public short @get(String arg0, short arg1)
			{
				return Instance.CallMethod<short>("get", "(Ljava/lang/String;S)S", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;F)F")]
			public float @get(String arg0, float arg1)
			{
				return Instance.CallMethod<float>("get", "(Ljava/lang/String;F)F", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;D)D")]
			public double @get(String arg0, double arg1)
			{
				return Instance.CallMethod<double>("get", "(Ljava/lang/String;D)D", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;")]
			public IJavaObject @get(String arg0, IJavaObject arg1)
			{
				return Instance.CallMethod<IJavaObject>("get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;Z)Z")]
			public bool @get(String arg0, bool arg1)
			{
				return Instance.CallMethod<bool>("get", "(Ljava/lang/String;Z)Z", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;B)B")]
			public byte @get(String arg0, byte arg1)
			{
				return Instance.CallMethod<byte>("get", "(Ljava/lang/String;B)B", arg0, arg1);
			}
			
			[JavaSignature("(Ljava/lang/String;C)C")]
			public char @get(String arg0, char arg1)
			{
				return Instance.CallMethod<char>("get", "(Ljava/lang/String;C)C", arg0, arg1);
			}
			
			[JavaSignature("()Ljava/io/ObjectStreamClass;")]
			public ObjectStreamClass getObjectStreamClass()
			{
				return Instance.CallMethod<ObjectStreamClass>("getObjectStreamClass", "()Ljava/io/ObjectStreamClass;");
			}
			
			[JavaSignature("(Ljava/lang/String;)Z")]
			public bool defaulted(String arg0)
			{
				return Instance.CallMethod<bool>("defaulted", "(Ljava/lang/String;)Z", arg0);
			}
		}
	}
}
