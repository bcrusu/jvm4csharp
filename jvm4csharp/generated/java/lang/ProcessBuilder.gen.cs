//------------------------------------------------------------------------
//	This code was generated using jvm4csharp-generator:
//	https://github.com/bcrusu/jvm4csharp-generator
//
//	Generated using:
//	java_version					: 1.8.0_51
//	java_vm_name					: Java HotSpot(TM) 64-Bit Server VM
//	java_vm_version					: 25.51-b03
//------------------------------------------------------------------------

using jvm4csharp.Arrays;
using jvm4csharp.java.io;
using jvm4csharp.java.util;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang
{
	[JavaProxy("java/lang/ProcessBuilder")]
	public partial class ProcessBuilder : Object
	{
		protected ProcessBuilder(ProxyCtor p) : base(p) {}
		
		public ProcessBuilder(List<String> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("(Ljava/util/List;)V", arg0);
		}
		
		public ProcessBuilder(ObjectArray<String> arg0) : base(ProxyCtor.I)
		{
			Instance.CallConstructor("([Ljava/lang/String;)V", arg0);
		}
	
		[JavaSignature("()Ljava/lang/Process;")]
		public Process start()
		{
			return Instance.CallMethod<Process>("start", "()Ljava/lang/Process;");
		}
		
		[JavaSignature("()Ljava/io/File;")]
		public File directory()
		{
			return Instance.CallMethod<File>("directory", "()Ljava/io/File;");
		}
		
		[JavaSignature("(Ljava/io/File;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder directory(File arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("()Ljava/util/Map;")]
		public Map<String, String> environment()
		{
			return Instance.CallMethod<Map<String, String>>("environment", "()Ljava/util/Map;");
		}
		
		[JavaSignature("(Ljava/util/List;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder command(List<String> arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("()Ljava/util/List;")]
		public List<String> command()
		{
			return Instance.CallMethod<List<String>>("command", "()Ljava/util/List;");
		}
		
		[JavaSignature("([Ljava/lang/String;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder command(ObjectArray<String> arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder inheritIO()
		{
			return Instance.CallMethod<ProcessBuilder>("inheritIO", "()Ljava/lang/ProcessBuilder;");
		}
		
		[JavaSignature("(Ljava/io/File;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder redirectError(File arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("redirectError", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/ProcessBuilder/Redirect;")]
		public ProcessBuilder_.Redirect redirectError()
		{
			return Instance.CallMethod<ProcessBuilder_.Redirect>("redirectError", "()Ljava/lang/ProcessBuilder/Redirect;");
		}
		
		[JavaSignature("(Ljava/lang/ProcessBuilder/Redirect;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder redirectError(ProcessBuilder_.Redirect arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("redirectError", "(Ljava/lang/ProcessBuilder/Redirect;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("()Z")]
		public bool redirectErrorStream()
		{
			return Instance.CallMethod<bool>("redirectErrorStream", "()Z");
		}
		
		[JavaSignature("(Z)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder redirectErrorStream(bool arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/io/File;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder redirectInput(File arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("redirectInput", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/ProcessBuilder/Redirect;")]
		public ProcessBuilder_.Redirect redirectInput()
		{
			return Instance.CallMethod<ProcessBuilder_.Redirect>("redirectInput", "()Ljava/lang/ProcessBuilder/Redirect;");
		}
		
		[JavaSignature("(Ljava/lang/ProcessBuilder/Redirect;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder redirectInput(ProcessBuilder_.Redirect arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("redirectInput", "(Ljava/lang/ProcessBuilder/Redirect;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/io/File;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder redirectOutput(File arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("redirectOutput", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("(Ljava/lang/ProcessBuilder/Redirect;)Ljava/lang/ProcessBuilder;")]
		public ProcessBuilder redirectOutput(ProcessBuilder_.Redirect arg0)
		{
			return Instance.CallMethod<ProcessBuilder>("redirectOutput", "(Ljava/lang/ProcessBuilder/Redirect;)Ljava/lang/ProcessBuilder;", arg0);
		}
		
		[JavaSignature("()Ljava/lang/ProcessBuilder/Redirect;")]
		public ProcessBuilder_.Redirect redirectOutput()
		{
			return Instance.CallMethod<ProcessBuilder_.Redirect>("redirectOutput", "()Ljava/lang/ProcessBuilder/Redirect;");
		}
	}
	
	public static partial class ProcessBuilder_
	{
		[JavaProxy("java/lang/ProcessBuilder/Redirect")]
		public abstract partial class Redirect : Object
		{
			protected Redirect(ProxyCtor p) : base(p) {}
		
			[JavaSignature("Ljava/lang/ProcessBuilder/Redirect;")]
			public static ProcessBuilder_.Redirect PIPE
			{
				get { return Static.GetField<ProcessBuilder_.Redirect>(typeof(Redirect), "PIPE", "Ljava/lang/ProcessBuilder/Redirect;"); }
			}
			
			[JavaSignature("Ljava/lang/ProcessBuilder/Redirect;")]
			public static ProcessBuilder_.Redirect INHERIT
			{
				get { return Static.GetField<ProcessBuilder_.Redirect>(typeof(Redirect), "INHERIT", "Ljava/lang/ProcessBuilder/Redirect;"); }
			}
		
			[JavaSignature("()Ljava/lang/ProcessBuilder/Redirect/Type;")]
			public ProcessBuilder_.Redirect_.Type type()
			{
				return Instance.CallMethod<ProcessBuilder_.Redirect_.Type>("type", "()Ljava/lang/ProcessBuilder/Redirect/Type;");
			}
			
			[JavaSignature("(Ljava/io/File;)Ljava/lang/ProcessBuilder/Redirect;")]
			public static ProcessBuilder_.Redirect appendTo(File arg0)
			{
				return Static.CallMethod<ProcessBuilder_.Redirect>(typeof(Redirect), "appendTo", "(Ljava/io/File;)Ljava/lang/ProcessBuilder/Redirect;", arg0);
			}
			
			[JavaSignature("()Ljava/io/File;")]
			public File file()
			{
				return Instance.CallMethod<File>("file", "()Ljava/io/File;");
			}
			
			[JavaSignature("(Ljava/io/File;)Ljava/lang/ProcessBuilder/Redirect;")]
			public static ProcessBuilder_.Redirect @from(File arg0)
			{
				return Static.CallMethod<ProcessBuilder_.Redirect>(typeof(Redirect), "from", "(Ljava/io/File;)Ljava/lang/ProcessBuilder/Redirect;", arg0);
			}
			
			[JavaSignature("(Ljava/io/File;)Ljava/lang/ProcessBuilder/Redirect;")]
			public static ProcessBuilder_.Redirect to(File arg0)
			{
				return Static.CallMethod<ProcessBuilder_.Redirect>(typeof(Redirect), "to", "(Ljava/io/File;)Ljava/lang/ProcessBuilder/Redirect;", arg0);
			}
		}
		
		public static partial class Redirect_
		{
			[JavaProxy("java/lang/ProcessBuilder/Redirect/Type")]
			public partial class Type : Enum<ProcessBuilder_.Redirect_.Type>
			{
				protected Type(ProxyCtor p) : base(p) {}
			
				[JavaSignature("Ljava/lang/ProcessBuilder/Redirect/Type;")]
				public static ProcessBuilder_.Redirect_.Type PIPE
				{
					get { return Static.GetField<ProcessBuilder_.Redirect_.Type>(typeof(Type), "PIPE", "Ljava/lang/ProcessBuilder/Redirect/Type;"); }
				}
				
				[JavaSignature("Ljava/lang/ProcessBuilder/Redirect/Type;")]
				public static ProcessBuilder_.Redirect_.Type INHERIT
				{
					get { return Static.GetField<ProcessBuilder_.Redirect_.Type>(typeof(Type), "INHERIT", "Ljava/lang/ProcessBuilder/Redirect/Type;"); }
				}
				
				[JavaSignature("Ljava/lang/ProcessBuilder/Redirect/Type;")]
				public static ProcessBuilder_.Redirect_.Type READ
				{
					get { return Static.GetField<ProcessBuilder_.Redirect_.Type>(typeof(Type), "READ", "Ljava/lang/ProcessBuilder/Redirect/Type;"); }
				}
				
				[JavaSignature("Ljava/lang/ProcessBuilder/Redirect/Type;")]
				public static ProcessBuilder_.Redirect_.Type WRITE
				{
					get { return Static.GetField<ProcessBuilder_.Redirect_.Type>(typeof(Type), "WRITE", "Ljava/lang/ProcessBuilder/Redirect/Type;"); }
				}
				
				[JavaSignature("Ljava/lang/ProcessBuilder/Redirect/Type;")]
				public static ProcessBuilder_.Redirect_.Type APPEND
				{
					get { return Static.GetField<ProcessBuilder_.Redirect_.Type>(typeof(Type), "APPEND", "Ljava/lang/ProcessBuilder/Redirect/Type;"); }
				}
			
				[JavaSignature("()[Ljava/lang/ProcessBuilder/Redirect/Type;")]
				public static ObjectArray<ProcessBuilder_.Redirect_.Type> values()
				{
					return Static.CallMethod<ObjectArray<ProcessBuilder_.Redirect_.Type>>(typeof(Type), "values", "()[Ljava/lang/ProcessBuilder/Redirect/Type;");
				}
				
				[JavaSignature("(Ljava/lang/String;)Ljava/lang/ProcessBuilder/Redirect/Type;")]
				public static ProcessBuilder_.Redirect_.Type valueOf(String arg0)
				{
					return Static.CallMethod<ProcessBuilder_.Redirect_.Type>(typeof(Type), "valueOf", "(Ljava/lang/String;)Ljava/lang/ProcessBuilder/Redirect/Type;", arg0);
				}
			}
		}
	}
}
