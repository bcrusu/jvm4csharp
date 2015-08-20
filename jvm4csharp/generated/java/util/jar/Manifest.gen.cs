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
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.jar
{
	[JavaProxy("java/util/jar/Manifest")]
	public partial class Manifest : Object, Cloneable
	{
		protected Manifest(ProxyCtor p) : base(p) {}
		
		public Manifest(Manifest arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/jar/Manifest;)V", arg0);
		}
		
		public Manifest(InputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/InputStream;)V", arg0);
		}
		
		public Manifest() : base(ProxyCtor.I)
		{
			Instance.CallConstructor("()V");
		}
	
		[JavaSignature("()V")]
		public void clear()
		{
			Instance.CallMethod("clear", "()V");
		}
		
		[JavaSignature("(Ljava/io/OutputStream;)V")]
		public void write(OutputStream arg0)
		{
			Instance.CallMethod("write", "(Ljava/io/OutputStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/io/InputStream;)V")]
		public void read(InputStream arg0)
		{
			Instance.CallMethod("read", "(Ljava/io/InputStream;)V", arg0);
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/jar/Attributes;")]
		public Attributes getAttributes(String arg0)
		{
			return Instance.CallMethod<Attributes>("getAttributes", "(Ljava/lang/String;)Ljava/util/jar/Attributes;", arg0);
		}
		
		[JavaSignature("()Ljava/util/jar/Attributes;")]
		public Attributes getMainAttributes()
		{
			return Instance.CallMethod<Attributes>("getMainAttributes", "()Ljava/util/jar/Attributes;");
		}
		
		[JavaSignature("()Ljava/util/Map;")]
		public Map<String, Attributes> getEntries()
		{
			return Instance.CallMethod<Map<String, Attributes>>("getEntries", "()Ljava/util/Map;");
		}
	}
}
