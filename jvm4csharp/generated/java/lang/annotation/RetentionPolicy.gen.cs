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

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.lang.annotation
{
	[JavaProxy("java/lang/annotation/RetentionPolicy")]
	public class RetentionPolicy : Enum<RetentionPolicy>
	{
		protected RetentionPolicy(ProxyCtor p) : base(p) {}
	
		[JavaSignature("Ljava/lang/annotation/RetentionPolicy;")]
		public static RetentionPolicy SOURCE
		{
			get { return Static.GetField<RetentionPolicy>(typeof(RetentionPolicy), "SOURCE", "Ljava/lang/annotation/RetentionPolicy;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/RetentionPolicy;")]
		public static RetentionPolicy CLASS
		{
			get { return Static.GetField<RetentionPolicy>(typeof(RetentionPolicy), "CLASS", "Ljava/lang/annotation/RetentionPolicy;"); }
		}
		
		[JavaSignature("Ljava/lang/annotation/RetentionPolicy;")]
		public static RetentionPolicy RUNTIME
		{
			get { return Static.GetField<RetentionPolicy>(typeof(RetentionPolicy), "RUNTIME", "Ljava/lang/annotation/RetentionPolicy;"); }
		}
	
		[JavaSignature("()[Ljava/lang/annotation/RetentionPolicy;")]
		public static ObjectArray<RetentionPolicy> values()
		{
			return Static.CallMethod<ObjectArray<RetentionPolicy>>(typeof(RetentionPolicy), "values", "()[Ljava/lang/annotation/RetentionPolicy;");
		}
		
		[JavaSignature("(Ljava/lang/String;)Ljava/lang/annotation/RetentionPolicy;")]
		public static RetentionPolicy valueOf(String arg0)
		{
			return Static.CallMethod<RetentionPolicy>(typeof(RetentionPolicy), "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/RetentionPolicy;", arg0);
		}
	}
}
