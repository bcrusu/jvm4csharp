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
using jvm4csharp.java.nio.charset;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.zip
{
	[JavaProxy("java/util/zip/ZipOutputStream")]
	public class ZipOutputStream : DeflaterOutputStream
	{
		protected ZipOutputStream(ProxyCtor p) : base(p) {}
		
		public ZipOutputStream(OutputStream arg0, Charset arg1) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V", arg0, arg1);
		}
		
		public ZipOutputStream(OutputStream arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/io/OutputStream;)V", arg0);
		}
	
		[JavaSignature("I")]
		public static int STORED
		{
			get { return Static.GetField<int>(typeof(ZipOutputStream), "STORED", "I"); }
		}
		
		[JavaSignature("I")]
		public static int DEFLATED
		{
			get { return Static.GetField<int>(typeof(ZipOutputStream), "DEFLATED", "I"); }
		}
	
		[JavaSignature("(Ljava/lang/String;)V")]
		public void setComment(String arg0)
		{
			Instance.CallMethod("setComment", "(Ljava/lang/String;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setMethod(int arg0)
		{
			Instance.CallMethod("setMethod", "(I)V", arg0);
		}
		
		[JavaSignature("()V")]
		public void closeEntry()
		{
			Instance.CallMethod("closeEntry", "()V");
		}
		
		[JavaSignature("(Ljava/util/zip/ZipEntry;)V")]
		public void putNextEntry(ZipEntry arg0)
		{
			Instance.CallMethod("putNextEntry", "(Ljava/util/zip/ZipEntry;)V", arg0);
		}
		
		[JavaSignature("(I)V")]
		public void setLevel(int arg0)
		{
			Instance.CallMethod("setLevel", "(I)V", arg0);
		}
	}
}
