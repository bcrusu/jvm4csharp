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
	[JavaProxy("java/util/jar/Pack200")]
	public abstract partial class Pack200 : Object
	{
		protected Pack200(ProxyCtor p) : base(p) {}
	
		[JavaSignature("()Ljava/util/jar/Pack200/Packer;")]
		public static Pack200_.Packer newPacker()
		{
			return Static.CallMethod<Pack200_.Packer>(typeof(Pack200), "newPacker", "()Ljava/util/jar/Pack200/Packer;");
		}
		
		[JavaSignature("()Ljava/util/jar/Pack200/Unpacker;")]
		public static Pack200_.Unpacker newUnpacker()
		{
			return Static.CallMethod<Pack200_.Unpacker>(typeof(Pack200), "newUnpacker", "()Ljava/util/jar/Pack200/Unpacker;");
		}
	}
	
	public static partial class Pack200_
	{
		[JavaProxy("java/util/jar/Pack200/Packer")]
		public partial interface Packer : IJavaObject
		{
			[JavaSignature("()Ljava/util/SortedMap;")]
			SortedMap<String, String> properties();
			
			[JavaSignature("(Ljava/util/jar/JarInputStream;Ljava/io/OutputStream;)V")]
			void pack(JarInputStream arg0, OutputStream arg1);
			
			[JavaSignature("(Ljava/util/jar/JarFile;Ljava/io/OutputStream;)V")]
			void pack(JarFile arg0, OutputStream arg1);
		}
		
		public static partial class Packer_
		{
			private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
			
			[JavaSignature("Ljava/lang/String;")]
			public static String SEGMENT_LIMIT
			{
				get { return Static.GetField<String>(typeof(Packer), "SEGMENT_LIMIT", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String KEEP_FILE_ORDER
			{
				get { return Static.GetField<String>(typeof(Packer), "KEEP_FILE_ORDER", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String EFFORT
			{
				get { return Static.GetField<String>(typeof(Packer), "EFFORT", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String DEFLATE_HINT
			{
				get { return Static.GetField<String>(typeof(Packer), "DEFLATE_HINT", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String MODIFICATION_TIME
			{
				get { return Static.GetField<String>(typeof(Packer), "MODIFICATION_TIME", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String PASS_FILE_PFX
			{
				get { return Static.GetField<String>(typeof(Packer), "PASS_FILE_PFX", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String UNKNOWN_ATTRIBUTE
			{
				get { return Static.GetField<String>(typeof(Packer), "UNKNOWN_ATTRIBUTE", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String CLASS_ATTRIBUTE_PFX
			{
				get { return Static.GetField<String>(typeof(Packer), "CLASS_ATTRIBUTE_PFX", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String FIELD_ATTRIBUTE_PFX
			{
				get { return Static.GetField<String>(typeof(Packer), "FIELD_ATTRIBUTE_PFX", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String METHOD_ATTRIBUTE_PFX
			{
				get { return Static.GetField<String>(typeof(Packer), "METHOD_ATTRIBUTE_PFX", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String CODE_ATTRIBUTE_PFX
			{
				get { return Static.GetField<String>(typeof(Packer), "CODE_ATTRIBUTE_PFX", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String PROGRESS
			{
				get { return Static.GetField<String>(typeof(Packer), "PROGRESS", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String KEEP
			{
				get { return Static.GetField<String>(typeof(Packer), "KEEP", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String PASS
			{
				get { return Static.GetField<String>(typeof(Packer), "PASS", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String STRIP
			{
				get { return Static.GetField<String>(typeof(Packer), "STRIP", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String ERROR
			{
				get { return Static.GetField<String>(typeof(Packer), "ERROR", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String TRUE
			{
				get { return Static.GetField<String>(typeof(Packer), "TRUE", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String FALSE
			{
				get { return Static.GetField<String>(typeof(Packer), "FALSE", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String LATEST
			{
				get { return Static.GetField<String>(typeof(Packer), "LATEST", "Ljava/lang/String;"); }
			}
		
		}
		
		[JavaProxy("java/util/jar/Pack200/Unpacker")]
		public partial interface Unpacker : IJavaObject
		{
			[JavaSignature("()Ljava/util/SortedMap;")]
			SortedMap<String, String> properties();
			
			[JavaSignature("(Ljava/io/File;Ljava/util/jar/JarOutputStream;)V")]
			void unpack(File arg0, JarOutputStream arg1);
			
			[JavaSignature("(Ljava/io/InputStream;Ljava/util/jar/JarOutputStream;)V")]
			void unpack(InputStream arg0, JarOutputStream arg1);
		}
		
		public static partial class Unpacker_
		{
			private static readonly JavaProxyOperations.Static Static = JavaProxyOperations.Static.Singleton;
			
			[JavaSignature("Ljava/lang/String;")]
			public static String KEEP
			{
				get { return Static.GetField<String>(typeof(Unpacker), "KEEP", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String TRUE
			{
				get { return Static.GetField<String>(typeof(Unpacker), "TRUE", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String FALSE
			{
				get { return Static.GetField<String>(typeof(Unpacker), "FALSE", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String DEFLATE_HINT
			{
				get { return Static.GetField<String>(typeof(Unpacker), "DEFLATE_HINT", "Ljava/lang/String;"); }
			}
			
			[JavaSignature("Ljava/lang/String;")]
			public static String PROGRESS
			{
				get { return Static.GetField<String>(typeof(Unpacker), "PROGRESS", "Ljava/lang/String;"); }
			}
		
		}
	}
}
