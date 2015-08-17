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
namespace jvm4csharp.java.util.logging
{
	[JavaProxy("java/util/logging/Level")]
	public class Level : Object, Serializable
	{
		protected Level(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level OFF
		{
			get { return Static.GetField<Level>(typeof(Level), "OFF", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level SEVERE
		{
			get { return Static.GetField<Level>(typeof(Level), "SEVERE", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level WARNING
		{
			get { return Static.GetField<Level>(typeof(Level), "WARNING", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level INFO
		{
			get { return Static.GetField<Level>(typeof(Level), "INFO", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level CONFIG
		{
			get { return Static.GetField<Level>(typeof(Level), "CONFIG", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level FINE
		{
			get { return Static.GetField<Level>(typeof(Level), "FINE", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level FINER
		{
			get { return Static.GetField<Level>(typeof(Level), "FINER", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level FINEST
		{
			get { return Static.GetField<Level>(typeof(Level), "FINEST", "Ljava/util/logging/Level;"); }
		}
		
		[JavaSignature("Ljava/util/logging/Level;")]
		public static Level ALL
		{
			get { return Static.GetField<Level>(typeof(Level), "ALL", "Ljava/util/logging/Level;"); }
		}
	
		[JavaSignature("()I")]
		public int intValue()
		{
			return Instance.CallMethod<int>("intValue", "()I");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getName()
		{
			return Instance.CallMethod<String>("getName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/util/logging/Level;")]
		public static Level parse(String arg0)
		{
			return Static.CallMethod<Level>(typeof(Level), "parse", "(Ljava/lang/String;)Ljava/util/logging/Level;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getLocalizedName()
		{
			return Instance.CallMethod<String>("getLocalizedName", "()Ljava/lang/String;");
		}
		
		[JavaSignature("()Ljava/lang/String;")]
		public String getResourceBundleName()
		{
			return Instance.CallMethod<String>("getResourceBundleName", "()Ljava/lang/String;");
		}
	}
}
