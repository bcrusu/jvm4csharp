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
namespace jvm4csharp.java.io
{
	[JavaProxy("java/io/ObjectStreamConstants")]
	public interface ObjectStreamConstants : IJavaObject
	{
	}
	
	public static class ObjectStreamConstants_
	{
		private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
		
		[JavaSignature("S")]
		public static short STREAM_MAGIC
		{
			get { return Static.GetField<short>(typeof(ObjectStreamConstants), "STREAM_MAGIC", "S"); }
		}
		
		[JavaSignature("S")]
		public static short STREAM_VERSION
		{
			get { return Static.GetField<short>(typeof(ObjectStreamConstants), "STREAM_VERSION", "S"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_BASE
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_BASE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_NULL
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_NULL", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_REFERENCE
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_REFERENCE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_CLASSDESC
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_CLASSDESC", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_OBJECT
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_OBJECT", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_STRING
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_STRING", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_ARRAY
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_ARRAY", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_CLASS
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_CLASS", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_BLOCKDATA
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_BLOCKDATA", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_ENDBLOCKDATA
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_ENDBLOCKDATA", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_RESET
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_RESET", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_BLOCKDATALONG
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_BLOCKDATALONG", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_EXCEPTION
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_EXCEPTION", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_LONGSTRING
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_LONGSTRING", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_PROXYCLASSDESC
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_PROXYCLASSDESC", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_ENUM
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_ENUM", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte TC_MAX
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "TC_MAX", "B"); }
		}
		
		[JavaSignature("I")]
		public static int baseWireHandle
		{
			get { return Static.GetField<int>(typeof(ObjectStreamConstants), "baseWireHandle", "I"); }
		}
		
		[JavaSignature("B")]
		public static byte SC_WRITE_METHOD
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "SC_WRITE_METHOD", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte SC_BLOCK_DATA
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "SC_BLOCK_DATA", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte SC_SERIALIZABLE
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "SC_SERIALIZABLE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte SC_EXTERNALIZABLE
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "SC_EXTERNALIZABLE", "B"); }
		}
		
		[JavaSignature("B")]
		public static byte SC_ENUM
		{
			get { return Static.GetField<byte>(typeof(ObjectStreamConstants), "SC_ENUM", "B"); }
		}
		
		[JavaSignature("I")]
		public static int PROTOCOL_VERSION_1
		{
			get { return Static.GetField<int>(typeof(ObjectStreamConstants), "PROTOCOL_VERSION_1", "I"); }
		}
		
		[JavaSignature("I")]
		public static int PROTOCOL_VERSION_2
		{
			get { return Static.GetField<int>(typeof(ObjectStreamConstants), "PROTOCOL_VERSION_2", "I"); }
		}
	
	}
}
