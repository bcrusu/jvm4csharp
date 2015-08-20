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
namespace jvm4csharp.java.util.prefs
{
	[JavaProxy("java/util/prefs/Preferences")]
	public abstract partial class Preferences : Object
	{
		protected Preferences(ProxyCtor p) : base(p) {}
	
		[JavaSignature("I")]
		public static int MAX_KEY_LENGTH
		{
			get { return Static.GetField<int>(typeof(Preferences), "MAX_KEY_LENGTH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_VALUE_LENGTH
		{
			get { return Static.GetField<int>(typeof(Preferences), "MAX_VALUE_LENGTH", "I"); }
		}
		
		[JavaSignature("I")]
		public static int MAX_NAME_LENGTH
		{
			get { return Static.GetField<int>(typeof(Preferences), "MAX_NAME_LENGTH", "I"); }
		}
	
		[JavaSignature("()Ljava/lang/String;")]
		public String name()
		{
			return Instance.CallMethod<String>("name", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)V")]
		public void @remove(String arg0)
		{
			Instance.CallMethod("remove", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		public Preferences parent()
		{
			return Instance.CallMethod<Preferences>("parent", "()Ljava/util/prefs/Preferences;");
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
		public String @get(String arg0, String arg1)
		{
			return Instance.CallMethod<String>("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Ljava/lang/String;)V")]
		public void put(String arg0, String arg1)
		{
			Instance.CallMethod("put", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Z)Z")]
		public bool getBoolean(String arg0, bool arg1)
		{
			return Instance.CallMethod<bool>("getBoolean", "(Ljava/lang/String;Z)Z", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;Z)V")]
		public void putBoolean(String arg0, bool arg1)
		{
			Instance.CallMethod("putBoolean", "(Ljava/lang/String;Z)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;I)I")]
		public int getInt(String arg0, int arg1)
		{
			return Instance.CallMethod<int>("getInt", "(Ljava/lang/String;I)I", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;I)V")]
		public void putInt(String arg0, int arg1)
		{
			Instance.CallMethod("putInt", "(Ljava/lang/String;I)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;J)J")]
		public long getLong(String arg0, long arg1)
		{
			return Instance.CallMethod<long>("getLong", "(Ljava/lang/String;J)J", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;J)V")]
		public void putLong(String arg0, long arg1)
		{
			Instance.CallMethod("putLong", "(Ljava/lang/String;J)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;F)F")]
		public float getFloat(String arg0, float arg1)
		{
			return Instance.CallMethod<float>("getFloat", "(Ljava/lang/String;F)F", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;F)V")]
		public void putFloat(String arg0, float arg1)
		{
			Instance.CallMethod("putFloat", "(Ljava/lang/String;F)V", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;D)D")]
		public double getDouble(String arg0, double arg1)
		{
			return Instance.CallMethod<double>("getDouble", "(Ljava/lang/String;D)D", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/lang/String;D)V")]
		public void putDouble(String arg0, double arg1)
		{
			Instance.CallMethod("putDouble", "(Ljava/lang/String;D)V", arg0, arg1);
		}
		
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("()V")]
		public void flush()
		{
			Instance.CallMethod("flush", "()V");
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> keys()
		{
			return Instance.CallMethod<ObjectArray<String>>("keys", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("()V")]
		public void sync()
		{
			Instance.CallMethod("sync", "()V");
		}
		
		[JavaSignature("()V")]
		public void removeNode()
		{
			Instance.CallMethod("removeNode", "()V");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/prefs/Preferences;")]
		public Preferences node(String arg0)
		{
			return Instance.CallMethod<Preferences>("node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;[B)V")]
		public void putByteArray(String arg0, ByteArray arg1)
		{
			Instance.CallMethod("putByteArray", "(Ljava/lang/String;[B)V", arg0, arg1);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String absolutePath()
		{
			return Instance.CallMethod<String>("absolutePath", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/util/prefs/NodeChangeListener;)V")]
		public void addNodeChangeListener(NodeChangeListener arg0)
		{
			Instance.CallMethod("addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/prefs/PreferenceChangeListener;)V")]
		public void addPreferenceChangeListener(PreferenceChangeListener arg0)
		{
			Instance.CallMethod("addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", arg0);
		}
		
		[JavaSignature("()[Ljava/lang/String;")]
		public ObjectArray<String> childrenNames()
		{
			return Instance.CallMethod<ObjectArray<String>>("childrenNames", "()[Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/io/OutputStream;)V")]
		public void exportNode(OutputStream arg0)
		{
			Instance.CallMethod("exportNode", "(Ljava/io/OutputStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/OutputStream;)V")]
		public void exportSubtree(OutputStream arg0)
		{
			Instance.CallMethod("exportSubtree", "(Ljava/io/OutputStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;[B)[B")]
		public ByteArray getByteArray(String arg0, ByteArray arg1)
		{
			return Instance.CallMethod<ByteArray>("getByteArray", "(Ljava/lang/String;[B)[B", arg0, arg1);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)V")]
		public static void importPreferences(InputStream arg0)
		{
			Static.CallMethod(typeof(Preferences), "importPreferences", "(Ljava/io/InputStream;)V", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool isUserNode()
		{
			return Instance.CallMethod<bool>("isUserNode", "()Z");
		}
		
		[JavaSignature("(Ljava/lang/String;)Z")]
		public bool nodeExists(String arg0)
		{
			return Instance.CallMethod<bool>("nodeExists", "(Ljava/lang/String;)Z", arg0);
		}
		
		[JavaSignature("(Ljava/util/prefs/NodeChangeListener;)V")]
		public void removeNodeChangeListener(NodeChangeListener arg0)
		{
			Instance.CallMethod("removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", arg0);
		}
		
		[JavaSignature("(Ljava/util/prefs/PreferenceChangeListener;)V")]
		public void removePreferenceChangeListener(PreferenceChangeListener arg0)
		{
			Instance.CallMethod("removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/util/prefs/Preferences;")]
		public static Preferences systemNodeForPackage(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<Preferences>(typeof(Preferences), "systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", arg0);
		}
		
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		public static Preferences systemRoot()
		{
			return Static.CallMethod<Preferences>(typeof(Preferences), "systemRoot", "()Ljava/util/prefs/Preferences;");
		}
		
		[JavaSignature("(Ljava/lang/Class;)Ljava/util/prefs/Preferences;")]
		public static Preferences userNodeForPackage(Class<IJavaObject> arg0)
		{
			return Static.CallMethod<Preferences>(typeof(Preferences), "userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", arg0);
		}
		
		[JavaSignature("()Ljava/util/prefs/Preferences;")]
		public static Preferences userRoot()
		{
			return Static.CallMethod<Preferences>(typeof(Preferences), "userRoot", "()Ljava/util/prefs/Preferences;");
		}
	}
}
