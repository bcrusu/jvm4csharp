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
	[JavaProxy("java/io/ObjectStreamClass")]
	public partial class ObjectStreamClass : Object, Serializable
	{
		protected ObjectStreamClass(ProxyCtor p) : base(p) {}
	
		[JavaSignature("[Ljava/io/ObjectStreamField;")]
		public static ObjectArray<ObjectStreamField> NO_FIELDS
		{
			get { return Static.GetField<ObjectArray<ObjectStreamField>>(typeof(ObjectStreamClass), "NO_FIELDS", "[Ljava/io/ObjectStreamField;"); }
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/io/ObjectStreamField;")]
		public ObjectStreamField getField(String arg0)
		{
			return Instance.CallMethod<ObjectStreamField>("getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;", arg0);
		}
		
		[JavaSignature("()[Ljava/io/ObjectStreamField;")]
		public ObjectArray<ObjectStreamField> getFields()
		{
			return Instance.CallMethod<ObjectArray<ObjectStreamField>>("getFields", "()[Ljava/io/ObjectStreamField;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;")]
		public static ObjectStreamClass lookup(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<ObjectStreamClass>(typeof(ObjectStreamClass), "lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/Class;")]
		public Class<IJavaObject> forClass()
		{
			return Instance.CallMethod<Class<IJavaObject>>("forClass", "()Ljava/lang/Class;");
		}
		
		[JavaSignature("()J")]
		public long getSerialVersionUID()
		{
			return Instance.CallMethod<long>("getSerialVersionUID", "()J");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;")]
		public static ObjectStreamClass lookupAny(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<ObjectStreamClass>(typeof(ObjectStreamClass), "lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", arg0);
		}
	}
}
